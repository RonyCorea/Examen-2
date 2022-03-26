using Datos.AlmacenarEntidades;
using Datos.PermitirAcceso;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_2
{
    public partial class PedidosVista : Form
    {
        public PedidosVista()
        {
            InitializeComponent();
        }

        ProductoPA productoPA = new ProductoPA();   
        Pedidos pedidos = new Pedidos(); 
        Producto producto; 
        PedidosPA pedidosPA = new PedidosPA();  

        List<DetallePedidos> detallePedidosLista = new List<DetallePedidos>();

        private void PedidosVista_Load(object sender, EventArgs e)
        {
            DetallePedidosDataGridView.DataSource = detallePedidosLista;
        }

        private void CodigoProductoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char)Keys.Enter)
            {
                producto = new Producto();
                producto = productoPA.GetProductoPorCodigo(CodigoProductoTextBox.Text);
                DescripcionProductoTextBox.Text = producto.Descripcion;
                CantidadTextBox.Focus();
            }
            else
            {
                producto = null;
                DescripcionProductoTextBox.Clear();
                CantidadTextBox.Clear();
            }
        }

        private void CantidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(CantidadTextBox.Text))
            {
                DetallePedidos detallePedidos = new DetallePedidos();
                detallePedidos.CodigoProducto = producto.Codigo;
                detallePedidos.Descripcion = producto.Descripcion;  
                detallePedidos.Cantidad= Convert.ToInt32(CantidadTextBox.Text);
                detallePedidos.Precio= producto.Precio;
                detallePedidos.Total= producto.Precio*Convert.ToInt32(CantidadTextBox.Text);    

                detallePedidosLista.Add(detallePedidos);
                DetallePedidosDataGridView.DataSource = null;
                DetallePedidosDataGridView.DataSource = detallePedidosLista; 
            }
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            pedidos.IdCliente= IdentidadMaskedTextBox.Text;
            pedidos.Cliente= NombreTextBox.Text;
            pedidos.Fecha = FechaDateTimePicker.Value;

            int idPedidos = 0;
            idPedidos = pedidosPA.InsertarPedido(pedidos);

            if(idPedidos != 0)
            {
                foreach (var item in detallePedidosLista)
                {
                    item.idPedidos= idPedidos;  
                    pedidosPA.InsertarDetalle(item);    
                } 
            }
        }
    }
}
