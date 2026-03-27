using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Confeccionar un programa que permita ingresar un valor del 1 al 10 y nos muestre la tabla de multiplicar del mismo (los primeros 13 términos)
            Ejemplo: Si ingreso 3 deberá aparecer en pantalla los valores 3, 6, 9, hasta el 39.*/

            int num, numtab, i;
            string numIng;

            Console.Write("Ingrese un numero para conocer su tabla de multiplicar hasta el numero 13: ");
            numIng = Console.ReadLine();
            num = int.Parse(numIng);

            for (i = 0; i < 13; i++) {
                Console.WriteLine(num);
                num += int.Parse(numIng);
            }

            Console.ReadKey();
        }
    }
}
