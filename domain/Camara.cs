using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
    public class Camara : Producto
    {
        public string Tipo { get; set; }
        public float Espesor { get; set; }
        public string UnidadMedida { get; set; }
    }
}
