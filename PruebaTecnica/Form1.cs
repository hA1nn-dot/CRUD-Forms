using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Layout;
using iText.Layout.Element;
using PruebaTecnica.Controllers;
using PruebaTecnica.Model;
using PruebaTecnica.View;

namespace PruebaTecnica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EmpleadoModel.showEmpleados(this.dataGridView1);
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            AgregarEmpleadoView nuevoEmpleado = new AgregarEmpleadoView();
            nuevoEmpleado.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshEmpleados();
        }

        private void btnBorrarEmployee_Click(object sender, EventArgs e)
        {
            int idEmpleado = Int32.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string nombreEmpleado = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            EmpleadoModel.deleteEmpleado(idEmpleado);
            MessageBox.Show("Usuario " + nombreEmpleado + " eliminado");
            refreshEmpleados();
        }

        private void refreshEmpleados() {
            this.dataGridView1.Columns.Clear();
            EmpleadoModel.showEmpleados(this.dataGridView1);
        }

        private void btnExportExcelData_Click(object sender, EventArgs e)
        {
            excelCoverter.export(this.dataGridView1);
        }

        private void btnDetalleEmpleado_Click(object sender, EventArgs e)
        {
            int idEmpleado = Int32.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //Crear empleado
            Empleado empleado = new Empleado();
            empleado.IdEmpleado = idEmpleado;
            empleado.Nombre = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            empleado.ApellidoPaterno = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            empleado.ApellidoMaterno = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            empleado.Edad = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            empleado.Genero = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            empleado.Puesto = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            empleado.Estudios = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            empleado.TipoEmpleado = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            empleado.Calle = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
            empleado.Num = this.dataGridView1.CurrentRow.Cells[11].Value.ToString();
            empleado.CP = this.dataGridView1.CurrentRow.Cells[12].Value.ToString();
            empleado.EntidadFederativa = this.dataGridView1.CurrentRow.Cells[13].Value.ToString();
            empleado.Telefonos = EmpleadoModel.getTelefonosByIdEmpleado(idEmpleado);
            //Convertir a pdf
            empleado.toPDFCovert("Reporte.pdf");
            MessageBox.Show("Reporte.pdf guardado!","Reporte.pdf");
        }
    }
}
