using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*1- Crear una matriz de 2 filas y 5 columnas. Realizar la carga de
        componentes por columna (es decir primero ingresar toda la primer
        columna, luego la segunda columna y así sucesivamente)
        Imprimir luego la matriz.*/
    internal class matriz
    {
        private int[,] mat;
        public void cargar()
        {
            mat = new int[2, 5];
            for(int c = 0; c<mat.GetLength(1); c++)
            {
                for (int f = 0; f<mat.GetLength(0); f++)
                {
                    Console.Write($"Ingrese el valor de la fila {f} y la columna {c}: ");
                    mat[f, c] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void imprimir()
        {
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.Write($"{mat[f, c]} ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            matriz m1 = new matriz();
            m1.cargar();
            m1.imprimir();

            Console.ReadKey();
        }
    }
}
