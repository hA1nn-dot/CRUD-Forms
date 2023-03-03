using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using PruebaTecnica.Controllers;
using PruebaTecnica.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Model
{
    abstract class toPDFModel
    {
        public static void convert(Empleado empleado, string fileName) {
            PdfWriter pdfWritter = new PdfWriter(fileName);
            PdfDocument pdf = new PdfDocument(pdfWritter);
            Document document = new Document(pdf);

            document.SetMargins(60, 20, 55, 20);


            var parrafoNombre = new Paragraph("Nombre: " + empleado.Nombre + " " + empleado.ApellidoPaterno + " " + empleado.ApellidoMaterno);
            var parrafoEdad = new Paragraph("Edad: " + empleado.Edad);
            var parrafoGenero = new Paragraph("Genero: " + empleado.Genero);
            var parrafoPuesto = new Paragraph("Puesto: " + empleado.Puesto);
            var parrafoEstudios = new Paragraph("Ultimo grado de estudios: " + empleado.Estudios);
            var parrafoTipoEmpleado = new Paragraph("Tipo de Empleado: " + empleado.TipoEmpleado);
            var parrafoDireccion = new Paragraph("Direccion: " + empleado.Calle + " " + empleado.Num + " ," + empleado.EntidadFederativa);
            var parrafoCodigoPostal = new Paragraph("CP: " + empleado.CP);
            document.Add(parrafoNombre);
            document.Add(parrafoEdad);
            document.Add(parrafoGenero);
            document.Add(parrafoPuesto);
            document.Add(parrafoEstudios);
            document.Add(parrafoTipoEmpleado);
            document.Add(parrafoDireccion);
            document.Add(parrafoCodigoPostal);
            foreach (Telefono telefono in empleado.Telefonos)
            {
                var parrafoTelefono = new Paragraph("Telefono :" + telefono.Numero + " Ext:  " + telefono.Extension + " Tipo: " + telefono.Tipo);
                document.Add(parrafoTelefono);
            }

            document.Close();
        }
    }
}
