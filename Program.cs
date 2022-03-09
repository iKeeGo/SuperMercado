using SuperMercado.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SuperMercado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var clientes = new Cliente();
            var productos = new Producto();
            var ventas = new Venta();
            var items = new Item();

            productos.listaProductos = new List<Producto>() {
                new Producto(){ cod = 41419, nombre = "Fideos", precio = 450, cantidad = 210},
                new Producto(){ cod = 70717, nombre =  "Cuaderno", precio = 900, cantidad = 119 },
                new Producto(){ cod = 78714, nombre =  "Jabon", precio = 730, cantidad = 708 },
                new Producto(){ cod = 30877, nombre =  "Desodorante", precio = 2190, cantidad = 79 },
                new Producto(){ cod = 47470, nombre =  "Yogur", precio = 99, cantidad = 832 },
                new Producto(){ cod = 50809, nombre =  "Palta", precio = 500, cantidad = 55 },
                new Producto(){ cod = 75466, nombre =  "Galletas", precio = 235, cantidad = 0 },
                new Producto(){ cod = 33692, nombre =  "Bebida", precio = 700, cantidad = 20 },
                new Producto(){ cod = 89148, nombre =  "Arroz", precio = 900, cantidad = 121 },
                new Producto(){ cod = 66194, nombre =  "Lapiz", precio = 120, cantidad = 900 },
                new Producto(){ cod = 15982, nombre =  "Vuvuzela", precio = 12990, cantidad = 40 },
                new Producto(){ cod = 41235, nombre =  "Chocolate", precio = 3099, cantidad = 48 }
            };

            clientes.listaClientes = new List<Cliente>()
            {
                new Cliente() { rut = "11652624-7", nombre = "Perico Los Palotes" },
                new Cliente() { rut = "8830268-0", nombre = "Leonardo Farkas" },
                new Cliente() { rut = "7547896-8", nombre = "Fulanita de Tal" }

            };


            DateTime date1 = new DateTime(2010, 9, 12);
            DateTime date2 = new DateTime(2010, 9, 19);
            DateTime date3 = new DateTime(2010, 9, 30);
            DateTime date4 = new DateTime(2010, 10, 1);
            DateTime date5 = new DateTime(2010, 10, 13);
            DateTime date6 = new DateTime(2010, 11, 11);


            ventas.listaVentas = new List<Venta>()
            {
                new Venta() {NumB = 1, dt = date1 , rut = "8830268-0" },
                new Venta() {NumB = 2, dt = date2 , rut = "11652624-7" },
                new Venta() {NumB = 3, dt = date3 , rut = "7547896-8" },
                new Venta() {NumB = 4, dt = date4 , rut = "8830268-0" },
                new Venta() {NumB = 5, dt = date5 , rut = "7547896-8" },
                new Venta() {NumB = 6, dt = date6 , rut = "11652624-7" }
            };

            items.listaItems = new List<Item>()
            {
                new Item() {NumB = 1, cod = 89148,  cantidad = 3},
                new Item() {NumB = 2, cod = 50809,  cantidad = 4},
                new Item() {NumB = 2, cod = 33692,  cantidad = 2},
                new Item() {NumB = 2, cod = 47470,  cantidad = 6},
                new Item() {NumB = 3, cod = 30877,  cantidad = 1},
                new Item() {NumB = 4, cod = 89148,  cantidad = 1},
                new Item() {NumB = 4, cod = 75466,  cantidad = 2},
                new Item() {NumB = 5, cod = 89148,  cantidad = 2},
                new Item() {NumB = 5, cod = 47470,  cantidad = 10},
                new Item() {NumB = 6, cod = 41419,  cantidad = 2}
            };

            //ProductoCaro(productos);
            //ValorBodega(productos);
            //IngresoTotalxVentas(items, productos);
            ProductoIngreso(items, productos);


            //Console.WriteLine("\nFind: Part where name contains \"Palta\": {0}",
            //listaProductos.Find(x => x.nombre.Contains("Palta")));


            //var listaClientes = new List<Tuple<int , string, int >>
            //{
            //   Tuple.Create(15982, "Vuvuzela" , 12990),

            //};
        }

        //private static void ImprimirProductos(List<Producto> this.listaProductos)
        //{
        //    Console.WriteLine("Lista de productos:");
        //    foreach (var item in listaProductos)
        //    {
        //        Console.WriteLine($"cod = {item.cod} nombre = {item.nombre} precio = {item.precio} cantidad = {item.cantidad}");
        //    }
        //}
        private static void ProductoCaro(Producto productos)

        {


            int precioM = 0;
            string nombreM = null;
            var products = productos.listaProductos.Select(x => x.precio).Max();
            foreach (var item in productos.listaProductos)
            {
                //Console.WriteLine($"cod = {item.cod} nombre = {item.nombre} precio = {item.precio} cantidad = {item.cantidad}");
                if (precioM < item.precio)
                {
                    precioM = item.precio;
                    nombreM = item.nombre;
                }




            }
            Console.WriteLine($"el producto mas caro es la {nombreM} con un valor de : {precioM} ");

        }

        private static void ValorBodega(Producto productos)
        {

            int valorTotal;
            List<int> listaPrecios = new List<int>();

            foreach (var item in productos.listaProductos)
            {
                valorTotal = item.precio * item.cantidad;
                listaPrecios.Add(valorTotal);

            }
            int valorBodega = listaPrecios.Sum();

            Console.WriteLine($"El valor total de la bodega es {valorBodega}");
        }

        private static void IngresoTotalxVentas(Item items, Producto productos)
        {

            List<int> listaPrecios = new List<int>();
            foreach (var i in items.listaItems)
            {
                var product = productos.listaProductos.FirstOrDefault(x => x.cod == i.cod);
                int total = i.cantidad * product.precio;
                listaPrecios.Add(total);
            }
            Console.WriteLine($"ingreso total por ventas es de {listaPrecios.Sum()}");
        }

        private static void ProductoIngreso(Item items, Producto productos)
        {
            
            var tupleList = new List<Tuple<int, string>>();
            foreach (var i in items.listaItems)
            {
                
                var product = productos.listaProductos.FirstOrDefault(x => x.cod == i.cod);

                var total = i.cantidad * product.precio;
                var nombre = product.nombre;

                tupleList.Add(Tuple.Create(total, nombre));

            }
            Console.WriteLine($"el producto con mas ingresos es el {tupleList.Max().Item2}");
        }

        private static void ClientePago (Item items, Producto productos, Cliente clientes)
        {


        }
    }
}
