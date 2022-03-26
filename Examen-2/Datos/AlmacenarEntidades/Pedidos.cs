using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.AlmacenarEntidades
{
    public class Pedidos
    {
        public int idPedidos { get; set; }
        public string IdCliente { get; set; }
        public string Cliente { get; set; }
        public DateTime Fecha { get; set; }

        public Pedidos()
        {

        }

        public Pedidos(int idPedidos, string idCliente, string cliente, DateTime fecha)
        {
            this.idPedidos = idPedidos;
            IdCliente = idCliente;
            Cliente = cliente;
            this.Fecha = fecha;
        }
    }
}
