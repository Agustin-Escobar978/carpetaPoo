using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*3. Cargar un vector de n elementos de tipo entero. Ordenar posteriormente el vector
        (el orden lo pueden elegir ustedes).*/
    internal class vectorOrd
    {
        private int[] vector;
        public void cargar()
        {
            int numIng;
            string datoIng;
            Console.Write("Ingrese el largo del vector: ");
            datoIng = Console.ReadLine();
            numIng = int.Parse(datoIng);
            vector = new int[numIng];

            for (int k = 0; k<vector.Length; k++)
            {
                Console.Write($"Ingrese el {k + 1}° elemento: ");
                datoIng = Console.ReadLine();
                vector[k] = int.Parse(datoIng);
            }
        }

        public void ordenar()
        {
            for (int i = 0; i < vector.Length; i++) {
                for(int j = 0; j < (vector.Length - 1) - i; j++)
                {
                    if (vector[j] < vector[j + 1])
                    {
                        int aux = vector[j];
                        vector[j] = vector[j + 1];
                        vector[j + 1] = aux;
                    }
                }
            }
        }

        public void imprimir()
        {
            Console.WriteLine("Vector ordenado de mayor a menor");
            for(int i = 0; i<vector.Length; i++)
            {
                Console.WriteLine(vector[i]);
            }
        }

        static void Main(string[] args)
        {
            vectorOrd v = new vectorOrd();
            v.cargar();
            v.ordenar();
            v.imprimir();

            Console.ReadKey();
        }
    }
}
