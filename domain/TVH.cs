using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
    public class TVH
    {
        public Vidrio v1 { get; set; }
        public Camara c1 { get; set; }
        public Vidrio v2 { get; set; }
        public Camara c2 { get; set; }
        public Vidrio v3 { get; set; }

        public List<Producto> opsTVH = new List<Producto>();
    }
}
