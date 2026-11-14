using System.Data;
using Microsoft.Data.SqlClient;

namespace PubsApp;

public partial class FrmRoysched : Form
{
    bool esNuevo = false;

    // Valores originales de la fila seleccionada (la tabla no tiene llave primaria)
    string oTi = "";
    int? oLo, oHi, oRo;

    const string Donde = @"title_id=@oti
        AND (lorange=@olo OR (lorange IS NULL AND @olo IS NULL))
        AND (hirange=@ohi OR (hirange IS NULL AND @ohi IS NULL))
        AND (royalty=@oro OR (royalty IS NULL AND @oro IS NULL))";

    public FrmRoysched()
    {
        InitializeComponent();
    }

    private void FrmRoysched_Load(object? sender, EventArgs e)
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
                "SELECT title_id, title_id + ' - ' + title AS txt FROM titles ORDER BY title_id", cn)
                .Fill(dt);
            cboTitle.DisplayMember = "txt";
            cboTitle.ValueMember = "title_id";
            cboTitle.DataSource = dt;
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
            var da = new SqlDataAdapter("SELECT * FROM roysched ORDER BY title_id, lorange", cn);
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

        oTi = r.Cells["title_id"].Value?.ToString() ?? "";
        oLo = r.Cells["lorange"].Value is int a ? a : (int?)null;
        oHi = r.Cells["hirange"].Value is int b ? b : (int?)null;
        oRo = r.Cells["royalty"].Value is int c ? c : (int?)null;

        cboTitle.SelectedValue = oTi;
        txtLo.Text = oLo?.ToString();
        txtHi.Text = oHi?.ToString();
        txtRoy.Text = oRo?.ToString();
        esNuevo = false;
    }

    private void dgv_SelectionChanged(object? sender, EventArgs e)
    {
        MostrarFila();
    }

    static bool Ent(string s, out int? v)
    {
        s = s.Trim();
        v = null;
        if (s == "") return true;
        if (int.TryParse(s, out int x))
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

    private void btnNuevo_Click(object? sender, EventArgs e)
    {
        dgv.ClearSelection();
        txtLo.Clear();
        txtHi.Clear();
        txtRoy.Clear();
        esNuevo = true;
        cboTitle.Focus();
    }

    private void btnGuardar_Click(object? sender, EventArgs e)
    {
        if (cboTitle.SelectedValue == null)
        {
            MessageBox.Show("Seleccione el libro.");
            return;
        }
        if (!Ent(txtLo.Text, out int? lo) || !Ent(txtHi.Text, out int? hi) || !Ent(txtRoy.Text, out int? ro))
        {
            MessageBox.Show("lorange, hirange y royalty deben ser números enteros.");
            return;
        }

        string ti = cboTitle.SelectedValue.ToString()!;

        string sql = esNuevo
            ? @"INSERT INTO roysched (title_id, lorange, hirange, royalty)
                VALUES (@ti, @lo, @hi, @ro)"
            : @"UPDATE TOP (1) roysched SET title_id=@ti, lorange=@lo, hirange=@hi, royalty=@ro
                WHERE " + Donde;

        try
        {
            using var cn = new SqlConnection(Conexion.Cadena);
            using var cmd = new SqlCommand(sql, cn);
            P(cmd, "@ti", SqlDbType.VarChar, ti, 6);
            P(cmd, "@lo", SqlDbType.Int, lo);
            P(cmd, "@hi", SqlDbType.Int, hi);
            P(cmd, "@ro", SqlDbType.Int, ro);
            if (!esNuevo)
            {
                P(cmd, "@oti", SqlDbType.VarChar, oTi, 6);
                P(cmd, "@olo", SqlDbType.Int, oLo);
                P(cmd, "@ohi", SqlDbType.Int, oHi);
                P(cmd, "@oro", SqlDbType.Int, oRo);
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
        if (esNuevo || oTi == "")
        {
            MessageBox.Show("Seleccione un registro de la tabla.");
            return;
        }

        if (MessageBox.Show("¿Eliminar este registro?", "Confirmar",
            MessageBoxButtons.YesNo) != DialogResult.Yes) return;

        try
        {
            using var cn = new SqlConnection(Conexion.Cadena);
            using var cmd = new SqlCommand("DELETE TOP (1) FROM roysched WHERE " + Donde, cn);
            P(cmd, "@oti", SqlDbType.VarChar, oTi, 6);
            P(cmd, "@olo", SqlDbType.Int, oLo);
            P(cmd, "@ohi", SqlDbType.Int, oHi);
            P(cmd, "@oro", SqlDbType.Int, oRo);
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