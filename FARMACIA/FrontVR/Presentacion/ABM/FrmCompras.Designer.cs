namespace FrontVR.Presentacion.ABM
{
    partial class FrmCompras
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
            listBoxProductos = new ListBox();
            btnNuevo = new Button();
            btnEditar = new Button();
            btnGrabar = new Button();
            btnBorrar = new Button();
            btnSalir = new Button();
            label7 = new Label();
            cboProveedor = new ComboBox();
            cboPais = new ComboBox();
            label6 = new Label();
            txtStock = new TextBox();
            cboCaracteristica = new ComboBox();
            label8 = new Label();
            label5 = new Label();
            txtPrecio = new TextBox();
            cboMarca = new ComboBox();
            label9 = new Label();
            label4 = new Label();
            cboTipoProducto = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            txtDescripcion = new TextBox();
            label1 = new Label();
            txtNombre = new TextBox();
            gbDatos = new GroupBox();
            gbDatos.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxProductos
            // 
            listBoxProductos.FormattingEnabled = true;
            listBoxProductos.ItemHeight = 15;
            listBoxProductos.Location = new Point(313, 24);
            listBoxProductos.Name = "listBoxProductos";
            listBoxProductos.Size = new Size(231, 304);
            listBoxProductos.TabIndex = 2;
            listBoxProductos.SelectedIndexChanged += listBoxProductos_SelectedIndexChanged;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(34, 348);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(130, 348);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(228, 348);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(75, 23);
            btnGrabar.TabIndex = 6;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(327, 348);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 4;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(423, 348);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(87, 255);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 13;
            label7.Text = "Pais";
            // 
            // cboProveedor
            // 
            cboProveedor.FormattingEnabled = true;
            cboProveedor.Location = new Point(147, 225);
            cboProveedor.Name = "cboProveedor";
            cboProveedor.Size = new Size(121, 23);
            cboProveedor.TabIndex = 7;
            // 
            // cboPais
            // 
            cboPais.FormattingEnabled = true;
            cboPais.Location = new Point(87, 273);
            cboPais.Name = "cboPais";
            cboPais.Size = new Size(121, 23);
            cboPais.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(147, 207);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 11;
            label6.Text = "Proveedor";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(93, 106);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(46, 23);
            txtStock.TabIndex = 2;
            // 
            // cboCaracteristica
            // 
            cboCaracteristica.FormattingEnabled = true;
            cboCaracteristica.Location = new Point(147, 179);
            cboCaracteristica.Name = "cboCaracteristica";
            cboCaracteristica.Size = new Size(121, 23);
            cboCaracteristica.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(51, 109);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 16;
            label8.Text = "Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(147, 161);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 9;
            label5.Text = "Caracteristica";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(189, 106);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(46, 23);
            txtPrecio.TabIndex = 3;
            // 
            // cboMarca
            // 
            cboMarca.FormattingEnabled = true;
            cboMarca.Location = new Point(9, 225);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(121, 23);
            cboMarca.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(147, 109);
            label9.Name = "label9";
            label9.Size = new Size(40, 15);
            label9.TabIndex = 18;
            label9.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 207);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 7;
            label4.Text = "Marca";
            // 
            // cboTipoProducto
            // 
            cboTipoProducto.FormattingEnabled = true;
            cboTipoProducto.Location = new Point(9, 179);
            cboTipoProducto.Name = "cboTipoProducto";
            cboTipoProducto.Size = new Size(121, 23);
            cboTipoProducto.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 161);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 5;
            label3.Text = "Tipo de Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 61);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(93, 61);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 30);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(93, 27);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            // 
            // gbDatos
            // 
            gbDatos.Controls.Add(txtNombre);
            gbDatos.Controls.Add(label1);
            gbDatos.Controls.Add(txtDescripcion);
            gbDatos.Controls.Add(label2);
            gbDatos.Controls.Add(label3);
            gbDatos.Controls.Add(cboTipoProducto);
            gbDatos.Controls.Add(label4);
            gbDatos.Controls.Add(label9);
            gbDatos.Controls.Add(cboMarca);
            gbDatos.Controls.Add(txtPrecio);
            gbDatos.Controls.Add(label5);
            gbDatos.Controls.Add(label8);
            gbDatos.Controls.Add(cboCaracteristica);
            gbDatos.Controls.Add(txtStock);
            gbDatos.Controls.Add(label6);
            gbDatos.Controls.Add(cboPais);
            gbDatos.Controls.Add(cboProveedor);
            gbDatos.Controls.Add(label7);
            gbDatos.Location = new Point(21, 12);
            gbDatos.Name = "gbDatos";
            gbDatos.Size = new Size(282, 316);
            gbDatos.TabIndex = 5;
            gbDatos.TabStop = false;
            gbDatos.Text = "Datos";
            // 
            // FrmCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 390);
            Controls.Add(gbDatos);
            Controls.Add(btnSalir);
            Controls.Add(btnBorrar);
            Controls.Add(btnGrabar);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(listBoxProductos);
            MaximumSize = new Size(580, 429);
            MinimumSize = new Size(580, 429);
            Name = "FrmCompras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmContactos";
            Load += FrmContactos_Load;
            gbDatos.ResumeLayout(false);
            gbDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxProductos;
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnGrabar;
        private Button btnBorrar;
        private Button btnSalir;
        private Label label7;
        private ComboBox cboProveedor;
        private ComboBox cboPais;
        private Label label6;
        private TextBox txtStock;
        private ComboBox cboCaracteristica;
        private Label label8;
        private Label label5;
        private TextBox txtPrecio;
        private ComboBox cboMarca;
        private Label label9;
        private Label label4;
        private ComboBox cboTipoProducto;
        private Label label3;
        private Label label2;
        private TextBox txtDescripcion;
        private Label label1;
        private TextBox txtNombre;
        private GroupBox gbDatos;
    }
}