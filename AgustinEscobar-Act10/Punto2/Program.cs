using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*2- Crear una matriz de n * m filas (cargar n y m por teclado) Intercambiar la
        primer fila con la segunda. Imprimir luego la matriz.*/
    internal class matriz2
    {
        private int[,] mat;
        public void cargar()
        {
            Console.Write("Ingrese el numero de filas de la matriz: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el numero de columnas de la matriz: ");
            int m = int.Parse(Console.ReadLine());
            mat = new int[n, m];
            
            for(int f = 0; f < mat.GetLength(0); f++)
            {
                for(int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.Write($"Ingrese el valor de la fila {f} y la columna {c}: ");
                    mat[f, c] = int.Parse(Console.ReadLine());
                }
            }

        }

        public void intercambiar()
        {
            int aux;
            for(int i = 0; i < mat.GetLength(1); i++)
            {
                aux = mat[0, i];
                mat[0, i] = mat[1, i];
                mat[1, i] = aux;
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
            matriz2 m1 = new matriz2();
            m1.cargar();
            m1.intercambiar();
            m1.imprimir();

            Console.ReadKey();
        }
    }
}
