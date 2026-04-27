using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*3- Crear una matriz de n * m filas (cargar n y m por teclado) Imprimir los
        cuatro valores que se encuentran en los vértices de la misma (mat[0][0] etc.)*/
    internal class Matriz3
    {
        private int[,] mat;

        public void cargar()
        {
            Console.Write("Ingrese la cantidad de filas de la matriz: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de columnas de la matriz: ");
            int m = int.Parse(Console.ReadLine());

            mat = new int[n, m];

            for (int f = 0; f<mat.GetLength(0); f++)
            {
                for (int c = 0; c<mat.GetLength(1); c++)
                {
                    Console.Write($"Ingrese el valor de la fila {f} y la columna {c}: ");
                    mat[f, c] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void imprimir()
        {
            for(int f = 0; f<mat.GetLength(0); f++)
            {
                for(int c = 0; c<mat.GetLength(1); c++)
                {
                    if ((f == 0 && c == 0) || (f == 0 && c == (mat.GetLength(1) - 1)) || (f == (mat.GetLength(0) - 1) && c == 0) || (f == (mat.GetLength(0) - 1) && c == (mat.GetLength(1) - 1)))
                    {
                        Console.WriteLine(mat[f, c]);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Matriz3 m1 = new Matriz3();
            m1.cargar();
            m1.imprimir();

            Console.ReadKey();
        }
    }
}
