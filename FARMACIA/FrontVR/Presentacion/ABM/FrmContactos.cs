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
using System.Net;

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
            gbCliente.Location = new System.Drawing.Point(846, 18);
            gbEmpleado.Location = new System.Drawing.Point(846, 18);
            gbMedico.Location = new System.Drawing.Point(846, 18);
            gbProveedor.Location = new System.Drawing.Point(846, 18);

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
            Habilitar(true);

            LimpiarPantalla();

            //solamente chequear uno
            chkEmpleado.Checked = false;
            chkMedico.Checked = false;
            chkProveedor.Checked = false;

            Bloquear(false);
            btnEditar.Enabled = false;
            btnGrabar.Enabled = false;
            btnBorrar.Enabled = false;
            gbCliente.Location = new System.Drawing.Point(6, 295);
            CargarComboCliente();
            CargarListaCliente();
        }

        private void Habilitar(bool v)
        {
            chkCliente.Enabled = !v;
            chkEmpleado.Enabled = !v;
            chkMedico.Enabled = !v;
            chkProveedor.Enabled = !v;
        }

        private async void CargarListaCliente()


        {
            listaClientes.Clear();
            lstContactos.Items.Clear();
            string urlCliente = "https://localhost:7071/api/Cliente";
            var result = await HelperHttp.GetInstance().GetAsync(urlCliente);
            listaClientes = JsonConvert.DeserializeObject<List<Cliente>>(result.Data);//AGREGAR URL
            lstContactos.Items.AddRange(listaClientes.ToArray());
        }

        private async void CargarComboCliente()
        {
            // ComboBox Obra Social de los Cliente
            cboObraCliente.Items.Clear();
            string urlObra = "https://localhost:7071/api/Medico/ObrasSociales";
            var resultObra = await HelperHttp.GetInstance().GetAsync(urlObra);
            List<ObraSocial> obrasSociales = JsonConvert.DeserializeObject<List<ObraSocial>>(resultObra.Data);
            foreach (ObraSocial ob in obrasSociales)
            {
                cboObraCliente.Items.Add(ob);
            }
            cboObraCliente.SelectedIndex = -1;
            cboObraCliente.DropDownStyle = ComboBoxStyle.DropDownList;

            //ComboBox Barrios de los clientes
            cboBarrioCliente.Items.Clear();
            string urlBarrio = "https://localhost:7071/api/Cliente/Barrio";
            var resultBarrio = await HelperHttp.GetInstance().GetAsync(urlBarrio);
            List<Barrio> barrios = JsonConvert.DeserializeObject<List<Barrio>>(resultBarrio.Data);
            foreach (Barrio ba in barrios)
            {
                cboBarrioCliente.Items.Add(ba);
            }

            cboBarrioCliente.SelectedIndex = -1;
            cboBarrioCliente.DropDownStyle = ComboBoxStyle.DropDownList;
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
                    cboObraCliente.SelectedItem = cliente.ObraSocial;
                    cboBarrioCliente.SelectedItem = cliente.Barrio;
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
                    cboPuesto.SelectedItem = empleado.Puesto;
                    cboSedeEmpleado.SelectedItem = empleado.Sede;
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
                    txtCuit.Text = proveedor.Cuit.ToString();
                }
            }
        }

        private void chkEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            Habilitar(true);
            LimpiarPantalla();

            //solamente chequear uno
            chkCliente.Checked = false;
            chkMedico.Checked = false;
            chkProveedor.Checked = false;

            Bloquear(false);
            btnEditar.Enabled = false;
            btnGrabar.Enabled = false;
            btnBorrar.Enabled = false;
            gbEmpleado.Location = new System.Drawing.Point(6, 295);
            CargarComboEmpleado();
            CargarListaEmpleado();
        }

        private async void CargarListaEmpleado()
        {
            listaEmpleados.Clear();
            lstContactos.Items.Clear();
            string urlEmpleado = "https://localhost:7071/api/Empleado";
            var result = await HelperHttp.GetInstance().GetAsync(urlEmpleado);
            listaEmpleados = JsonConvert.DeserializeObject<List<Empleado>>(result.Data);//AGREGAR URL
            lstContactos.Items.AddRange(listaEmpleados.ToArray());
        }

        private async void CargarComboEmpleado()
        {
            // ComboBox Puesto de los Empleados
            cboPuesto.Items.Clear();
            string urlPuesto = "https://localhost:7071/api/Empleado/Puestos"; //AGEGAR URL PUESTOS !!!!!!!!!!!!!!!!!
            var resultPuesto = await HelperHttp.GetInstance().GetAsync(urlPuesto);
            List<Puesto> puestos = JsonConvert.DeserializeObject<List<Puesto>>(resultPuesto.Data);
            foreach (Puesto p in puestos)
            {
                cboPuesto.Items.Add(p);
            }
            cboPuesto.SelectedIndex = -1;
            cboPuesto.DropDownStyle = ComboBoxStyle.DropDownList;


            // ComboBox Sede de los Empleados
            cboSedeEmpleado.Items.Clear();
            string urlSede = "https://localhost:7071/api/Factura/Sedes";
            var resultSede = await HelperHttp.GetInstance().GetAsync(urlSede);
            List<Sede> sedes = JsonConvert.DeserializeObject<List<Sede>>(resultSede.Data);
            foreach (Sede s in sedes)
            {
                cboSedeEmpleado.Items.Add(s);
            }

            cboSedeEmpleado.SelectedIndex = -1;
            cboSedeEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void chkMedico_CheckedChanged(object sender, EventArgs e)
        {
            Habilitar(true);
            LimpiarPantalla();

            //solamente chequear uno
            chkEmpleado.Checked = false;
            chkCliente.Checked = false;
            chkProveedor.Checked = false;

            Bloquear(false);
            btnEditar.Enabled = false;
            btnGrabar.Enabled = false;
            btnBorrar.Enabled = false;
            gbMedico.Location = new System.Drawing.Point(6, 295);
            CargarComboMedico();
            CargarListaMedico();
        }

        private async void CargarListaMedico()
        {
            listaMedicos.Clear();
            lstContactos.Items.Clear();
            string urlMedico = "https://localhost:7071/api/Medico";
            var result = await HelperHttp.GetInstance().GetAsync(urlMedico);
            listaMedicos = JsonConvert.DeserializeObject<List<Medico>>(result.Data);//AGREGAR URL

            lstContactos.Items.AddRange(listaMedicos.ToArray());
        }

        private async void CargarComboMedico()
        {
            // ComboBox Obra Social de los Medicos
            cboObraMedico.Items.Clear();
            string urlObra = "https://localhost:7071/api/Medico/ObrasSociales";
            var resultObra = await HelperHttp.GetInstance().GetAsync(urlObra);
            List<ObraSocial> obrasSociales = JsonConvert.DeserializeObject<List<ObraSocial>>(resultObra.Data);
            foreach (ObraSocial ob in obrasSociales)
            {
                cboObraMedico.Items.Add(ob);
            }

            cboObraMedico.SelectedIndex = -1;
            cboObraMedico.DropDownStyle = ComboBoxStyle.DropDownList;

            // ComboBox Obra Social de los Medicos
            cboSedeMedico.Items.Clear();
            string urlSede = "https://localhost:7071/api/Factura/Sedes";
            var resultSede = await HelperHttp.GetInstance().GetAsync(urlSede);
            List<Sede> sedes = JsonConvert.DeserializeObject<List<Sede>>(resultSede.Data);
            foreach (Sede s in sedes)
            {
                cboSedeMedico.Items.Add(s);
            }

            cboSedeMedico.SelectedIndex = -1;
            cboSedeMedico.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void chkProveedor_CheckedChanged(object sender, EventArgs e)
        {
            Habilitar(true);
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
            gbProveedor.Location = new System.Drawing.Point(6, 295);
            CargarComboProveedor();
            CargarListaProveedor();
        }

        private async void CargarListaProveedor()
        {
            listaProveedores.Clear();
            lstContactos.Items.Clear();
            string urlProveedor = "https://localhost:7071/api/Proveedor";
            var result = await HelperHttp.GetInstance().GetAsync(urlProveedor);
            listaProveedores = JsonConvert.DeserializeObject<List<Proveedor>>(result.Data);//AGREGAR URL

            lstContactos.Items.AddRange(listaProveedores.ToArray());
        }

        private async void CargarComboProveedor()
        {
            // ComboBox Razon Social de los Proveedores
            cboRazon.Items.Clear();
            string urlRazon = "https://localhost:7071/api/Proveedor/RazonesSociales"; // AGREGAR CONTROLLER RAZON SOCIAL !!!!!!!!!!!!!!!!!!!!!!!
            var resultRazon = await HelperHttp.GetInstance().GetAsync(urlRazon);
            List<RazonSocial> razones = JsonConvert.DeserializeObject<List<RazonSocial>>(resultRazon.Data);
            foreach (RazonSocial r in razones)
            {
                cboRazon.Items.Add(r);
            }

            cboRazon.SelectedIndex = -1;
            cboRazon.DropDownStyle = ComboBoxStyle.DropDownList;

            //ComboBox Barrios de los Proveedores
            cboBarrioCliente.Items.Clear();
            string urlBarrio = "https://localhost:7071/api/Cliente/Barrio";
            var resultBarrio = await HelperHttp.GetInstance().GetAsync(urlBarrio);
            List<Barrio> barrios = JsonConvert.DeserializeObject<List<Barrio>>(resultBarrio.Data);
            foreach (Barrio b in barrios)
            {
                cboBarrioProv.Items.Add(b);
            }

            cboBarrioProv.SelectedIndex = -1;
            cboBarrioProv.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async void btnGrabar_Click(object sender, EventArgs e)
        {
            int index = lstContactos.SelectedIndex;
            if (chkCliente.Checked) //Grabado de un Cliente
            {
                //validacion de los datos
                if (ValidarDatos())
                {

                    //crear objeto
                    ClienteDTO cliente = new ClienteDTO();

                    //group box datos
                    cliente.Nombre = txtNombre.Text;
                    cliente.Apellido = txtApellido.Text;
                    cliente.Telefono = Convert.ToInt64(txtTelefono.Text); //long
                    cliente.Email = txtEmail.Text;

                    //group box cliente
                    ObraSocial obraSocial = (ObraSocial)cboObraCliente.SelectedItem;
                    cliente.ObraSocial = obraSocial.Id;
                    Barrio barrio = (Barrio)cboBarrioCliente.SelectedItem;
                    cliente.Barrio = barrio.Id;

                    cliente.Dni = Convert.ToInt32(txtDni.Text);
                    cliente.Sexo = rbtMujer.Checked; //Si mujer no esta chequeado, es false, por lo tanto, es hombre, no hace falta el if de rbtHombre


                    string body = JsonConvert.SerializeObject(cliente);
                    if (btnGrabar.Text == "Confirmar")
                    {
                        cliente.IdCliente = listaClientes[index].IdCliente;
                        string url = "https://localhost:7071/api/Cliente";
                        var result = await HelperHttp.GetInstance().PutAsync(url, body);
                        if (ServicioDao.ObtenerServicio().ActualizarCliente(cliente)) //result.StatusCode == HttpStatusCode.OK)
                        {
                            MessageBox.Show("Se actualizo exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            Bloquear(true);
                            LimpiarPantalla();

                            btnSalir.Text = "Salir";
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido actualizar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }

                    }
                    else
                    {
                        string url = "https://localhost:7071/api/Cliente";
                        var result = await HelperHttp.GetInstance().PostAsync(url, body);

                        if (ServicioDao.ObtenerServicio().CargarCliente(cliente))// result.StatusCode == HttpStatusCode.OK))
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
            if (chkEmpleado.Checked) //grabado de un Empleado
            {
                //validacion de los datos
                if (ValidarDatos())
                {

                    //crear objeto
                    EmpleadoDTO empleado = new EmpleadoDTO();

                    //group box datos
                    empleado.Nombre = txtNombre.Text;
                    empleado.Apellido = txtApellido.Text;
                    empleado.Telefono = Convert.ToInt64(txtTelefono.Text); //long
                    empleado.Email = txtEmail.Text;

                    //group box empleado
                    Puesto puesto = (Puesto)cboPuesto.SelectedItem;
                    empleado.Puesto = puesto.Id;
                    Sede sede = (Sede)cboSedeEmpleado.SelectedItem;
                    empleado.Sede = sede.Id;

                    empleado.Sueldo = Convert.ToDouble(txtSueldo.Text);


                    string bodyContent = JsonConvert.SerializeObject(empleado);

                    if (btnGrabar.Text == "Confirmar")
                    {
                        empleado.Legajo = listaEmpleados[index].Legajo;
                        string url = "https://localhost:7071/api/Empleado";
                        var result = await HelperHttp.GetInstance().PutAsync(url, bodyContent);
                        if (result.StatusCode == HttpStatusCode.OK)
                        {
                            MessageBox.Show("Se actualizo exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            Bloquear(true);
                            LimpiarPantalla();

                            btnSalir.Text = "Salir";
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido actulizar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                    }
                    else
                    {
                        string url = "https://localhost:7071/api/Empleado";
                        var result = await HelperHttp.GetInstance().PostAsync(url, bodyContent);
                        if (result.StatusCode == HttpStatusCode.OK)
                        {
                            MessageBox.Show("Se actualizo exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            Bloquear(true);
                            LimpiarPantalla();

                            btnSalir.Text = "Salir";
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido actulizar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                    }

                }
            }
            if (chkMedico.Checked) // grabado de un medico
            {

                //validacion de los datos
                if (ValidarDatos())
                {

                    //crear objeto
                    MedicoDTO medico = new MedicoDTO();

                    //group box datos
                    medico.Nombre = txtNombre.Text;
                    medico.Apellido = txtApellido.Text;
                    medico.Telefono = Convert.ToInt64(txtTelefono.Text); //long
                    medico.Email = txtEmail.Text;

                    //group box medico
                    ObraSocial obra = (ObraSocial)cboObraMedico.SelectedItem;
                    medico.ObraSocial = obra.Id;
                    Sede sede = (Sede)cboSedeMedico.SelectedItem;
                    medico.Sede = sede.Id;

                    medico.Matricula = Convert.ToInt32(txtMatricula.Text);


                    string bodyContent = JsonConvert.SerializeObject(medico);

                    if (btnGrabar.Text == "Confirmar")
                    {
                        medico.Id = listaMedicos[index].Id;
                        string url = "https://localhost:7071/api/Medico";
                        var result = await HelperHttp.GetInstance().PutAsync(url, bodyContent);

                        if (result.StatusCode == HttpStatusCode.OK)
                        {
                            MessageBox.Show("Se actualizo exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            Bloquear(true);
                            LimpiarPantalla();

                            btnSalir.Text = "Salir";
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido actualizar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                    }
                    else
                    {
                        string url = "https://localhost:7071/api/Medico";
                        var result = await HelperHttp.GetInstance().PostAsync(url, bodyContent);

                        if (result.StatusCode == HttpStatusCode.OK)
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
            if (chkProveedor.Checked) // grabado de un Proveedor
            {
                txtApellido.Enabled = false;
                //validacion de los datos
                if (ValidarDatos())
                {

                    //crear objeto
                    ProveedorDTO proveedor = new ProveedorDTO();

                    //group box datos
                    proveedor.Nombre = txtNombre.Text;

                    proveedor.Telefono = Convert.ToInt64(txtTelefono.Text); //long
                    proveedor.Email = txtEmail.Text;

                    //group box proveedor
                    RazonSocial razon = (RazonSocial)cboRazon.SelectedItem;
                    proveedor.RazonSocial = razon.Id; ;
                    Barrio barrio = (Barrio)cboBarrioProv.SelectedItem;
                    proveedor.Barrio = barrio.Id;

                    proveedor.Calle = txtCalle.Text;
                    proveedor.Cuit = Convert.ToInt64(txtCuit.Text);


                    string bodyContent = JsonConvert.SerializeObject(proveedor);
                    if (btnGrabar.Text == "Confirmar")
                    {
                        proveedor.Id = listaProveedores[index].Id;
                        string url = "https://localhost:7071/api/Proveedor";
                        var result = await HelperHttp.GetInstance().PutAsync(url, bodyContent);

                        if (result.StatusCode == HttpStatusCode.OK)
                        {
                            MessageBox.Show("Se actualizo exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            Bloquear(true);
                            LimpiarPantalla();

                            btnSalir.Text = "Salir";
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido actualizar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                    }
                    else
                    {
                        string url = "https://localhost:7071/api/Proveedor";
                        var result = await HelperHttp.GetInstance().PostAsync(url, bodyContent);

                        if (result.StatusCode == HttpStatusCode.OK)
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
                txtApellido.Enabled = true;
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
            btnGrabar.Text = "Confirmar";
            btnGrabar.Enabled = true;
            lstContactos.Enabled = false;
            btnBorrar.Enabled = false;
            btnEditar.Enabled = false;
            btnSalir.Text = "Cancelar";
        }

        private async void btnBorrar_Click(object sender, EventArgs e)
        {
            int index = lstContactos.SelectedIndex;
            if (MessageBox.Show("Seguro que desea borrar ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (chkCliente.Checked) //Borrar un Cliente
                {
                    string urlCliente = "https://localhost:7071/api/Cliente/";
                    string urlConParametro = $"{urlCliente}{listaClientes[index].IdCliente}";
                    var result = await HelperHttp.GetInstance().DeleteAsync(urlConParametro);

                    if (result.StatusCode == HttpStatusCode.OK)
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
                    string urlEmpleado = "https://localhost:7071/api/Empleado/";
                    string urlConParametro = $"{urlEmpleado}{listaEmpleados[index].Legajo}";
                    var result = await HelperHttp.GetInstance().DeleteAsync(urlConParametro);

                    if (result.StatusCode == HttpStatusCode.OK)
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
                    string urlMedico = "https://localhost:7071/api/Medico/";
                    string urlConParametro = $"{urlMedico}{listaMedicos[index].Id}";
                    var result = await HelperHttp.GetInstance().DeleteAsync(urlConParametro);

                    if (result.StatusCode == HttpStatusCode.OK)
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
                    string urlProveedor = "https://localhost:7071/api/Proveedor/";
                    string urlConParametro = $"{urlProveedor}{listaProveedores[index].Id}";
                    var result = await HelperHttp.GetInstance().DeleteAsync(urlConParametro);

                    if (result.StatusCode == HttpStatusCode.OK)
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
                Habilitar(false);
            }
        }
    }
}
