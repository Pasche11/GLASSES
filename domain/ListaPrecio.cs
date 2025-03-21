using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
    public class ListaPrecio
    {
        public string Nombre { get; set; }

        public List<Producto> productos = new List<Producto>();
    }
}
