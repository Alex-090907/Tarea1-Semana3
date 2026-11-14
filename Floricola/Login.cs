using Floricola.Vistas;

namespace Floricola
{
    using Floricola.Controladores;
    public partial class Login : Form
    {
        private readonly UsuariosController _usuariosController;
        private int intentos = 0;
        private const int MaxIntentos = 3;

        public Login()
        {
            InitializeComponent();
            _usuariosController = new UsuariosController();
        }

        public async void button3_Click(object sender, EventArgs e)
        {

            string nombreUsuario = textBox1.Text;
            string password = textBox2.Text;

            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(password))
            {
                lblMensaje.Text = "Por favor, ingrese su usuario \n y contraseña.";
                return;
            }

            try
            {
                var usuarioValido = _usuariosController.IniciarSesion(nombreUsuario, password);
                if (usuarioValido == null)
                {
                    intentos++;
                    if (intentos >= MaxIntentos)
                    {
                        MessageBox.Show("Superó el número de intentos. El programa se cerrará.");
                        Application.Exit();
                        return;
                    }
                    lblMensaje.Text = $"Usuario o contraseña incorrectos.\nIntento {intentos} de {MaxIntentos}.";
                    return;
                }
                lblMensaje.Text = "Bienvenido, " + usuarioValido.Nombre_Usuario;

                await Task.Delay(2000); // Espera 1 segundo antes de abrir el Dashboard

                var dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();



            }
            catch (Exception)
            {
                throw;
            }

            
        }

        public async void grabar()
        {
            var usuario = new Modelos.UsuarioModel
            {
                Nombre_Usuario = "admin",
                Password = "admin123",
                Activo = true
            };

            if (_usuariosController.CrearUsuario(usuario))
            {
                lblMensaje.Text = "Usuario creado correctamente.";
            }
            else
            {
                lblMensaje.Text = "Error al crear el usuario.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}