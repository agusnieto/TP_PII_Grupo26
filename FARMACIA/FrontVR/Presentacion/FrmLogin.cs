using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontVR
{
    public partial class frmLogin : Form
    {
        AccesoDatos ayudante = new AccesoDatos();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (ValidarLogueo())
            {
                int resultado = ayudante.Logeo(txtUsuario.Text, txtClave.Text);

                if (resultado == 1)
                {
                    // ACA ESTA LA RUTA AL FORM DE VALENTINA
                    //Form frmExitoso = new frmExitoso();
                    FrmMenu menu = new FrmMenu();
                    this.Hide();
                    // LO MUESTRA
                    //frmExitoso.ShowDialog();
                    menu.ShowDialog();
                }
                else if (resultado == 0)
                {
                    MessageBox.Show("Usuario o contraseña incorrecta...");
                }
            }
        }

        public bool ValidarLogueo()
        {
            if (txtUsuario.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar su USUARIO...", "Error", MessageBoxButtons.OK);
                LimpiarLogueo();
                return false;
            }

            if (txtClave.Text == "")
            {
                MessageBox.Show("Debe ingresar su CLAVE...", "Error", MessageBoxButtons.OK);
                LimpiarLogueo();
                return false;
            }
            return true;
        }

        private void LimpiarLogueo()
        {
            txtUsuario.Clear();
            txtClave.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals(string.Empty) && txtClave.Text.Equals(string.Empty))
            {

                if (MessageBox.Show("Esta Seguro que Desea Salir?", "Si", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                txtUsuario.Text = string.Empty;
                txtClave.Text = string.Empty;
            }




        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightBlue;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtClave_Enter(object sender, EventArgs e)
        {
            if (txtClave.Text == "CONTRASEÑA")
            {
                txtClave.Text = "";
                txtClave.ForeColor = Color.LightBlue;
                txtClave.UseSystemPasswordChar = true;
            }
        }

        private void txtClave_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtClave.Text = "CONTRASEÑA";
                txtClave.ForeColor = Color.DimGray;
                txtClave.UseSystemPasswordChar = false;
            }
        }

        int posx;
        int posy;
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button != MouseButtons.Left)
            {
                posx = e.X;
                posy = e.Y;
            }
            else
            {
                Left = Left + (e.X - posx);
                Top = Top + (e.Y - posy);
            }


        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posx = e.X;
                posy = e.Y;
            }
            else
            {
                Left = Left + (e.X - posx);
                Top = Top + (e.Y - posy);
            }
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
