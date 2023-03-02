using PruebaTecnica.Controllers;
using PruebaTecnica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.View
{
    class Empleado
    {
        private int idEmpleado; 
        private string nombre;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private string edad;
        private string genero;
        private string puesto;
        private string estudios; //catalogo
        private string tipoEmpleado; //catalogo

        private string calle;
        private string num;
        private string cp;
        private string entidadFederativa;

        private List<Telefono> telefonos;

        public Empleado(string nombre, string apellidoPaterno, string apellidoMaterno, string edad, string genero, string puesto, string estudios, string tipoEmpleado, string calle, string num, string cP, string entidadFederativa, List<Telefono> telefonos)
        {
            this.Nombre = nombre;
            this.ApellidoPaterno = apellidoPaterno;
            this.ApellidoMaterno = apellidoMaterno;
            this.Edad = edad;
            this.Genero = genero;
            this.Puesto = puesto;
            this.Estudios = estudios;
            this.TipoEmpleado = tipoEmpleado;
            this.Calle = calle;
            this.Num = num;
            this.cp = cP;
            this.EntidadFederativa = entidadFederativa;
            this.Telefonos = telefonos;
        }

        public Empleado(int idEmpleado, string nombre, string apellidoPaterno, string apellidoMaterno, string edad, string genero, string puesto, string estudios, string tipoEmpleado, string calle, string num, string cP, string entidadFederativa)
        {
            this.IdEmpleado = idEmpleado;
            this.Nombre = nombre;
            this.ApellidoPaterno = apellidoPaterno;
            this.ApellidoMaterno = apellidoMaterno;
            this.Edad = edad;
            this.Genero = genero;
            this.Puesto = puesto;
            this.Estudios = estudios;
            this.TipoEmpleado = tipoEmpleado;
            this.Calle = calle;
            this.Num = num;
            this.cp = cP;
            this.EntidadFederativa = entidadFederativa;
        }

        public void toPDFCovert(string fileName) {
            toPDFModel.convert(this, fileName);
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
        public string Edad { get => edad; set => edad = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Puesto { get => puesto; set => puesto = value; }
        public string Estudios { get => estudios; set => estudios = value; }
        public string TipoEmpleado { get => tipoEmpleado; set => tipoEmpleado = value; }
        public string Calle { get => calle; set => calle = value; }
        public string Num { get => num; set => num = value; }
        public string CP { get => cp; set => cp = value; }
        public string EntidadFederativa { get => entidadFederativa; set => entidadFederativa = value; }
        internal List<Telefono> Telefonos { get => telefonos; set => telefonos = value; }
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
    }
}
