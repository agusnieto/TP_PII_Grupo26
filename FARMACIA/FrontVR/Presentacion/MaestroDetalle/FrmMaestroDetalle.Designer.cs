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
            btnFinalizar = new Button();
            SuspendLayout();
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(123, 124);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(75, 23);
            btnSiguiente.TabIndex = 1;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(23, 124);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(123, 31);
            label1.Name = "label1";
            label1.Size = new Size(79, 30);
            label1.TabIndex = 9;
            label1.Text = "Carrito";
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(221, 124);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(75, 23);
            btnFinalizar.TabIndex = 10;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // FrmMaestroDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 195);
            Controls.Add(btnFinalizar);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnSiguiente);
            Name = "FrmMaestroDetalle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MaestroDetalle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSiguiente;
        private Button btnCancelar;
        private Label label1;
        private Button btnFinalizar;
    }
}