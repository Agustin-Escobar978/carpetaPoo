using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{

    /*2. Una empresa registra los nombres de sus 5 vendedores y el total de ventas
        realizadas por cada uno en un mes. Cargar los nombres y ventas en dos
        vectores paralelos, ordenar los datos de mayor a menor según las ventas,
        imprimir la lista ordenada con nombre y monto de la venta, e informar quien fue
        el que menos vendió de los 5 empleados.*/
    internal class Empresa
    {
        private string[] nombres;
        private int[] ventas;
        public void cargar()
        {
            nombres = new string[5];
            ventas = new int[5];
            string datoIng;
            for(int i = 0; i<nombres.Length; i++)
            {
                Console.Write($"Ingrese el nombre del {i + 1}° vendedor: ");
                nombres[i] = Console.ReadLine();
                Console.Write($"Ingrese la cantidad de ventas que tuvo {nombres[i]} en el mes: ");
                datoIng = Console.ReadLine();
                ventas[i] = int.Parse(datoIng);
            }
        }

        public void ordenar()
        {
            string auxN;
            int auxV;
            for(int i = 0; i < ventas.Length; i++)
            {
                for (int j = 0; j<(ventas.Length - 1) - i; j++)
                {
                    if (ventas[j] < ventas[j + 1])
                    {
                        auxV = ventas[j];
                        auxN = nombres[j];
                        ventas[j] = ventas[j + 1];
                        nombres[j] = nombres[j + 1];
                        ventas[j + 1] = auxV;
                        nombres[j + 1] = auxN;
                    }
                }
            }
        }

        public void imprimir()
        {
            Console.WriteLine("*** Orden de mayor a menor segun cantidad de ventas ***");
            for(int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"{nombres[i]}-----{ventas[i]}");
            }
            if (ventas[ventas.Length - 1] == ventas[ventas.Length - 2])
            {
                int j = 0;
                Console.WriteLine($"Los vendedores que menos vendieron fueron: ");
                do
                {
                    j++;
                    Console.WriteLine(nombres[(nombres.Length - j)]);
                } while (ventas[ventas.Length - j] == ventas[(ventas.Length - j) - 1]);
            }
            else
            {
                Console.WriteLine($"El vendedor que menos vendio fue: {nombres[(nombres.Length - 1)]}");
            }
            
        }

        static void Main(string[] args)
        {
            Empresa mes1 = new Empresa();
            mes1.cargar();
            mes1.ordenar();
            mes1.imprimir();

            Console.ReadKey();
        }
    }
}
