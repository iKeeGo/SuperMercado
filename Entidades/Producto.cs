using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMercado.Entidades
{
    public class Producto
    {


        public int cod { get; set; }
        public string nombre { get; set; }
        public int precio { get; set; }
        public int cantidad { get; set; }

        public List<Producto> listaProductos { get; set; }
    }
}
