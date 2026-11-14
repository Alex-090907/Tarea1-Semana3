using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;

namespace Floricola.BaseDatos
{
    public class ConexionMySql
    {
        private readonly string cn = "server=localhost;"+
            "database=floricola;"+
            "user=root;"+
            "password=;";


        public MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cn);
        }

        public bool ProbarConexion()
        {
            try
            {
                using (MySqlConnection conexion = ObtenerConexion())
                {
                    conexion.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message, 
                    "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }

}
