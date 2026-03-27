using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4. Se cuenta con la siguiente información:
                ● Las edades de 20 estudiantes del turno mañana.
                ● Las edades de 30 estudiantes del turno tarde.
                ● Las edades de 15 estudiantes del turno noche.
            Las edades de cada estudiante deben ingresarse por teclado.
                a) Obtener el promedio de las edades de cada turno (tres promedios)
                b) Imprimir dichos promedios (promedio de cada turno)
                c) Mostrar por pantalla un mensaje que indique cuál de los tres turnos tiene un promedio de edades menor.*/


            float promM, promT, promN, edad, i, suma = 0; ;
            string edadIng;

            Console.WriteLine("Turno mañana ingrese las edades: ");
            for (i = 1; i <= 20; i++)
            {
                Console.Write("Ingrese la edad del alumno " + i + ": ");
                edadIng = Console.ReadLine();
                edad = float.Parse(edadIng);
                suma += edad;
            }
            promM = suma / 20;
            Console.WriteLine("El promedio de la mañana es: " + promM);
            suma = 0;

            Console.WriteLine("Turno tarde ingrese las edades: ");
            for (i = 1; i <= 30; i++)
            {
                Console.Write("Ingrese la edad del alumno " + i + ": ");
                edadIng = Console.ReadLine();
                edad = float.Parse(edadIng);
                suma += edad;
            }
            promT = suma / 30;
            Console.WriteLine("El promedio de la tarde es: " + promT);
            suma = 0;

            Console.WriteLine("Turno Noche ingrese las edades: ");
            for (i = 1; i <= 15; i++)
            {
                Console.Write("Ingrese la edad del alumno " + i + ": ");
                edadIng = Console.ReadLine();
                edad = float.Parse(edadIng);
                suma += edad;
            }
            promN = suma / 15;
            Console.WriteLine("El promedio de la mañana es: " + promN);

            if (promM < promN && promM < promT) {
                Console.Write("El promedio de la mañana es el menor");
            }else
            {
                if (promT < promN && promT < promM)
                {
                    Console.Write("El promedio de la tarde es el menor");
                }
                else
                {
                    Console.Write("El promedio de la noche es el menor");
                }
            }
            Console.ReadKey();
        }
    }
}
