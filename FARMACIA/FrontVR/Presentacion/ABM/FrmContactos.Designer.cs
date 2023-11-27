namespace FrontVR.Presentacion.ABM
{
    partial class FrmContactos
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
            txtEmail = new TextBox();
            label1 = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtApellido = new TextBox();
            gbCliente = new GroupBox();
            rbtHombre = new RadioButton();
            rbtMujer = new RadioButton();
            label5 = new Label();
            label4 = new Label();
            txtDni = new TextBox();
            cboBarrioCliente = new ComboBox();
            label2 = new Label();
            cboObraCliente = new ComboBox();
            label6 = new Label();
            txtTelefono = new TextBox();
            gbEmpleado = new GroupBox();
            label9 = new Label();
            label7 = new Label();
            txtSueldo = new TextBox();
            cboSedeEmpleado = new ComboBox();
            label8 = new Label();
            cboPuesto = new ComboBox();
            gbMedico = new GroupBox();
            label12 = new Label();
            txtMatricula = new TextBox();
            label11 = new Label();
            cboSedeMedico = new ComboBox();
            label10 = new Label();
            cboObraMedico = new ComboBox();
            gbProveedor = new GroupBox();
            label16 = new Label();
            txtCuit = new TextBox();
            label15 = new Label();
            txtCalle = new TextBox();
            label14 = new Label();
            cboBarrioProv = new ComboBox();
            label13 = new Label();
            cboRazon = new ComboBox();
            lstContactos = new ListBox();
            chkCliente = new CheckBox();
            label17 = new Label();
            label18 = new Label();
            chkProveedor = new CheckBox();
            chkMedico = new CheckBox();
            chkEmpleado = new CheckBox();
            btnNuevo = new Button();
            btnEditar = new Button();
            btnBorrar = new Button();
            btnGrabar = new Button();
            btnSalir = new Button();
            gbDatos = new GroupBox();
            gbBotones = new GroupBox();
            gbCliente.SuspendLayout();
            gbEmpleado.SuspendLayout();
            gbMedico.SuspendLayout();
            gbProveedor.SuspendLayout();
            gbDatos.SuspendLayout();
            gbBotones.SuspendLayout();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(68, 106);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(162, 23);
            txtEmail.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 109);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "e-mail";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(11, 25);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(68, 22);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(162, 23);
            txtNombre.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 54);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 5;
            label3.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(68, 51);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(162, 23);
            txtApellido.TabIndex = 1;
            // 
            // gbCliente
            // 
            gbCliente.Controls.Add(rbtHombre);
            gbCliente.Controls.Add(rbtMujer);
            gbCliente.Controls.Add(label5);
            gbCliente.Controls.Add(label4);
            gbCliente.Controls.Add(txtDni);
            gbCliente.Controls.Add(cboBarrioCliente);
            gbCliente.Controls.Add(label2);
            gbCliente.Controls.Add(cboObraCliente);
            gbCliente.Location = new Point(846, 327);
            gbCliente.Name = "gbCliente";
            gbCliente.Size = new Size(245, 152);
            gbCliente.TabIndex = 6;
            gbCliente.TabStop = false;
            gbCliente.Text = "Cliente";
            // 
            // rbtHombre
            // 
            rbtHombre.AutoSize = true;
            rbtHombre.Location = new Point(116, 116);
            rbtHombre.Name = "rbtHombre";
            rbtHombre.Size = new Size(69, 19);
            rbtHombre.TabIndex = 4;
            rbtHombre.TabStop = true;
            rbtHombre.Text = "Hombre";
            rbtHombre.UseVisualStyleBackColor = true;
            // 
            // rbtMujer
            // 
            rbtMujer.AutoSize = true;
            rbtMujer.Location = new Point(40, 116);
            rbtMujer.Name = "rbtMujer";
            rbtMujer.Size = new Size(56, 19);
            rbtMujer.TabIndex = 3;
            rbtMujer.TabStop = true;
            rbtMujer.Text = "Mujer";
            rbtMujer.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 90);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 8;
            label5.Text = "DNI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 61);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 10;
            label4.Text = "Barrio";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(88, 87);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(121, 23);
            txtDni.TabIndex = 2;
            // 
            // cboBarrioCliente
            // 
            cboBarrioCliente.FormattingEnabled = true;
            cboBarrioCliente.Location = new Point(88, 58);
            cboBarrioCliente.Name = "cboBarrioCliente";
            cboBarrioCliente.Size = new Size(121, 23);
            cboBarrioCliente.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 32);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 8;
            label2.Text = "Obra Social";
            // 
            // cboObraCliente
            // 
            cboObraCliente.FormattingEnabled = true;
            cboObraCliente.Location = new Point(88, 29);
            cboObraCliente.Name = "cboObraCliente";
            cboObraCliente.Size = new Size(121, 23);
            cboObraCliente.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 83);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 10;
            label6.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(68, 80);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(162, 23);
            txtTelefono.TabIndex = 2;
            // 
            // gbEmpleado
            // 
            gbEmpleado.Controls.Add(label9);
            gbEmpleado.Controls.Add(label7);
            gbEmpleado.Controls.Add(txtSueldo);
            gbEmpleado.Controls.Add(cboSedeEmpleado);
            gbEmpleado.Controls.Add(label8);
            gbEmpleado.Controls.Add(cboPuesto);
            gbEmpleado.Location = new Point(595, 17);
            gbEmpleado.Name = "gbEmpleado";
            gbEmpleado.Size = new Size(245, 123);
            gbEmpleado.TabIndex = 7;
            gbEmpleado.TabStop = false;
            gbEmpleado.Text = "Empleado";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 88);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 13;
            label9.Text = "Sueldo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 59);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 14;
            label7.Text = "Sede";
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(98, 85);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(121, 23);
            txtSueldo.TabIndex = 2;
            // 
            // cboSedeEmpleado
            // 
            cboSedeEmpleado.FormattingEnabled = true;
            cboSedeEmpleado.Location = new Point(98, 56);
            cboSedeEmpleado.Name = "cboSedeEmpleado";
            cboSedeEmpleado.Size = new Size(121, 23);
            cboSedeEmpleado.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 30);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 12;
            label8.Text = "Puesto";
            // 
            // cboPuesto
            // 
            cboPuesto.FormattingEnabled = true;
            cboPuesto.Location = new Point(98, 27);
            cboPuesto.Name = "cboPuesto";
            cboPuesto.Size = new Size(121, 23);
            cboPuesto.TabIndex = 0;
            // 
            // gbMedico
            // 
            gbMedico.Controls.Add(label12);
            gbMedico.Controls.Add(txtMatricula);
            gbMedico.Controls.Add(label11);
            gbMedico.Controls.Add(cboSedeMedico);
            gbMedico.Controls.Add(label10);
            gbMedico.Controls.Add(cboObraMedico);
            gbMedico.Location = new Point(846, 18);
            gbMedico.Name = "gbMedico";
            gbMedico.Size = new Size(245, 139);
            gbMedico.TabIndex = 8;
            gbMedico.TabStop = false;
            gbMedico.Text = "Medico";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(25, 92);
            label12.Name = "label12";
            label12.Size = new Size(57, 15);
            label12.TabIndex = 18;
            label12.Text = "Matricula";
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(98, 89);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(121, 23);
            txtMatricula.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(25, 63);
            label11.Name = "label11";
            label11.Size = new Size(32, 15);
            label11.TabIndex = 16;
            label11.Text = "Sede";
            // 
            // cboSedeMedico
            // 
            cboSedeMedico.FormattingEnabled = true;
            cboSedeMedico.Location = new Point(98, 60);
            cboSedeMedico.Name = "cboSedeMedico";
            cboSedeMedico.Size = new Size(121, 23);
            cboSedeMedico.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(25, 34);
            label10.Name = "label10";
            label10.Size = new Size(67, 15);
            label10.TabIndex = 10;
            label10.Text = "Obra Social";
            // 
            // cboObraMedico
            // 
            cboObraMedico.FormattingEnabled = true;
            cboObraMedico.Location = new Point(98, 31);
            cboObraMedico.Name = "cboObraMedico";
            cboObraMedico.Size = new Size(121, 23);
            cboObraMedico.TabIndex = 0;
            // 
            // gbProveedor
            // 
            gbProveedor.Controls.Add(label16);
            gbProveedor.Controls.Add(txtCuit);
            gbProveedor.Controls.Add(label15);
            gbProveedor.Controls.Add(txtCalle);
            gbProveedor.Controls.Add(label14);
            gbProveedor.Controls.Add(cboBarrioProv);
            gbProveedor.Controls.Add(label13);
            gbProveedor.Controls.Add(cboRazon);
            gbProveedor.Location = new Point(846, 163);
            gbProveedor.Name = "gbProveedor";
            gbProveedor.Size = new Size(245, 158);
            gbProveedor.TabIndex = 9;
            gbProveedor.TabStop = false;
            gbProveedor.Text = "Proveedor";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(25, 120);
            label16.Name = "label16";
            label16.Size = new Size(32, 15);
            label16.TabIndex = 22;
            label16.Text = "CUIT";
            // 
            // txtCuit
            // 
            txtCuit.Location = new Point(98, 117);
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(121, 23);
            txtCuit.TabIndex = 3;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(25, 91);
            label15.Name = "label15";
            label15.Size = new Size(33, 15);
            label15.TabIndex = 20;
            label15.Text = "Calle";
            // 
            // txtCalle
            // 
            txtCalle.Location = new Point(98, 88);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(121, 23);
            txtCalle.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(25, 62);
            label14.Name = "label14";
            label14.Size = new Size(38, 15);
            label14.TabIndex = 14;
            label14.Text = "Barrio";
            // 
            // cboBarrioProv
            // 
            cboBarrioProv.FormattingEnabled = true;
            cboBarrioProv.Location = new Point(98, 59);
            cboBarrioProv.Name = "cboBarrioProv";
            cboBarrioProv.Size = new Size(121, 23);
            cboBarrioProv.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(25, 32);
            label13.Name = "label13";
            label13.Size = new Size(73, 15);
            label13.TabIndex = 12;
            label13.Text = "Razon Social";
            // 
            // cboRazon
            // 
            cboRazon.FormattingEnabled = true;
            cboRazon.Location = new Point(98, 29);
            cboRazon.Name = "cboRazon";
            cboRazon.Size = new Size(121, 23);
            cboRazon.TabIndex = 0;
            // 
            // lstContactos
            // 
            lstContactos.FormattingEnabled = true;
            lstContactos.ItemHeight = 15;
            lstContactos.Location = new Point(257, 117);
            lstContactos.Name = "lstContactos";
            lstContactos.Size = new Size(226, 409);
            lstContactos.TabIndex = 5;
            lstContactos.SelectedIndexChanged += lstContactos_SelectedIndexChanged;
            // 
            // chkCliente
            // 
            chkCliente.AutoSize = true;
            chkCliente.Location = new Point(222, 51);
            chkCliente.Name = "chkCliente";
            chkCliente.Size = new Size(63, 19);
            chkCliente.TabIndex = 0;
            chkCliente.Text = "Cliente";
            chkCliente.UseVisualStyleBackColor = true;
            chkCliente.CheckedChanged += chkCliente_CheckedChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(11, 9);
            label17.Name = "label17";
            label17.Size = new Size(195, 30);
            label17.TabIndex = 16;
            label17.Text = "Carga de Contactos";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(47, 59);
            label18.Name = "label18";
            label18.Size = new Size(166, 20);
            label18.TabIndex = 17;
            label18.Text = "Seleccionar una opcion:";
            // 
            // chkProveedor
            // 
            chkProveedor.AutoSize = true;
            chkProveedor.Location = new Point(326, 76);
            chkProveedor.Name = "chkProveedor";
            chkProveedor.Size = new Size(80, 19);
            chkProveedor.TabIndex = 3;
            chkProveedor.Text = "Proveedor";
            chkProveedor.UseVisualStyleBackColor = true;
            chkProveedor.CheckedChanged += chkProveedor_CheckedChanged;
            // 
            // chkMedico
            // 
            chkMedico.AutoSize = true;
            chkMedico.Location = new Point(326, 51);
            chkMedico.Name = "chkMedico";
            chkMedico.Size = new Size(66, 19);
            chkMedico.TabIndex = 1;
            chkMedico.Text = "Medico";
            chkMedico.UseVisualStyleBackColor = true;
            chkMedico.CheckedChanged += chkMedico_CheckedChanged;
            // 
            // chkEmpleado
            // 
            chkEmpleado.AutoSize = true;
            chkEmpleado.Location = new Point(222, 76);
            chkEmpleado.Name = "chkEmpleado";
            chkEmpleado.Size = new Size(79, 19);
            chkEmpleado.TabIndex = 2;
            chkEmpleado.Text = "Empleado";
            chkEmpleado.UseVisualStyleBackColor = true;
            chkEmpleado.CheckedChanged += chkEmpleado_CheckedChanged;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(18, 22);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(112, 22);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(297, 22);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 3;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(203, 22);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(75, 23);
            btnGrabar.TabIndex = 4;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(387, 22);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // gbDatos
            // 
            gbDatos.Controls.Add(txtNombre);
            gbDatos.Controls.Add(txtEmail);
            gbDatos.Controls.Add(label1);
            gbDatos.Controls.Add(lblNombre);
            gbDatos.Controls.Add(txtApellido);
            gbDatos.Controls.Add(label3);
            gbDatos.Controls.Add(txtTelefono);
            gbDatos.Controls.Add(label6);
            gbDatos.Location = new Point(6, 112);
            gbDatos.Name = "gbDatos";
            gbDatos.Size = new Size(245, 142);
            gbDatos.TabIndex = 6;
            gbDatos.TabStop = false;
            gbDatos.Text = "Datos";
            // 
            // gbBotones
            // 
            gbBotones.Controls.Add(btnNuevo);
            gbBotones.Controls.Add(btnEditar);
            gbBotones.Controls.Add(btnSalir);
            gbBotones.Controls.Add(btnGrabar);
            gbBotones.Controls.Add(btnBorrar);
            gbBotones.Location = new Point(6, 534);
            gbBotones.Name = "gbBotones";
            gbBotones.Size = new Size(477, 59);
            gbBotones.TabIndex = 4;
            gbBotones.TabStop = false;
            // 
            // FrmContactos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 599);
            Controls.Add(gbBotones);
            Controls.Add(gbDatos);
            Controls.Add(chkEmpleado);
            Controls.Add(chkMedico);
            Controls.Add(chkProveedor);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(chkCliente);
            Controls.Add(lstContactos);
            Controls.Add(gbProveedor);
            Controls.Add(gbMedico);
            Controls.Add(gbEmpleado);
            Controls.Add(gbCliente);
            MaximumSize = new Size(511, 638);
            MinimumSize = new Size(511, 638);
            Name = "FrmContactos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ABMC Contactos";
            Load += FrmContactos_Load;
            gbCliente.ResumeLayout(false);
            gbCliente.PerformLayout();
            gbEmpleado.ResumeLayout(false);
            gbEmpleado.PerformLayout();
            gbMedico.ResumeLayout(false);
            gbMedico.PerformLayout();
            gbProveedor.ResumeLayout(false);
            gbProveedor.PerformLayout();
            gbDatos.ResumeLayout(false);
            gbDatos.PerformLayout();
            gbBotones.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private Label label1;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtApellido;
        private GroupBox gbCliente;
        private Label label5;
        private Label label4;
        private TextBox txtDni;
        private ComboBox cboBarrioCliente;
        private Label label2;
        private ComboBox cboObraCliente;
        private Label label6;
        private TextBox txtTelefono;
        private RadioButton rbtHombre;
        private RadioButton rbtMujer;
        private GroupBox gbEmpleado;
        private Label label7;
        private ComboBox cboSedeEmpleado;
        private Label label8;
        private ComboBox cboPuesto;
        private Label label9;
        private TextBox txtSueldo;
        private GroupBox gbMedico;
        private Label label11;
        private ComboBox cboSedeMedico;
        private Label label10;
        private ComboBox cboObraMedico;
        private Label label12;
        private TextBox txtMatricula;
        private GroupBox gbProveedor;
        private Label label14;
        private ComboBox cboBarrioProv;
        private Label label13;
        private ComboBox cboRazon;
        private Label label16;
        private TextBox txtCuit;
        private Label label15;
        private TextBox txtCalle;
        private ListBox lstContactos;
        private CheckBox chkCliente;
        private Label label17;
        private Label label18;
        private CheckBox chkProveedor;
        private CheckBox chkMedico;
        private CheckBox chkEmpleado;
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnBorrar;
        private Button btnGrabar;
        private Button btnSalir;
        private GroupBox gbDatos;
        private GroupBox gbBotones;
    }
}