using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Punto1
{
    /*1. Se desea desarrollar un programa que permita registrar los nombres y las
        calificaciones de 6 estudiantes. Luego de cargar los datos, se debe mostrar el
        nombre del estudiante con la nota más alta, junto con su nota. Al igual que el
        estudiante con la nota más baja. Informar si hay estudiantes con la misma nota
        máxima o mínima.*/
    internal class School
    {
        private string[] nombres;
        private int[] notas;

        public void cargar()
        {
            nombres = new string[6];
            notas = new int[6];
            int datoIng;

            for (int i = 0; i<nombres.Length; i++) {
                Console.Write($"Ingrese el nombre del {i + 1}° alumno: ");
                nombres[i] = Console.ReadLine();
                bool verif = false;
                do
                {
                    Console.Write($"Ingrese la nota de {nombres[i]}: ");
                    datoIng = int.Parse(Console.ReadLine());
                    if(datoIng > 10 || datoIng < 0)
                    {
                        Console.WriteLine("Ingrese un numero entre 0 y 10");
                    }
                    else
                    {
                        verif = true;
                    }
                    
                } while (verif == false);
                notas[i] = datoIng;

            }
        }

        public void maxymin()
        {
            int max = notas[notas.Length - 1], min = notas[0];
            for(int i = 0; i < notas.Length; i++)
            {
                if(max < notas[i])
                {
                    max = notas[i];
                }if(min > notas[i])
                {
                    min = notas [i];
                }
            }
                            
            imprimir(max, min);
        }


        public void imprimir(int max, int min)
        {
            int cont = 0;
            Console.WriteLine("***El/los alumnos con la nota mas alta son: ***");
            for (int i = 0; i < nombres.Length; i ++) {
                if (notas[i] == max)
                {
                    Console.WriteLine($"{nombres[i]}-----{notas[i]}");
                    cont++;
                }
            }
            Console.WriteLine($"Dando un total de {cont} Estudiante/s con esa nota\n");

            cont = 0;

            Console.WriteLine("***El/los alumnos con la nota mas baja son: ***");
            for (int j = 0; j < nombres.Length; j++)
            {
                if (notas[j] == min)
                {
                    Console.WriteLine($"{nombres[j]}-----{notas[j]}");
                    cont++;
                }
            }
            Console.WriteLine($"Dando un total de {cont} Estudiante/s con esa nota");
        }
        static void Main(string[] args)
        {
            School boletin1 = new School();
            boletin1.cargar();
            boletin1.maxymin();

            Console.ReadKey();
        }
    }
}
