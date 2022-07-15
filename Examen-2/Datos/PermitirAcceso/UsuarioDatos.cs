using Datos.AlmacenarEntidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.PermitirAcceso
{
    public class UsuarioDatos
    {
        readonly string cadena ="Data Source=localhost; Initial Catalog=examenII; User ID=root; Password=123456";
        MySqlConnection conexion;
        MySqlCommand comando;

        public Usuario ValidarUsuario(string Codigo, string Clave)
        {
            Usuario usuario = null;

            try
            {
                string sql = "SELECT * FROM usuario WHERE Codigo=@Codigo AND Clave=@Clave;";
                conexion = new MySqlConnection(cadena);
                conexion.Open();
                comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@Codigo", Codigo);
                comando.Parameters.AddWithValue("@Clave", Clave);
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    usuario = new Usuario();
                    usuario.Codigo = reader[0].ToString();
                    usuario.Nombre = reader[1].ToString();
                    usuario.Email = reader[2].ToString();
                    usuario.Clave = reader[3].ToString();
                }
                reader.Close();
                conexion.Close();
            }
            catch (Exception)
            {

            }
            return usuario;
        }


    }
}
