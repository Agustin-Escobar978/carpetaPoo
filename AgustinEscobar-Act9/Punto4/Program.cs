using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    /*4. Se realiza una evaluación a 6 docentes por parte de sus alumnos. Se registran
        sus nombres y puntajes promedio obtenidos (de 1 a 10).
        Cargar sus datos en vectores paralelos, mostrar docente con calificación más
        alta y más baja, ordenar los vectores de mayor a menor de acuerdo con la
        calificación y mostrar en pantalla la cantidad de docentes que aprobaron y
        desaprobaron (tomando como base que se aprueba con una nota mayor o igual
        a 6)*/
    internal class Evaluacion
    {
        private string[] nombres;
        private int[] notas;

        public void cargar()
        {
            nombres = new string[6];
            notas = new int[6];
            string datoIng;
            for(int i = 0; i<nombres.Length; i++)
            {
                Console.Write($"Ingrese el nombre del {i + 1}° docente: ");
                nombres[i] = Console.ReadLine();
                Console.Write($"Ingrese el puntaje de {nombres[i]}: ");
                datoIng = Console.ReadLine();
                notas[i] = int.Parse(datoIng);
            }
        }
        public void ordenar()
        {
            string auxN;
            int auxP, k = 0;
            for (int i = 0; i<notas.Length ; i++)
            {
                for (int j = 0; j<(notas.Length - 1) - i; j++) {
                    if (notas[j] < notas[j + 1])
                    {
                        auxN = nombres[j];
                        auxP = notas[j];
                        nombres[j] = nombres[j + 1];
                        notas[j] = notas[j + 1];
                        nombres[j + 1] = auxN;
                        notas[j + 1] = auxP;
                    }
                }
            }
            Console.WriteLine("***El/Los docentes con la calificacion mas alta son: ***");
            do
            {
                Console.WriteLine($"{nombres[k]} con {notas[k]}");
                k++;
            } while (notas[k - 1] == notas[k] && k < notas.Length - 1);
            Console.WriteLine("***El/Los docentes con la calificacion mas bajas son: ***");
            k = 0;
            do
            {
                k++;
                Console.WriteLine($"{nombres[nombres.Length - k]} con {notas[notas.Length - k]}");
            } while (notas[notas.Length - k] == notas[(notas.Length - k) - 1] && k < notas.Length - 1);
        }

        public void verificar()
        {
            int cant = 0;
            if (notas[0] < 6)
            {
                Console.WriteLine("***Ningun docente supero los 6 puntos***");
            }
            else
            {
                Console.WriteLine("***El/Los docentes que aprobaron fueron***");
                for (int i = 0; i < notas.Length; i++)
                {
                    if (notas[i] >= 6)
                    {
                        Console.WriteLine(nombres[i]);
                        cant++;
                    }
                }
                Console.WriteLine($"dando una cantidad de {cant}");
            }
           
        }

        static void Main(string[] args)
        {
            Evaluacion eva1 = new Evaluacion();
            eva1.cargar();
            eva1.ordenar();
            eva1.verificar();

            Console.ReadKey();
        }
    }
}
