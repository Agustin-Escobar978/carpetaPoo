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
        private int[] posMax;
        private int[] posMin;

        public void cargar()
        {
            nombres = new string[6];
            notas = new int[6];
            string datoIng;

            for (int i = 0; i<nombres.Length; i++) {
                Console.Write($"Ingrese el nombre del {i + 1}° alumno: ");
                nombres[i] = Console.ReadLine();
                Console.Write($"Ingrese la nota de {nombres[i]}: ");
                datoIng = Console.ReadLine();
                notas[i] = int.Parse(datoIng);
            }
        }

        public void maxymin()
        {
            int max = 0, min = notas[0], cantMax = 0, cantMin = 0, a = 0, b = 0;
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
            for (int j = 0; j < nombres.Length; j++)
            {
                if (max == notas[j])
                {
                    cantMax++;
                }if(min == notas[j])
                {
                    cantMin++;
                }
            }
            posMax = new int[cantMax];
            posMin = new int[cantMin];
                for (int k = 0; k < notas.Length; k++)
                {
                    if (max == notas[k] )
                    {
                        posMax[a] = k;
                        a++;
                    }
                if (min == notas[k])
                {
                    posMin[b] = k;
                    b++;
                }
            }
            
            
            imprimir(max, min);
        }


        public void imprimir(int max, int min)
        {
            if (posMax.Length > 1)
            {
                Console.WriteLine($"la nota mas alta es {max} y los alumnos que la tienen son {posMax.Length}: ");
                for (int i = 0; i < posMax.Length; i++)
                {
                    Console.WriteLine(nombres[posMax[i]]);
                }
            }
            else
            {
                Console.WriteLine($"La nota maxima es {max} por el alumno {nombres[posMax[0]]}");
            }
            if (posMin.Length > 1)
            {
                Console.WriteLine($"la nota mas baja es {min} y los alumnos que la tienen son {posMin.Length}: ");
                for (int i = 0; i < posMin.Length; i++)
                {
                    Console.WriteLine(nombres[posMin[i]]);
                }
            }
            else
            {
                Console.WriteLine($"La nota mas baja es {min} por el alumno {nombres[posMin[0]]}");
            }
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
