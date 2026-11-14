using System.Data;
using Microsoft.Data.SqlClient;

namespace PubsApp;

public partial class FrmStores : Form
{
    bool esNuevo = false;

    public FrmStores()
    {
        InitializeComponent();
    }

    private void FrmStores_Load(object? sender, EventArgs e)
    {
        Cargar();
    }

    void Cargar(string? seleccionar = null)
    {
        try
        {
            using var cn = new SqlConnection(Conexion.Cadena);
            var da = new SqlDataAdapter("SELECT * FROM stores ORDER BY stor_id", cn);
            var dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;

            if (seleccionar != null)
            {
                foreach (DataGridViewRow fila in dgv.Rows)
                {
                    if (fila.Cells["stor_id"].Value?.ToString() == seleccionar)
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

        txtId.Text = r.Cells["stor_id"].Value?.ToString();
        txtName.Text = r.Cells["stor_name"].Value?.ToString();
        txtAddress.Text = r.Cells["stor_address"].Value?.ToString();
        txtCity.Text = r.Cells["city"].Value?.ToString();
        txtState.Text = r.Cells["state"].Value?.ToString();
        txtZip.Text = r.Cells["zip"].Value?.ToString();

        esNuevo = false;
        txtId.ReadOnly = true;
    }

    private void dgv_SelectionChanged(object? sender, EventArgs e)
    {
        MostrarFila();
    }

    static object V(string s)
    {
        return string.IsNullOrWhiteSpace(s) ? DBNull.Value : s.Trim();
    }

    private void btnNuevo_Click(object? sender, EventArgs e)
    {
        dgv.ClearSelection();
        txtId.Clear();
        txtName.Clear();
        txtAddress.Clear();
        txtCity.Clear();
        txtState.Clear();
        txtZip.Clear();
        esNuevo = true;
        txtId.ReadOnly = false;
        txtId.Focus();
    }

    private void btnGuardar_Click(object? sender, EventArgs e)
    {
        if (txtId.Text.Trim() == "")
        {
            MessageBox.Show("stor_id es obligatorio.");
            return;
        }

        string sql = esNuevo
            ? @"INSERT INTO stores (stor_id, stor_name, stor_address, city, state, zip)
                VALUES (@id, @nm, @ad, @ci, @st, @zi)"
            : @"UPDATE stores SET stor_name=@nm, stor_address=@ad, city=@ci, state=@st, zip=@zi
                WHERE stor_id=@id";

        try
        {
            using var cn = new SqlConnection(Conexion.Cadena);
            using var cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@id", txtId.Text.Trim());
            cmd.Parameters.AddWithValue("@nm", V(txtName.Text));
            cmd.Parameters.AddWithValue("@ad", V(txtAddress.Text));
            cmd.Parameters.AddWithValue("@ci", V(txtCity.Text));
            cmd.Parameters.AddWithValue("@st", V(txtState.Text));
            cmd.Parameters.AddWithValue("@zi", V(txtZip.Text));
            cn.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Registro guardado.");
            Cargar(txtId.Text.Trim());
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al guardar: " + ex.Message);
        }
    }

    private void btnEliminar_Click(object? sender, EventArgs e)
    {
        if (esNuevo || txtId.Text.Trim() == "")
        {
            MessageBox.Show("Seleccione un registro de la tabla.");
            return;
        }

        if (MessageBox.Show("¿Eliminar la tienda " + txtId.Text + "?", "Confirmar",
            MessageBoxButtons.YesNo) != DialogResult.Yes) return;

        try
        {
            using var cn = new SqlConnection(Conexion.Cadena);
            using var cmd = new SqlCommand("DELETE FROM stores WHERE stor_id=@id", cn);
            cmd.Parameters.AddWithValue("@id", txtId.Text.Trim());
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