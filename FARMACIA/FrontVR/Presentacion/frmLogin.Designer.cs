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
            label1.Location = new Point(600, 40);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(189, 51);
            label1.TabIndex = 4;
            label1.Text = "LOGIN";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(15, 15, 15);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point);
            txtUsuario.ForeColor = Color.DimGray;
            txtUsuario.Location = new Point(431, 149);
            txtUsuario.Margin = new Padding(4, 5, 4, 5);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(509, 23);
            txtUsuario.TabIndex = 0;
            txtUsuario.Text = "USUARIO";
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
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
            btnIngresar.Location = new Point(431, 308);
            btnIngresar.Margin = new Padding(4, 5, 4, 5);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(509, 61);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
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
            btnCancelar.Location = new Point(431, 401);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(509, 61);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 122, 204);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(logo);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(328, 518);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 122, 204);
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(328, 23);
            panel3.TabIndex = 13;
            panel3.MouseMove += panel3_MouseMove;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(24, 112);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(268, 335);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // logo
            // 
            logo.Image = Properties.Resources.logosolo;
            logo.Location = new Point(24, 72);
            logo.Margin = new Padding(4, 5, 4, 5);
            logo.Name = "logo";
            logo.Size = new Size(268, 335);
            logo.SizeMode = PictureBoxSizeMode.CenterImage;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(427, 182);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(387, 20);
            label4.TabIndex = 9;
            label4.Text = "_______________________________________________________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(427, 252);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(387, 20);
            label3.TabIndex = 11;
            label3.Text = "_______________________________________________________________";
            // 
            // txtClave
            // 
            txtClave.BackColor = Color.FromArgb(15, 15, 15);
            txtClave.BorderStyle = BorderStyle.None;
            txtClave.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point);
            txtClave.ForeColor = Color.DimGray;
            txtClave.Location = new Point(431, 221);
            txtClave.Margin = new Padding(4, 5, 4, 5);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(509, 23);
            txtClave.TabIndex = 1;
            txtClave.Text = "CONTRASEÑA";
            txtClave.TextChanged += txtClave_TextChanged;
            txtClave.Enter += txtClave_Enter;
            txtClave.Leave += txtClave_Leave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 15, 15);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(328, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(695, 23);
            panel1.TabIndex = 12;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(24, 112);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(268, 335);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(1023, 518);
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
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmLogin";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
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

