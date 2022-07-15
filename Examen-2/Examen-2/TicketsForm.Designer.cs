namespace Examen_2
{
    partial class TicketsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.CodigoTextBox = new System.Windows.Forms.TextBox();
            this.FechaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TipoSoporteTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NombreClienteTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.TicketsDataGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.DescripcionSolucionTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CostoTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DescripcionProblemaTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TipoEquipoTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TicketsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de Ticket:";
            // 
            // CodigoTextBox
            // 
            this.CodigoTextBox.Enabled = false;
            this.CodigoTextBox.Location = new System.Drawing.Point(229, 13);
            this.CodigoTextBox.Name = "CodigoTextBox";
            this.CodigoTextBox.Size = new System.Drawing.Size(217, 22);
            this.CodigoTextBox.TabIndex = 1;
            // 
            // FechaTextBox
            // 
            this.FechaTextBox.Enabled = false;
            this.FechaTextBox.Location = new System.Drawing.Point(229, 44);
            this.FechaTextBox.Name = "FechaTextBox";
            this.FechaTextBox.Size = new System.Drawing.Size(217, 22);
            this.FechaTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha:";
            // 
            // TipoSoporteTextBox
            // 
            this.TipoSoporteTextBox.Enabled = false;
            this.TipoSoporteTextBox.Location = new System.Drawing.Point(229, 100);
            this.TipoSoporteTextBox.Name = "TipoSoporteTextBox";
            this.TipoSoporteTextBox.Size = new System.Drawing.Size(217, 22);
            this.TipoSoporteTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo de soporte:";
            // 
            // NombreClienteTextBox
            // 
            this.NombreClienteTextBox.Enabled = false;
            this.NombreClienteTextBox.Location = new System.Drawing.Point(229, 72);
            this.NombreClienteTextBox.Name = "NombreClienteTextBox";
            this.NombreClienteTextBox.Size = new System.Drawing.Size(217, 22);
            this.NombreClienteTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre del cliente:";
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(69, 270);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 23);
            this.NuevoButton.TabIndex = 8;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(460, 269);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 24);
            this.GuardarButton.TabIndex = 9;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // TicketsDataGridView
            // 
            this.TicketsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketsDataGridView.Location = new System.Drawing.Point(12, 299);
            this.TicketsDataGridView.Name = "TicketsDataGridView";
            this.TicketsDataGridView.Size = new System.Drawing.Size(644, 135);
            this.TicketsDataGridView.TabIndex = 10;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DescripcionSolucionTextBox
            // 
            this.DescripcionSolucionTextBox.Enabled = false;
            this.DescripcionSolucionTextBox.Location = new System.Drawing.Point(229, 220);
            this.DescripcionSolucionTextBox.Name = "DescripcionSolucionTextBox";
            this.DescripcionSolucionTextBox.Size = new System.Drawing.Size(217, 22);
            this.DescripcionSolucionTextBox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "DescripcionSolucion:";
            // 
            // CostoTextBox
            // 
            this.CostoTextBox.Enabled = false;
            this.CostoTextBox.Location = new System.Drawing.Point(229, 192);
            this.CostoTextBox.Name = "CostoTextBox";
            this.CostoTextBox.Size = new System.Drawing.Size(217, 22);
            this.CostoTextBox.TabIndex = 16;
            this.CostoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CostoTextBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Costo:";
            // 
            // DescripcionProblemaTextBox
            // 
            this.DescripcionProblemaTextBox.Enabled = false;
            this.DescripcionProblemaTextBox.Location = new System.Drawing.Point(229, 164);
            this.DescripcionProblemaTextBox.Name = "DescripcionProblemaTextBox";
            this.DescripcionProblemaTextBox.Size = new System.Drawing.Size(217, 22);
            this.DescripcionProblemaTextBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Descripción del problema:";
            // 
            // TipoEquipoTextBox
            // 
            this.TipoEquipoTextBox.Enabled = false;
            this.TipoEquipoTextBox.Location = new System.Drawing.Point(229, 130);
            this.TipoEquipoTextBox.Name = "TipoEquipoTextBox";
            this.TipoEquipoTextBox.Size = new System.Drawing.Size(217, 22);
            this.TipoEquipoTextBox.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tipo de equipo:";
            // 
            // TicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 446);
            this.Controls.Add(this.DescripcionSolucionTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CostoTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DescripcionProblemaTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TipoEquipoTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TicketsDataGridView);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.TipoSoporteTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NombreClienteTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FechaTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CodigoTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TicketsForm";
            this.Text = "TicketsForm";
            this.Load += new System.EventHandler(this.TicketsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TicketsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodigoTextBox;
        private System.Windows.Forms.TextBox FechaTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TipoSoporteTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NombreClienteTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.DataGridView TicketsDataGridView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox DescripcionSolucionTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CostoTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DescripcionProblemaTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TipoEquipoTextBox;
        private System.Windows.Forms.Label label8;
    }
}