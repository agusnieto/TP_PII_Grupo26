using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class FrmDatosPersonales : Form
    {
        private List<String> listPersonal;
        public FrmDatosPersonales()
        {
            InitializeComponent();
            listPersonal = new List<String>();
            listPersonal.Insert(0, "Medico");
            listPersonal.Insert(1, "Cliente");
            listPersonal.Insert(2, "Empleado");
            listPersonal.Insert(3, "Proveedor");
        }

        private void gbMedico_Enter(object sender, EventArgs e)
        {

        }

        private void DatosPersonales_Load(object sender, EventArgs e)
        {
            cboPersonal.DataSource = listPersonal;
            cboPersonal.DropDownStyle = ComboBoxStyle.DropDownList;
            LimpiarPantalla();
            LimpiarDatos();
            cboPersonal.SelectedIndex = -1;


        }



        private void LimpiarDatos()
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

                if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Now;
                }

                if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
            }
        }

        private void LimpiarPantalla()
        {
            gbMedico.Visible = false;
            gbCliente.Visible = false;
            gbEmpleado.Visible = false;
            gbProveedor.Visible = false;
        }

        private void cboPersonal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPersonal.SelectedItem != null)
            {
                //string seleccion = cboPersonal.SelectedItem.ToString();
                string seleccion = cboPersonal.SelectedItem.ToString();


                if (cboPersonal.SelectedIndex != -1)
                {
                    switch (seleccion)
                    {
                        case "Medico":
                            LimpiarPantalla();
                            gbMedico.Visible = true;
                            gbMedico.Location = new Point(461, 86);
                            break;
                        case "Cliente":
                            LimpiarPantalla();
                            gbCliente.Visible = true;
                            gbCliente.Location = new Point(461, 86);
                            break;
                        case "Empleado":
                            LimpiarPantalla();
                            gbEmpleado.Visible = true;
                            gbEmpleado.Location = new Point(461, 86);
                            break;
                        case "Proveedor":
                            LimpiarPantalla();
                            gbProveedor.Visible = true;
                            gbProveedor.Location = new Point(461, 86);
                            break;
                        default:
                            LimpiarPantalla();
                            break;
                    }
                }
            }






        }




        private void gbCliente_Enter(object sender, EventArgs e)
        {

        }
    }
}
