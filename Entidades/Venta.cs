using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMercado.Entidades
{
    public class Venta
    {
        public int NumB { get; set; } 
        public DateTime dt { get; set; } 

        public string rut { get; set; }    

        public List<Venta> listaVentas { get; set; }

        public DateTime date1 = new DateTime(2010, 9, 12);
    }
}
