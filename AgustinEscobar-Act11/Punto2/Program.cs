using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*2. Confeccionar una clase para administrar una matriz irregular de 5 filas y 1 columna la
        primer fila, 2 columnas la segunda fila y así sucesivamente hasta 5 columnas la última fila
        (crearla sin la intervención del operador)
        Realizar la carga por teclado e imprimir posteriormente.*/
    internal class matrizI
    {
        private int[][] mat;

        public void cargar()
        {
            mat = new int[5][];
            for(int i = 0; i<mat.Length; i++)
            {
                mat[i] = new int[i + 1];
                for (int k = 0; k < mat[i].Length; k++) 
                {
                    Console.Write($"Ingresar el valor de la casilla {i} y {k}: ");
                    mat[i][k] = int.Parse(Console.ReadLine());
                }
            }
            
        }

        public void imprimir()
        {
            for(int i = 0; i<mat.Length; i++)
            {
                for(int k = 0; k < mat[i].Length; k++)
                {
                    Console.Write($"{mat[i][k]}   ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            matrizI m1 = new matrizI();
            m1.cargar();
            m1.imprimir();

            Console.ReadKey();
        }
    }
}
