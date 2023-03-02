using PruebaTecnica.Controllers;
using PruebaTecnica.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaTecnica.View
{
    public partial class AgregarEmpleadoView : Form
    {
        //Valores por default
        List<string> entidades = new List<string>() {
            "Aguascalientes","Baja California","Baja California Sur", "Campeche","Coahuila de Zaragoza",
            "Colima","Chiapas", "Chihuahua", "Ciudad de México","Durango","Guanajuato", "Guerrero","Hidalgo",
            "Jalisco","Edo. de México", "Michoacán de Ocampo", "San Luis Potosí"
        };

        List<string> estudios = new List<string>() {
            "Preparatoria Trunca", "Licenciatura Terminada"
        };

        List<string> tipoEmpleados = new List<string>() {
            "Administrativo", "Operativo"
        };

        List<Telefono> telefonos = new List<Telefono>();

        public AgregarEmpleadoView()
        {
            InitializeComponent();
        }

        private void AgregarEmpleadoView_Load(object sender, EventArgs e)
        {
            //Agregar valores por default
            foreach (string entidad in entidades) {
                this.comboEntidadFederativa.Items.Add(entidad);
            }
            foreach (string estudio in estudios) {
                this.comboEstudios.Items.Add(estudio);
            }
            foreach (string tipoEmpleado in tipoEmpleados) {
                this.comboTipoEmpleado.Items.Add(tipoEmpleado);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Crear empleado
            string genero = radioHombre.Checked == true ? "H" : "M";
            Empleado empleado = new Empleado(
                txtNombre.Text,
                txtApellidoP.Text,
                txtApellidoM.Text,
                txtEdad.Text,
                genero,
                txtTipoPuesto.Text,
                comboEstudios.SelectedItem.ToString(),
                comboTipoEmpleado.SelectedItem.ToString(),
                txtCalle.Text,
                txtNumeroCasa.Text,
                txtCP.Text,
                comboEntidadFederativa.SelectedItem.ToString(),
                telefonos);

            //Guardar empleado a la DB
            EmpleadoModel.nuevoEmpleado(empleado);
            this.Close();
            
        }

        private void AddPhone_Click(object sender, EventArgs e)
        {
            string numero = txtTelefono.Text;
            string extension = txtExtension.Text;
            string tipo = txtTipoTelefono.Text;

            Telefono telefono = new Telefono(extension, numero , tipo);
            telefonos.Add(telefono);

            this.dataGridView1.Rows.Add(numero, extension, tipo);
        }
    }
}
