using System.Data;
using System.Globalization;
using Microsoft.Data.SqlClient;

namespace PubsApp;

public partial class FrmTitles : Form
{
    bool esNuevo = false;

    public FrmTitles()
    {
        InitializeComponent();
    }

    private void FrmTitles_Load(object? sender, EventArgs e)
    {
        Cargar();
    }

    void Cargar(string? seleccionar = null)
    {
        try
        {
            using var cn = new SqlConnection(Conexion.Cadena);
            var da = new SqlDataAdapter("SELECT * FROM titles ORDER BY title_id", cn);
            var dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;

            if (seleccionar != null)
            {
                foreach (DataGridViewRow fila in dgv.Rows)
                {
                    if (fila.Cells["title_id"].Value?.ToString() == seleccionar)
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

    static string F(object? v)
    {
        return v == null || v == DBNull.Value
            ? ""
            : Convert.ToDecimal(v).ToString("0.00", CultureInfo.InvariantCulture);
    }

    void MostrarFila()
    {
        var r = dgv.CurrentRow;
        if (r == null) return;

        txtId.Text = r.Cells["title_id"].Value?.ToString();
        txtTitle.Text = r.Cells["title"].Value?.ToString();
        txtType.Text = r.Cells["type"].Value?.ToString()?.Trim();
        txtPub.Text = r.Cells["pub_id"].Value?.ToString();
        txtPrice.Text = F(r.Cells["price"].Value);
        txtAdvance.Text = F(r.Cells["advance"].Value);
        txtRoyalty.Text = r.Cells["royalty"].Value?.ToString();
        txtYtd.Text = r.Cells["ytd_sales"].Value?.ToString();
        txtNotes.Text = r.Cells["notes"].Value?.ToString();
        if (r.Cells["pubdate"].Value is DateTime d) dtpPubdate.Value = d;

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

    static bool Dec(string s, out object v)
    {
        s = s.Trim();
        v = DBNull.Value;
        if (s == "") return true;
        if (decimal.TryParse(s, NumberStyles.Number, CultureInfo.InvariantCulture, out var d))
        {
            v = d;
            return true;
        }
        return false;
    }

    static bool Ent(string s, out object v)
    {
        s = s.Trim();
        v = DBNull.Value;
        if (s == "") return true;
        if (int.TryParse(s, out var i))
        {
            v = i;
            return true;
        }
        return false;
    }

    private void btnNuevo_Click(object? sender, EventArgs e)
    {
        dgv.ClearSelection();
        txtId.Clear();
        txtTitle.Clear();
        txtType.Clear();
        txtPub.Clear();
        txtPrice.Clear();
        txtAdvance.Clear();
        txtRoyalty.Clear();
        txtYtd.Clear();
        txtNotes.Clear();
        dtpPubdate.Value = DateTime.Now;
        esNuevo = true;
        txtId.ReadOnly = false;
        txtId.Focus();
    }

    private void btnGuardar_Click(object? sender, EventArgs e)
    {
        if (txtId.Text.Trim() == "" || txtTitle.Text.Trim() == "" || txtType.Text.Trim() == "")
        {
            MessageBox.Show("title_id, title y type son obligatorios.");
            return;
        }
        if (!Dec(txtPrice.Text, out object price) || !Dec(txtAdvance.Text, out object adv))
        {
            MessageBox.Show("price y advance deben ser números (use punto decimal, ej. 19.99).");
            return;
        }
        if (!Ent(txtRoyalty.Text, out object roy) || !Ent(txtYtd.Text, out object ytd))
        {
            MessageBox.Show("royalty y ytd_sales deben ser números enteros.");
            return;
        }

        string sql = esNuevo
            ? @"INSERT INTO titles (title_id, title, type, pub_id, price, advance, royalty, ytd_sales, notes, pubdate)
                VALUES (@id, @ti, @ty, @pu, @pr, @ad, @ro, @yt, @no, @pd)"
            : @"UPDATE titles SET title=@ti, type=@ty, pub_id=@pu, price=@pr, advance=@ad,
                royalty=@ro, ytd_sales=@yt, notes=@no, pubdate=@pd WHERE title_id=@id";

        try
        {
            using var cn = new SqlConnection(Conexion.Cadena);
            using var cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@id", txtId.Text.Trim());
            cmd.Parameters.AddWithValue("@ti", txtTitle.Text.Trim());
            cmd.Parameters.AddWithValue("@ty", txtType.Text.Trim());
            cmd.Parameters.AddWithValue("@pu", V(txtPub.Text));
            cmd.Parameters.AddWithValue("@pr", price);
            cmd.Parameters.AddWithValue("@ad", adv);
            cmd.Parameters.AddWithValue("@ro", roy);
            cmd.Parameters.AddWithValue("@yt", ytd);
            cmd.Parameters.AddWithValue("@no", V(txtNotes.Text));
            cmd.Parameters.AddWithValue("@pd", dtpPubdate.Value);
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

        if (MessageBox.Show("¿Eliminar el libro " + txtId.Text + "?", "Confirmar",
            MessageBoxButtons.YesNo) != DialogResult.Yes) return;

        try
        {
            using var cn = new SqlConnection(Conexion.Cadena);
            using var cmd = new SqlCommand("DELETE FROM titles WHERE title_id=@id", cn);
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