
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
            string url = "http://localhost:5031/ClientesDTO";
            var result = await HelperHttp.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<ClienteDTO>>(result.Data);
            cboCliente.DataSource = lst;
            cboCliente.DisplayMember = "NombreCompleto";
            cboCliente.ValueMember = "IdCliente";
            cboCliente.SelectedIndex = 0;

            cboEmpleado.Items.Clear();
            string url2 = "http://localhost:5031/EmpleadosDTO";
            var result2 = await HelperHttp.GetInstance().GetAsync(url2);
            var lst2 = JsonConvert.DeserializeObject<List<EmpleadoDTO>>(result.Data);
            cboEmpleado.DataSource = lst;
            cboEmpleado.DisplayMember = "NombreCompleto";
            cboEmpleado.ValueMember = "Id";
            cboEmpleado.SelectedIndex = 0;

            cboEnvio.Items.Clear();
            string url3 = "http://localhost:5031/FormaEnvio";
            var result3 = await HelperHttp.GetInstance().GetAsync(url3);
            var lst3 = JsonConvert.DeserializeObject<List<FormaEnvio>>(result.Data);
            cboEnvio.DataSource = lst;
            cboEnvio.DisplayMember = "Forma";
            cboEnvio.ValueMember = "Id";
            cboEnvio.SelectedIndex = 0;

            cboPago.Items.Clear();
            string url4 = "http://localhost:5031/FormaPago";
            var result4 = await HelperHttp.GetInstance().GetAsync(url4);
            var lst4 = JsonConvert.DeserializeObject<List<FormaEnvio>>(result.Data);
            cboPago.DataSource = lst;
            cboPago.DisplayMember = "Forma";
            cboPago.ValueMember = "Id";
            cboPago.SelectedIndex = 0;


            cboSede.Items.Clear();
            string url5 = "http://localhost:5031/Sede";
            var result5 = await HelperHttp.GetInstance().GetAsync(url5);
            var lst5 = JsonConvert.DeserializeObject<List<FormaEnvio>>(result.Data);
            cboSede.DataSource = lst;
            cboSede.DisplayMember = "Forma";
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
            CargarEmpleados(((Sede)cboSede.SelectedItem));
        }
        private async void CargarEmpleados(Sede sede)
        {
            cboEmpleado.Enabled = true;
            cboEmpleado.Items.Clear();

            string url = "http://localhost:5031/EmpleadoDTO";
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
    }
}
