using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
    public class Cliente
    {
        public bool RI { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public int CPostal { get; set; }
        public string Cuit { get; set; }
        public int Numero { get; set; }
        public string Nombre { get; set;}
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
    }
}
