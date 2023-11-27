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
        FrmMDEncabezado encabezado;

        List<DetalleFactura> detalleFactura;
        List<DetalleServicio> detalleServicio;
        Factura factura;
        public FrmMDServicios(Factura factura)
        {
            InitializeComponent();

            this.factura = factura;
            this.detalleFactura = factura.DetalleFactura;
            this.detalleServicio = factura.DetalleServicio;
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
            cboServicio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboServicio.DisplayMember = "Nombre";
            cboServicio.ValueMember = "Id";
            cboServicio.SelectedIndex = 0;


            cboMedico.Items.Clear();
            string url2 = "https://localhost:7071/api/Medico";
            var result2 = await HelperHttp.GetInstance().GetAsync(url2);
            var lst2 = JsonConvert.DeserializeObject<List<Medico>>(result2.Data);


            foreach (Medico e in lst2)
            {
                cboMedico.Items.Add(e);
            }
            cboMedico.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMedico.DisplayMember = "Nombre";
            cboMedico.ValueMember = "Id";
            cboMedico.SelectedIndex = 0;

        }
        private async void AgregarServicio(Servicio servicio, Medico medico, int atencion, double precio)
        {
            if (MedicoServicioDuplicado(servicio, medico))
            {
                MessageBox.Show("Servicio y Medico ya ingresado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                detalleServicio.Add(new DetalleServicio()
                {
                    Medico = medico,
                    Servicio = servicio,
                    Atencion = atencion,
                    Precio = precio,
                });
            }
        }

        private bool MedicoServicioDuplicado(Servicio servicio, Medico medico)
        {
            bool ok = false;

            foreach (DetalleServicio det in factura.DetalleServicio)
            {
                if (det.Servicio.Id == servicio.Id && det.Medico.Id == medico.Id)
                {
                    ok = true;
                }
            }
            return ok;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir?", "Salir del Formulario", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Dispose();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            encabezado = new FrmMDEncabezado(factura);
            encabezado.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarServicio((Servicio)cboServicio.SelectedItem, (Medico)cboMedico.SelectedItem,
                Convert.ToInt32(nudAtencion.Value), Convert.ToDouble(nudPrecio.Value));
            ActualizarDgv();
            ActualizarTotal();
        }

        private void ActualizarTotal()
        {
            lblTotal.Text = factura.TotalServicios().ToString();
        }

        private void ActualizarDgv()
        {
            dgvDetalleServicio.Rows.Clear();
            foreach (DetalleServicio det in detalleServicio)
            {
                dgvDetalleServicio.Rows.Add(new object[]
                {
                    det.Servicio.ToString(),
                    det.Medico.ToString(),
                    det.Atencion.ToString(),
                    det.Precio.ToString(),
                    det.Precio + det.Atencion,
                    "Quitar"
                });
            }
        }

        private void dgvDetalleServicio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalleServicio.CurrentCell.ColumnIndex == 5)
            {
                factura.QuitarDetalleServicio(dgvDetalleServicio.CurrentRow.Index);
                dgvDetalleServicio.Rows.RemoveAt(dgvDetalleServicio.CurrentRow.Index);
                lblTotal.Text = factura.TotalServicios().ToString();
            }
        }
    }
}
