using FarmaciaBack.Datos;
using FarmaciaBack.Datos.Dominio;
using FarmaciaBack.Datos.DTOs;
using FarmaciaBack.Servicio.Implementacion;
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
    public partial class FrmMDServicios : Form
    {
        List<DetalleServicio> detalleServicios;
        Factura factura = new Factura();

        public FrmMDServicios(Factura factura)
        {
            InitializeComponent();
            this.factura = factura;
            this.detalleServicios = factura.DetalleServicio;
        }

        private async void FrmMDServicios_Load(object sender, EventArgs e)
        {
            CargarCombosAsync();
        }
        private async void CargarCombosAsync()
        {
            cboServicio.Items.Clear();
            string url = "https://localhost:7071/api/Factura/ServicioDTO";
            var result = await HelperHttp.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Servicio>>(result.Data);

            cboServicio.DataSource = lst;
            cboServicio.DisplayMember = "Nombre";
            cboServicio.ValueMember = "Id";
            cboServicio.SelectedIndex = 0;


            cboMedico.Items.Clear();
            string url2 = "https://localhost:7071/api/Medico/MedicoDTO";
            var result2 = await HelperHttp.GetInstance().GetAsync(url2);
            var lst2 = JsonConvert.DeserializeObject<List<MedicoDTO>>(result2.Data);

            cboServicio.DataSource = lst2;
            cboServicio.DisplayMember = "Nombre";
            cboServicio.ValueMember = "Id";
            cboMedico.SelectedIndex = 0;

        }
    }
}
