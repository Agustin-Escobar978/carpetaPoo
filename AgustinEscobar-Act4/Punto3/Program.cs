using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*3. Realizar un programa que acumule (sume) valores ingresados por teclado hasta ingresar el 9999 (no sumar dicho valor, indica que ha finalizado la carga). 
              Imprimir el valor acumulado e informar si dicho valor es cero, mayor a cero o menor a cero.*/
            int suma, num;
            string numIng;

            suma = 0;

            do
            {
                Console.Write("Ingrese un numero por teclado: ");
                numIng = Console.ReadLine();
                num = int.Parse(numIng);

                if (num != 9999)
                {
                    suma += num;
                }
            } while (num != 9999);

            Console.WriteLine("La suma de todos los numeros es: " + suma);
            if (suma < 0) {
                Console.Write("La suma de todos los numeros es menor a 0");
            }else
            {
                if (suma == 0)
                {
                    Console.Write("La suma de todos los numeros es igual a 0");
                }
                else {
                    if (suma > 0)
                    {
                        Console.Write("La suma de todos los numeros es mayor a 0");
                    }
                }
            }
        }
    }
}
