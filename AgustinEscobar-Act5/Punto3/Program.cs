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
            /*3. Se realiza la carga de 10 valores enteros por teclado. Se desea conocer:
                a) La cantidad de valores ingresados negativos.
                b) La cantidad de valores ingresados positivos.
                c) La cantidad de múltiplos de 15.
                d) El valor acumulado de los números ingresados que son pares.*/

            int num, i, cantP = 0, cantN = 0, cantMul = 0, sumP = 0, res;
            string numIng;

            for(i = 1; i <= 10; i++)
            {
                Console.Write("Ingresa el numero " + i + ": ");
                numIng = Console.ReadLine();
                num = int.Parse(numIng);

                if(num > 0)
                {
                    cantP++;
                }
                else
                {
                    if(num < 0)
                    {
                        cantN++;
                    }
                }
                res = num % 15;
                if (res == 0) {
                    cantMul++;
                }
                res = num % 2;
                if (res == 0) {
                    sumP += num;
                }
            }
            Console.WriteLine("Los numeros positivos ingresados es: " + cantP);
            Console.WriteLine("Los numeros negativos ingresados es: " + cantN);
            Console.WriteLine("La cantidad de multiplos de 15 ingresados es: " + cantMul);
            Console.WriteLine("La suma de los valores pares es: " + sumP);

            Console.ReadKey();
        }
    }
}
