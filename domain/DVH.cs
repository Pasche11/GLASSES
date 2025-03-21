using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
    public class DVH
    {
        public Vidrio v1 { get; set; }
        public Camara c1 { get; set; }
        public Vidrio v2 { get; set; }

        public List<Producto> opsDVH = new List<Producto>();
    }
}
