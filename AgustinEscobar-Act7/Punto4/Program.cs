using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    /*4. Cargar un vector de 10 elementos y verificar posteriormente si el mismo está
        ordenado de menor a mayor y de mayor a menor.*/
    internal class vectorOrd
    {
        private int[] vector;

        public void cargar()
        {
            string datoIng;
            vector = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Ingrese la posicion {i} del vector: ");
                datoIng = Console.ReadLine();
                vector[i] = int.Parse(datoIng);
            }
        }

        public void verificar()
        {
            int menor = 0, mayor = 0;
            for(int i = 0; i < 9; i++)
            {
                if (vector[i] < vector[i + 1])
                {
                    menor++;
                }
                else
                {
                    if (vector[i] > vector[i + 1])
                    {
                        mayor++;
                    }
                }
            }
            if (menor == 9)
            {
                Console.WriteLine("El vector esta ordenado de menor a mayor");
            }
            else
            {
                if (mayor == 9)
                {
                    Console.WriteLine("El vector esta ordenado de mayor a menor");
                }
                else
                {
                    Console.WriteLine("Intente ordenar el vector de menor a mayor");
                }
            }
        }
        static void Main(string[] args)
        {
            vectorOrd vec1 = new vectorOrd();
            vec1.cargar();
            vec1.verificar();

            Console.ReadKey();
        }
    }
}
