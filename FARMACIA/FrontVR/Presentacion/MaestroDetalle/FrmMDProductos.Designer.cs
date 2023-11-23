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
            txtCodigo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            lblTotal = new Label();
            dgvProductos = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            ColTipo = new DataGridViewTextBoxColumn();
            ColNombre = new DataGridViewTextBoxColumn();
            ColPrecio = new DataGridViewTextBoxColumn();
            ColCantidad = new DataGridViewTextBoxColumn();
            ColSubtotal = new DataGridViewTextBoxColumn();
            ColQuitar = new DataGridViewButtonColumn();
            label1 = new Label();
            button1 = new Button();
            btnSiguiente = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(334, 91);
            txtCodigo.Margin = new Padding(3, 4, 3, 4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(186, 27);
            txtCodigo.TabIndex = 1;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            txtCodigo.KeyDown += txtCodigo_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(257, 95);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 2;
            label2.Text = "Codigo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(553, 500);
            label3.Name = "label3";
            label3.Size = new Size(244, 32);
            label3.TabIndex = 4;
            label3.Text = "Total en Productos:  $";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(859, 500);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(44, 32);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "---";
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColTipo, ColNombre, ColPrecio, ColCantidad, ColSubtotal, ColQuitar });
            dgvProductos.Location = new Point(14, 129);
            dgvProductos.Margin = new Padding(3, 4, 3, 4);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(887, 352);
            dgvProductos.TabIndex = 6;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "Producto";
            ColumnId.MinimumWidth = 6;
            ColumnId.Name = "ColumnId";
            ColumnId.Width = 80;
            // 
            // ColTipo
            // 
            ColTipo.HeaderText = "Tipo";
            ColTipo.MinimumWidth = 6;
            ColTipo.Name = "ColTipo";
            ColTipo.Width = 160;
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
            label1.Location = new Point(14, 28);
            label1.Name = "label1";
            label1.Size = new Size(366, 37);
            label1.TabIndex = 9;
            label1.Text = "Agregar Productos al Carrito";
            // 
            // button1
            // 
            button1.Location = new Point(199, 528);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 11;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(390, 528);
            btnSiguiente.Margin = new Padding(3, 4, 3, 4);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(86, 31);
            btnSiguiente.TabIndex = 12;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // button2
            // 
            button2.Location = new Point(553, 91);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 13;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FrmMDProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button2);
            Controls.Add(btnSiguiente);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dgvProductos);
            Controls.Add(lblTotal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCodigo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmMDProductos";
            Text = "FrmMDProductos";
            Load += FrmMDProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCodigo;
        private Label label2;
        private Label label3;
        private Label lblTotal;
        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColTipo;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColPrecio;
        private DataGridViewTextBoxColumn ColCantidad;
        private DataGridViewTextBoxColumn ColSubtotal;
        private DataGridViewButtonColumn ColQuitar;
        private Label label1;
        private Button button1;
        private Button btnSiguiente;
        private Button button2;
    }
}