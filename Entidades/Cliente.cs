using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMercado.Entidades
{
    public class Cliente
    {
        public string rut { get; set; }
        public  string nombre { get; set; }

        public List<Cliente> listaClientes { get; set; }



        // public Escuela(string nombre, int año) // Constructor.
        // {
        //     this.nombre = nombre;
        //     AñoDeCreacion = año;
        //Para que en el main solo pida los values por los paramtros
        //  }

         
    }
}
