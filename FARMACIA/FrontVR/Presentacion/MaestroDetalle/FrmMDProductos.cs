using FarmaciaBack.Datos;
using FarmaciaBack.Datos.Dominio;
using FarmaciaBack.Datos.DTOs;
using FarmaciaBack.Datos.Implementacion;
using FarmaciaBack.Datos.Interfaz;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontVR.Presentacion.MaestroDetalle
{
    public partial class FrmMDProductos : Form
    {
        FrmMDServicios servicios;

        List<DetalleFactura> detalleFactura;
        List<DetalleServicio> detalleServicio;
        Factura factura;
        public FrmMDProductos(Factura factura)
        {
            InitializeComponent();
            this.factura = factura;
            this.detalleFactura = factura.DetalleFactura;
            this.detalleServicio = factura.DetalleServicio;
        }

        private async void AgregarProducto(int codigo)
        {
            string url = "https://localhost:7071/api/Factura/Productos?id="; // Asegúrate de tener el separador correcto

            string urlExitosa = $"{url}{codigo}";
            var result = await HelperHttp.GetInstance().GetAsync(urlExitosa);
            Producto prod = JsonConvert.DeserializeObject<Producto>(result.Data);

            if (prod != null)
            {
                CargarDetalle(prod);
                ActualizarDgv();
                ActualizarTotal();
            }
        }

        private void ActualizarTotal()
        {
            lblTotal.Text = factura.TotalProductos().ToString();
        }
        private void ActualizarDgv()
        {
            dgvProductos.Rows.Clear();
            foreach (DetalleFactura det in factura.DetalleFactura)
            {
                dgvProductos.Rows.Add(new object[] {

                    det.Producto.Id,
                    det.Producto.TipoProducto.Tipo,
                    det.Producto.Nombre,
                    det.Producto.Precio,

                    det.Cantidad,

                    det.Precio = det.Producto.Precio * det.Cantidad,
                    "Quitar"
                    });
            }
        }
        private void CargarDetalle(Producto prod)
        {
            bool existe = false;
            if (prod != null)
            {
                foreach (DetalleFactura det in factura.DetalleFactura)
                {
                    if (prod.Id == det.Producto.Id)
                    {
                        det.Cantidad++;
                        existe = true;
                    }
                }

                if (!existe)
                {
                    factura.DetalleFactura.Add(new DetalleFactura()
                    {
                        Producto = prod,
                        Cantidad = Convert.ToInt32(nudCantidad.Value),
                        Precio = prod.Precio
                    });
                }
            }
        }
        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.CurrentCell.ColumnIndex == 6)
            {
                factura.QuitarDetalleFactura(dgvProductos.CurrentRow.Index);
                dgvProductos.Rows.RemoveAt(dgvProductos.CurrentRow.Index);
                lblTotal.Text = factura.TotalProductos().ToString();
            }
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
            servicios = new FrmMDServicios(factura);
            servicios.ShowDialog();
        }

        private void FrmMDProductos_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { 
            AgregarProducto(Convert.ToInt32(nudCodigo.Value));
            nudCodigo.Value = 1;
            ActualizarDgv();
            
        }
    }
}
