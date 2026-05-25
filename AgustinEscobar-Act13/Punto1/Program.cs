using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*1. Confeccionar una clase que represente un empleado. Definir como atributos su
        nombre y su sueldo. En el constructor cargar los atributos y luego en otro
        método imprimir sus datos y por último uno que imprima un mensaje si debe
        pagar impuestos (si el sueldo supera a 3000)*/
    internal class Empleado
    {
        private string nombre;
        private int sueldo;

        public Empleado() {
            Console.Write("Ingrese el nombre del empleado: ");
            nombre = Console.ReadLine();
            Console.Write($"Ingresa el sueldo de {nombre}: ");
            sueldo = int.Parse(Console.ReadLine());
        }

        public void Imprimir() {
            Console.WriteLine($"\nEl nombre del empleado es: {nombre}\nSu sueldo es de: {sueldo}$");
        }

        public void Impuestos() {
            if (sueldo > 3000)
            {
                Console.WriteLine("\nEl empleado debe pagar impuestos debido a que su sueldo supero los 3000$");
            }
            else {
                Console.WriteLine("\nEl empleado no debe pagar impuestos");
            }
        }
        static void Main(string[] args)
        {
            Empleado em1 = new Empleado();
            em1.Imprimir();
            em1.Impuestos();


            Console.ReadKey();
        }
    }
}
