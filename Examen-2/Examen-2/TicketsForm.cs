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
    public partial class TicketsForm : Form
    {
        public TicketsForm()
        {
            InitializeComponent();
        }
        string operacion = string.Empty;

        TicketsDatos ticketsDatos = new TicketsDatos();

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            operacion = "Nuevo";
            HabilitarControles();
        }

        private void HabilitarControles()
        {
            CodigoTextBox.Enabled = true;
            FechaTextBox.Enabled = true;
            NombreClienteTextBox.Enabled = true;
            TipoSoporteTextBox.Enabled = true;
            TipoEquipoTextBox.Enabled = true;
            DescripcionProblemaTextBox.Enabled = true;
            CostoTextBox.Enabled = true;
            DescripcionSolucionTextBox.Enabled = true;
            GuardarButton.Enabled = true;
            NuevoButton.Enabled = false;

        }
        private void DesabilitarControles()
        {
            CodigoTextBox.Enabled = false;
            FechaTextBox.Enabled = false;
            NombreClienteTextBox.Enabled = false;
            TipoSoporteTextBox.Enabled = false;
            TipoEquipoTextBox.Enabled = false;
            DescripcionProblemaTextBox.Enabled = false;
            CostoTextBox.Enabled = false;
            DescripcionSolucionTextBox.Enabled = false;
            GuardarButton.Enabled = false;
            NuevoButton.Enabled = true;
        }
        private void LimpiarControles()
        {
            CodigoTextBox.Clear();
            FechaTextBox.Clear();
            NombreClienteTextBox.Clear();
            TipoSoporteTextBox.Clear();
            TipoEquipoTextBox.Clear();
            DescripcionProblemaTextBox.Clear();
            CostoTextBox.Clear();
            DescripcionSolucionTextBox.Clear();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(CodigoTextBox.Text))
                {
                    errorProvider1.SetError(CodigoTextBox, "Ingrese el código del ticket");
                    CodigoTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(FechaTextBox.Text))
                {
                    errorProvider1.SetError(FechaTextBox, "Ingrese fecha");
                    FechaTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(NombreClienteTextBox.Text))
                {
                    errorProvider1.SetError(NombreClienteTextBox, "Ingrese nombre del cliente");
                    NombreClienteTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(TipoSoporteTextBox.Text))
                {
                    errorProvider1.SetError(TipoSoporteTextBox, "Ingrese el tipo de soporte");
                    TipoSoporteTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(TipoEquipoTextBox.Text))
                {
                    errorProvider1.SetError(TipoSoporteTextBox, "Ingrese el tipo de equipo");
                    TipoEquipoTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(DescripcionProblemaTextBox.Text))
                {
                    errorProvider1.SetError(TipoSoporteTextBox, "Ingrese la descripcion del problema");
                    DescripcionProblemaTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(CostoTextBox.Text))
                {
                    errorProvider1.SetError(CostoTextBox, "Digite el costo");
                    CostoTextBox.Focus();
                    return;
                }

                Tickets tickets = new Tickets();
                tickets.Id = CodigoTextBox.Text;
                tickets.Fecha = FechaTextBox.Text;
                tickets.NombreCliente = NombreClienteTextBox.Text;
                tickets.TipoSoporte = TipoSoporteTextBox.Text;
                tickets.TipoEquipo = TipoEquipoTextBox.Text; 
                tickets.DescripcionProblema=DescripcionProblemaTextBox.Text;
                tickets.Costo = Convert.ToDouble(CostoTextBox.Text);
                tickets.DescripcionSolucion = DescripcionSolucionTextBox.Text;

                if (operacion == "Nuevo")
                {
                    bool inserto = ticketsDatos.GenerarTickets(tickets);

                    if (inserto)
                    {
                        DesabilitarControles();
                        LimpiarControles();
                        ListarTickets();
                        MessageBox.Show("Ticket insertado");
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void TicketsForm_Load(object sender, EventArgs e)
        {
            ListarTickets();
        }

        private void ListarTickets()
        {
            TicketsDataGridView.DataSource = ticketsDatos.DevolverTickets();    
        }
        
        private void CostoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(CostoTextBox, "Ingrese un caracter numerico");
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
