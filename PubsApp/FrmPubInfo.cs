using System.Data;
using Microsoft.Data.SqlClient;

namespace PubsApp;

public partial class FrmPubInfo : Form
{
    bool esNuevo = false;
    byte[]? logoBytes;

    public FrmPubInfo()
    {
        InitializeComponent();
    }

    private void FrmPubInfo_Load(object? sender, EventArgs e)
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
                "SELECT pub_id, pub_id + ' - ' + ISNULL(pub_name, '') AS txt FROM publishers ORDER BY pub_id", cn)
                .Fill(dt);
            cboPub.DisplayMember = "txt";
            cboPub.ValueMember = "pub_id";
            cboPub.DataSource = dt;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al cargar lista: " + ex.Message);
        }
    }

    void Cargar(string? seleccionar = null)
    {
        try
        {
            using var cn = new SqlConnection(Conexion.Cadena);
            var da = new SqlDataAdapter(
                @"SELECT pub_id,
                         CASE WHEN logo IS NULL THEN 'No' ELSE 'Sí' END AS logo,
                         CAST(pr_info AS varchar(100)) AS pr_info
                  FROM pub_info ORDER BY pub_id", cn);
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

    void MostrarLogo(byte[]? bytes)
    {
        logoBytes = bytes;
        picLogo.Image?.Dispose();
        picLogo.Image = null;
        if (bytes == null) return;
        try
        {
            picLogo.Image = Image.FromStream(new MemoryStream(bytes));
        }
        catch
        {
            picLogo.Image = null;
        }
    }

    void MostrarFila()
    {
        var r = dgv.CurrentRow;
        if (r == null) return;

        string id = r.Cells["pub_id"].Value?.ToString() ?? "";
        cboPub.SelectedValue = id;

        try
        {
            using var cn = new SqlConnection(Conexion.Cadena);
            using var cmd = new SqlCommand("SELECT logo, pr_info FROM pub_info WHERE pub_id=@id", cn);
            cmd.Parameters.AddWithValue("@id", id);
            cn.Open();
            using var rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                MostrarLogo(rd.IsDBNull(0) ? null : (byte[])rd[0]);
                string info = rd.IsDBNull(1) ? "" : rd.GetString(1);
                txtInfo.Text = info.Replace("\r\n", "\n").Replace("\n", "\r\n");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al leer el registro: " + ex.Message);
        }

        esNuevo = false;
        cboPub.Enabled = false;
    }

    private void dgv_SelectionChanged(object? sender, EventArgs e)
    {
        MostrarFila();
    }

    private void btnCargarLogo_Click(object? sender, EventArgs e)
    {
        using var dlg = new OpenFileDialog
        {
            Filter = "Imágenes|*.gif;*.jpg;*.jpeg;*.png;*.bmp"
        };
        if (dlg.ShowDialog() != DialogResult.OK) return;

        try
        {
            MostrarLogo(File.ReadAllBytes(dlg.FileName));
        }
        catch (Exception ex)
        {
            MessageBox.Show("No se pudo cargar la imagen: " + ex.Message);
        }
    }

    private void btnQuitarLogo_Click(object? sender, EventArgs e)
    {
        MostrarLogo(null);
    }

    private void btnNuevo_Click(object? sender, EventArgs e)
    {
        dgv.ClearSelection();
        MostrarLogo(null);
        txtInfo.Clear();
        esNuevo = true;
        cboPub.Enabled = true;
        cboPub.Focus();
    }

    private void btnGuardar_Click(object? sender, EventArgs e)
    {
        if (cboPub.SelectedValue == null)
        {
            MessageBox.Show("Seleccione la editorial.");
            return;
        }

        string id = cboPub.SelectedValue.ToString()!;

        string sql = esNuevo
            ? "INSERT INTO pub_info (pub_id, logo, pr_info) VALUES (@id, @lo, @pr)"
            : "UPDATE pub_info SET logo=@lo, pr_info=@pr WHERE pub_id=@id";

        try
        {
            using var cn = new SqlConnection(Conexion.Cadena);
            using var cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.Add("@lo", SqlDbType.VarBinary, -1).Value =
                (object?)logoBytes ?? DBNull.Value;
            cmd.Parameters.Add("@pr", SqlDbType.VarChar, -1).Value =
                string.IsNullOrWhiteSpace(txtInfo.Text) ? DBNull.Value : txtInfo.Text;
            cn.Open();
            cmd.ExecuteNonQuery();

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
        if (esNuevo || cboPub.SelectedValue == null)
        {
            MessageBox.Show("Seleccione un registro de la tabla.");
            return;
        }

        if (MessageBox.Show("¿Eliminar la información de la editorial " + cboPub.SelectedValue + "?",
            "Confirmar", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

        try
        {
            using var cn = new SqlConnection(Conexion.Cadena);
            using var cmd = new SqlCommand("DELETE FROM pub_info WHERE pub_id=@id", cn);
            cmd.Parameters.AddWithValue("@id", cboPub.SelectedValue.ToString());
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