using Floricola.BaseDatos;
using Floricola.Modelos;
using MySqlConnector;

namespace Floricola.Controladores
{
    public class UsuariosController
    {
        public UsuarioModel IniciarSesion(string Nombre_Usuario, string Password)
        {
            if (string.IsNullOrEmpty(Nombre_Usuario) || string.IsNullOrEmpty(Password))
            {
                return null;
            }
            using var conexion = new ConexionMySql().ObtenerConexion();
            conexion.Open();
            string cadena = "Select * from usuarios where " +
                    "Nombre_Usuario = @Nombre_Usuario and " +
                    "Password_hash = @Password";

            using var comando = new MySqlCommand(cadena, conexion);
            comando.Parameters.AddWithValue("@Nombre_Usuario", Nombre_Usuario);
            comando.Parameters.AddWithValue("@Password", Password);

            using var lector = comando.ExecuteReader();

            if (lector.Read())
            {
                var user = new UsuarioModel
                {
                    Id = lector.GetInt32("id"),
                    Nombre_Usuario = lector.GetString("nombre_usuario"),
                    Password = lector.GetString("password_hash"),
                    Activo = lector.GetBoolean("activo")
                };
                return user;
            }
            else
            {
                return null;
            }
        }


        public bool CrearUsuario(UsuarioModel usuario)
        {
            using var conexion = new ConexionMySql().ObtenerConexion();
            conexion.Open();
            string cadena = "INSERT INTO usuarios (Nombre_Usuario, Password_hash, Activo) " +
                            "VALUES (@Nombre_Usuario, @Password, 1)";
            using var comando = new MySqlCommand(cadena, conexion);
            comando.Parameters.AddWithValue("@Nombre_Usuario", usuario.Nombre_Usuario);
            comando.Parameters.AddWithValue("@Password", usuario.Password);
            comando.Parameters.AddWithValue("@Activo", usuario.Activo);
            int filasAfectadas = comando.ExecuteNonQuery();
            return filasAfectadas > 0;
        }
        public bool ActualizarUsuario(UsuarioModel usuario)
        {
            using var conexion = new ConexionMySql().ObtenerConexion();
            conexion.Open();
            string cadena = "UPDATE usuarios SET Nombre_Usuario = @Nombre_Usuario, Password_hash = @Password, Activo = @Activo " +
                            "WHERE id = @Id";
            using var comando = new MySqlCommand(cadena, conexion);
            comando.Parameters.AddWithValue("@Id", usuario.Id);
            comando.Parameters.AddWithValue("@Nombre_Usuario", usuario.Nombre_Usuario);
            comando.Parameters.AddWithValue("@Password", usuario.Password);
            comando.Parameters.AddWithValue("@Activo", usuario.Activo);
            int filasAfectadas = comando.ExecuteNonQuery();
            return filasAfectadas > 0;
        }
        public bool EliminarUsuario(int id)
        {
            using var conexion = new ConexionMySql().ObtenerConexion();
            conexion.Open();
            string cadena = "DELETE FROM usuarios WHERE id = @Id";
            using var comando = new MySqlCommand(cadena, conexion);
            comando.Parameters.AddWithValue("@Id", id);
            int filasAfectadas = comando.ExecuteNonQuery();
            return filasAfectadas > 0;
        }
    }

}
