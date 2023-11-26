using FarmaciaBack.Datos.Dominio;
using FarmaciaBack.Datos;
using FarmaciaBack.Datos.DTOs;
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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace FrontVR.Presentacion.ABM
{
    public partial class FrmContactos : Form
    {
        List<Cliente> listaClientes;
        List<Empleado> listaEmpleados;
        List<Proveedor> listaProveedores;
        List<Medico> listaMedicos;
        public FrmContactos()
        {
            InitializeComponent();
            listaClientes = new List<Cliente>();
            listaEmpleados = new List<Empleado>();
            listaProveedores = new List<Proveedor>();
            listaMedicos = new List<Medico>();
        }

        private void FrmContactos_Load(object sender, EventArgs e)
        {
            Bloquear(true);
            LimpiarPantalla();
        }

        private void LimpiarPantalla()
        {
            //limpiar la listbox
            lstContactos.Items.Clear();

            //locacion de ventanas
            gbCliente.Location = new System.Drawing.Point(595, 153);
            gbEmpleado.Location = new System.Drawing.Point(595, 17);
            gbMedico.Location = new System.Drawing.Point(846, 18);
            gbProveedor.Location = new System.Drawing.Point(846, 163);

            //limpiar controles
            foreach (Control control in this.gbDatos.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = String.Empty;
                }
            }
            foreach (Control control in this.gbCliente.Controls)
            {
                if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
                if (control is TextBox)
                {
                    control.Text = String.Empty;
                }
                if (control is RadioButton)
                {
                    ((RadioButton)control).Checked = false;
                }
            }
            foreach (Control control in this.gbEmpleado.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = String.Empty;
                }
                if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
            }
            foreach (Control control in this.gbMedico.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = String.Empty;
                }
                if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
            }
            foreach (Control control in this.gbProveedor.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = String.Empty;
                }
                if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
            }
        }

        private void Bloquear(bool v)
        {
            txtNombre.Enabled = !v;
            txtApellido.Enabled = !v;
            txtTelefono.Enabled = !v;
            txtEmail.Enabled = !v;
            lstContactos.Enabled = !v;
            btnNuevo.Enabled = !v;
            btnEditar.Enabled = !v;
            btnGrabar.Enabled = !v;
            btnBorrar.Enabled = !v;
            btnSalir.Enabled = !v;
        }


        private void chkCliente_CheckedChanged(object sender, EventArgs e)
        {
            LimpiarPantalla();

            //solamente chequear uno
            chkEmpleado.Checked = false;
            chkMedico.Checked = false;
            chkProveedor.Checked = false;

            Bloquear(false);
            btnEditar.Enabled = false;
            btnGrabar.Enabled = false;
            btnBorrar.Enabled = false;
            gbCliente.Location = new System.Drawing.Point(6, 260);
            CargarComboCliente();
            CargarListaCliente();
        }

        private void CargarListaCliente()
        {
            listaClientes.Clear();
            lstContactos.Items.Clear();
            listaClientes = ServicioDao.ObtenerServicio().ConsultarClientes();
            lstContactos.Items.AddRange(listaClientes.ToArray());
        }

        private async void CargarComboCliente()
        {
            // ComboBox Obra Social de los Cliente
            cboObraCliente.Items.Clear();
            string urlObra = "https://localhost:7071/api/Medico/ObrasSociales";
            var resultObra = await HelperHttp.GetInstance().GetAsync(urlObra);
            List<ObraSocial> obrasSociales = JsonConvert.DeserializeObject<List<ObraSocial>>(resultObra.Data);
            cboObraCliente.DataSource = obrasSociales;
            cboObraCliente.DisplayMember = "Nombre";
            cboObraCliente.ValueMember = "Id";
            cboObraCliente.SelectedIndex = 0;

            //ComboBox Barrios de los clientes
            cboBarrioCliente.Items.Clear();
            string urlBarrio = "https://localhost:7071/api/Cliente/Barrio";
            var resultBarrio = await HelperHttp.GetInstance().GetAsync(urlBarrio);
            List<Barrio> barrios = JsonConvert.DeserializeObject<List<Barrio>>(resultBarrio.Data);
            cboObraCliente.DataSource = barrios;
            cboObraCliente.DisplayMember = "Nombre";
            cboObraCliente.ValueMember = "Id";
            cboObraCliente.SelectedIndex = 0;
        }

        private void lstContactos_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEditar.Enabled = true;
            btnBorrar.Enabled = true;

            int selected = lstContactos.SelectedIndex;
            if (selected != -1)
            {
                if (chkCliente.Checked) // Opcion Cliente
                {
                    Cliente cliente = listaClientes[selected];
                    txtNombre.Text = cliente.Nombre.ToString();
                    txtApellido.Text = cliente.Apellido.ToString();
                    txtTelefono.Text = cliente.Telefono.ToString();
                    txtEmail.Text = cliente.Email.ToString();
                    cboObraCliente.SelectedValue = cliente.ObraSocial.Id;
                    cboBarrioCliente.SelectedValue = cliente.Barrio.Id;
                    txtDni.Text = cliente.Dni.ToString();
                    if (cliente.Sexo) //mujer es true, hombre es false
                    {
                        rbtMujer.Checked = true;
                    }
                    else
                    {
                        rbtHombre.Checked = true;
                    }
                }

                if (chkEmpleado.Checked) // Opcion Empleado
                {
                    Empleado empleado = listaEmpleados[selected];
                    txtNombre.Text = empleado.Nombre.ToString();
                    txtApellido.Text = empleado.Apellido.ToString();
                    txtTelefono.Text = empleado.Telefono.ToString();
                    txtEmail.Text = empleado.Email.ToString();
                    cboPuesto.SelectedValue = empleado.Puesto.Id;
                    cboSedeEmpleado.SelectedValue = empleado.Sede.Id;
                    txtSueldo.Text = empleado.Sueldo.ToString();
                }

                if (chkMedico.Checked) // Opcion Medico
                {
                    Medico medico = listaMedicos[selected];
                    txtNombre.Text = medico.Nombre.ToString();
                    txtApellido.Text = medico.Apellido.ToString();
                    txtTelefono.Text = medico.Telefono.ToString();
                    txtEmail.Text = medico.Email.ToString();
                    cboObraMedico.SelectedValue = medico.ObraSocial.Id;
                    cboSedeMedico.SelectedValue = medico.Sede.Id;
                    txtMatricula.Text = medico.Matricula.ToString();
                }

                if (chkProveedor.Checked) // Opcion Proveedor
                {
                    Proveedor proveedor = listaProveedores[selected];
                    txtNombre.Text = proveedor.Nombre.ToString();
                    txtTelefono.Text = proveedor.Telefono.ToString();
                    txtEmail.Text = proveedor.Email.ToString();
                    cboRazon.SelectedValue = proveedor.Razon;
                    cboBarrioProv.SelectedValue = proveedor.Barrio;
                    txtCalle.Text = proveedor.Calle.ToString();
                    txtCuit.Text = proveedor.Calle.ToString();
                }
            }
        }

        private void chkEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            LimpiarPantalla();

            //solamente chequear uno
            chkCliente.Checked = false;
            chkMedico.Checked = false;
            chkProveedor.Checked = false;

            Bloquear(false);
            btnEditar.Enabled = false;
            btnGrabar.Enabled = false;
            btnBorrar.Enabled = false;
            gbEmpleado.Location = new System.Drawing.Point(6, 260);
            CargarComboEmpleado();
            CargarListaEmpleado();
        }

        private void CargarListaEmpleado()
        {
            listaEmpleados.Clear();
            lstContactos.Items.Clear();
            listaEmpleados = ServicioDao.ObtenerServicio().ConsultarEmpleados();
            lstContactos.Items.AddRange(listaEmpleados.ToArray());
        }

        private async void CargarComboEmpleado()
        {
            // ComboBox Puesto de los Empleados
            cboPuesto.Items.Clear();
            string urlPuesto = "https://localhost:7071/api/Medico/ObrasSociales"; //AGEGAR URL PUESTOS !!!!!!!!!!!!!!!!!
            var resultPuesto = await HelperHttp.GetInstance().GetAsync(urlPuesto);
            List<Puesto> obrasSociales = JsonConvert.DeserializeObject<List<Puesto>>(resultPuesto.Data);
            cboPuesto.DataSource = obrasSociales;
            cboPuesto.DisplayMember = "Descripcion";
            cboPuesto.ValueMember = "Id";
            cboPuesto.SelectedIndex = 0;

            // ComboBox Sede de los Empleados
            cboSedeEmpleado.Items.Clear();
            string urlSede = "https://localhost:7071/api/Factura/Sedes";
            var resultSede = await HelperHttp.GetInstance().GetAsync(urlSede);
            List<Sede> sedes = JsonConvert.DeserializeObject<List<Sede>>(resultSede.Data);
            cboPuesto.DataSource = sedes;
            cboPuesto.DisplayMember = "Nombre";
            cboPuesto.ValueMember = "Id";
            cboPuesto.SelectedIndex = 0;
        }

        private void chkMedico_CheckedChanged(object sender, EventArgs e)
        {
            LimpiarPantalla();

            //solamente chequear uno
            chkEmpleado.Checked = false;
            chkCliente.Checked = false;
            chkProveedor.Checked = false;

            Bloquear(false);
            btnEditar.Enabled = false;
            btnGrabar.Enabled = false;
            btnBorrar.Enabled = false;
            gbMedico.Location = new System.Drawing.Point(6, 260);
            CargarComboMedico();
            CargarListaMedico();
        }

        private void CargarListaMedico()
        {
            listaMedicos.Clear();
            lstContactos.Items.Clear();
            listaMedicos = ServicioDao.ObtenerServicio().ConsultarMedicos();
            lstContactos.Items.AddRange(listaMedicos.ToArray());
        }

        private async void CargarComboMedico()
        {
            // ComboBox Obra Social de los Medicos
            cboObraMedico.Items.Clear();
            string urlObra = "https://localhost:7071/api/Medico/ObrasSociales";
            var resultObra = await HelperHttp.GetInstance().GetAsync(urlObra);
            List<ObraSocial> obrasSociales = JsonConvert.DeserializeObject<List<ObraSocial>>(resultObra.Data);
            cboObraMedico.DataSource = obrasSociales;
            cboObraMedico.DisplayMember = "Nombre";
            cboObraMedico.ValueMember = "Id";
            cboObraMedico.SelectedIndex = 0;

            // ComboBox Obra Social de los Medicos
            cboSedeMedico.Items.Clear();
            string urlSede = "https://localhost:7071/api/Factura/Sedes";
            var resultSede = await HelperHttp.GetInstance().GetAsync(urlSede);
            List<Sede> sedes = JsonConvert.DeserializeObject<List<Sede>>(resultSede.Data);
            cboSedeMedico.DataSource = sedes;
            cboSedeMedico.DisplayMember = "Nombre";
            cboSedeMedico.ValueMember = "Id";
            cboSedeMedico.SelectedIndex = 0;
        }

        private void chkProveedor_CheckedChanged(object sender, EventArgs e)
        {
            LimpiarPantalla();

            txtApellido.Enabled = false; //Proveedor no va a tener un apellido nunca

            //solamente chequear uno
            chkEmpleado.Checked = false;
            chkCliente.Checked = false;
            chkMedico.Checked = false;

            Bloquear(false);
            btnEditar.Enabled = false;
            btnGrabar.Enabled = false;
            btnBorrar.Enabled = false;
            gbProveedor.Location = new System.Drawing.Point(6, 260);
            CargarComboProveedor();
            CargarListaProveedor();
        }

        private void CargarListaProveedor()
        {
            listaProveedores.Clear();
            lstContactos.Items.Clear();
            listaProveedores = ServicioDao.ObtenerServicio().ConsultarProveedores();
            lstContactos.Items.AddRange(listaProveedores.ToArray());
        }

        private async void CargarComboProveedor()
        {
            // ComboBox Razon Social de los Proveedores
            cboRazon.Items.Clear();
            string urlRazon = "https://localhost:7071/api/Medico/ObrasSociales"; // AGREGAR CONTROLLER RAZON SOCIAL !!!!!!!!!!!!!!!!!!!!!!!
            var resultRazon = await HelperHttp.GetInstance().GetAsync(urlRazon);
            List<RazonSocial> obrasSociales = JsonConvert.DeserializeObject<List<RazonSocial>>(resultRazon.Data);
            cboRazon.DataSource = obrasSociales;
            cboRazon.DisplayMember = "Nombre";
            cboRazon.ValueMember = "Id";
            cboRazon.SelectedIndex = 0;

            //ComboBox Barrios de los Proveedores
            cboBarrioCliente.Items.Clear();
            string urlBarrio = "https://localhost:7071/api/Cliente/Barrio";
            var resultBarrio = await HelperHttp.GetInstance().GetAsync(urlBarrio);
            List<Barrio> barrios = JsonConvert.DeserializeObject<List<Barrio>>(resultBarrio.Data);
            cboObraCliente.DataSource = barrios;
            cboObraCliente.DisplayMember = "Nombre";
            cboObraCliente.ValueMember = "Id";
            cboObraCliente.SelectedIndex = 0;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (chkCliente.Checked) //Grabado de un Cliente
            {
                //validacion de los datos
                if (ValidarDatos())
                {

                    //crear objeto
                    Cliente cliente = new Cliente();

                    //group box datos
                    cliente.Nombre = txtNombre.Text;
                    cliente.Apellido = txtApellido.Text;
                    cliente.Telefono = Convert.ToInt64(txtTelefono.Text); //long
                    cliente.Email = txtEmail.Text;

                    //group box cliente
                    cliente.ObraSocial.Id = Convert.ToInt32(cboObraCliente.SelectedValue);
                    cliente.ObraSocial.Nombre = cboObraCliente.SelectedText;
                    cliente.Barrio.Id = Convert.ToInt32(cboBarrioCliente.SelectedValue);
                    cliente.Barrio.Nombre = cboBarrioCliente.SelectedText;

                    cliente.Dni = Convert.ToInt32(txtDni.Text);
                    cliente.Sexo = rbtMujer.Checked; //Si mujer no esta chequeado, es false, por lo tanto, es hombre, no hace falta el if de rbtHombre

                    if (ServicioDao.ObtenerServicio().CargarCliente(cliente))
                    {
                        MessageBox.Show("Se grabo exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        Bloquear(true);
                        LimpiarPantalla();

                        btnSalir.Text = "Salir";
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido grabar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            if (chkEmpleado.Checked) //grabado de un Empleado
            {
                //validacion de los datos
                if (ValidarDatos())
                {

                    //crear objeto
                    Empleado empleado = new Empleado();

                    //group box datos
                    empleado.Nombre = txtNombre.Text;
                    empleado.Apellido = txtApellido.Text;
                    empleado.Telefono = Convert.ToInt64(txtTelefono.Text); //long
                    empleado.Email = txtEmail.Text;

                    //group box empleado
                    empleado.Puesto.Id = Convert.ToInt32(cboPuesto.SelectedValue);
                    empleado.Puesto.Descripcion = cboPuesto.SelectedText;
                    empleado.Sede.Id = Convert.ToInt32(cboSedeEmpleado.SelectedValue);
                    empleado.Sede.Nombre = cboSedeEmpleado.SelectedText;

                    empleado.Sueldo = Convert.ToDouble(txtSueldo.Text);

                    if (true)// (ServicioDao.ObtenerServicio().CargarEmpleado(empleado)) FALTA CARGAR EMPLEADO
                    {
                        MessageBox.Show("Se grabo exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        Bloquear(true);
                        LimpiarPantalla();

                        btnSalir.Text = "Salir";
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido grabar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            if (chkMedico.Checked) // grabado de un medico
            {
                //validacion de los datos
                if (ValidarDatos())
                {

                    //crear objeto
                    Medico medico = new Medico();

                    //group box datos
                    medico.Nombre = txtNombre.Text;
                    medico.Apellido = txtApellido.Text;
                    medico.Telefono = Convert.ToInt64(txtTelefono.Text); //long
                    medico.Email = txtEmail.Text;

                    //group box medico
                    medico.ObraSocial.Id = Convert.ToInt32(cboObraMedico.SelectedValue);
                    medico.ObraSocial.Nombre = cboObraMedico.SelectedText;
                    medico.Sede.Id = Convert.ToInt32(cboSedeMedico.SelectedValue);
                    medico.Sede.Nombre = cboSedeMedico.SelectedText;

                    medico.Matricula = Convert.ToInt32(txtMatricula.Text);

                    if (true)// (ServicioDao.ObtenerServicio().CargarMedico(medico)) FALTA CARGAR MEDICO !!!!!!!!!
                    {
                        MessageBox.Show("Se grabo exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        Bloquear(true);
                        LimpiarPantalla();

                        btnSalir.Text = "Salir";
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido grabar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            if (chkProveedor.Checked) // grabado de un Proveedor
            {
                //validacion de los datos
                if (ValidarDatos())
                {

                    //crear objeto
                    Proveedor proveedor = new Proveedor();

                    //group box datos
                    proveedor.Nombre = txtNombre.Text;

                    proveedor.Telefono = Convert.ToInt64(txtTelefono.Text); //long
                    proveedor.Email = txtEmail.Text;

                    //group box proveedor
                    proveedor.Razon.Id = Convert.ToInt32(cboRazon.SelectedValue);
                    proveedor.Razon.Nombre = cboRazon.SelectedText;
                    proveedor.Barrio.Id = Convert.ToInt32(cboBarrioProv.SelectedValue);
                    proveedor.Barrio.Nombre = cboBarrioProv.SelectedText;

                    proveedor.Calle = txtCalle.Text;
                    proveedor.Cuit = Convert.ToInt64(txtCuit.Text);

                    if (true)// (ServicioDao.ObtenerServicio().CargarMedico(medico)) FALTA CARGAR MEDICO !!!!!!!!!
                    {
                        MessageBox.Show("Se grabo exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        Bloquear(true);
                        LimpiarPantalla();

                        btnSalir.Text = "Salir";
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido grabar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }
        }

        private bool ValidarDatos()
        {
            //DATOS

            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un nombre...");
                txtNombre.Focus();
                return false;
            }
            if (txtApellido.Text == string.Empty && txtApellido.Enabled == true) // proveedor no posee apellido, solamente validar cuando esta activo
            {
                MessageBox.Show("Ingrese un apellido...");
                txtApellido.Focus();
                return false;
            }
            if (txtTelefono.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un Telefono...");
                txtTelefono.Focus();
                return false;
            }
            if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un e-mail...");
                txtEmail.Focus();
                return false;
            }

            if (chkCliente.Checked) //Validaciones por si es un cliente
            {
                if (cboObraCliente.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar una Obra Social...");
                    cboObraCliente.Focus();
                    return false;
                }
                if (cboBarrioCliente.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un Barrio...");
                    cboBarrioCliente.Focus();
                    return false;
                }
                if (txtDni.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese un DNI...");
                    txtDni.Focus();
                    return false;
                }
                if ((rbtHombre.Checked && rbtMujer.Checked) || (!rbtHombre.Checked && !rbtMujer.Checked)) //si los dos o ninguno esta seleccionado
                {
                    MessageBox.Show("La seleccion de sexo no es valida...");
                    rbtHombre.Focus();
                    return false;
                }
            }
            if (chkEmpleado.Checked) // validaciones si es un empleado
            {
                if (cboPuesto.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un Puesto...");
                    cboPuesto.Focus();
                    return false;
                }
                if (cboSedeEmpleado.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar una Sede...");
                    cboPuesto.Focus();
                    return false;
                }
                if (txtSueldo.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese un Sueldo...");
                    txtSueldo.Focus();
                    return false;
                }
            }
            if (chkMedico.Checked) // validaciones por si es un medico
            {
                if (cboObraMedico.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar una Obra Social...");
                    cboObraMedico.Focus();
                    return false;
                }
                if (cboSedeMedico.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar una Sede...");
                    cboSedeMedico.Focus();
                    return false;
                }
                if (txtMatricula.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese una Matricula...");
                    txtMatricula.Focus();
                    return false;
                }
            }
            if (chkProveedor.Checked) //si es un Proveedor validar lo siguiente:
            {
                if (cboRazon.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar una Razon Social...");
                    cboRazon.Focus();
                    return false;
                }
                if (cboBarrioProv.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un Barrio...");
                    cboBarrioProv.Focus();
                    return false;
                }
                if (txtCalle.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese una Calle...");
                    txtCalle.Focus();
                    return false;
                }
                if (txtCuit.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese un CUIT...");
                    txtCuit.Focus();
                    return false;
                }
            }
            return true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnGrabar.Enabled = true;
            lstContactos.Enabled = false;
            btnBorrar.Enabled = false;
            btnEditar.Enabled = false;
            //LimpiarPantalla();
            btnSalir.Text = "Cancelar";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnGrabar.Enabled = true;
            lstContactos.Enabled = false;
            btnBorrar.Enabled = false;
            btnEditar.Enabled = false;
            btnSalir.Text = "Cancelar";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int index = lstContactos.SelectedIndex;
            if (MessageBox.Show("Seguro que desea borrar ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (chkCliente.Checked) //Borrar un Cliente
                {
                    if (ServicioDao.ObtenerServicio().EliminarCliente(listaClientes[index].IdCliente))
                    {
                        MessageBox.Show("El Cliente fue eliminado!", "Informacion");
                        Bloquear(true);
                        LimpiarPantalla();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo borrar el Cliente seleccionado!", "Error");
                    }
                }
                if (chkEmpleado.Checked) //Borrar un Empleado
                {
                    if (ServicioDao.ObtenerServicio().EliminarEmpleado(listaEmpleados[index].Legajo))
                    {
                        MessageBox.Show("El Empleado fue eliminado!", "Informacion");
                        Bloquear(true);
                        LimpiarPantalla();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo borrar el Empleado seleccionado!", "Error");
                    }
                }
                if (chkMedico.Checked) //Borrar un Medico
                {
                    if (ServicioDao.ObtenerServicio().EliminarMedico(listaMedicos[index].Id))
                    {
                        MessageBox.Show("El Medico fue eliminado!", "Informacion");
                        Bloquear(true);
                        LimpiarPantalla();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo borrar el Medico seleccionado!", "Error");
                    }
                }
                if (chkProveedor.Checked) //Borrar un Proveedor
                {
                    if (ServicioDao.ObtenerServicio().EliminarProveedor(listaProveedores[index].Id))
                    {
                        MessageBox.Show("El Proveedor fue eliminado!", "Informacion");
                        Bloquear(true);
                        LimpiarPantalla();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo borrar el Proveedor seleccionado!", "Error");
                    }
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
                LimpiarPantalla();
                Bloquear(true);
            }
        }
    }
}
