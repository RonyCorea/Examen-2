using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen_2
{
    public partial class MenuForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        TicketsForm ticketsForm = null;
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (ticketsForm == null)
            {
                ticketsForm = new TicketsForm();
                ticketsForm.MdiParent = this;
                ticketsForm.Show();
            }
            else
            {
                ticketsForm.Activate();
            }

        }

    }
}
