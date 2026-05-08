using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*3. Confeccionar una clase para administrar los días que han faltado los 3 empleados de una empresa.
        Definir un vector de 3 elementos de tipo string para cargar los nombres y una matriz
        irregular para cargar los días que han faltado cada empleado (cargar el número de día que
        faltó)
        Cada fila de la matriz representa los días de cada empleado.
        a. Mostrar los empleados con la cantidad de inasistencias.
        b. Cuál empleado faltó menos días.*/
    internal class Calendario
    {

        private string[] nombres;
        private string[][] faltas;

        public void cargar()
        {
            nombres = new string[3];
            faltas = new string[3][];

            for(int i = 0; i < nombres.Length; i++)
            {
                Console.Write($"Ingrese el nombre del {i + 1}° empleado: ");
                nombres[i] = Console.ReadLine();
                Console.Write($"Ingrese la cantidad de faltas que tuvo {nombres[i]}: ");
                int cant = int.Parse(Console.ReadLine());
                faltas[i] = new string[cant];      
                for(int j = 0; j<cant; j++)
                {
                    Console.Write($"Ingrese la fecha de la {j + 1}° falta: ");
                    faltas[i][j] = Console.ReadLine();
                }
            }
        }


        public void imprimir()
        {
            for(int i = 0; i < faltas.Length; i++)
            {
                Console.WriteLine($"\nEl empleado {nombres[i]} tuvo {faltas[i].Length} faltas en las fechas:");
                for(int k = 0; k < faltas[i].Length; k++)
                {
                    Console.WriteLine(faltas[i][k]);
                }
                Console.WriteLine();
            }
        }

        public void menosFal()
        {
            int min = faltas[0].Length;
            for(int i = 0; i<faltas.Length; i++)
            {
                if(min > faltas[i].Length)
                {
                    min = faltas[i].Length;
                }
            }
            Console.WriteLine("\n*** El/Los empleados con menos faltas son: ***");
            for(int j = 0; j < faltas.Length; j++)
            {
                if(min == faltas[j].Length)
                {
                    Console.WriteLine($"{nombres[j]} con {faltas[j].Length}");
                }
            }
        }
        static void Main(string[] args)
        {
            Calendario c1 = new Calendario();
            c1.cargar();
            c1.imprimir();
            c1.menosFal();

            Console.ReadKey();
        }
    }
}
