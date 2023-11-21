using FarmaciaBack.Datos;
using FarmaciaBack.Datos.Dominio;
using FarmaciaBack.Datos.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontVR.Presentacion.MaestroDetalle
{
    public partial class FrmMDEncabezado : Form
    {
        Factura factura;
        public FrmMDEncabezado(Factura factura)
        {
            InitializeComponent();
            this.factura = factura;
        }

        private void FrmMDEncabezado_Load(object sender, EventArgs e)
        {
            ActualizarTotales();
            CargarCombos();
        }
        private void CargarCombos()
        {

        }
        public void ActualizarTotales()
        {
            lblTotalProductos.Text = factura.TotalProductos().ToString();
            lblTotalServicios.Text = factura.TotalServicios().ToString();
            lblTotal.Text = factura.Total().ToString();
        }

        private void cboEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarEmpleados(((Sede)cboSede.SelectedItem));
        }
        private void CargarEmpleados(Sede sede)
        {
            cboEmpleado.Enabled = true;
            cboEmpleado.Items.Clear();



            //                        SP DEL GET EMPLEADOS_X_SEDE
            //List<Empleado> empleados = empleadoDao.GetEmpoleadosPorSede(sede);
            //foreach (Empleado e in empleados)
            //{
            //    cboEmpleado.Items.Add(e);
            //}
        }
        public void ActualizarFactura()
        {
            factura.Sede = (Sede)cboSede.SelectedItem;
            factura.Empleado = (Empleado)cboEmpleado.SelectedItem;
            factura.Cliente = (Cliente)cboCliente.SelectedItem;
            factura.Envio = (FormaEnvio)cboEnvio.SelectedItem;
            factura.FormaPago = (FormaPago)cboPago.SelectedItem;
            
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {

        }
    }
}
