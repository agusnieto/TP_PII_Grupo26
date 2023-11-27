namespace Farmacia
{
    partial class FrmMaestroDetalle
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
            btnSiguiente = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(133, 97);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(75, 23);
            btnSiguiente.TabIndex = 1;
            btnSiguiente.Text = "Agregar";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(33, 97);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Volver";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(76, 35);
            label1.Name = "label1";
            label1.Size = new Size(79, 30);
            label1.TabIndex = 2;
            label1.Text = "Carrito";
            // 
            // FrmMaestroDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 146);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnSiguiente);
            MaximumSize = new Size(250, 185);
            MinimumSize = new Size(250, 185);
            Name = "FrmMaestroDetalle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MaestroDetalle";
            Load += FrmMaestroDetalle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSiguiente;
        private Button btnCancelar;
        private Label label1;
    }
}