using FarmaciaBack.Datos.Dominio;
using FrontVR.Presentacion.MaestroDetalle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class FrmMaestroDetalle : Form
    {
        int stepActual = 0;
        List<Form> steps;
        FrmMDProductos formProd;
        FrmMDServicios formServ;
        FrmMDEncabezado formEncabezado;

        List<DetalleServicio> detalleServicio;
        List<DetalleFactura> detalleFactura;

        Factura factura;

        //FacturaDAO facturaDAO;
        public FrmMaestroDetalle()
        {
            //facturaDAO = new FacturaDAO();

            detalleServicio = new List<DetalleServicio>();
            detalleFactura = new List<DetalleFactura>();
            this.factura = new Factura();
            factura.DetalleFactura = detalleFactura;
            factura.DetalleServicio = detalleServicio;

            InitializeComponent();

            formProd = new FrmMDProductos(factura);
            formProd.TopLevel = false;
            formProd.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(formProd);
            formProd.Location = new Point(40, 80);

            formServ = new FrmMDServicios(factura);
            formServ.TopLevel = false;
            formServ.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(formServ);
            formServ.Location = new Point(40, 80);

            formEncabezado = new FrmMDEncabezado(factura);
            formEncabezado.TopLevel = false;
            formEncabezado.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(formEncabezado);
            formEncabezado.Location = new Point(40, 80);

            steps = new List<Form>();
            steps.Add(formProd);
            steps.Add(formServ);
            steps.Add(formEncabezado);
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            btnCancelar.Enabled = true;


            if (stepActual == 2)
            {
                FinalizarCompra();
                formEncabezado.Hide();
                factura = new Factura();
                stepActual = 0;
                detalleServicio = new List<DetalleServicio>();
                detalleFactura = new List<DetalleFactura>();
                this.factura = new Factura();
                factura.DetalleFactura = detalleFactura;
                factura.DetalleServicio = detalleServicio;


                InitializeComponent();

                formProd = new FrmMDProductos(factura);
                formProd.TopLevel = false;
                formProd.FormBorderStyle = FormBorderStyle.None;
                this.Controls.Add(formProd);
                formProd.Location = new Point(40, 80);



                formServ = new FrmMDServicios(factura);
                formServ.TopLevel = false;
                formServ.FormBorderStyle = FormBorderStyle.None;
                this.Controls.Add(formServ);
                formServ.Location = new Point(40, 80);


                formEncabezado = new FrmMDEncabezado(factura);
                formEncabezado.TopLevel = false;
                formEncabezado.FormBorderStyle = FormBorderStyle.None;
                this.Controls.Add(formEncabezado);
                formEncabezado.Location = new Point(40, 80);

                steps.Clear();
                steps.Add(formProd);
                steps.Add(formServ);
                steps.Add(formEncabezado);
                steps[stepActual].Show();
                btnCancelar.Enabled = false;

            }
            else
            {
                steps[stepActual].Hide();
                stepActual++;
                steps[stepActual].Show();

                formEncabezado.ActualizarTotales();

                if (stepActual == 2) { btnSiguiente.Text = "Finalizar"; };
            }
        }
        private void FinalizarCompra()
        {
            formEncabezado.ActualizarFactura();
            int nroFactura = 0;//facturaDao.CrearFactura(factura); *********************
            if (nroFactura == -1)
            {
                MessageBox.Show("Ha ocurrido un error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Factura {nroFactura} creada con éxito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
