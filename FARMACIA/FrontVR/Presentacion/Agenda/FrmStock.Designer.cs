namespace FrontVR.Presentacion.Agenda
{
    partial class FrmStock
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
            dgvProductos = new DataGridView();
            ColID = new DataGridViewTextBoxColumn();
            ColProducto = new DataGridViewTextBoxColumn();
            ColDetalle = new DataGridViewTextBoxColumn();
            ColProveedor = new DataGridViewTextBoxColumn();
            ColPais = new DataGridViewTextBoxColumn();
            ColStock = new DataGridViewTextBoxColumn();
            ColPrecio = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { ColID, ColProducto, ColDetalle, ColProveedor, ColPais, ColStock, ColPrecio });
            dgvProductos.Location = new Point(12, 59);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(776, 379);
            dgvProductos.TabIndex = 1;
            // 
            // ColID
            // 
            ColID.HeaderText = "ID";
            ColID.Name = "ColID";
            ColID.Width = 40;
            // 
            // ColProducto
            // 
            ColProducto.FillWeight = 120F;
            ColProducto.HeaderText = "Producto";
            ColProducto.Name = "ColProducto";
            ColProducto.Width = 130;
            // 
            // ColDetalle
            // 
            ColDetalle.FillWeight = 120F;
            ColDetalle.HeaderText = "Detalle";
            ColDetalle.Name = "ColDetalle";
            ColDetalle.Width = 130;
            // 
            // ColProveedor
            // 
            ColProveedor.FillWeight = 120F;
            ColProveedor.HeaderText = "Proveedor";
            ColProveedor.Name = "ColProveedor";
            ColProveedor.Width = 130;
            // 
            // ColPais
            // 
            ColPais.FillWeight = 120F;
            ColPais.HeaderText = "Pais";
            ColPais.Name = "ColPais";
            // 
            // ColStock
            // 
            ColStock.FillWeight = 80F;
            ColStock.HeaderText = "Stock";
            ColStock.Name = "ColStock";
            // 
            // ColPrecio
            // 
            ColPrecio.HeaderText = "Precio";
            ColPrecio.Name = "ColPrecio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(240, 32);
            label1.TabIndex = 3;
            label1.Text = "Control de Productos";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(402, 20);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(191, 23);
            txtNombre.TabIndex = 0;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(288, 23);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 2;
            label2.Text = "Buscar por nombre";
            // 
            // FrmStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(dgvProductos);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "FrmStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos";
            Load += FrmStock_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private DataGridViewTextBoxColumn ColID;
        private DataGridViewTextBoxColumn ColProducto;
        private DataGridViewTextBoxColumn ColDetalle;
        private DataGridViewTextBoxColumn ColProveedor;
        private DataGridViewTextBoxColumn ColPais;
        private DataGridViewTextBoxColumn ColStock;
        private DataGridViewTextBoxColumn ColPrecio;
    }
}