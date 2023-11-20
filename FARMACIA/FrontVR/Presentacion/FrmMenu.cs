using Farmacia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontVR
{
    public partial class FrmMenu : Form
    {
        int posx;
        int posy;
        public FrmMenu()
        {
            InitializeComponent();
            PersonalizarDis();
        }

        private void FrmPrincipalRain_Load(object sender, EventArgs e)
        {

        }
        private void PersonalizarDis()
        {
            PanelSubMenuFacturacion.Visible = false;
            PanelSubMenuObrasSociales.Visible = false;
            PanelSubMenuArticulos.Visible = false;
        }

        private void OcutarSubmenu()
        {
            if (PanelSubMenuFacturacion.Visible)
            {
                PanelSubMenuFacturacion.Visible = false;
            }
            if (PanelSubMenuObrasSociales.Visible)
            {
                PanelSubMenuObrasSociales.Visible = false;
            }
            if (PanelSubMenuArticulos.Visible)
            {
                PanelSubMenuArticulos.Visible = false;
            }
        }

        private void MostrarSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                OcutarSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private Form activeForm = null;
        private void AbrirFormulario(Form nuevo)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = nuevo;
                nuevo.TopLevel = false;
                nuevo.FormBorderStyle = FormBorderStyle.None;
                nuevo.Dock = DockStyle.Fill;
                PanelMostrar.Tag = nuevo;
                nuevo.BringToFront();
                nuevo.Show();

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PanelSubMenuFacturacion);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnNotaCredito_Click(object sender, EventArgs e)
        {
            //mostrar formulario

            OcutarSubmenu();
        }

        private void btnClientes_Click_1(object sender, EventArgs e)
        {
            //mostrar formulario

            OcutarSubmenu();
        }

        private void btnReintegros_Click(object sender, EventArgs e)
        {
            //mostrar formulario

            OcutarSubmenu();
        }


        private void PanelMostrar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnFacturacion_Click_1(object sender, EventArgs e)
        {
            //mostrar formulario

            //MostrarSubMenu(PanelSubMenuFacturacion);
        }

        private void btnObrasSociales_Click_1(object sender, EventArgs e)
        {
            //MostrarSubMenu(PanelSubMenuObrasSociales);
        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            //MostrarSubMenu(PanelSubMenuArticulos);
        }

        private void btnNuevaFactura_Click(object sender, EventArgs e)
        {
            // frmFactura nuevo = new frmFactura();
            //nuevo.ShowDialog();
            FrmDatosPersonales nuevo = new FrmDatosPersonales();
            nuevo.Show();


        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmMaestroDetalle nuevo = new FrmMaestroDetalle();
            nuevo.Show();
        }

        //-----------------------------------------------------------------------
        private void btnInventario_Click(object sender, EventArgs e)

        {

            MostrarSubMenu(PanelSubMenuArticulos);
        }

        private void btnFacturacion_Click_2(object sender, EventArgs e)
        {
            MostrarSubMenu(PanelSubMenuFacturacion);
        }

        private void btnObrasSociales_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PanelSubMenuObrasSociales);
        }

        private void btnArticulos_Click_1(object sender, EventArgs e)
        {
            MostrarSubMenu(PanelSubMenuArticulos);
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
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

        private void btnAMC_Click(object sender, EventArgs e)
        {
           FrmAbmc nuevo = new FrmAbmc();
            nuevo.Show();
        }

        private void PanelMostrar_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
