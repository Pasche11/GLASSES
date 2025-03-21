using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
    public class Presupuesto
    {
        public Cliente ClientePresupuesto { get; set; }
        public ListaPrecio PrecioPresupuesto { get; set; }
        public List<TVH> tvh = new List<TVH>();
        public List<DVH> dvh = new List<DVH>();
        public List<VSimple> simples = new List<VSimple>();
    }
}
