using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
    public class Producto
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public float precio { get; set; }
        public string descripcion { get; set;}
        public string categoria { get; set; }
        // 0 para vidrio METRO CUADRADO
        // 1 para camara y pulido METRO LINEAL
        // 2 para extras x CANTIDAD
        // 3 GAS si o no. (bool)
    }
}
