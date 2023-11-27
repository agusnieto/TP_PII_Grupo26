using FarmaciaBack.Datos.Dominio;
using FarmaciaBack.Datos.DTOs;
using FarmaciaBack.Servicio.Implementacion;
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
        FrmMDProductos formProd;

        List<DetalleServicio> detalleServicio;
        List<DetalleFactura> detalleFactura;

        Factura factura;

        public FrmMaestroDetalle()
        {
            factura = new Factura();
            detalleServicio = new List<DetalleServicio>();
            detalleFactura = new List<DetalleFactura>();
            factura.DetalleFactura = detalleFactura;
            factura.DetalleServicio = detalleServicio;

            InitializeComponent();
        }
        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            formProd = new FrmMDProductos(factura);
            formProd.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir?", "Salir del Formulario", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Dispose();
            }
        }

        private void FrmMaestroDetalle_Load(object sender, EventArgs e)
        {

        }
    }
}
