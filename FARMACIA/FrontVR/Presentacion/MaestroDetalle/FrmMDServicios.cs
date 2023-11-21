using FarmaciaBack.Datos.Dominio;
using FarmaciaBack.Servicio.Implementacion;
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
        //IServicioDAO servicioDAO;
        //IMedicoDao medicoDao;
        List<DetalleServicio> detalleServicios;
        Factura factura = new Factura();

        public FrmMDServicios(Factura factura)
        {
            InitializeComponent();
            //servicio dao inicializ / medicodao
            this.factura = factura;
            this.detalleServicios = factura.DetalleServicio;
        }

        private void FrmMDServicios_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }
        private void CargarCombos()
        {
            cboServicio.Items.Clear();
            //List<Servicio> servicios = servicioDao.ObtenerServicios();
            //foreach (Servicio servicio in servicios)
            //{
            //    cboServicio.Items.Add(servicio);
            //}
            cboServicio.SelectedIndex = 0;


            cboMedico.Items.Clear();
            //List<Medico> medicos = medicoDAO.ObtenerMedicos();
            //foreach (Medico medico in medicos)
            //{
            //    cboMedico.Items.Add(medico);
            //}
            cboMedico.SelectedIndex = 0;

        }
    }
}
