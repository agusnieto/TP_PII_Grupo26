namespace Farmacia
{
    partial class FrmAbmc
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
            btnNuevo = new Button();
            btnEditar = new Button();
            btnGrabar = new Button();
            btnBorrar = new Button();
            btnSalir = new Button();
            gb = new GroupBox();
            textBox1 = new TextBox();
            label11 = new Label();
            cboTipoProducto = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            cboUnidadMedida = new ComboBox();
            chkBajoReceta = new CheckBox();
            nudStockMinimo = new NumericUpDown();
            nudStockActual = new NumericUpDown();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            dtpFec_vencimiento = new DateTimePicker();
            chkHabilitado = new CheckBox();
            txtPrecioUnitario = new TextBox();
            label3 = new Label();
            txtDescripcion = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtID = new TextBox();
            dataGridView1 = new DataGridView();
            gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudStockMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStockActual).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevo.ForeColor = Color.FromArgb(46, 123, 140);
            btnNuevo.Location = new Point(41, 964);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(117, 42);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditar.ForeColor = Color.FromArgb(46, 123, 140);
            btnEditar.Location = new Point(209, 964);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(117, 42);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            btnGrabar.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGrabar.ForeColor = Color.FromArgb(46, 123, 140);
            btnGrabar.Location = new Point(559, 964);
            btnGrabar.Margin = new Padding(3, 4, 3, 4);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(117, 42);
            btnGrabar.TabIndex = 3;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            btnBorrar.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBorrar.ForeColor = Color.FromArgb(46, 123, 140);
            btnBorrar.Location = new Point(389, 964);
            btnBorrar.Margin = new Padding(3, 4, 3, 4);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(117, 42);
            btnBorrar.TabIndex = 2;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.FromArgb(46, 123, 140);
            btnSalir.Location = new Point(737, 964);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(117, 42);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // gb
            // 
            gb.BackColor = Color.FromArgb(138, 176, 191);
            gb.Controls.Add(textBox1);
            gb.Controls.Add(label11);
            gb.Controls.Add(cboTipoProducto);
            gb.Controls.Add(label9);
            gb.Controls.Add(label10);
            gb.Controls.Add(cboUnidadMedida);
            gb.Controls.Add(chkBajoReceta);
            gb.Controls.Add(nudStockMinimo);
            gb.Controls.Add(nudStockActual);
            gb.Controls.Add(label7);
            gb.Controls.Add(label6);
            gb.Controls.Add(label5);
            gb.Controls.Add(dtpFec_vencimiento);
            gb.Controls.Add(chkHabilitado);
            gb.Controls.Add(txtPrecioUnitario);
            gb.Controls.Add(label3);
            gb.Controls.Add(txtDescripcion);
            gb.Controls.Add(label2);
            gb.Controls.Add(label1);
            gb.Controls.Add(txtID);
            gb.FlatStyle = FlatStyle.Flat;
            gb.ForeColor = Color.White;
            gb.Location = new Point(12, 331);
            gb.Margin = new Padding(3, 4, 3, 4);
            gb.Name = "gb";
            gb.Padding = new Padding(3, 4, 3, 4);
            gb.Size = new Size(901, 619);
            gb.TabIndex = 5;
            gb.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(257, 456);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(527, 30);
            textBox1.TabIndex = 45;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(85, 459);
            label11.Name = "label11";
            label11.Size = new Size(133, 23);
            label11.TabIndex = 44;
            label11.Text = "Descuento";
            // 
            // cboTipoProducto
            // 
            cboTipoProducto.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboTipoProducto.FormattingEnabled = true;
            cboTipoProducto.Location = new Point(257, 402);
            cboTipoProducto.Margin = new Padding(3, 4, 3, 4);
            cboTipoProducto.Name = "cboTipoProducto";
            cboTipoProducto.Size = new Size(527, 31);
            cboTipoProducto.TabIndex = 43;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(15, 405);
            label9.Name = "label9";
            label9.Size = new Size(203, 23);
            label9.TabIndex = 42;
            label9.Text = "Tipo de Producto";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(12, 349);
            label10.Name = "label10";
            label10.Size = new Size(206, 23);
            label10.TabIndex = 41;
            label10.Text = "Unidad de Medida";
            // 
            // cboUnidadMedida
            // 
            cboUnidadMedida.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboUnidadMedida.FormattingEnabled = true;
            cboUnidadMedida.Location = new Point(257, 346);
            cboUnidadMedida.Margin = new Padding(3, 4, 3, 4);
            cboUnidadMedida.Name = "cboUnidadMedida";
            cboUnidadMedida.Size = new Size(527, 31);
            cboUnidadMedida.TabIndex = 40;
            // 
            // chkBajoReceta
            // 
            chkBajoReceta.AutoSize = true;
            chkBajoReceta.Checked = true;
            chkBajoReceta.CheckState = CheckState.Checked;
            chkBajoReceta.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkBajoReceta.ForeColor = Color.White;
            chkBajoReceta.Location = new Point(257, 516);
            chkBajoReceta.Margin = new Padding(3, 4, 3, 4);
            chkBajoReceta.Name = "chkBajoReceta";
            chkBajoReceta.Size = new Size(172, 27);
            chkBajoReceta.TabIndex = 38;
            chkBajoReceta.Text = "Bajo Receta";
            chkBajoReceta.UseVisualStyleBackColor = true;
            // 
            // nudStockMinimo
            // 
            nudStockMinimo.Location = new Point(217, 932);
            nudStockMinimo.Margin = new Padding(3, 12, 3, 12);
            nudStockMinimo.Name = "nudStockMinimo";
            nudStockMinimo.Size = new Size(313, 27);
            nudStockMinimo.TabIndex = 37;
            // 
            // nudStockActual
            // 
            nudStockActual.Location = new Point(217, 769);
            nudStockActual.Margin = new Padding(3, 12, 3, 12);
            nudStockActual.Name = "nudStockActual";
            nudStockActual.Size = new Size(313, 27);
            nudStockActual.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(60, 291);
            label7.Name = "label7";
            label7.Size = new Size(158, 23);
            label7.TabIndex = 35;
            label7.Text = "Stock Minimo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(56, 241);
            label6.Name = "label6";
            label6.Size = new Size(162, 23);
            label6.TabIndex = 34;
            label6.Text = "Stock Actual";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(70, 193);
            label5.Name = "label5";
            label5.Size = new Size(148, 23);
            label5.TabIndex = 33;
            label5.Text = "Vencimiento";
            // 
            // dtpFec_vencimiento
            // 
            dtpFec_vencimiento.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFec_vencimiento.Format = DateTimePickerFormat.Short;
            dtpFec_vencimiento.Location = new Point(257, 186);
            dtpFec_vencimiento.Margin = new Padding(3, 4, 3, 4);
            dtpFec_vencimiento.Name = "dtpFec_vencimiento";
            dtpFec_vencimiento.Size = new Size(527, 30);
            dtpFec_vencimiento.TabIndex = 32;
            // 
            // chkHabilitado
            // 
            chkHabilitado.AutoSize = true;
            chkHabilitado.Checked = true;
            chkHabilitado.CheckState = CheckState.Checked;
            chkHabilitado.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkHabilitado.ForeColor = Color.White;
            chkHabilitado.Location = new Point(257, 551);
            chkHabilitado.Margin = new Padding(3, 4, 3, 4);
            chkHabilitado.Name = "chkHabilitado";
            chkHabilitado.Size = new Size(153, 27);
            chkHabilitado.TabIndex = 30;
            chkHabilitado.Text = "Habilitado";
            chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Enabled = false;
            txtPrecioUnitario.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecioUnitario.Location = new Point(257, 131);
            txtPrecioUnitario.Margin = new Padding(3, 4, 3, 4);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(527, 30);
            txtPrecioUnitario.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(31, 134);
            label3.Name = "label3";
            label3.Size = new Size(187, 23);
            label3.TabIndex = 28;
            label3.Text = "Precio Unitario";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Enabled = false;
            txtDescripcion.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.Location = new Point(257, 76);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(527, 30);
            txtDescripcion.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(70, 79);
            label2.Name = "label2";
            label2.Size = new Size(148, 23);
            label2.TabIndex = 26;
            label2.Text = "Descripcion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(184, 30);
            label1.Name = "label1";
            label1.Size = new Size(34, 23);
            label1.TabIndex = 25;
            label1.Text = "ID";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(257, 27);
            txtID.Margin = new Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.Size = new Size(527, 30);
            txtID.TabIndex = 24;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.DarkSlateGray;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(925, 323);
            dataGridView1.TabIndex = 6;
            // 
            // ABMC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 112, 140);
            ClientSize = new Size(925, 1023);
            Controls.Add(dataGridView1);
            Controls.Add(gb);
            Controls.Add(btnSalir);
            Controls.Add(btnGrabar);
            Controls.Add(btnBorrar);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            ForeColor = Color.FromArgb(46, 123, 140);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(943, 1070);
            MinimumSize = new Size(943, 1070);
            Name = "ABMC";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            gb.ResumeLayout(false);
            gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudStockMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStockActual).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNuevo;
        private Button btnEditar;
        private Button btnGrabar;
        private Button btnBorrar;
        private Button btnSalir;
        private GroupBox gb;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label11;
        private ComboBox cboTipoProducto;
        private Label label9;
        private Label label10;
        private ComboBox cboUnidadMedida;
        private CheckBox chkBajoReceta;
        private NumericUpDown nudStockMinimo;
        private NumericUpDown nudStockActual;
        private Label label7;
        private Label label6;
        private Label label5;
        private DateTimePicker dtpFec_vencimiento;
        private CheckBox chkHabilitado;
        private TextBox txtPrecioUnitario;
        private Label label3;
        private TextBox txtDescripcion;
        private Label label2;
        private Label label1;
        private TextBox txtID;
    }
}