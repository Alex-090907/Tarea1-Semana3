using System.Data;
using Microsoft.Data.SqlClient;

namespace PubsApp;

public partial class FrmPublishers : Form
{
    bool esNuevo = false;

    public FrmPublishers()
    {
        InitializeComponent();
    }

    private void FrmPublishers_Load(object? sender, EventArgs e)
    {
        Cargar();
    }

    void Cargar(string? seleccionar = null)
    {
        try
        {
            using var cn = new SqlConnection(Conexion.Cadena);
            var da = new SqlDataAdapter("SELECT * FROM publishers ORDER BY pub_id", cn);
            var dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;

            if (seleccionar != null)
            {
                foreach (DataGridViewRow fila in dgv.Rows)
                {
                    if (fila.Cells["pub_id"].Value?.ToString() == seleccionar)
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

        txtPubId.Text = r.Cells["pub_id"].Value?.ToString();
        txtName.Text = r.Cells["pub_name"].Value?.ToString();
        txtCity.Text = r.Cells["city"].Value?.ToString();
        txtState.Text = r.Cells["state"].Value?.ToString();
        txtCountry.Text = r.Cells["country"].Value?.ToString();

        esNuevo = false;
        txtPubId.ReadOnly = true;
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
        txtPubId.Clear();
        txtName.Clear();
        txtCity.Clear();
        txtState.Clear();
        txtCountry.Clear();
        esNuevo = true;
        txtPubId.ReadOnly = false;
        txtPubId.Focus();
    }

    private void btnGuardar_Click(object? sender, EventArgs e)
    {
        if (txtPubId.Text.Trim() == "")
        {
            MessageBox.Show("pub_id es obligatorio.");
            return;
        }

        string sql = esNuevo
            ? @"INSERT INTO publishers (pub_id, pub_name, city, state, country)
                VALUES (@id, @nm, @ci, @st, @co)"
            : @"UPDATE publishers SET pub_name=@nm, city=@ci, state=@st, country=@co
                WHERE pub_id=@id";

        try
        {
            using var cn = new SqlConnection(Conexion.Cadena);
            using var cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@id", txtPubId.Text.Trim());
            cmd.Parameters.AddWithValue("@nm", V(txtName.Text));
            cmd.Parameters.AddWithValue("@ci", V(txtCity.Text));
            cmd.Parameters.AddWithValue("@st", V(txtState.Text));
            cmd.Parameters.AddWithValue("@co", V(txtCountry.Text));
            cn.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Registro guardado.");
            Cargar(txtPubId.Text.Trim());
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al guardar: " + ex.Message);
        }
    }

    private void btnEliminar_Click(object? sender, EventArgs e)
    {
        if (esNuevo || txtPubId.Text.Trim() == "")
        {
            MessageBox.Show("Seleccione un registro de la tabla.");
            return;
        }

        if (MessageBox.Show("¿Eliminar la editorial " + txtPubId.Text + "?", "Confirmar",
            MessageBoxButtons.YesNo) != DialogResult.Yes) return;

        try
        {
            using var cn = new SqlConnection(Conexion.Cadena);
            using var cmd = new SqlCommand("DELETE FROM publishers WHERE pub_id=@id", cn);
            cmd.Parameters.AddWithValue("@id", txtPubId.Text.Trim());
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