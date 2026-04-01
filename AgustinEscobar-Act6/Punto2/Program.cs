using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Cuadrado

    /*2. Desarrollar una clase que represente un Cuadrado y tenga los siguientes
         métodos: cargar el valor de su lado, imprimir su perímetro y su superficie.*/

    {
        public void cargaValor()
        {
            int lado;
            string ladoIng;

            Console.Write("Ingresa el lado de un cuadrado para conocer su perimetro y superficie: ");
            ladoIng = Console.ReadLine();
            lado = int.Parse(ladoIng);
            imprimirPerimetro(lado);
            imprimirSuperficie(lado);

        }

        public void imprimirPerimetro(int l)
        {
            int peri = l * 4;
            Console.WriteLine("El perimetro del cuadrado es: " + peri);
        }

        public void imprimirSuperficie(int l)
        {
            int super = l * l;
            Console.WriteLine("La superficie es: " + super);
        }
        static void Main(string[] args)
        {
            Cuadrado cua1 = new Cuadrado();
            cua1.cargaValor();
            Console.ReadKey();
        }
    }
}
