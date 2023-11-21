
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
using System.Security.Policy;
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
        private async void CargarCombos()
        {
            cboCliente.Items.Clear();
            string url = "https://localhost:7071/api/Factura/ClientesDTO";
            var result = await HelperHttp.GetInstance().GetAsync(url);
            List<ClienteDTO> lst = JsonConvert.DeserializeObject<List<ClienteDTO>>(result.Data);
            cboCliente.DataSource = lst;
            cboCliente.DisplayMember = "NombreCompleto";
            cboCliente.ValueMember = "IdCliente";
            cboCliente.SelectedIndex = 0;

            cboEmpleado.Items.Clear();
            string url2 = "https://localhost:7071/api/Factura/EmpleadosDTO";
            var result2 = await HelperHttp.GetInstance().GetAsync(url2);
            List<EmpleadoDTO> lst2 = JsonConvert.DeserializeObject<List<EmpleadoDTO>>(result2.Data);
            cboEmpleado.DataSource = lst2;
            cboEmpleado.DisplayMember = "NombreCompleto";
            cboEmpleado.ValueMember = "Id";
            cboEmpleado.SelectedIndex = 0;

            cboEnvio.Items.Clear();
            string url3 = "https://localhost:7071/api/Factura/Envios";
            var result3 = await HelperHttp.GetInstance().GetAsync(url3);
            List<FormaEnvio> lst3 = JsonConvert.DeserializeObject<List<FormaEnvio>>(result3.Data);
            cboEnvio.DataSource = lst3;
            cboEnvio.DisplayMember = "Forma";
            cboEnvio.ValueMember = "Id";
            cboEnvio.SelectedIndex = 0;

            cboPago.Items.Clear();
            string url4 = "https://localhost:7071/api/Factura/Pagos";
            var result4 = await HelperHttp.GetInstance().GetAsync(url4);
            List<FormaPago> lst4 = JsonConvert.DeserializeObject<List<FormaPago>>(result4.Data);
            cboPago.DataSource = lst4;
            cboPago.DisplayMember = "Forma";
            cboPago.ValueMember = "Id";
            cboPago.SelectedIndex = 0;


            cboSede.Items.Clear();
            string url5 = "https://localhost:7071/api/Factura/Sedes";
            var result5 = await HelperHttp.GetInstance().GetAsync(url5);
            List<Sede> lst5 = JsonConvert.DeserializeObject<List<Sede>>(result5.Data);
            cboSede.DataSource = lst5;
            cboSede.DisplayMember = "Nombre";
            cboSede.ValueMember = "Id";
            cboSede.SelectedIndex = 0;

        }
        public void ActualizarTotales()
        {
            lblTotalProductos.Text = factura.TotalProductos().ToString();
            lblTotalServicios.Text = factura.TotalServicios().ToString();
            lblTotal.Text = factura.Total().ToString();
        }

        private void cboEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private async void CargarEmpleados(Sede sede)
        {
            cboEmpleado.Enabled = true;
            cboEmpleado.Items.Clear();

            string url = "https://localhost:7071/api/Factura/EmpleadosDTO";
            var result = await HelperHttp.GetInstance().GetAsync(url);
            List<EmpleadoDTO> lst = JsonConvert.DeserializeObject<List<EmpleadoDTO>>(result.Data);

            foreach (EmpleadoDTO e in lst)
            {
                cboEmpleado.Items.Add(e);
            }
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

        private void cboSede_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboEmpleado.Items.Clear();
            CargarEmpleados(((Sede)cboSede.SelectedItem));
        }
    }
}
