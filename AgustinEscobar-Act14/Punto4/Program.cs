using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    /*4. Inventario de Sucursales 
        Plantear una clase llamada Articulo que tenga como atributos privados el NombreArticulo, el Precio y el StockActual. El constructor de la clase debe cargar estos atributos 
        por teclado. Confeccionar otra clase llamada Sucursal que contenga un vector de 3 objetos de la clase Articulo. El constructor de Sucursal debe pedir el nombre o número de 
        la sucursal y realizar la carga de los 3 artículos.
        Implementar en la clase Sucursal los siguientes métodos:
                Un método que imprima la lista de los artículos junto con su valor total en inventario (Precio * Stock).
                Un método que busque y muestre el nombre del artículo más caro del local.
                Un método que verifique e indique qué artículos de la sucursal requieren reposición urgente (aquellos cuyo stock sea menor o igual a 5 unidades).
    */

    class Articulo
    {
        private string NombreArticulo;
        private float Precio;
        private int StockActual;

        public Articulo()
        {
            Console.Write("\nIngrese el nombre del articulo: ");
            NombreArticulo = Console.ReadLine();
            Console.Write($"Ingrese el precio de {NombreArticulo}: ");
            Precio = float.Parse(Console.ReadLine());
            Console.Write($"Ingrese el stock actual de {NombreArticulo}: ");
            StockActual = int.Parse(Console.ReadLine());
        }

        public string RetornarNom()
        {
            return NombreArticulo;
        }

        public float RetornarPre()
        {
            return Precio;
        }

        public int RetornarStock()
        {
            return StockActual;
        }
    }

    class Sucursal
    {
        private string NombreSuc;
        Articulo[] articulos = new Articulo[3];

        public Sucursal()
        {
            Console.Write("Ingrese el nombre de la sucursal: ");
            NombreSuc = Console.ReadLine();
            for (int i = 0; i < articulos.Length; i++)
            {
                articulos[i] = new Articulo();
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("\n***Lista de articulos***");
            for (int i = 0; i < articulos.Length; i++)
            {
                Console.WriteLine($"\n{articulos[i].RetornarNom()} con un valor total de: ${articulos[i].RetornarPre() * articulos[i].RetornarStock()}");
            }
        }

        public void MasCaro(){
            Console.WriteLine("\n***El/los articulo mas caro son***");
            float Caro = articulos[0].RetornarPre();
            for (int i = 0; i < articulos.Length; i++) {
                float PrecioAct = articulos[i].RetornarPre();
                if (Caro < PrecioAct) {
                    Caro = PrecioAct;
                }
            }
            for (int j = 0; j < articulos.Length; j++) {
                if (Caro == articulos[j].RetornarPre()) {
                    Console.WriteLine(articulos[j].RetornarNom());
                }
            }
        }

        public void Reponer() {
            Console.WriteLine("\n***Articulos a reponer***");
            for (int i = 0; i < articulos.Length; i++) {
                if (articulos[i].RetornarStock() <= 5) {
                    Console.WriteLine($"{articulos[i].RetornarNom()} necesitan ser reponidos debido a que quedan {articulos[i].RetornarStock()}");
                }
            }
        }

        static void Main(string[] args)
        {
            Sucursal s1 = new Sucursal();
            s1.Imprimir();
            s1.MasCaro();
            s1.Reponer();

            Console.ReadKey();
        }
    }
}

