﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
    public class Gas : Producto
    {
        public string UnidadMedida { get; set; }
        public float Espesor { get; set; }
    }
}
