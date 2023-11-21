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
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(292, 68);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(163, 23);
            txtCodigo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(225, 71);
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
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColTipo, ColNombre, ColPrecio, ColCantidad, ColSubtotal, ColQuitar });
            dgvProductos.Location = new Point(12, 97);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(776, 264);
            dgvProductos.TabIndex = 6;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "Producto";
            ColumnId.Name = "ColumnId";
            ColumnId.Width = 80;
            // 
            // ColTipo
            // 
            ColTipo.HeaderText = "Tipo";
            ColTipo.Name = "ColTipo";
            ColTipo.Width = 160;
            // 
            // ColNombre
            // 
            ColNombre.HeaderText = "Nombre";
            ColNombre.Name = "ColNombre";
            ColNombre.Width = 160;
            // 
            // ColPrecio
            // 
            ColPrecio.HeaderText = "Precio";
            ColPrecio.Name = "ColPrecio";
            ColPrecio.Width = 80;
            // 
            // ColCantidad
            // 
            ColCantidad.HeaderText = "Cantidad";
            ColCantidad.Name = "ColCantidad";
            ColCantidad.Width = 80;
            // 
            // ColSubtotal
            // 
            ColSubtotal.HeaderText = "Subtotal";
            ColSubtotal.Name = "ColSubtotal";
            ColSubtotal.Width = 120;
            // 
            // ColQuitar
            // 
            ColQuitar.HeaderText = "Quitar";
            ColQuitar.Name = "ColQuitar";
            ColQuitar.Width = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(289, 30);
            label1.TabIndex = 9;
            label1.Text = "Agregar Productos al Carrito";
            // 
            // FrmMDProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dgvProductos);
            Controls.Add(lblTotal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCodigo);
            Name = "FrmMDProductos";
            Text = "FrmMDProductos";
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
    }
}