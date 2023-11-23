namespace FrontVR.Presentacion.MaestroDetalle
{
    partial class FrmMDEncabezado
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
            gbSede = new GroupBox();
            cboSede = new ComboBox();
            label1 = new Label();
            gbEmpleado = new GroupBox();
            cboEmpleado = new ComboBox();
            gbCliente = new GroupBox();
            cboCliente = new ComboBox();
            gbEnvio = new GroupBox();
            cboEnvio = new ComboBox();
            gbPago = new GroupBox();
            cboPago = new ComboBox();
            lblTotalProductos = new Label();
            label3 = new Label();
            lblTotalServicios = new Label();
            label4 = new Label();
            lblTotal = new Label();
            label6 = new Label();
            btnComprobante = new Button();
            btnFinalizar = new Button();
            gbSede.SuspendLayout();
            gbEmpleado.SuspendLayout();
            gbCliente.SuspendLayout();
            gbEnvio.SuspendLayout();
            gbPago.SuspendLayout();
            SuspendLayout();
            // 
            // gbSede
            // 
            gbSede.Controls.Add(cboSede);
            gbSede.Location = new Point(53, 156);
            gbSede.Margin = new Padding(3, 4, 3, 4);
            gbSede.Name = "gbSede";
            gbSede.Padding = new Padding(3, 4, 3, 4);
            gbSede.Size = new Size(223, 75);
            gbSede.TabIndex = 7;
            gbSede.TabStop = false;
            gbSede.Text = "Sede";
            // 
            // cboSede
            // 
            cboSede.FormattingEnabled = true;
            cboSede.Location = new Point(17, 29);
            cboSede.Margin = new Padding(3, 4, 3, 4);
            cboSede.Name = "cboSede";
            cboSede.Size = new Size(188, 28);
            cboSede.TabIndex = 1;
            cboSede.SelectedIndexChanged += cboSede_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(34, 36);
            label1.Name = "label1";
            label1.Size = new Size(251, 37);
            label1.TabIndex = 8;
            label1.Text = "Finalizar la Compra";
            // 
            // gbEmpleado
            // 
            gbEmpleado.Controls.Add(cboEmpleado);
            gbEmpleado.Location = new Point(282, 104);
            gbEmpleado.Margin = new Padding(3, 4, 3, 4);
            gbEmpleado.Name = "gbEmpleado";
            gbEmpleado.Padding = new Padding(3, 4, 3, 4);
            gbEmpleado.Size = new Size(223, 75);
            gbEmpleado.TabIndex = 9;
            gbEmpleado.TabStop = false;
            gbEmpleado.Text = "Empleado";
            // 
            // cboEmpleado
            // 
            cboEmpleado.FormattingEnabled = true;
            cboEmpleado.Location = new Point(17, 29);
            cboEmpleado.Margin = new Padding(3, 4, 3, 4);
            cboEmpleado.Name = "cboEmpleado";
            cboEmpleado.Size = new Size(188, 28);
            cboEmpleado.TabIndex = 1;
            cboEmpleado.SelectedIndexChanged += cboEmpleado_SelectedIndexChanged;
            // 
            // gbCliente
            // 
            gbCliente.Controls.Add(cboCliente);
            gbCliente.Location = new Point(282, 187);
            gbCliente.Margin = new Padding(3, 4, 3, 4);
            gbCliente.Name = "gbCliente";
            gbCliente.Padding = new Padding(3, 4, 3, 4);
            gbCliente.Size = new Size(223, 75);
            gbCliente.TabIndex = 10;
            gbCliente.TabStop = false;
            gbCliente.Text = "Cliente";
            // 
            // cboCliente
            // 
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(17, 29);
            cboCliente.Margin = new Padding(3, 4, 3, 4);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(188, 28);
            cboCliente.TabIndex = 1;
            // 
            // gbEnvio
            // 
            gbEnvio.Controls.Add(cboEnvio);
            gbEnvio.Location = new Point(608, 104);
            gbEnvio.Margin = new Padding(3, 4, 3, 4);
            gbEnvio.Name = "gbEnvio";
            gbEnvio.Padding = new Padding(3, 4, 3, 4);
            gbEnvio.Size = new Size(223, 75);
            gbEnvio.TabIndex = 11;
            gbEnvio.TabStop = false;
            gbEnvio.Text = "Envio";
            // 
            // cboEnvio
            // 
            cboEnvio.FormattingEnabled = true;
            cboEnvio.Location = new Point(17, 29);
            cboEnvio.Margin = new Padding(3, 4, 3, 4);
            cboEnvio.Name = "cboEnvio";
            cboEnvio.Size = new Size(188, 28);
            cboEnvio.TabIndex = 1;
            // 
            // gbPago
            // 
            gbPago.Controls.Add(cboPago);
            gbPago.Location = new Point(608, 187);
            gbPago.Margin = new Padding(3, 4, 3, 4);
            gbPago.Name = "gbPago";
            gbPago.Padding = new Padding(3, 4, 3, 4);
            gbPago.Size = new Size(223, 75);
            gbPago.TabIndex = 8;
            gbPago.TabStop = false;
            gbPago.Text = "Forma de Pago";
            // 
            // cboPago
            // 
            cboPago.FormattingEnabled = true;
            cboPago.Location = new Point(17, 29);
            cboPago.Margin = new Padding(3, 4, 3, 4);
            cboPago.Name = "cboPago";
            cboPago.Size = new Size(188, 28);
            cboPago.TabIndex = 1;
            // 
            // lblTotalProductos
            // 
           
            lblTotalProductos.AutoSize = true;
            lblTotalProductos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalProductos.Location = new Point(605, 300);
            lblTotalProductos.Name = "lblTotalProductos";
            lblTotalProductos.Size = new Size(44, 32);
            lblTotalProductos.TabIndex = 13;
            lblTotalProductos.Text = "---";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(286, 300);
            label3.Name = "label3";
            label3.Size = new Size(244, 32);
            label3.TabIndex = 12;
            label3.Text = "Total en Productos:  $";
            // 
            // lblTotalServicios
            // 
            lblTotalServicios.AutoSize = true;
            lblTotalServicios.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalServicios.Location = new Point(605, 352);
            lblTotalServicios.Name = "lblTotalServicios";
            lblTotalServicios.Size = new Size(44, 32);
            lblTotalServicios.TabIndex = 15;
            lblTotalServicios.Text = "---";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(298, 352);
            label4.Name = "label4";
            label4.Size = new Size(231, 32);
            label4.TabIndex = 14;
            label4.Text = "Total en Servicios:  $";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(605, 411);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(62, 46);
            lblTotal.TabIndex = 17;
            lblTotal.Text = "---";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(168, 411);
            label6.Name = "label6";
            label6.Size = new Size(366, 46);
            label6.TabIndex = 16;
            label6.Text = "Total en Productos:  $";
            // 
            // btnComprobante
            // 
            btnComprobante.Location = new Point(625, 47);
            btnComprobante.Margin = new Padding(3, 4, 3, 4);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new Size(189, 31);
            btnComprobante.TabIndex = 18;
            btnComprobante.Text = "Descargar Comprobante";
            btnComprobante.UseVisualStyleBackColor = true;
            btnComprobante.Click += btnComprobante_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(401, 535);
            btnFinalizar.Margin = new Padding(3, 4, 3, 4);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(86, 32);
            btnFinalizar.TabIndex = 19;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // FrmMDEncabezado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnFinalizar);
            Controls.Add(btnComprobante);
            Controls.Add(lblTotal);
            Controls.Add(label6);
            Controls.Add(lblTotalServicios);
            Controls.Add(label4);
            Controls.Add(lblTotalProductos);
            Controls.Add(label3);
            Controls.Add(gbPago);
            Controls.Add(gbEnvio);
            Controls.Add(gbCliente);
            Controls.Add(gbEmpleado);
            Controls.Add(label1);
            Controls.Add(gbSede);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmMDEncabezado";
            Text = "FrmMDEncabezado";
            Load += FrmMDEncabezado_Load;
            gbSede.ResumeLayout(false);
            gbEmpleado.ResumeLayout(false);
            gbCliente.ResumeLayout(false);
            gbEnvio.ResumeLayout(false);
            gbPago.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbSede;
        private ComboBox cboSede;
        private Label label1;
        private GroupBox gbEmpleado;
        private ComboBox cboEmpleado;
        private GroupBox gbCliente;
        private ComboBox cboCliente;
        private GroupBox gbEnvio;
        private ComboBox cboEnvio;
        private GroupBox gbPago;
        private ComboBox cboPago;
        private Label lblTotalProductos;
        private Label label3;
        private Label lblTotalServicios;
        private Label label4;
        private Label lblTotal;
        private Label label6;
        private Button btnComprobante;
        private Button btnFinalizar;
    }
}