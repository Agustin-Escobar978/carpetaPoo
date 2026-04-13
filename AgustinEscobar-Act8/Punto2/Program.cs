using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*2. Definir un vector donde almacenar los nombres de 5 países. Confeccionar el
         algoritmo de ordenamiento alfabético.*/
    internal class Paises
    {
        private string[] vector;
        public void cargar()
        {
            vector = new string[5];
            
            for(int i = 0; i<5; i++)
            {
                Console.Write($"Ingrese el nombre del {i + 1}° país: ");
                vector[i] = Console.ReadLine();
            }
        }

        public void ordenar()
        {
            string aux;
            for (int j = 0; j < 4; j++) {
                for (int i = 0; i < 4 - j; i++) {
                    if (vector[i].CompareTo(vector[i + 1]) > 0)
                    {
                        aux = vector[i];
                        vector[i] = vector[i + 1];
                        vector[i + 1] = aux;
                    }
                } 
            }
        }

        public void imprimir()
        {
            Console.WriteLine("Paises ordenados alfabeticamente:");
            for(int i = 0; i<5; i++)
            {
                Console.WriteLine(vector[i]);
            }
        }

        static void Main(string[] args)
        {
            Paises p = new Paises();
            p.cargar();
            p.ordenar();
            p.imprimir();

            Console.ReadKey();
        }
    }
}
