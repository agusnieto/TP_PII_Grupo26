namespace FrontVR
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtUsuario = new TextBox();
            btnIngresar = new Button();
            btnCancelar = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            logo = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            txtClave = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 122, 204);
            label1.Location = new Point(750, 50);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(226, 61);
            label1.TabIndex = 4;
            label1.Text = "LOGIN";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(15, 15, 15);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point);
            txtUsuario.ForeColor = Color.DimGray;
            txtUsuario.Location = new Point(539, 187);
            txtUsuario.Margin = new Padding(6, 7, 6, 7);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(636, 28);
            txtUsuario.TabIndex = 0;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(40, 40, 40);
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnIngresar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Copperplate Gothic Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.ForeColor = Color.FromArgb(0, 122, 204);
            btnIngresar.Location = new Point(539, 385);
            btnIngresar.Margin = new Padding(6, 7, 6, 7);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(636, 77);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(40, 40, 40);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Copperplate Gothic Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.FromArgb(0, 122, 204);
            btnCancelar.Location = new Point(539, 502);
            btnCancelar.Margin = new Padding(6, 7, 6, 7);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(636, 77);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 122, 204);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(logo);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(410, 647);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 122, 204);
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(410, 28);
            panel3.TabIndex = 13;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(30, 140);
            pictureBox2.Margin = new Padding(6, 7, 6, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(334, 418);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // logo
            // 
            logo.Image = Properties.Resources.logosolo;
            logo.Location = new Point(30, 90);
            logo.Margin = new Padding(6, 7, 6, 7);
            logo.Name = "logo";
            logo.Size = new Size(334, 418);
            logo.SizeMode = PictureBoxSizeMode.CenterImage;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(534, 227);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(453, 25);
            label4.TabIndex = 9;
            label4.Text = "_______________________________________________________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(534, 315);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(453, 25);
            label3.TabIndex = 11;
            label3.Text = "_______________________________________________________________";
            // 
            // txtClave
            // 
            txtClave.BackColor = Color.FromArgb(15, 15, 15);
            txtClave.BorderStyle = BorderStyle.None;
            txtClave.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point);
            txtClave.ForeColor = Color.DimGray;
            txtClave.Location = new Point(539, 277);
            txtClave.Margin = new Padding(6, 7, 6, 7);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(636, 28);
            txtClave.TabIndex = 1;
            txtClave.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 15, 15);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(410, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(869, 28);
            panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(30, 140);
            pictureBox1.Margin = new Padding(6, 7, 6, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(334, 418);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(1279, 647);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(txtClave);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(btnCancelar);
            Controls.Add(btnIngresar);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 7, 6, 7);
            Name = "frmLogin";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmLogin_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsuario;
        private Button btnIngresar;
        private Button btnCancelar;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private TextBox txtClave;
        private PictureBox logo;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private PictureBox pictureBox2;
    }
}

