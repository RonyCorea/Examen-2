using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen_2
{
    public partial class MenuVista : Syncfusion.Windows.Forms.Office2010Form
    {
        public MenuVista()
        {
            InitializeComponent();
        }

        ProductosVista productosVista = null;
        PedidosVista pedidosVista = null;
        private void ProductosToolStripButton_Click(object sender, EventArgs e)
        {
            if(productosVista == null)
            {
                productosVista = new ProductosVista();
                productosVista.MdiParent = this;
                productosVista.FormClosed += ProductosVista_FormClosed;
                productosVista.Show();
            }
            else
            {
                productosVista.Activate();
            }
        }

        private void ProductosVista_FormClosed(object sender, FormClosedEventArgs e)
        {
            productosVista = null;
        }

        private void NuevoPedidoToolStripButton_Click(object sender, EventArgs e)
        {
             if(pedidosVista == null)
            {
                pedidosVista = new PedidosVista();
                pedidosVista.MdiParent = this;
                pedidosVista.FormClosed += PedidosVista_FormClosed;
                pedidosVista.Show();
            }
            else
            {
                pedidosVista.Activate();
            }
        }

        private void PedidosVista_FormClosed(object sender, FormClosedEventArgs e)
        {
            pedidosVista=null;
        }
    }
}
