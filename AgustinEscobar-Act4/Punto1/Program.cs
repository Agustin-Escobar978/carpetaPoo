using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y $500, realizar un programa que lea los sueldos que cobra cada empleado e
            informe cuántos empleados cobran entre $100 y $300 y cuántos cobran más de $300. Además el programa deberá informar el importe que gasta la empresa
            en sueldos al personal.*/
            int sueldo, empleados, cant1, cant2, gastoT, i;
            string sueldoIng, empleadosIng;

            Console.Write("Escribir la cantidad de empleados: ");
            empleadosIng = Console.ReadLine();
            empleados = int.Parse(empleadosIng);

            cant1 = 0;
            cant2 = 0;
            gastoT = 0;
            i = 0;

            while (i < empleados)
            {
                Console.Write("Escribe el sueldo que cobra el empleado: ");
                sueldoIng = Console.ReadLine();
                sueldo = int.Parse(sueldoIng);

                gastoT += sueldo;
                if(sueldo >= 100 && sueldo <= 300)
                {
                    cant1++;
                }
                else
                {
                    if(sueldo > 300)
                    {
                        cant2++;
                    }
                }

                i++;
            }

            Console.Write("La cantidad de empleados que cobran entre 100 y 300 es: ");
            Console.WriteLine(cant1);
            Console.Write("La cantidad de empleados que cobran mas de 300 es: ");
            Console.WriteLine(cant2);
            Console.Write("La cantidad de dinero que gasta la empresa en sueldos es: ");
            Console.WriteLine(gastoT);
            Console.ReadKey();
        }
    }
}
