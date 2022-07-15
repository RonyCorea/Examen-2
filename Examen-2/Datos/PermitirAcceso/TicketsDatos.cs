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
    public class TicketsDatos
    {
        readonly string cadena = "Data Source=localhost; Initial Catalog=examenII; User ID=root; Password=123456";
        MySqlConnection conexion;
        MySqlCommand comando;

        public DataTable DevolverTickets()
        {
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM tickets;";
                conexion = new MySqlConnection(cadena);
                conexion.Open();

                comando = new MySqlCommand(sql, conexion);

                MySqlDataReader reader = comando.ExecuteReader();
                dt.Load(reader);
                reader.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {
            }
            return dt;
        }

        public bool GenerarTickets(Tickets tickets)
        {
            bool insert = false;
            try
            {
                string sql = "INSERT INTO tickets VALUES (@Id, @Fecha, @NombreCliente, @TipoSoporte, @TipoEquipo, @DescripcionProblema, @Costo, @DescripcionSolucion);";

                conexion = new MySqlConnection(cadena);
                conexion.Open();

                comando = new MySqlCommand(sql, conexion);

                comando.Parameters.AddWithValue("@Id", tickets.Id);
                comando.Parameters.AddWithValue("@Fecha", tickets.Fecha);
                comando.Parameters.AddWithValue("@NombreCliente", tickets.NombreCliente);
                comando.Parameters.AddWithValue("@TipoSoporte", tickets.TipoSoporte);
                comando.Parameters.AddWithValue("@TipoEquipo", tickets.TipoEquipo);
                comando.Parameters.AddWithValue("@DescripcionProblema", tickets.DescripcionProblema);
                comando.Parameters.AddWithValue("@Costo", tickets.Costo);
                comando.Parameters.AddWithValue("@DescripcionSolucion", tickets.DescripcionSolucion);
                comando.ExecuteNonQuery();
                insert = true;

                conexion.Close();
            }
            catch (Exception)
            {
            }
            return insert;
        }

        public Tickets GetTicketsPorCodigo(string id)
        {
            Tickets tickets = new Tickets();
            try
            {
                string sql = "Select * from tickets WHERE Id = @Id;";

                conexion = new MySqlConnection(cadena);
                conexion.Open();

                comando = new MySqlCommand(sql, conexion);

                comando.Parameters.AddWithValue("@Id", id);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    tickets.Id = reader["Id"].ToString();
                    tickets.Fecha = reader["Fecha"].ToString();
                    tickets.NombreCliente = reader["NombreCliente"].ToString();
                    tickets.TipoSoporte = reader["TipoSoporte"].ToString();
                    tickets.TipoEquipo = reader["TipoEquipo"].ToString();
                    tickets.DescripcionProblema = reader["DescripcionProblema"].ToString();
                    tickets.Costo = Convert.ToDouble(reader["Costo"]);
                    tickets.DescripcionSolucion = reader["DescripcionSolucion"].ToString();
                }

                conexion.Close();
            }
            catch (Exception)
            {
            }
            return tickets;
        }
    }
}
