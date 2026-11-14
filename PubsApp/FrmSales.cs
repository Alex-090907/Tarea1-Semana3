using System.Data;
using Microsoft.Data.SqlClient;

namespace PubsApp;

public partial class FrmSales : Form
{
    bool esNuevo = false;

    public FrmSales()
    {
        InitializeComponent();
    }

    private void FrmSales_Load(object? sender, EventArgs e)
    {
        CargarCombos();
        Cargar();
    }

    void CargarCombos()
    {
        try
        {
            using var cn = new SqlConnection(Conexion.Cadena);

            var dtSt = new DataTable();
            new SqlDataAdapter(
                "SELECT stor_id, stor_id + ' - ' + ISNULL(stor_name, '') AS txt FROM stores ORDER BY stor_id", cn)
                .Fill(dtSt);
            cboStor.DisplayMember = "txt";
            cboStor.ValueMember = "stor_id";
            cboStor.DataSource = dtSt;

            var dtTi = new DataTable();
            new SqlDataAdapter(
                "SELECT title_id, title_id + ' - ' + title AS txt FROM titles ORDER BY title_id", cn)
                .Fill(dtTi);
            cboTitle.DisplayMember = "txt";
            cboTitle.ValueMember = "title_id";
            cboTitle.DataSource = dtTi;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al cargar listas: " + ex.Message);
        }
    }

    void Cargar(string? st = null, string? ord = null, string? ti = null)
    {
        try
        {
            using var cn = new SqlConnection(Conexion.Cadena);
            var da = new SqlDataAdapter("SELECT * FROM sales ORDER BY stor_id, ord_num, title_id", cn);
            var dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;

            if (st != null && ord != null && ti != null)
            {
                foreach (DataGridViewRow fila in dgv.Rows)
                {
                    if (fila.Cells["stor_id"].Value?.ToString() == st &&
                        fila.Cells["ord_num"].Value?.ToString() == ord &&
                        fila.Cells["title_id"].Value?.ToString() == ti)
                    {
                        dgv.CurrentCell = fila.Cells[0];
                        break;
                    }
                }
            }
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

        cboStor.SelectedValue = r.Cells["stor_id"].Value?.ToString() ?? "";
        txtOrd.Text = r.Cells["ord_num"].Value?.ToString();
        cboTitle.SelectedValue = r.Cells["title_id"].Value?.ToString() ?? "";
        if (r.Cells["ord_date"].Value is DateTime d) dtpDate.Value = d;
        txtQty.Text = r.Cells["qty"].Value?.ToString();
        txtPay.Text = r.Cells["payterms"].Value?.ToString();

        esNuevo = false;
        cboStor.Enabled = false;
        txtOrd.ReadOnly = true;
        cboTitle.Enabled = false;
    }

    private void dgv_SelectionChanged(object? sender, EventArgs e)
    {
        MostrarFila();
    }

    private void btnNuevo_Click(object? sender, EventArgs e)
    {
        dgv.ClearSelection();
        txtOrd.Clear();
        txtQty.Clear();
        txtPay.Clear();
        dtpDate.Value = DateTime.Now;
        esNuevo = true;
        cboStor.Enabled = true;
        cboTitle.Enabled = true;
        txtOrd.ReadOnly = false;
        cboStor.Focus();
    }

    private void btnGuardar_Click(object? sender, EventArgs e)
    {
        if (cboStor.SelectedValue == null || cboTitle.SelectedValue == null ||
            txtOrd.Text.Trim() == "" || txtPay.Text.Trim() == "")
        {
            MessageBox.Show("Tienda, ord_num, libro y payterms son obligatorios.");
            return;
        }
        if (!short.TryParse(txtQty.Text, out short qty))
        {
            MessageBox.Show("qty debe ser un número entero.");
            return;
        }

        string st = cboStor.SelectedValue.ToString()!;
        string ti = cboTitle.SelectedValue.ToString()!;
        string ord = txtOrd.Text.Trim();

        string sql = esNuevo
            ? @"INSERT INTO sales (stor_id, ord_num, ord_date, qty, payterms, title_id)
                VALUES (@st, @or, @fe, @qt, @pa, @ti)"
            : @"UPDATE sales SET ord_date=@fe, qty=@qt, payterms=@pa
                WHERE stor_id=@st AND ord_num=@or AND title_id=@ti";

        try
        {
            using var cn = new SqlConnection(Conexion.Cadena);
            using var cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@st", st);
            cmd.Parameters.AddWithValue("@or", ord);
            cmd.Parameters.AddWithValue("@fe", dtpDate.Value);
            cmd.Parameters.AddWithValue("@qt", qty);
            cmd.Parameters.AddWithValue("@pa", txtPay.Text.Trim());
            cmd.Parameters.AddWithValue("@ti", ti);
            cn.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Registro guardado.");
            Cargar(st, ord, ti);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al guardar: " + ex.Message);
        }
    }

    private void btnEliminar_Click(object? sender, EventArgs e)
    {
        if (esNuevo || cboStor.SelectedValue == null || cboTitle.SelectedValue == null)
        {
            MessageBox.Show("Seleccione un registro de la tabla.");
            return;
        }

        if (MessageBox.Show("¿Eliminar esta venta?", "Confirmar",
            MessageBoxButtons.YesNo) != DialogResult.Yes) return;

        try
        {
            using var cn = new SqlConnection(Conexion.Cadena);
            using var cmd = new SqlCommand(
                "DELETE FROM sales WHERE stor_id=@st AND ord_num=@or AND title_id=@ti", cn);
            cmd.Parameters.AddWithValue("@st", cboStor.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@or", txtOrd.Text.Trim());
            cmd.Parameters.AddWithValue("@ti", cboTitle.SelectedValue.ToString());
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
        CargarCombos();
        Cargar();
    }
}