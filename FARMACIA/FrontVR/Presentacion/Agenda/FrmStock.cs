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

namespace FrontVR.Presentacion.Agenda
{
    public partial class FrmStock : Form
    {
        public FrmStock()
        {
            InitializeComponent();
        }

        private void FrmStock_Load(object sender, EventArgs e)
        {
            List<Producto> lista = ServicioDao.ObtenerServicio().ControlStock("%");

            foreach (Producto item in lista)
            {
                dgvProductos.Rows.Add(new object[]
                {
                    item.Id,
                    item.Nombre,
                    item.Descripcion, //Columna detalle
                    item.Proveedor.Nombre,
                    item.Pais.Nombre,
                    item.Stock,
                    item.Precio

                });
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            dgvProductos.Rows.Clear();

            string texto = txtNombre.Text;

            List<Producto> lista = ServicioDao.ObtenerServicio().ControlStock(texto);

            foreach (Producto item in lista)
            {
                dgvProductos.Rows.Add(new object[]
                {
                    item.Id,
                    item.Nombre,
                    item.Descripcion, //Columna detalle
                    item.Proveedor.Nombre,
                    item.Pais.Nombre,
                    item.Stock,
                    item.Precio

                });
            }
        }
    }
}
