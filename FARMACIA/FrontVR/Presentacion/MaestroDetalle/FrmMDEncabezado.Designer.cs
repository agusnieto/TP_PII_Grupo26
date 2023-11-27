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
            gbSede.Location = new Point(46, 117);
            gbSede.Name = "gbSede";
            gbSede.Size = new Size(195, 56);
            gbSede.TabIndex = 0;
            gbSede.TabStop = false;
            gbSede.Text = "Sede";
            // 
            // cboSede
            // 
            cboSede.FormattingEnabled = true;
            cboSede.Location = new Point(15, 22);
            cboSede.Name = "cboSede";
            cboSede.Size = new Size(165, 23);
            cboSede.TabIndex = 0;
            cboSede.SelectedIndexChanged += cboSede_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 27);
            label1.Name = "label1";
            label1.Size = new Size(196, 30);
            label1.TabIndex = 8;
            label1.Text = "Finalizar la Compra";
            // 
            // gbEmpleado
            // 
            gbEmpleado.Controls.Add(cboEmpleado);
            gbEmpleado.Location = new Point(247, 78);
            gbEmpleado.Name = "gbEmpleado";
            gbEmpleado.Size = new Size(195, 56);
            gbEmpleado.TabIndex = 4;
            gbEmpleado.TabStop = false;
            gbEmpleado.Text = "Empleado";
            // 
            // cboEmpleado
            // 
            cboEmpleado.FormattingEnabled = true;
            cboEmpleado.Location = new Point(15, 22);
            cboEmpleado.Name = "cboEmpleado";
            cboEmpleado.Size = new Size(165, 23);
            cboEmpleado.TabIndex = 0;
            // 
            // gbCliente
            // 
            gbCliente.Controls.Add(cboCliente);
            gbCliente.Location = new Point(247, 140);
            gbCliente.Name = "gbCliente";
            gbCliente.Size = new Size(195, 56);
            gbCliente.TabIndex = 1;
            gbCliente.TabStop = false;
            gbCliente.Text = "Cliente";
            // 
            // cboCliente
            // 
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(15, 22);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(165, 23);
            cboCliente.TabIndex = 0;
            // 
            // gbEnvio
            // 
            gbEnvio.Controls.Add(cboEnvio);
            gbEnvio.Location = new Point(532, 78);
            gbEnvio.Name = "gbEnvio";
            gbEnvio.Size = new Size(195, 56);
            gbEnvio.TabIndex = 3;
            gbEnvio.TabStop = false;
            gbEnvio.Text = "Envio";
            // 
            // cboEnvio
            // 
            cboEnvio.FormattingEnabled = true;
            cboEnvio.Location = new Point(15, 22);
            cboEnvio.Name = "cboEnvio";
            cboEnvio.Size = new Size(165, 23);
            cboEnvio.TabIndex = 0;
            // 
            // gbPago
            // 
            gbPago.Controls.Add(cboPago);
            gbPago.Location = new Point(532, 140);
            gbPago.Name = "gbPago";
            gbPago.Size = new Size(195, 56);
            gbPago.TabIndex = 2;
            gbPago.TabStop = false;
            gbPago.Text = "Forma de Pago";
            // 
            // cboPago
            // 
            cboPago.FormattingEnabled = true;
            cboPago.Location = new Point(15, 22);
            cboPago.Name = "cboPago";
            cboPago.Size = new Size(165, 23);
            cboPago.TabIndex = 0;
            // 
            // lblTotalProductos
            // 
            lblTotalProductos.AutoSize = true;
            lblTotalProductos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalProductos.Location = new Point(529, 225);
            lblTotalProductos.Name = "lblTotalProductos";
            lblTotalProductos.Size = new Size(36, 25);
            lblTotalProductos.TabIndex = 13;
            lblTotalProductos.Text = "---";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(250, 225);
            label3.Name = "label3";
            label3.Size = new Size(192, 25);
            label3.TabIndex = 12;
            label3.Text = "Total en Productos:  $";
            // 
            // lblTotalServicios
            // 
            lblTotalServicios.AutoSize = true;
            lblTotalServicios.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalServicios.Location = new Point(529, 264);
            lblTotalServicios.Name = "lblTotalServicios";
            lblTotalServicios.Size = new Size(36, 25);
            lblTotalServicios.TabIndex = 15;
            lblTotalServicios.Text = "---";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(261, 264);
            label4.Name = "label4";
            label4.Size = new Size(181, 25);
            label4.TabIndex = 14;
            label4.Text = "Total en Servicios:  $";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(529, 308);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(50, 37);
            lblTotal.TabIndex = 17;
            lblTotal.Text = "---";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(147, 308);
            label6.Name = "label6";
            label6.Size = new Size(295, 37);
            label6.TabIndex = 16;
            label6.Text = "Total en Productos:  $";
            // 
            // btnComprobante
            // 
            btnComprobante.Location = new Point(547, 35);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new Size(165, 23);
            btnComprobante.TabIndex = 6;
            btnComprobante.Text = "Descargar Comprobante";
            btnComprobante.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(351, 401);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(75, 24);
            btnFinalizar.TabIndex = 5;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // FrmMDEncabezado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "FrmMDEncabezado";
            StartPosition = FormStartPosition.CenterScreen;
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