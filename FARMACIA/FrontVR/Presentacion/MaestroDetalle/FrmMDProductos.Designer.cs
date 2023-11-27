namespace FrontVR.Presentacion.MaestroDetalle
{
    partial class FrmMDProductos
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
            label2 = new Label();
            label3 = new Label();
            lblTotal = new Label();
            dgvProductos = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            ColMarca = new DataGridViewTextBoxColumn();
            ColNombre = new DataGridViewTextBoxColumn();
            ColPrecio = new DataGridViewTextBoxColumn();
            ColCantidad = new DataGridViewTextBoxColumn();
            ColSubtotal = new DataGridViewTextBoxColumn();
            ColQuitar = new DataGridViewButtonColumn();
            label1 = new Label();
            button1 = new Button();
            btnSiguiente = new Button();
            btnAgregar = new Button();
            gbCantidad = new GroupBox();
            nudCantidad = new NumericUpDown();
            nudCodigo = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            gbCantidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCodigo).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 64);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 2;
            label2.Text = "Codigo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(484, 375);
            label3.Name = "label3";
            label3.Size = new Size(192, 25);
            label3.TabIndex = 4;
            label3.Text = "Total en Productos:  $";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(752, 375);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(36, 25);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "---";
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColMarca, ColNombre, ColPrecio, ColCantidad, ColSubtotal, ColQuitar });
            dgvProductos.Location = new Point(12, 97);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(776, 264);
            dgvProductos.TabIndex = 5;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "Producto";
            ColumnId.MinimumWidth = 6;
            ColumnId.Name = "ColumnId";
            ColumnId.Width = 80;
            // 
            // ColMarca
            // 
            ColMarca.HeaderText = "Marca";
            ColMarca.MinimumWidth = 6;
            ColMarca.Name = "ColMarca";
            ColMarca.Width = 160;
            // 
            // ColNombre
            // 
            ColNombre.HeaderText = "Nombre";
            ColNombre.MinimumWidth = 6;
            ColNombre.Name = "ColNombre";
            ColNombre.Width = 160;
            // 
            // ColPrecio
            // 
            ColPrecio.HeaderText = "Precio";
            ColPrecio.MinimumWidth = 6;
            ColPrecio.Name = "ColPrecio";
            ColPrecio.Width = 80;
            // 
            // ColCantidad
            // 
            ColCantidad.HeaderText = "Cantidad";
            ColCantidad.MinimumWidth = 6;
            ColCantidad.Name = "ColCantidad";
            ColCantidad.Width = 80;
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
            ColQuitar.Width = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(289, 30);
            label1.TabIndex = 9;
            label1.Text = "Agregar Productos al Carrito";
            // 
            // button1
            // 
            button1.Location = new Point(174, 396);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(341, 396);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(75, 23);
            btnSiguiente.TabIndex = 4;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(514, 61);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += button2_Click;
            // 
            // gbCantidad
            // 
            gbCantidad.Controls.Add(nudCantidad);
            gbCantidad.Location = new Point(393, 39);
            gbCantidad.Name = "gbCantidad";
            gbCantidad.Size = new Size(93, 52);
            gbCantidad.TabIndex = 1;
            gbCantidad.TabStop = false;
            gbCantidad.Text = "Cantidad";
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(6, 22);
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(79, 23);
            nudCantidad.TabIndex = 0;
            nudCantidad.ThousandsSeparator = true;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudCodigo
            // 
            nudCodigo.Location = new Point(191, 61);
            nudCodigo.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nudCodigo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCodigo.Name = "nudCodigo";
            nudCodigo.Size = new Size(79, 23);
            nudCodigo.TabIndex = 10;
            nudCodigo.ThousandsSeparator = true;
            nudCodigo.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // FrmMDProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nudCodigo);
            Controls.Add(gbCantidad);
            Controls.Add(btnAgregar);
            Controls.Add(btnSiguiente);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dgvProductos);
            Controls.Add(lblTotal);
            Controls.Add(label3);
            Controls.Add(label2);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "FrmMDProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMDProductos";
            Load += FrmMDProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            gbCantidad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCodigo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label lblTotal;
        private DataGridView dgvProductos;
        private Label label1;
        private Button button1;
        private Button btnSiguiente;
        private Button btnAgregar;
        private GroupBox gbCantidad;
        private NumericUpDown nudCantidad;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColMarca;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColPrecio;
        private DataGridViewTextBoxColumn ColCantidad;
        private DataGridViewTextBoxColumn ColSubtotal;
        private DataGridViewButtonColumn ColQuitar;
        private NumericUpDown nudCodigo;
    }
}