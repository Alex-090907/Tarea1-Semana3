using System.Data;
using System.Globalization;
using Microsoft.Data.SqlClient;

namespace PubsApp;

public partial class FrmDiscounts : Form
{
    bool esNuevo = false;

    // Valores originales de la fila seleccionada (la tabla no tiene llave primaria)
    string oTy = "";
    string? oSt;
    short? oLo, oHi;
    decimal oDi;

    const string Donde = @"discounttype=@oty
        AND (stor_id=@ost OR (stor_id IS NULL AND @ost IS NULL))
        AND (lowqty=@olo OR (lowqty IS NULL AND @olo IS NULL))
        AND (highqty=@ohi OR (highqty IS NULL AND @ohi IS NULL))
        AND discount=@odi";

    public FrmDiscounts()
    {
        InitializeComponent();
    }

    private void FrmDiscounts_Load(object? sender, EventArgs e)
    {
        CargarCombo();
        Cargar();
    }

    void CargarCombo()
    {
        try
        {
            using var cn = new SqlConnection(Conexion.Cadena);
            var dt = new DataTable();
            new SqlDataAdapter(
                @"SELECT CAST(NULL AS varchar(4)) AS stor_id, '(ninguna)' AS txt, 0 AS o
                  UNION ALL
                  SELECT stor_id, stor_id + ' - ' + ISNULL(stor_name, ''), 1 FROM stores
                  ORDER BY o, stor_id", cn).Fill(dt);
            cboStor.DisplayMember = "txt";
            cboStor.ValueMember = "stor_id";
            cboStor.DataSource = dt;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al cargar lista: " + ex.Message);
        }
    }

    void Cargar()
    {
        try
        {
            using var cn = new SqlConnection(Conexion.Cadena);
            var da = new SqlDataAdapter("SELECT * FROM discounts ORDER BY discounttype", cn);
            var dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            MostrarFila();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al cargar: " + ex.Message);
        }
    }

    void MostrarFila()
    {
        var r = dgv.CurrentRow;
        if (r == null) return;

        oTy = r.Cells["discounttype"].Value?.ToString() ?? "";
        oSt = r.Cells["stor_id"].Value is string s ? s.Trim() : null;
        oLo = r.Cells["lowqty"].Value is short a ? a : (short?)null;
        oHi = r.Cells["highqty"].Value is short b ? b : (short?)null;
        oDi = r.Cells["discount"].Value is decimal d ? d : 0m;

        txtType.Text = oTy;
        if (oSt == null) cboStor.SelectedIndex = 0;
        else cboStor.SelectedValue = oSt;
        txtLow.Text = oLo?.ToString();
        txtHigh.Text = oHi?.ToString();
        txtDisc.Text = oDi.ToString("0.00", CultureInfo.InvariantCulture);
        esNuevo = false;
    }

    private void dgv_SelectionChanged(object? sender, EventArgs e)
    {
        MostrarFila();
    }

    static bool Sh(string s, out short? v)
    {
        s = s.Trim();
        v = null;
        if (s == "") return true;
        if (short.TryParse(s, out short x))
        {
            v = x;
            return true;
        }
        return false;
    }

    static void P(SqlCommand c, string n, SqlDbType t, object? v, int size = 0)
    {
        var p = size > 0 ? c.Parameters.Add(n, t, size) : c.Parameters.Add(n, t);
        p.Value = v ?? DBNull.Value;
    }

    static void PD(SqlCommand c, string n, decimal v)
    {
        var p = c.Parameters.Add(n, SqlDbType.Decimal);
        p.Precision = 4;
        p.Scale = 2;
        p.Value = v;
    }

    private void btnNuevo_Click(object? sender, EventArgs e)
    {
        dgv.ClearSelection();
        txtType.Clear();
        txtLow.Clear();
        txtHigh.Clear();
        txtDisc.Clear();
        cboStor.SelectedIndex = 0;
        esNuevo = true;
        txtType.Focus();
    }

    private void btnGuardar_Click(object? sender, EventArgs e)
    {
        if (txtType.Text.Trim() == "")
        {
            MessageBox.Show("discounttype es obligatorio.");
            return;
        }
        if (!Sh(txtLow.Text, out short? low) || !Sh(txtHigh.Text, out short? high))
        {
            MessageBox.Show("lowqty y highqty deben ser números enteros.");
            return;
        }
        if (!decimal.TryParse(txtDisc.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture,
                out decimal disc) || disc < 0 || disc > 99.99m)
        {
            MessageBox.Show("discount debe ser un número entre 0 y 99.99 (use punto decimal).");
            return;
        }

        string? stor = cboStor.SelectedValue is string s ? s.Trim() : null;

        string sql = esNuevo
            ? @"INSERT INTO discounts (discounttype, stor_id, lowqty, highqty, discount)
                VALUES (@ty, @st, @lo, @hi, @di)"
            : @"UPDATE TOP (1) discounts SET discounttype=@ty, stor_id=@st, lowqty=@lo,
                highqty=@hi, discount=@di WHERE " + Donde;

        try
        {
            using var cn = new SqlConnection(Conexion.Cadena);
            using var cmd = new SqlCommand(sql, cn);
            P(cmd, "@ty", SqlDbType.VarChar, txtType.Text.Trim(), 40);
            P(cmd, "@st", SqlDbType.Char, stor, 4);
            P(cmd, "@lo", SqlDbType.SmallInt, low);
            P(cmd, "@hi", SqlDbType.SmallInt, high);
            PD(cmd, "@di", disc);
            if (!esNuevo)
            {
                P(cmd, "@oty", SqlDbType.VarChar, oTy, 40);
                P(cmd, "@ost", SqlDbType.Char, oSt, 4);
                P(cmd, "@olo", SqlDbType.SmallInt, oLo);
                P(cmd, "@ohi", SqlDbType.SmallInt, oHi);
                PD(cmd, "@odi", oDi);
            }
            cn.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Registro guardado.");
            Cargar();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al guardar: " + ex.Message);
        }
    }

    private void btnEliminar_Click(object? sender, EventArgs e)
    {
        if (esNuevo || oTy == "")
        {
            MessageBox.Show("Seleccione un registro de la tabla.");
            return;
        }

        if (MessageBox.Show("¿Eliminar el descuento " + oTy + "?", "Confirmar",
            MessageBoxButtons.YesNo) != DialogResult.Yes) return;

        try
        {
            using var cn = new SqlConnection(Conexion.Cadena);
            using var cmd = new SqlCommand("DELETE TOP (1) FROM discounts WHERE " + Donde, cn);
            P(cmd, "@oty", SqlDbType.VarChar, oTy, 40);
            P(cmd, "@ost", SqlDbType.Char, oSt, 4);
            P(cmd, "@olo", SqlDbType.SmallInt, oLo);
            P(cmd, "@ohi", SqlDbType.SmallInt, oHi);
            PD(cmd, "@odi", oDi);
            cn.Open();
            cmd.ExecuteNonQuery();
            Cargar();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al eliminar: " + ex.Message);
        }
    }

    private void btnRecargar_Click(object? sender, EventArgs e)
    {
        CargarCombo();
        Cargar();
    }
}