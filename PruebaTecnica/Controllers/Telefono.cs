using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Controllers
{
    class Telefono
    {
        private string extension;
        private string numero;
        private string tipo;

        public Telefono(string extension, string numero, string tipo)
        {
            this.extension = extension;
            this.numero = numero;
            this.tipo = tipo;
        }

        public string Extension { get => extension; set => extension = value; }
        public string  Numero { get => numero; set => numero = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
