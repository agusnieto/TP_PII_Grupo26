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
            cboServicio.Location = new Point(15, 22);
            cboServicio.Name = "cboServicio";
            cboServicio.Size = new Size(165, 23);
            cboServicio.TabIndex = 0;
            // 
            // nudAtencion
            // 
            nudAtencion.Increment = new decimal(new int[] { 250, 0, 0, 0 });
            nudAtencion.Location = new Point(6, 22);
            nudAtencion.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudAtencion.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudAtencion.Name = "nudAtencion";
            nudAtencion.Size = new Size(92, 23);
            nudAtencion.TabIndex = 0;
            nudAtencion.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // nudPrecio
            // 
            nudPrecio.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            nudPrecio.Location = new Point(6, 22);
            nudPrecio.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudPrecio.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(92, 23);
            nudPrecio.TabIndex = 0;
            nudPrecio.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(696, 74);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // gbServicio
            // 
            gbServicio.Controls.Add(cboServicio);
            gbServicio.Location = new Point(28, 54);
            gbServicio.Name = "gbServicio";
            gbServicio.Size = new Size(195, 56);
            gbServicio.TabIndex = 0;
            gbServicio.TabStop = false;
            gbServicio.Text = "Servicio";
            // 
            // gbMedico
            // 
            gbMedico.Controls.Add(cboMedico);
            gbMedico.Location = new Point(239, 54);
            gbMedico.Name = "gbMedico";
            gbMedico.Size = new Size(195, 56);
            gbMedico.TabIndex = 1;
            gbMedico.TabStop = false;
            gbMedico.Text = "Medico";
            // 
            // cboMedico
            // 
            cboMedico.FormattingEnabled = true;
            cboMedico.Location = new Point(15, 22);
            cboMedico.Name = "cboMedico";
            cboMedico.Size = new Size(165, 23);
            cboMedico.TabIndex = 0;
            // 
            // gbAtencion
            // 
            gbAtencion.Controls.Add(nudAtencion);
            gbAtencion.Location = new Point(451, 54);
            gbAtencion.Name = "gbAtencion";
            gbAtencion.Size = new Size(104, 56);
            gbAtencion.TabIndex = 2;
            gbAtencion.TabStop = false;
            gbAtencion.Text = "Costo Atencion";
            // 
            // gbPrecio
            // 
            gbPrecio.Controls.Add(nudPrecio);
            gbPrecio.Location = new Point(570, 54);
            gbPrecio.Name = "gbPrecio";
            gbPrecio.Size = new Size(104, 56);
            gbPrecio.TabIndex = 3;
            gbPrecio.TabStop = false;
            gbPrecio.Text = "Precio";
            // 
            // dgvDetalleServicio
            // 
            dgvDetalleServicio.AllowUserToAddRows = false;
            dgvDetalleServicio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleServicio.Columns.AddRange(new DataGridViewColumn[] { ColServicio, ColMedico, ColAtencion, ColPrecio, ColSubtotal, ColQuitar });
            dgvDetalleServicio.Location = new Point(28, 131);
            dgvDetalleServicio.Name = "dgvDetalleServicio";
            dgvDetalleServicio.RowHeadersWidth = 51;
            dgvDetalleServicio.RowTemplate.Height = 25;
            dgvDetalleServicio.Size = new Size(743, 244);
            dgvDetalleServicio.TabIndex = 7;
            dgvDetalleServicio.CellContentClick += dgvDetalleServicio_CellContentClick;
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
            lblTotal.Location = new Point(735, 387);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(36, 25);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "---";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(467, 387);
            label3.Name = "label3";
            label3.Size = new Size(192, 25);
            label3.TabIndex = 11;
            label3.Text = "Total en Productos:  $";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 21);
            label1.Name = "label1";
            label1.Size = new Size(197, 30);
            label1.TabIndex = 13;
            label1.Text = "Gestor de Servicios";
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(298, 398);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(75, 23);
            btnSiguiente.TabIndex = 6;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // button1
            // 
            button1.Location = new Point(131, 398);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmMDServicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "FrmMDServicios";
            StartPosition = FormStartPosition.CenterScreen;
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