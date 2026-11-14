namespace PubsApp;

public partial class FrmLogin : Form
{
    int intentos = 0;
    const int MaxIntentos = 3;

    public FrmLogin()
    {
        InitializeComponent();
    }

    // Cambia esto por la validación de tu login de clase
    bool Validar(string usuario, string clave)
    {
        return usuario == "admin" && clave == "1234";
    }

    private void btnIngresar_Click(object? sender, EventArgs e)
    {
        if (Validar(txtUsuario.Text.Trim(), txtClave.Text))
        {
            DialogResult = DialogResult.OK;
            return;
        }

        intentos++;
        if (intentos >= MaxIntentos)
        {
            MessageBox.Show("Superó el número de intentos. El programa se cerrará.");
            DialogResult = DialogResult.Cancel;
            return;
        }

        MessageBox.Show($"Datos incorrectos. Intento {intentos} de {MaxIntentos}.");
        txtClave.Clear();
        txtClave.Focus();
    }
}