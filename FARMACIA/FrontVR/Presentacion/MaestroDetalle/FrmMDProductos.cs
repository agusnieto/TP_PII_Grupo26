using FarmaciaBack.Datos.Dominio;
using FarmaciaBack.Datos.Implementacion;
using FarmaciaBack.Datos.Interfaz;
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
    public partial class FrmMDProductos : Form
    {
        List<DetalleFactura> detalleFactura;
        Factura factura;
        IProductoDao productoDAO;
        public FrmMDProductos(Factura factura)
        {
            InitializeComponent();
            this.factura = factura;
            this.detalleFactura = factura.DetalleFactura;
            productoDAO = new ProductoDao();
        }
        private void AgregarProducto(string codigo)
        {
            Producto prod = productoDAO.GetProducto(Convert.ToInt32(codigo));

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

                    det.Product.Id,
                    det.Product.TipoProducto.Tipo,
                    det.Product.Nombre,
                    det.Product.Precio,

                    det.Cantidad,

                    det.Precio = det.Product.Precio * det.Cantidad

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
                    if (prod.Id == det.Product.Id)
                    {
                        det.Cantidad++;
                        existe = true;
                    }
                }

                if (!existe)
                {
                    detalleFactura.Add(new DetalleFactura()
                    {
                        Product = prod,
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
    }
}
