using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMercado.Entidades
{
    internal class Item
    {
        public int NumB { get; set; }
        public int cod { get; set; }
        public int cantidad { get; set; }

        public List<Item> listaItems { get; set; }
    }
}
