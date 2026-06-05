using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*2. Plantear una clase Producto y otra clase Inventario.
        La clase Producto debe tener como atributos privados el nombre, precio y
        stock. Definir propiedades para acceder a estos atributos, asegurando que el
        stock no pueda ser negativo y el precio sea mayor a cero.
        La clase Inventario debe contener 3 objetos de la clase Producto. Definir un
        método para mostrar todos los productos ordenados de menor a mayor en
        base al precio, además, mostrar el producto más caro y más barato del
        inventario.*/

    class Producto
    {
        private string nombre;
        private float precio;
        private int stock;

        public string Nombre
        {
            set {
                nombre = value;
            }
            get {
                return nombre;
            }
        }
        public float Precio
        {
            set
            {
                if (value > 0) {
                    precio = value;
                }
            }
            get
            {
                return precio;
            }
        }
        public int Stock
        {
            set
            {
                if (value >= 0) {
                    stock = value;
                }
                
            }
            get
            {
                return stock;
            }
        }
    }

    class Inventario
    {
        Producto[] productos = new Producto[3];
        public Inventario() {
            for (int i = 0; i < productos.Length; i++) {
                productos[i] = new Producto();
                Console.Write("Ingrese el nombre del producto: ");
                productos[i].Nombre = Console.ReadLine();
                Console.Write("Ingrese el precio del producto: ");
                productos[i].Precio = float.Parse(Console.ReadLine());
                Console.Write("Ingrese el stock del producto: ");
                productos[i].Stock = int.Parse(Console.ReadLine());
                Console.WriteLine();

            }
        }

        public void imprimirOrd() {
            for (int i = 1; i < (productos.Length); i++) {
                for (int j = 0; j < productos.Length - i; j++) {
                    if (productos[j].Precio > productos[j + 1].Precio)
                    {
                        float auxP = productos[j].Precio;
                        int auxS = productos[j].Stock;
                        string auxN = productos[j].Nombre;
                        productos[j].Precio = productos[j + 1].Precio;
                        productos[.j].Nombre = productos[j + 1].Nombre;
                        productos[j].Stock = productos[j + 1].Stock;
                        productos[j + 1].Precio = auxP;
                        productos[j + 1].Nombre = auxN;
                        productos[j + 1].Stock = auxS;
                    }
                }   
            }
            Console.WriteLine("***Los productos ordenados de menor a mayor por precio***\n");
            for (int k = 0; k < productos.Length; k++) {
                Console.WriteLine($"{productos[k].Nombre} tiene un precio de: {productos[k].Precio} y un stock de: {productos[k].Stock}");
            }
        }

        public void masMenos() {
            float masB = productos[0].Precio;
            float masC = productos[0].Precio;
            for (int i = 0; i < productos.Length; i++) {
                if (masC < productos[i].Precio) {
                    masC = productos[i].Precio;
                }
                if (masB > productos[i].Precio)
                {
                    masB = productos[i].Precio;
                }
            }
            Console.WriteLine("\n***El/los producto mas barato es***\n");
            for (int j = 0; j < productos.Length; j++) {
                if (masB == productos[j].Precio) {
                    Console.WriteLine($"{productos[j].Nombre} con un precio de {productos[j].Precio}");
                }
            }
            Console.WriteLine("\n***El/los producto mas caro es***\n");
            for (int j = 0; j < productos.Length; j++)
            {
                if (masC == productos[j].Precio)
                {
                    Console.WriteLine($"{productos[j].Nombre} con un precio de {productos[j].Precio}");
                }
            }
        }

        static void Main(string[] args)
        {
            Inventario i1 = new Inventario();
            i1.imprimirOrd();
            i1.masMenos();

            Console.ReadKey();
        }
    }
}
