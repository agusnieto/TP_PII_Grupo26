
using FarmaciaBack.Datos;
using FarmaciaBack.Datos.Dominio;
using FarmaciaBack.Datos.DTOs;
using FarmaciaBack.Datos.Implementacion;
using FarmaciaBack.Servicio.Implementacion;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
            cboEmpleado.Enabled = false;
        }
        private async void CargarCombos()
        {
            cboSede.Items.Clear();
            string url5 = "https://localhost:7071/api/Factura/Sedes";
            var result5 = await HelperHttp.GetInstance().GetAsync(url5);
            List<Sede> lst5 = JsonConvert.DeserializeObject<List<Sede>>(result5.Data);
            cboSede.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSede.DataSource = lst5;
            cboSede.DisplayMember = "Nombre";
            cboSede.ValueMember = "Id";
            cboSede.SelectedIndex = 0;

            cboCliente.Items.Clear();
            string url = "https://localhost:7071/api/Factura/ClientesDTO";
            var result = await HelperHttp.GetInstance().GetAsync(url);
            List<ClienteDTO> lst = JsonConvert.DeserializeObject<List<ClienteDTO>>(result.Data);
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.DataSource = lst;
            cboCliente.DisplayMember = "NombreCompleto";
            cboCliente.ValueMember = "IdCliente";
            cboCliente.SelectedIndex = 0;

            cboEnvio.Items.Clear();
            string url3 = "https://localhost:7071/api/Factura/Envios";
            var result3 = await HelperHttp.GetInstance().GetAsync(url3);
            List<FormaEnvio> lst3 = JsonConvert.DeserializeObject<List<FormaEnvio>>(result3.Data);
            cboEnvio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEnvio.DataSource = lst3;
            cboEnvio.DisplayMember = "Forma";
            cboEnvio.ValueMember = "Id";
            cboEnvio.SelectedIndex = 0;

            cboPago.Items.Clear();
            string url4 = "https://localhost:7071/api/Factura/Pagos";
            var result4 = await HelperHttp.GetInstance().GetAsync(url4);
            List<FormaPago> lst4 = JsonConvert.DeserializeObject<List<FormaPago>>(result4.Data);
            cboPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPago.DataSource = lst4;
            cboPago.DisplayMember = "Forma";
            cboPago.ValueMember = "Id";
            cboPago.SelectedIndex = 0;
        }
        public void ActualizarTotales()
        {

            lblTotalProductos.Text = factura.TotalProductos().ToString();
            lblTotalServicios.Text = factura.TotalServicios().ToString();
            lblTotal.Text = factura.Total().ToString();
        }
        private async void CargarEmpleados(Sede sede)
        {
            cboEmpleado.Enabled = true;
            cboEmpleado.Items.Clear();

            /*string url = "https://localhost:7071/api/Factura/EmpleadosDTO";
            var resultado = await HelperHttp.GetInstance().GetAsync($"{url}{sede.Id}");
            List<EmpleadoDTO> listaEmpleados = JsonConvert.DeserializeObject<List<EmpleadoDTO>>(resultado.Data);*/

            List<EmpleadoDTO> listaEmpleados = ServicioDao.ObtenerServicio().ConsultarEmpleadosXSede(sede.Id);

            foreach (EmpleadoDTO e in listaEmpleados)
            {
                cboEmpleado.Items.Add(e);
            }
            cboEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        public void ActualizarFactura()
        {
            factura.Sede = (Sede)cboSede.SelectedItem;
            factura.Empleado = (EmpleadoDTO)cboEmpleado.SelectedItem;
            factura.Cliente = (ClienteDTO)cboCliente.SelectedItem;
            factura.Envio = (FormaEnvio)cboEnvio.SelectedItem;
            factura.FormaPago = (FormaPago)cboPago.SelectedItem;

        }
        private void cboSede_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboEmpleado.Items.Clear();
            CargarEmpleados(((Sede)cboSede.SelectedItem));
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            FinalizarCompra();
        }


        private async void FinalizarCompra()
        {
            ActualizarFactura();
            string body = JsonConvert.SerializeObject(factura);
            string url = "https://localhost:7071/api/Factura";
            var result = await HelperHttp.GetInstance().PostAsync(url, body);
            //bool aux = ServicioDao.ObtenerServicio().CargarFactura(factura); //hacerlo con api
            if (result.StatusCode == HttpStatusCode.OK)
            {
                MessageBox.Show("Ha ocurrido un error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Factura {factura.NroFactura} creada con éxito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
