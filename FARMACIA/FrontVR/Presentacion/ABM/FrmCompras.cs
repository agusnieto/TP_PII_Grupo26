using FarmaciaBack.Datos.Dominio;
using FarmaciaBack.Datos;
using FarmaciaBack.Datos.DTOs;
using FarmaciaBack.Datos.Interfaz;
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
using FarmaciaBack.Servicio.Implementacion;
using System.Net;
using System.Reflection;

namespace FrontVR.Presentacion.ABM
{
    public partial class FrmCompras : Form
    {
        List<ProductoDTO> listaProducto;
        public FrmCompras()
        {
            InitializeComponent();
            listaProducto = new List<ProductoDTO>();
        }

        private void FrmContactos_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarLista();
            Habilitar(true);
        }

        private void Habilitar(bool v)
        {
            txtNombre.Enabled = !v;
            txtDescripcion.Enabled = !v;
            txtStock.Enabled = !v;
            txtPrecio.Enabled = !v;
            cboCaracteristica.Enabled = !v;
            cboMarca.Enabled = !v;
            cboPais.Enabled = !v;
            cboProveedor.Enabled = !v;
            cboTipoProducto.Enabled = !v;

            btnNuevo.Enabled = v;
            btnGrabar.Enabled = !v;
            btnSalir.Enabled = v;
            btnEditar.Enabled = !v;
            btnBorrar.Enabled = !v;
        }

        private async void CargarLista()
        {
            listaProducto.Clear();
            listBoxProductos.Items.Clear();
            string url = "https://localhost:7071/api/Producto";
            var result = await HelperHttp.GetInstance().GetAsync(url);
            listaProducto = JsonConvert.DeserializeObject<List<ProductoDTO>>(result.Data);

            listBoxProductos.Items.AddRange(listaProducto.ToArray());
        }

        private async void CargarCombos()
        {
            cboCaracteristica.Items.Clear();
            string url = "https://localhost:7071/api/Producto/Caracteristicas";
            var result = await HelperHttp.GetInstance().GetAsync(url);
            List<Caracteristica> lst = JsonConvert.DeserializeObject<List<Caracteristica>>(result.Data);
            cboCaracteristica.DataSource = lst;
            cboCaracteristica.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCaracteristica.DisplayMember = "Tipo";
            cboCaracteristica.ValueMember = "Id";
            cboCaracteristica.SelectedIndex = 0;

            cboTipoProducto.Items.Clear();
            string url2 = "https://localhost:7071/api/Producto/TiposProducto";
            var result2 = await HelperHttp.GetInstance().GetAsync(url2);
            List<TipoProducto> lst2 = JsonConvert.DeserializeObject<List<TipoProducto>>(result2.Data);
            cboTipoProducto.DataSource = lst2;
            cboTipoProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoProducto.DisplayMember = "Tipo";
            cboTipoProducto.ValueMember = "Id";
            cboTipoProducto.SelectedIndex = 0;

            cboMarca.Items.Clear();
            string url3 = "https://localhost:7071/api/Producto/Marcas";
            var result3 = await HelperHttp.GetInstance().GetAsync(url3);
            List<Marca> lst3 = JsonConvert.DeserializeObject<List<Marca>>(result3.Data);
            cboMarca.DataSource = lst3;
            cboMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMarca.DisplayMember = "Nombre";
            cboMarca.ValueMember = "Id";
            cboMarca.SelectedIndex = 0;

            cboProveedor.Items.Clear();
            string url4 = "https://localhost:7071/api/Producto/Proveedores";
            var result4 = await HelperHttp.GetInstance().GetAsync(url4);
            List<Proveedor> lst4 = JsonConvert.DeserializeObject<List<Proveedor>>(result4.Data);
            cboProveedor.DataSource = lst4;
            cboProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProveedor.DisplayMember = "Nombre";
            cboProveedor.ValueMember = "Id";
            cboProveedor.SelectedIndex = 0;


            cboPais.Items.Clear();
            string url5 = "https://localhost:7071/api/Producto/Paises";
            var result5 = await HelperHttp.GetInstance().GetAsync(url5);
            List<Pais> lst5 = JsonConvert.DeserializeObject<List<Pais>>(result5.Data);
            cboPais.DataSource = lst5;
            cboPais.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPais.DisplayMember = "Nombre";
            cboPais.ValueMember = "Id";
            cboPais.SelectedIndex = 0;
        }

        private void LimpiarCampos()
        {
            foreach (Control control in this.gbDatos.Controls)
            {
                if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
                if (control is TextBox)
                {
                    control.Text = String.Empty;
                }
            }
        }

        private void listBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = listBoxProductos.SelectedIndex;
            if (selected != -1)
            {
                ProductoDTO producto = listaProducto[selected];
                txtNombre.Text = producto.Nombre.ToString();
                txtDescripcion.Text = producto.Descripcion;
                txtStock.Text = producto.Stock.ToString();
                txtPrecio.Text = producto.Precio.ToString();
                cboCaracteristica.SelectedValue = producto.Caracteristica;
                cboTipoProducto.SelectedValue = producto.TipoProd;
                cboMarca.SelectedValue = producto.Marca;
                cboPais.SelectedValue = producto.Pais;
                cboProveedor.SelectedValue = producto.Proveedor;

                //cargar campos 
                txtNombre.Text = listaProducto[selected].Nombre;
                txtStock.Text = listaProducto[selected].Stock.ToString();
                txtPrecio.Text = listaProducto[selected].Precio.ToString();
                txtDescripcion.Text = listaProducto[selected].Descripcion.ToString();

                cboCaracteristica.SelectedValue = listaProducto[selected].Caracteristica;
                cboMarca.SelectedValue = listaProducto[selected].Marca;
                cboPais.SelectedValue = listaProducto[selected].Pais;
                cboProveedor.SelectedValue = listaProducto[selected].Proveedor;
                cboTipoProducto.SelectedValue = listaProducto[selected].TipoProd;

                btnEditar.Enabled = true;
                btnBorrar.Enabled = true;
            }
        }
        private async void btnGrabar_Click(object sender, EventArgs e)
        {
            int index = listBoxProductos.SelectedIndex;
            //validacion de los datos
            if (ValidarDatos())
            {

                //crear objeto
                ProductoDTO producto = new ProductoDTO();
                producto.Id = listaProducto[index].Id;
                producto.Nombre = txtNombre.Text;
                producto.Stock = Convert.ToInt32(txtStock.Text);
                producto.Precio = Convert.ToDouble(txtPrecio.Text);
                producto.Descripcion = txtDescripcion.Text;

                producto.TipoProd = Convert.ToInt32(cboTipoProducto.SelectedValue);
                producto.Caracteristica = Convert.ToInt32(cboCaracteristica.SelectedValue);
                producto.Proveedor = Convert.ToInt32(cboProveedor.SelectedValue);
                producto.Pais = Convert.ToInt32(cboPais.SelectedValue);
                producto.Marca = Convert.ToInt32(cboMarca.SelectedValue);

                string body = JsonConvert.SerializeObject(producto);
                string url = "https://localhost:7071/api/Producto";
                if (btnGrabar.Text == "Confirmar")
                {
                    var result = await HelperHttp.GetInstance().PutAsync(url, body);
                    if (result.StatusCode == HttpStatusCode.OK)
                    {
                        MessageBox.Show("Producto actualizado exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        Habilitar(true);
                        LimpiarCampos();
                        CargarLista();
                        btnSalir.Text = "Salir";
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el producto!", "Eroor", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    var result = await HelperHttp.GetInstance().PostAsync(url, body);
                    if (result.StatusCode == HttpStatusCode.OK)
                    {
                        MessageBox.Show("Producto cargado exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        Habilitar(true);
                        LimpiarCampos();
                        CargarLista();
                        btnSalir.Text = "Salir";
                    }
                    else
                    {
                        MessageBox.Show("No se podido cargar el producto!", "Eroor", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }
        }


        private bool ValidarDatos()
        {
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un nombre...");
                txtNombre.Focus();
                return false;
            }
            if (txtDescripcion.Text == string.Empty)
            {
                MessageBox.Show("Ingrese una descripcion...");
                txtDescripcion.Focus();
                return false;
            }
            if (txtPrecio.Text == string.Empty)
            {
                MessageBox.Show("Ingrese una precio...");
                txtPrecio.Focus();
                return false;
            }
            if (txtStock.Text == string.Empty)
            {
                MessageBox.Show("Ingrese una descripcion...");
                txtStock.Focus();
                return false;
            }
            if (cboCaracteristica.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una caracteristica...");
                cboCaracteristica.Focus();
                return false;
            }
            if (cboMarca.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una marca...");
                cboMarca.Focus();
                return false;
            }
            if (cboPais.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un pais...");
                cboPais.Focus();
                return false;
            }
            if (cboProveedor.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un proveedor...");
                cboProveedor.Focus();
                return false;
            }
            if (cboTipoProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de producto...");
                cboTipoProducto.Focus();
                return false;
            }
            return true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Habilitar(false);
            btnBorrar.Enabled = false;
            btnEditar.Enabled = false;
            LimpiarCampos();
            btnSalir.Text = "Cancelar";



        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            Habilitar(false);
            btnBorrar.Enabled = false;
            btnEditar.Enabled = false;
            btnSalir.Text = "Cancelar";
            btnSalir.Enabled = true;
            btnGrabar.Text = "Confirmar";

        }

        private async void btnBorrar_Click(object sender, EventArgs e)//PROGRAMAR CON URL
        {
            int index = listBoxProductos.SelectedIndex;
            if (MessageBox.Show("Seguro que desea borrar el producto seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string urlProducto = "https://localhost:7071/api/Producto/";
                string urlConParametro = $"{urlProducto}{listaProducto[index].Id}";
                var result = await HelperHttp.GetInstance().DeleteAsync(urlConParametro);

                if (result.StatusCode == HttpStatusCode.OK)
                {
                    MessageBox.Show("El Producto fue eliminado!", "Informacion");
                    Habilitar(true);
                    LimpiarCampos();
                    CargarLista();
                }
                else
                {
                    MessageBox.Show("No se pudo borrar el Producto seleccionado!", "Error");
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (btnSalir.Text == "Salir")
            {
                if (MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                btnSalir.Text = "Salir";
                LimpiarCampos();
                CargarLista();
                Habilitar(true);
            }
        }
    }
}
