﻿using FarmaciaBack.Datos.Dominio;
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

        private void CargarLista()
        {
            listaProducto.Clear();
            listBoxProductos.Items.Clear();
            listaProducto = ServicioDao.ObtenerServicio().ListarProducto();
            listBoxProductos.Items.AddRange(listaProducto.ToArray());
        }

        private async void CargarCombos()
        {
            cboCaracteristica.Items.Clear();
            string url = "https://localhost:7071/api/Producto/Caracteristicas";
            var result = await HelperHttp.GetInstance().GetAsync(url);
            List<Caracteristica> lst = JsonConvert.DeserializeObject<List<Caracteristica>>(result.Data);
            cboCaracteristica.DataSource = lst;
            cboCaracteristica.DisplayMember = "Tipo";
            cboCaracteristica.ValueMember = "Id";
            cboCaracteristica.SelectedIndex = 0;

            cboTipoProducto.Items.Clear();
            string url2 = "https://localhost:7071/api/Producto/TiposProducto";
            var result2 = await HelperHttp.GetInstance().GetAsync(url2);
            List<TipoProducto> lst2 = JsonConvert.DeserializeObject<List<TipoProducto>>(result2.Data);
            cboTipoProducto.DataSource = lst2;
            cboTipoProducto.DisplayMember = "Tipo";
            cboTipoProducto.ValueMember = "Id";
            cboTipoProducto.SelectedIndex = 0;

            cboMarca.Items.Clear();
            string url3 = "https://localhost:7071/api/Factura/Envios";
            var result3 = await HelperHttp.GetInstance().GetAsync(url3);
            List<Marca> lst3 = JsonConvert.DeserializeObject<List<Marca>>(result3.Data);
            cboMarca.DataSource = lst3;
            cboMarca.DisplayMember = "Nombre";
            cboMarca.ValueMember = "Id";
            cboMarca.SelectedIndex = 0;

            cboProveedor.Items.Clear();
            string url4 = "https://localhost:7071/api/Producto/Proveedores";
            var result4 = await HelperHttp.GetInstance().GetAsync(url4);
            List<Proveedor> lst4 = JsonConvert.DeserializeObject<List<Proveedor>>(result4.Data);
            cboProveedor.DataSource = lst4;
            cboProveedor.DisplayMember = "Nombre";
            cboProveedor.ValueMember = "Id";
            cboProveedor.SelectedIndex = 0;


            cboPais.Items.Clear();
            string url5 = "https://localhost:7071/api/Producto/Paises";
            var result5 = await HelperHttp.GetInstance().GetAsync(url5);
            List<Pais> lst5 = JsonConvert.DeserializeObject<List<Pais>>(result5.Data);
            cboPais.DataSource = lst5;
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
                cboTipoProducto.SelectedValue = producto.TipoProducto;
                cboMarca.SelectedValue = producto.Marca;
                cboPais.SelectedValue = producto.Pais;
                cboProveedor.SelectedValue = producto.Proveedor;


                btnEditar.Enabled = true;
                btnBorrar.Enabled = true;
            }
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //validacion de los datos
            if (ValidarDatos())
            {
                //crear objeto
                Producto producto = new Producto();
                producto.Nombre = txtNombre.Text;
                producto.Nombre = txtNombre.Text;
                producto.Stock = Convert.ToInt32(txtNombre.Text);
                producto.Precio = Convert.ToDouble(txtPrecio.Text);
                producto.TipoProducto.Id = (int)cboTipoProducto.SelectedValue;
                producto.TipoProducto.Tipo = (string)cboTipoProducto.ValueMember;
                producto.Caracteristica.Id = (int)cboCaracteristica.SelectedValue;
                producto.Caracteristica.Tipo = (string)cboCaracteristica.ValueMember;
                producto.Marca.Id = (int)cboMarca.SelectedValue;
                producto.Marca.Nombre = (string)cboMarca.ValueMember;
                producto.Proveedor.Id = (int)cboProveedor.SelectedValue;
                producto.Proveedor.Nombre = (string)cboProveedor.ValueMember;
                producto.Pais.Id = (int)cboPais.SelectedValue;
                producto.Pais.Nombre = (string)cboPais.ValueMember;

                if (ServicioDao.ObtenerServicio().CargarProducto(producto))
                {
                    MessageBox.Show("Se ha grabado exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Habilitar(true);
                LimpiarCampos();
                CargarLista();
                btnSalir.Text = "Salir";
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Habilitar(false);
            btnBorrar.Enabled = false;
            btnEditar.Enabled = false;
            btnSalir.Text = "Cancelar";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int index = listBoxProductos.SelectedIndex;
            if (MessageBox.Show("Seguro que desea borrar el producto seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ServicioDao.ObtenerServicio().EliminarProducto(listaProducto[index].Id))
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