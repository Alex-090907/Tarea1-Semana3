using System.Data;
using Microsoft.Data.SqlClient;

namespace PubsApp;

public partial class FrmTitleAuthor : Form
{
    bool esNuevo = false;

    public FrmTitleAuthor()
    {
        InitializeComponent();
    }

    private void FrmTitleAuthor_Load(object? sender, EventArgs e)
    {
        CargarCombos();
        Cargar();
    }

    void CargarCombos()
    {
        try
        {
            using var cn = new SqlConnection(Conexion.Cadena);

            var dtAu = new DataTable();
            new SqlDataAdapter(
                "SELECT au_id, au_id + ' - ' + au_lname AS txt FROM authors ORDER BY au_lname", cn)
                .Fill(dtAu);
            cboAu.DisplayMember = "txt";
            cboAu.ValueMember = "au_id";
            cboAu.DataSource = dtAu;

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

    void Cargar(string? au = null, string? ti = null)
    {
        try
        {
            using var cn = new SqlConnection(Conexion.Cadena);
            var da = new SqlDataAdapter("SELECT * FROM titleauthor ORDER BY au_id, title_id", cn);
            var dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;

            if (au != null && ti != null)
            {
                foreach (DataGridViewRow fila in dgv.Rows)
                {
                    if (fila.Cells["au_id"].Value?.ToString() == au &&
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

        cboAu.SelectedValue = r.Cells["au_id"].Value?.ToString() ?? "";
        cboTitle.SelectedValue = r.Cells["title_id"].Value?.ToString() ?? "";
        txtOrd.Text = r.Cells["au_ord"].Value?.ToString();
        txtRoy.Text = r.Cells["royaltyper"].Value?.ToString();

        esNuevo = false;
        cboAu.Enabled = false;
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
        txtRoy.Clear();
        esNuevo = true;
        cboAu.Enabled = true;
        cboTitle.Enabled = true;
        cboAu.Focus();
    }

    private void btnGuardar_Click(object? sender, EventArgs e)
    {
        if (cboAu.SelectedValue == null || cboTitle.SelectedValue == null)
        {
            MessageBox.Show("Seleccione el autor y el libro.");
            return;
        }

        object ord = DBNull.Value;
        object roy = DBNull.Value;
        if (txtOrd.Text.Trim() != "")
        {
            if (!byte.TryParse(txtOrd.Text, out byte o))
            {
                MessageBox.Show("au_ord debe ser un número entre 0 y 255.");
                return;
            }
            ord = o;
        }
        if (txtRoy.Text.Trim() != "")
        {
            if (!int.TryParse(txtRoy.Text, out int p))
            {
                MessageBox.Show("royaltyper debe ser un número entero.");
                return;
            }
            roy = p;
        }

        string au = cboAu.SelectedValue.ToString()!;
        string ti = cboTitle.SelectedValue.ToString()!;

        string sql = esNuevo
            ? @"INSERT INTO titleauthor (au_id, title_id, au_ord, royaltyper)
                VALUES (@au, @ti, @or, @ro)"
            : @"UPDATE titleauthor SET au_ord=@or, royaltyper=@ro
                WHERE au_id=@au AND title_id=@ti";

        try
        {
            using var cn = new SqlConnection(Conexion.Cadena);
            using var cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@au", au);
            cmd.Parameters.AddWithValue("@ti", ti);
            cmd.Parameters.AddWithValue("@or", ord);
            cmd.Parameters.AddWithValue("@ro", roy);
            cn.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Registro guardado.");
            Cargar(au, ti);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al guardar: " + ex.Message);
        }
    }

    private void btnEliminar_Click(object? sender, EventArgs e)
    {
        if (esNuevo || cboAu.SelectedValue == null || cboTitle.SelectedValue == null)
        {
            MessageBox.Show("Seleccione un registro de la tabla.");
            return;
        }

        if (MessageBox.Show("¿Eliminar este registro?", "Confirmar",
            MessageBoxButtons.YesNo) != DialogResult.Yes) return;

        try
        {
            using var cn = new SqlConnection(Conexion.Cadena);
            using var cmd = new SqlCommand(
                "DELETE FROM titleauthor WHERE au_id=@au AND title_id=@ti", cn);
            cmd.Parameters.AddWithValue("@au", cboAu.SelectedValue.ToString());
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