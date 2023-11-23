using FarmaciaBack.Datos;
using FarmaciaBack.Datos.Dominio;
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
        List<DetalleFactura> detalleFactura;
        Factura factura;
        public FrmMDProductos(Factura factura)
        {
            InitializeComponent();
            this.factura = factura;
            this.detalleFactura = factura.DetalleFactura;
        }

        public FrmMDProductos()
        {
            InitializeComponent();
            factura = new Factura();
            detalleFactura = new List<DetalleFactura>(); // Inicializar como una nueva lista vacía
        }

        private async void AgregarProducto(string codigo)
        {
            string url = "https://localhost:7071/api/Factura/Productos?id=5&codigo="; // Asegúrate de tener el separador correcto

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
            foreach (DetalleFactura det in detalleFactura)
            {
                dgvProductos.Rows.Add(new object[] {

                    det.Producto.Id,
                    det.Producto.TipoProducto.Tipo,
                    det.Producto.Nombre,
                    det.Producto.Precio,

                    det.Cantidad,

                    det.Precio = det.Producto.Precio * det.Cantidad

                    });
            }
        }
        private void CargarDetalle(Producto prod)
        {
            bool existe = false;
            if (prod != null)
            {
                foreach (DetalleFactura det in detalleFactura)
                {
                    if (prod.Id == det.Producto.Id)
                    {
                        det.Cantidad++;
                        existe = true;
                    }
                }

                if (!existe)
                {
                    detalleFactura.Add(new DetalleFactura()
                    {
                        Producto = prod,
                        Cantidad = 1,
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
            FrmMDServicios nuevo = new FrmMDServicios();
            nuevo.Show();
        }

        private void FrmMDProductos_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != String.Empty)
            {
                AgregarProducto(txtCodigo.Text);
                txtCodigo.Text = String.Empty;
                ActualizarDgv();
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
          
        }
    }
}
