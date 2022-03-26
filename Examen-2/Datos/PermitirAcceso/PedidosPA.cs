using Datos.AlmacenarEntidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.PermitirAcceso
{
    public  class PedidosPA
    {
        readonly string cadena = "Server=localhost; Port=3306; Database=examen2; Uid=root; Pwd=123456;";

        MySqlConnection conn;
        MySqlCommand cmd;

        public int InsertarPedido(Pedidos pedido)
        {
            int idPedido = 0;
            try
            {
                string sql = "INSERT INTO pedidos (IdCliente, Cliente, Fecha) VALUES (@IdCliente, @Cliente, @Fecha); select last_insert_idPedidos();";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@idCliente", pedido.IdCliente);
                cmd.Parameters.AddWithValue("@Cliente", pedido.Cliente);
                cmd.Parameters.AddWithValue("@Fecha", pedido.Fecha);
                idPedido = Convert.ToInt32(cmd.ExecuteScalar());


                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return idPedido;
        }

        public bool InsertarDetalle(DetallePedidos detallePedidos)
        {
            bool inserto = false;
            try
            {
                string sql = "INSERT INTO detallepedidos (idPedidos, CodigoProducto, Descripcion, Cantidad, Precio, Total) VALUES (@idPedidos, @CodigoProducto, @Descripcion, @Cantidad, @Precio, @Total);";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@idPedidos", detallePedidos.idPedidos);
                cmd.Parameters.AddWithValue("@CodigoProducto", detallePedidos.CodigoProducto);
                cmd.Parameters.AddWithValue("@Descripcion", detallePedidos.Descripcion);
                cmd.Parameters.AddWithValue("@Cantidad", detallePedidos.Cantidad);
                cmd.Parameters.AddWithValue("@Precio", detallePedidos.Precio);
                cmd.Parameters.AddWithValue("@Total", detallePedidos.Total);
                cmd.ExecuteNonQuery();

                inserto = true;
                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return inserto;
        }
    }
}
