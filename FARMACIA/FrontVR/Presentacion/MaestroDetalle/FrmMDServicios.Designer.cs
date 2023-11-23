namespace FrontVR.Presentacion.MaestroDetalle
{
    partial class FrmMDServicios
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
            cboServicio = new ComboBox();
            nudAtencion = new NumericUpDown();
            nudPrecio = new NumericUpDown();
            btnAgregar = new Button();
            gbServicio = new GroupBox();
            gbMedico = new GroupBox();
            cboMedico = new ComboBox();
            gbAtencion = new GroupBox();
            gbPrecio = new GroupBox();
            dgvDetalleServicio = new DataGridView();
            ColServicio = new DataGridViewTextBoxColumn();
            ColMedico = new DataGridViewTextBoxColumn();
            ColAtencion = new DataGridViewTextBoxColumn();
            ColPrecio = new DataGridViewTextBoxColumn();
            ColSubtotal = new DataGridViewTextBoxColumn();
            ColQuitar = new DataGridViewButtonColumn();
            lblTotal = new Label();
            label3 = new Label();
            label1 = new Label();
            btnSiguiente = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)nudAtencion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            gbServicio.SuspendLayout();
            gbMedico.SuspendLayout();
            gbAtencion.SuspendLayout();
            gbPrecio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleServicio).BeginInit();
            SuspendLayout();
            // 
            // cboServicio
            // 
            cboServicio.FormattingEnabled = true;
            cboServicio.Location = new Point(17, 29);
            cboServicio.Margin = new Padding(3, 4, 3, 4);
            cboServicio.Name = "cboServicio";
            cboServicio.Size = new Size(188, 28);
            cboServicio.TabIndex = 1;
            // 
            // nudAtencion
            // 
            nudAtencion.Increment = new decimal(new int[] { 250, 0, 0, 0 });
            nudAtencion.Location = new Point(8, 40);
            nudAtencion.Margin = new Padding(3, 4, 3, 4);
            nudAtencion.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudAtencion.Name = "nudAtencion";
            nudAtencion.Size = new Size(105, 27);
            nudAtencion.TabIndex = 3;
            // 
            // nudPrecio
            // 
            nudPrecio.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            nudPrecio.Location = new Point(7, 29);
            nudPrecio.Margin = new Padding(3, 4, 3, 4);
            nudPrecio.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(105, 27);
            nudPrecio.TabIndex = 4;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(795, 99);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(86, 31);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // gbServicio
            // 
            gbServicio.Controls.Add(cboServicio);
            gbServicio.Location = new Point(32, 72);
            gbServicio.Margin = new Padding(3, 4, 3, 4);
            gbServicio.Name = "gbServicio";
            gbServicio.Padding = new Padding(3, 4, 3, 4);
            gbServicio.Size = new Size(223, 75);
            gbServicio.TabIndex = 6;
            gbServicio.TabStop = false;
            gbServicio.Text = "Servicio";
            // 
            // gbMedico
            // 
            gbMedico.Controls.Add(cboMedico);
            gbMedico.Location = new Point(273, 72);
            gbMedico.Margin = new Padding(3, 4, 3, 4);
            gbMedico.Name = "gbMedico";
            gbMedico.Padding = new Padding(3, 4, 3, 4);
            gbMedico.Size = new Size(223, 75);
            gbMedico.TabIndex = 7;
            gbMedico.TabStop = false;
            gbMedico.Text = "Medico";
            // 
            // cboMedico
            // 
            cboMedico.FormattingEnabled = true;
            cboMedico.Location = new Point(17, 29);
            cboMedico.Margin = new Padding(3, 4, 3, 4);
            cboMedico.Name = "cboMedico";
            cboMedico.Size = new Size(188, 28);
            cboMedico.TabIndex = 1;
            // 
            // gbAtencion
            // 
            gbAtencion.Controls.Add(nudAtencion);
            gbAtencion.Location = new Point(515, 72);
            gbAtencion.Margin = new Padding(3, 4, 3, 4);
            gbAtencion.Name = "gbAtencion";
            gbAtencion.Padding = new Padding(3, 4, 3, 4);
            gbAtencion.Size = new Size(119, 75);
            gbAtencion.TabIndex = 8;
            gbAtencion.TabStop = false;
            gbAtencion.Text = "Costo Atencion";
            // 
            // gbPrecio
            // 
            gbPrecio.Controls.Add(nudPrecio);
            gbPrecio.Location = new Point(651, 72);
            gbPrecio.Margin = new Padding(3, 4, 3, 4);
            gbPrecio.Name = "gbPrecio";
            gbPrecio.Padding = new Padding(3, 4, 3, 4);
            gbPrecio.Size = new Size(119, 75);
            gbPrecio.TabIndex = 9;
            gbPrecio.TabStop = false;
            gbPrecio.Text = "Precio";
            // 
            // dgvDetalleServicio
            // 
            dgvDetalleServicio.AllowUserToAddRows = false;
            dgvDetalleServicio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleServicio.Columns.AddRange(new DataGridViewColumn[] { ColServicio, ColMedico, ColAtencion, ColPrecio, ColSubtotal, ColQuitar });
            dgvDetalleServicio.Location = new Point(32, 175);
            dgvDetalleServicio.Margin = new Padding(3, 4, 3, 4);
            dgvDetalleServicio.Name = "dgvDetalleServicio";
            dgvDetalleServicio.RowHeadersWidth = 51;
            dgvDetalleServicio.RowTemplate.Height = 25;
            dgvDetalleServicio.Size = new Size(849, 325);
            dgvDetalleServicio.TabIndex = 10;
            // 
            // ColServicio
            // 
            ColServicio.HeaderText = "Servicio";
            ColServicio.MinimumWidth = 6;
            ColServicio.Name = "ColServicio";
            ColServicio.Width = 150;
            // 
            // ColMedico
            // 
            ColMedico.HeaderText = "Medico";
            ColMedico.MinimumWidth = 6;
            ColMedico.Name = "ColMedico";
            ColMedico.Width = 150;
            // 
            // ColAtencion
            // 
            ColAtencion.HeaderText = "Atencion";
            ColAtencion.MinimumWidth = 6;
            ColAtencion.Name = "ColAtencion";
            ColAtencion.Width = 125;
            // 
            // ColPrecio
            // 
            ColPrecio.HeaderText = "Precio";
            ColPrecio.MinimumWidth = 6;
            ColPrecio.Name = "ColPrecio";
            ColPrecio.Width = 125;
            // 
            // ColSubtotal
            // 
            ColSubtotal.HeaderText = "Subtotal";
            ColSubtotal.MinimumWidth = 6;
            ColSubtotal.Name = "ColSubtotal";
            ColSubtotal.Width = 120;
            // 
            // ColQuitar
            // 
            ColQuitar.HeaderText = "Quitar";
            ColQuitar.MinimumWidth = 6;
            ColQuitar.Name = "ColQuitar";
            ColQuitar.Width = 80;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(840, 516);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(44, 32);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "---";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(534, 516);
            label3.Name = "label3";
            label3.Size = new Size(244, 32);
            label3.TabIndex = 11;
            label3.Text = "Total en Productos:  $";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 28);
            label1.Name = "label1";
            label1.Size = new Size(251, 37);
            label1.TabIndex = 13;
            label1.Text = "Gestor de Servicios";
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(341, 531);
            btnSiguiente.Margin = new Padding(3, 4, 3, 4);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(86, 31);
            btnSiguiente.TabIndex = 15;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // button1
            // 
            button1.Location = new Point(150, 531);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 14;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmMDServicios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnSiguiente);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(lblTotal);
            Controls.Add(label3);
            Controls.Add(dgvDetalleServicio);
            Controls.Add(gbPrecio);
            Controls.Add(gbAtencion);
            Controls.Add(gbMedico);
            Controls.Add(gbServicio);
            Controls.Add(btnAgregar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmMDServicios";
            Text = "FrmMDServicios";
            Load += FrmMDServicios_Load;
            ((System.ComponentModel.ISupportInitialize)nudAtencion).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            gbServicio.ResumeLayout(false);
            gbMedico.ResumeLayout(false);
            gbAtencion.ResumeLayout(false);
            gbPrecio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetalleServicio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cboServicio;
        private NumericUpDown nudAtencion;
        private NumericUpDown nudPrecio;
        private Button btnAgregar;
        private GroupBox gbServicio;
        private GroupBox gbMedico;
        private ComboBox cboMedico;
        private GroupBox gbAtencion;
        private GroupBox gbPrecio;
        private DataGridView dgvDetalleServicio;
        private DataGridViewTextBoxColumn ColServicio;
        private DataGridViewTextBoxColumn ColMedico;
        private DataGridViewTextBoxColumn ColAtencion;
        private DataGridViewTextBoxColumn ColPrecio;
        private DataGridViewTextBoxColumn ColSubtotal;
        private DataGridViewButtonColumn ColQuitar;
        private Label lblTotal;
        private Label label3;
        private Label label1;
        private Button btnSiguiente;
        private Button button1;
    }
}