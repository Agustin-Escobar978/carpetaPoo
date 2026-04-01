using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Empleado
    {
        /*3. Confeccionar una clase que represente un empleado. Definir como atributos su
        nombre y su sueldo. Confeccionar los métodos para la carga, otro para imprimir
        sus datos y por último uno que imprima un mensaje si debe pagar impuestos
        (si el sueldo supera a 3000).*/
        private int sueldo;
        private string nombre, sueldoIng;

        public void cargarValores() {
            Console.Write("Ingrese el nombre del empleado: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese el sueldo de " + nombre + ": ");
            sueldoIng = Console.ReadLine();
            sueldo = int.Parse(sueldoIng);
        }

        public void imprimirDatos() {
            Console.WriteLine("El nombre del empleado es: " + nombre);
            Console.WriteLine("Y su sueldo es: " + sueldo);
        }

        public void verificarImpuesto() { 
            if(sueldo > 3000)
            {
                Console.WriteLine("Debido al alto sueldo le corresponde pagar impuestos");
            }
        }
        static void Main(string[] args)
        {
            Empleado emp1 = new Empleado();
            emp1.cargarValores();
            emp1.imprimirDatos();
            emp1.verificarImpuesto();
            Console.ReadKey();
        }
    }
}
