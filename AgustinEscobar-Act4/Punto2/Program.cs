using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*2. Realizar un programa que imprima 25 términos de la serie 11 - 22 - 33 - 44, etc. (No se ingresan valores por teclado)*/
            int i, num;

            i = 0;
            num = 11;
            while (i < 25) {
                Console.Write(num + " - ");
                num += 11;
                i++;
            }
            Console.ReadKey();

        }
    }
}
