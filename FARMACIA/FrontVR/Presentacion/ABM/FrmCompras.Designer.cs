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
            listBoxProductos.ItemHeight = 20;
            listBoxProductos.Location = new Point(358, 32);
            listBoxProductos.Margin = new Padding(3, 4, 3, 4);
            listBoxProductos.Name = "listBoxProductos";
            listBoxProductos.Size = new Size(263, 404);
            listBoxProductos.TabIndex = 19;
            listBoxProductos.SelectedIndexChanged += listBoxProductos_SelectedIndexChanged;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(39, 464);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(86, 31);
            btnNuevo.TabIndex = 20;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(149, 464);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(86, 31);
            btnEditar.TabIndex = 21;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(261, 464);
            btnGrabar.Margin = new Padding(3, 4, 3, 4);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(86, 31);
            btnGrabar.TabIndex = 22;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(374, 464);
            btnBorrar.Margin = new Padding(3, 4, 3, 4);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(86, 31);
            btnBorrar.TabIndex = 23;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(483, 464);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(86, 31);
            btnSalir.TabIndex = 24;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(99, 340);
            label7.Name = "label7";
            label7.Size = new Size(34, 20);
            label7.TabIndex = 13;
            label7.Text = "Pais";
            // 
            // cboProveedor
            // 
            cboProveedor.FormattingEnabled = true;
            cboProveedor.Location = new Point(168, 300);
            cboProveedor.Margin = new Padding(3, 4, 3, 4);
            cboProveedor.Name = "cboProveedor";
            cboProveedor.Size = new Size(138, 28);
            cboProveedor.TabIndex = 12;
            // 
            // cboPais
            // 
            cboPais.FormattingEnabled = true;
            cboPais.Location = new Point(99, 364);
            cboPais.Margin = new Padding(3, 4, 3, 4);
            cboPais.Name = "cboPais";
            cboPais.Size = new Size(138, 28);
            cboPais.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(168, 276);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 11;
            label6.Text = "Proveedor";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(106, 141);
            txtStock.Margin = new Padding(3, 4, 3, 4);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(52, 27);
            txtStock.TabIndex = 15;
            // 
            // cboCaracteristica
            // 
            cboCaracteristica.FormattingEnabled = true;
            cboCaracteristica.Location = new Point(168, 239);
            cboCaracteristica.Margin = new Padding(3, 4, 3, 4);
            cboCaracteristica.Name = "cboCaracteristica";
            cboCaracteristica.Size = new Size(138, 28);
            cboCaracteristica.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(58, 145);
            label8.Name = "label8";
            label8.Size = new Size(45, 20);
            label8.TabIndex = 16;
            label8.Text = "Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(168, 215);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 9;
            label5.Text = "Caracteristica";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(216, 141);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(52, 27);
            txtPrecio.TabIndex = 17;
            // 
            // cboMarca
            // 
            cboMarca.FormattingEnabled = true;
            cboMarca.Location = new Point(10, 300);
            cboMarca.Margin = new Padding(3, 4, 3, 4);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(138, 28);
            cboMarca.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(168, 145);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 18;
            label9.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 276);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 7;
            label4.Text = "Marca";
            // 
            // cboTipoProducto
            // 
            cboTipoProducto.FormattingEnabled = true;
            cboTipoProducto.Location = new Point(10, 239);
            cboTipoProducto.Margin = new Padding(3, 4, 3, 4);
            cboTipoProducto.Name = "cboTipoProducto";
            cboTipoProducto.Size = new Size(138, 28);
            cboTipoProducto.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 215);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 5;
            label3.Text = "Tipo de Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 81);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 3;
            label2.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(106, 81);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(114, 27);
            txtDescripcion.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 40);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(106, 36);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(114, 27);
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
            gbDatos.Location = new Point(24, 16);
            gbDatos.Margin = new Padding(3, 4, 3, 4);
            gbDatos.Name = "gbDatos";
            gbDatos.Padding = new Padding(3, 4, 3, 4);
            gbDatos.Size = new Size(322, 421);
            gbDatos.TabIndex = 25;
            gbDatos.TabStop = false;
            gbDatos.Text = "Datos";
            // 
            // FrmCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 520);
            Controls.Add(gbDatos);
            Controls.Add(btnSalir);
            Controls.Add(btnBorrar);
            Controls.Add(btnGrabar);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(listBoxProductos);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmCompras";
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