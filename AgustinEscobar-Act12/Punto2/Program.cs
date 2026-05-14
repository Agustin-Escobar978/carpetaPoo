using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{

    /*2. Gestión de Complejo de Cine:
        Un cine tiene 4 salas con diferentes capacidades de espectadores (la Sala 1 tiene 10
        asientos, la Sala 2 tiene 15, la Sala 3 tiene 8 y la Sala 4 tiene 12).
        ● Definir una matriz irregular de 4 filas para representar los asientos.
        ● Métodos:
        1. Inicializar la matriz con los tamaños de las salas mencionadas (sin
        intervención del operador).
        2. Crear un método de "Venta de Entradas" que permita cargar la edad del
        espectador en un asiento específico (fila y columna).
        3. Imprimir el mapa de ocupación de las salas indicando la edad del espectador
        en cada asiento.
        4. Calcular cuántos menores de edad (menos de 18 años) hay en cada sala.
        5. Informar cuál es el promedio de edad de los espectadores de todo el
        complejo.*/

    internal class Cine
    {
        private int[][] salas;

        public void Venta_de_Entradas()
        {
            salas = new int[4][];
            salas[0] = new int[10];
            salas[1] = new int[15];
            salas[2] = new int[8];
            salas[3] = new int[12];
            for (int i = 0; i < salas.Length; i++)
            {
                for(int j = 0; j < salas[i].Length; j++)
                {
                    Console.Write($"Ingrese la edad del espectador en el asiento {j + 1} de la sala {i + 1}: ");
                    salas[i][j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
        }


        public void imprimir()
        {
            for(int i = 0; i < salas.Length; i++)
            {
                Console.WriteLine($"\n\n***Mapa de la sala {i + 1}***");
                for (int j = 0; j < salas[i].Length; j++)
                {
                    Console.Write($"{salas[i][j]}  ");
                }
            }
        }

        public void menores()
        {
            for (int i = 0; i < salas.Length; i++)
            {
                int cant = 0;
                Console.Write($"\n\nLa cantidad de menores de edad de la sala {i + 1} son: ");
                for (int j = 0; j < salas[i].Length; j++)
                {
                    if (salas[i][j] < 18) 
                    {
                        cant++;
                    }
                }
                Console.Write($"{cant}\n");

            }
        }

        public void promedio()
        {
            float prom = 0;
            int div = 0;
            for (int i = 0; i < salas.Length; i++) 
            {
                for(int j = 0; j < salas[i].Length; j++)
                {
                    prom += salas[i][j];
                    div++;
                }
            }
            prom /= div;

            Console.WriteLine($"\n\nEl promedio de edad del complejo es de: {prom} años");
        }


        static void Main(string[] args)
        {
            Cine d1 = new Cine();
            d1.Venta_de_Entradas();
            d1.imprimir();
            d1.menores();
            d1.promedio();

            Console.ReadKey();
        }
    }
}
