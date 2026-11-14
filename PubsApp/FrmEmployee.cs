using System.Data;
using Microsoft.Data.SqlClient;

namespace PubsApp;

public partial class FrmEmployee : Form
{
    bool esNuevo = false;

    public FrmEmployee()
    {
        InitializeComponent();
    }

    private void FrmEmployee_Load(object? sender, EventArgs e)
    {
        Cargar();
    }

    void Cargar(string? seleccionar = null)
    {
        try
        {
            using var cn = new SqlConnection(Conexion.Cadena);
            var da = new SqlDataAdapter("SELECT * FROM employee ORDER BY lname, fname", cn);
            var dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;

            if (seleccionar != null)
            {
                foreach (DataGridViewRow fila in dgv.Rows)
                {
                    if (fila.Cells["emp_id"].Value?.ToString() == seleccionar)
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

        txtId.Text = r.Cells["emp_id"].Value?.ToString();
        txtFname.Text = r.Cells["fname"].Value?.ToString();
        txtMinit.Text = r.Cells["minit"].Value?.ToString();
        txtLname.Text = r.Cells["lname"].Value?.ToString();
        txtJob.Text = r.Cells["job_id"].Value?.ToString();
        txtLvl.Text = r.Cells["job_lvl"].Value?.ToString();
        txtPub.Text = r.Cells["pub_id"].Value?.ToString();
        if (r.Cells["hire_date"].Value is DateTime d) dtpHire.Value = d;

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
        txtFname.Clear();
        txtMinit.Clear();
        txtLname.Clear();
        txtJob.Clear();
        txtLvl.Clear();
        txtPub.Clear();
        dtpHire.Value = DateTime.Now;
        esNuevo = true;
        txtId.ReadOnly = false;
        txtId.Focus();
    }

    private void btnGuardar_Click(object? sender, EventArgs e)
    {
        if (txtId.Text.Trim() == "" || txtFname.Text.Trim() == "" ||
            txtLname.Text.Trim() == "" || txtPub.Text.Trim() == "")
        {
            MessageBox.Show("emp_id, fname, lname y pub_id son obligatorios.");
            return;
        }
        if (!short.TryParse(txtJob.Text, out short job))
        {
            MessageBox.Show("job_id debe ser un número.");
            return;
        }
        object lvl = DBNull.Value;
        if (txtLvl.Text.Trim() != "")
        {
            if (!byte.TryParse(txtLvl.Text, out byte l))
            {
                MessageBox.Show("job_lvl debe ser un número entre 0 y 255.");
                return;
            }
            lvl = l;
        }

        string sql = esNuevo
            ? @"INSERT INTO employee (emp_id, fname, minit, lname, job_id, job_lvl, pub_id, hire_date)
                VALUES (@id, @fn, @mi, @ln, @jo, @lv, @pu, @hd)"
            : @"UPDATE employee SET fname=@fn, minit=@mi, lname=@ln, job_id=@jo, job_lvl=@lv,
                pub_id=@pu, hire_date=@hd WHERE emp_id=@id";

        try
        {
            using var cn = new SqlConnection(Conexion.Cadena);
            using var cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@id", txtId.Text.Trim());
            cmd.Parameters.AddWithValue("@fn", txtFname.Text.Trim());
            cmd.Parameters.AddWithValue("@mi", V(txtMinit.Text));
            cmd.Parameters.AddWithValue("@ln", txtLname.Text.Trim());
            cmd.Parameters.AddWithValue("@jo", job);
            cmd.Parameters.AddWithValue("@lv", lvl);
            cmd.Parameters.AddWithValue("@pu", txtPub.Text.Trim());
            cmd.Parameters.AddWithValue("@hd", dtpHire.Value);
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

        if (MessageBox.Show("¿Eliminar el empleado " + txtId.Text + "?", "Confirmar",
            MessageBoxButtons.YesNo) != DialogResult.Yes) return;

        try
        {
            using var cn = new SqlConnection(Conexion.Cadena);
            using var cmd = new SqlCommand("DELETE FROM employee WHERE emp_id=@id", cn);
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