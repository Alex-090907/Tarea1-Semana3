using System.Data;
using Microsoft.Data.SqlClient;

namespace PubsApp;

public partial class FrmAuthors : Form
{
    bool esNuevo = false;

    public FrmAuthors()
    {
        InitializeComponent();
    }

    private void FrmAuthors_Load(object? sender, EventArgs e)
    {
        Cargar();
    }

    void Cargar(string? seleccionar = null)
    {
        try
        {
            using var cn = new SqlConnection(Conexion.Cadena);
            var da = new SqlDataAdapter("SELECT * FROM authors ORDER BY au_lname", cn);
            var dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;

            if (seleccionar != null)
            {
                foreach (DataGridViewRow fila in dgv.Rows)
                {
                    if (fila.Cells["au_id"].Value?.ToString() == seleccionar)
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

        txtAuId.Text = r.Cells["au_id"].Value?.ToString();
        txtLname.Text = r.Cells["au_lname"].Value?.ToString();
        txtFname.Text = r.Cells["au_fname"].Value?.ToString();
        txtPhone.Text = r.Cells["phone"].Value?.ToString();
        txtAddress.Text = r.Cells["address"].Value?.ToString();
        txtCity.Text = r.Cells["city"].Value?.ToString();
        txtState.Text = r.Cells["state"].Value?.ToString();
        txtZip.Text = r.Cells["zip"].Value?.ToString();
        chkContract.Checked = r.Cells["contract"].Value is bool b && b;

        esNuevo = false;
        txtAuId.ReadOnly = true;
    }

    private void dgv_SelectionChanged(object? sender, EventArgs e)
    {
        MostrarFila();
    }

    void Limpiar()
    {
        txtAuId.Clear();
        txtLname.Clear();
        txtFname.Clear();
        txtPhone.Clear();
        txtAddress.Clear();
        txtCity.Clear();
        txtState.Clear();
        txtZip.Clear();
        chkContract.Checked = false;
    }

    static object V(string s)
    {
        return string.IsNullOrWhiteSpace(s) ? DBNull.Value : s.Trim();
    }

    private void btnNuevo_Click(object? sender, EventArgs e)
    {
        dgv.ClearSelection();
        Limpiar();
        esNuevo = true;
        txtAuId.ReadOnly = false;
        txtAuId.Focus();
    }

    private void btnGuardar_Click(object? sender, EventArgs e)
    {
        if (txtAuId.Text.Trim() == "" || txtLname.Text.Trim() == "" ||
            txtFname.Text.Trim() == "" || txtPhone.Text.Trim() == "")
        {
            MessageBox.Show("au_id, au_lname, au_fname y phone son obligatorios.");
            return;
        }

        string sql = esNuevo
            ? @"INSERT INTO authors (au_id, au_lname, au_fname, phone, address, city, state, zip, contract)
                VALUES (@id, @ln, @fn, @ph, @ad, @ci, @st, @zi, @co)"
            : @"UPDATE authors SET au_lname=@ln, au_fname=@fn, phone=@ph, address=@ad,
                city=@ci, state=@st, zip=@zi, contract=@co WHERE au_id=@id";

        try
        {
            using var cn = new SqlConnection(Conexion.Cadena);
            using var cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@id", txtAuId.Text.Trim());
            cmd.Parameters.AddWithValue("@ln", txtLname.Text.Trim());
            cmd.Parameters.AddWithValue("@fn", txtFname.Text.Trim());
            cmd.Parameters.AddWithValue("@ph", txtPhone.Text.Trim());
            cmd.Parameters.AddWithValue("@ad", V(txtAddress.Text));
            cmd.Parameters.AddWithValue("@ci", V(txtCity.Text));
            cmd.Parameters.AddWithValue("@st", V(txtState.Text));
            cmd.Parameters.AddWithValue("@zi", V(txtZip.Text));
            cmd.Parameters.AddWithValue("@co", chkContract.Checked);
            cn.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Registro guardado.");
            Cargar(txtAuId.Text.Trim());
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al guardar: " + ex.Message);
        }
    }

    private void btnEliminar_Click(object? sender, EventArgs e)
    {
        if (esNuevo || txtAuId.Text.Trim() == "")
        {
            MessageBox.Show("Seleccione un registro de la tabla.");
            return;
        }

        if (MessageBox.Show("¿Eliminar el autor " + txtAuId.Text + "?", "Confirmar",
            MessageBoxButtons.YesNo) != DialogResult.Yes) return;

        try
        {
            using var cn = new SqlConnection(Conexion.Cadena);
            using var cmd = new SqlCommand("DELETE FROM authors WHERE au_id=@id", cn);
            cmd.Parameters.AddWithValue("@id", txtAuId.Text.Trim());
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
        Cargar();
    }
}