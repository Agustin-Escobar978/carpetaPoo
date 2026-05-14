using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*3. Academia de Gastronomía: Recetario Dinámico:
            Un chef instructor evalúa a 3 alumnos en un examen final. Cada alumno debe presentar
            una cantidad distinta de platos (uno presenta 2 platos, otro 4 y otro 3).
            ● Definir un vector para los nombres de los alumnos.
            ● Definir una matriz irregular para cargar el puntaje obtenido (0 a 100) en cada plato
            presentado.
            ● Métodos:
            1. Cargar nombres y definir el tamaño de las filas según la cantidad de platos
            de cada alumno.
            2. Cargar los puntajes de cada plato validando que estén entre 0 y 100.
            3. Mostrar el listado de alumnos y el puntaje de cada uno de sus platos.
            4. Calcular el puntaje promedio de cada alumno e informar si está "Aprobado";
            (promedio >= 70) o "Reprobado";.
            5. Determinar quién obtuvo el puntaje individual más alto en un solo plato (el
            valor máximo de la matriz).*/
    internal class Academia
    {
        private string[] nombres;
        private int[][] puntaje;

        public void cargar() {
            puntaje = new int[3][];
            puntaje[0] = new int[2];
            puntaje[1] = new int[4];
            puntaje[2] = new int[3];
            nombres = new string[3];

            for (int i = 0; i < nombres.Length; i++) {
                Console.Write($"Ingrese el nombre del {i + 1}º alumno: ");
                nombres[i] = Console.ReadLine();
                for (int j = 0; j < puntaje[i].Length; j++)
                {
                    bool verif = false;
                    do {
                        Console.Write($"Ingrese el puntaje del {j + 1}º plato de {nombres[i]}: ");
                        puntaje[i][j] = int.Parse(Console.ReadLine());
                        if (puntaje[i][j] >= 0 && puntaje[i][j] <= 100)
                        {
                            verif = true;
                        }
                        else
                        {
                            Console.WriteLine("Ingrese un numero de 0 a 100");
                            verif = false;
                        }

                    
                    } while(verif == false);
                }
                Console.WriteLine();
            }
        }

        public void imprimir() {
            Console.WriteLine("\n\n***Los alumnos y sus platos***");
            for (int i = 0; i < nombres.Length; i++) {
                Console.WriteLine($"\n{nombres[i]} hizo {puntaje[i].Length} platos:");
                for (int j = 0; j < puntaje[i].Length; j++) {
                    Console.WriteLine($"El {j + 1}º plato obtuvo un puntaje de: {puntaje[i][j]}");
                }
            }
        }

        public void promedio() {
            Console.WriteLine("\n\n***Calificacion final de los alumnos***");
            for (int i = 0; i < nombres.Length; i++) {
                double prom = 0;
                for(int j = 0; j < puntaje[i].Length; j++)
                {
                    prom += puntaje[i][j];
                }
                prom /= puntaje[i].Length;
                if (prom >= 70)
                {
                    Console.WriteLine($"\n{nombres[i]} esta Aprobado");
                }
                else{
                    Console.WriteLine($"\n{nombres[i]} esta Reprobado");
                }
                
            }
        }

        public void puntajeAlt()
        {
            int max = puntaje[0][0];
            for (int i = 0; i < nombres.Length; i++) {
                for (int j = 0; j < puntaje[i].Length; j++) {
                    if (max < puntaje[i][j]) {
                        max = puntaje[i][j];
                    }
                }
            }
            Console.WriteLine($"\n***El puntaje mas alto es {max} y lo tiene***");
            for (int k = 0; k < nombres.Length; k++) {
                for (int l = 0; l < puntaje[k].Length; l++) {
                    if (max == puntaje[k][l]) {
                        Console.WriteLine($"\n{nombres[k]} con su {l + 1}º plato");
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Academia ex1 = new Academia();
            ex1.cargar();
            ex1.imprimir();
            ex1.promedio();
            ex1.puntajeAlt();


            Console.ReadKey();
        }
    }
}
