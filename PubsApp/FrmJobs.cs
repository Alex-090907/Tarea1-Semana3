using System.Data;
using Microsoft.Data.SqlClient;

namespace PubsApp;

public partial class FrmJobs : Form
{
    bool esNuevo = false;

    public FrmJobs()
    {
        InitializeComponent();
    }

    private void FrmJobs_Load(object? sender, EventArgs e)
    {
        Cargar();
    }

    void Cargar(string? seleccionar = null)
    {
        try
        {
            using var cn = new SqlConnection(Conexion.Cadena);
            var da = new SqlDataAdapter("SELECT * FROM jobs ORDER BY job_id", cn);
            var dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;

            if (seleccionar != null)
            {
                foreach (DataGridViewRow fila in dgv.Rows)
                {
                    if (fila.Cells["job_id"].Value?.ToString() == seleccionar)
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

        txtId.Text = r.Cells["job_id"].Value?.ToString();
        txtDesc.Text = r.Cells["job_desc"].Value?.ToString();
        txtMin.Text = r.Cells["min_lvl"].Value?.ToString();
        txtMax.Text = r.Cells["max_lvl"].Value?.ToString();
        esNuevo = false;
    }

    private void dgv_SelectionChanged(object? sender, EventArgs e)
    {
        MostrarFila();
    }

    private void btnNuevo_Click(object? sender, EventArgs e)
    {
        dgv.ClearSelection();
        txtId.Clear();
        txtDesc.Clear();
        txtMin.Clear();
        txtMax.Clear();
        esNuevo = true;
        txtDesc.Focus();
    }

    private void btnGuardar_Click(object? sender, EventArgs e)
    {
        if (txtDesc.Text.Trim() == "")
        {
            MessageBox.Show("job_desc es obligatorio.");
            return;
        }
        if (!byte.TryParse(txtMin.Text, out byte min) || !byte.TryParse(txtMax.Text, out byte max))
        {
            MessageBox.Show("min_lvl y max_lvl deben ser números entre 0 y 255.");
            return;
        }

        try
        {
            using var cn = new SqlConnection(Conexion.Cadena);
            using var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Parameters.AddWithValue("@ds", txtDesc.Text.Trim());
            cmd.Parameters.AddWithValue("@mn", min);
            cmd.Parameters.AddWithValue("@mx", max);

            if (esNuevo)
            {
                cmd.CommandText = @"INSERT INTO jobs (job_desc, min_lvl, max_lvl)
                                    OUTPUT INSERTED.job_id VALUES (@ds, @mn, @mx)";
            }
            else
            {
                cmd.CommandText = @"UPDATE jobs SET job_desc=@ds, min_lvl=@mn, max_lvl=@mx
                                    WHERE job_id=@id";
                cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
            }

            cn.Open();
            object? res = cmd.ExecuteScalar();
            string id = esNuevo ? res!.ToString()! : txtId.Text;

            MessageBox.Show("Registro guardado.");
            Cargar(id);
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

        if (MessageBox.Show("¿Eliminar el puesto " + txtId.Text + "?", "Confirmar",
            MessageBoxButtons.YesNo) != DialogResult.Yes) return;

        try
        {
            using var cn = new SqlConnection(Conexion.Cadena);
            using var cmd = new SqlCommand("DELETE FROM jobs WHERE job_id=@id", cn);
            cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
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