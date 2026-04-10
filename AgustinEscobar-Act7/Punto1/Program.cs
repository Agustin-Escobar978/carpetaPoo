using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*1. Desarrollar un programa que permita ingresar un vector de 8 elementos, e informe:
        El valor acumulado de todos los elementos del vector.
        El valor acumulado de los elementos del vector que sean mayores a 36.
        Cantidad de valores mayores a 50.*/
    internal class vector8
    {
        private int[] nums;
        private int res;

        public void cargar()
        {

            nums = new int[8];
            string datoIng;

            for (int i = 0; i < 8; i++)
            {
                Console.Write($"Ingrese un valor para la posicion {i}: ");
                datoIng = Console.ReadLine();
                nums[i] = int.Parse(datoIng);
            }
        }

        public void valorAcumulado()
        {
            res = 0;
            for (int i = 0; i < 8; i++)
            {
                res += nums[i];
            }
            Console.WriteLine($"La suma de todos los numeros del vector es igual a {res}");
        }

        public void valorAcu36()
        {
            res = 0;
            for (int i = 0; i < 8; i++)
            {
                if (nums[i] > 36)
                {
                    res += nums[i];
                }
            }
            Console.WriteLine($"La suma de todos los numeros mayores a 36 es: {res}");
        }

        public void cantVal()
        {
            res = 0;
            for (int i = 0; i < 8; i++)
            {
                if (nums[i] > 50)
                {
                    res++;
                }
            }
            Console.WriteLine($"La cantidad de valores mayores a 50 son {res}");
        }

        static void Main(string[] args)
        {
            vector8 v1 = new vector8();
            v1.cargar();
            v1.valorAcumulado();
            v1.valorAcu36();
            v1.cantVal();

            Console.ReadKey();
        }
    }
}