using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.AlmacenarEntidades
{
    public class DetallePedidos
    {
        public int idDetallePedidos { get; set; }
        public int idPedidos { get; set; }
        public string CodigoProducto { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }

        public DetallePedidos()
        {

        }

        public DetallePedidos(int IdDetallePedidos, int IdPedidos, string codigoProducto, string descripcion, int cantidad, decimal precio, decimal total)
        {
            idDetallePedidos = IdDetallePedidos;
            idPedidos = IdPedidos;
            CodigoProducto = codigoProducto;
            Descripcion = descripcion;
            Cantidad = cantidad;
            Precio = precio;
            Total = total;
        }
    }
}
