using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*1. Cargar un vector de n elementos. imprimir el menor y un mensaje si se repite dentro
        del vector.*/
    internal class vectorRep
    {
        private int[] vector;
        public void cargar()
        {
            int numIng;
            string datoIng;
            Console.Write("Ingrese la cantidad de elementos que va a tener el vector: ");
            datoIng = Console.ReadLine();
            numIng = int.Parse(datoIng);
            vector = new int[numIng];

            for(int i = 0; i < vector.Length; i++)
            {
                Console.Write($"Ingrese el valor de la posicion {i} : " );
                datoIng = Console.ReadLine();
                vector[i] = int.Parse(datoIng);
            }
        }

        public void imprimir()
        {
            int menor = vector[0];
            bool rep = false;

            for(int j = 0; j < vector.Length - 1; j++)
            {
                if (vector[j + 1] < menor)
                {
                    menor = vector[j + 1];
                }
                for (int k = 0; k < vector.Length; k++)
                {
                    if (vector[j] == vector[k] && j != k)
                    {
                        rep = true;
                    }
                }
            }
            if (rep == true)
            {
                Console.WriteLine($"Hay una repeticion de numeros");
            }
            else
            {
                Console.WriteLine($"El numero mas chico del array es el: {menor}");
            }

        }

        static void Main(string[] args)
        {
            vectorRep v1 = new vectorRep();
            v1.cargar();
            v1.imprimir();

            Console.ReadKey();
        }
    }
}
