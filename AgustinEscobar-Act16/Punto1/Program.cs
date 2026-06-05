using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*1. Confeccionar una clase Persona que tenga como atributos el nombre y la
        edad (definir las propiedades para poder acceder a dichos atributos). Definir
        un método para imprimirlos. Plantear una segunda clase Empleado que
        herede de la clase Persona. Añadir un atributo sueldo ( y su propiedad) y el
        método para imprimir su sueldo. Definir un objeto de la clase Persona y
        llamar a sus métodos y propiedades. También crear un objeto de la clase
        Empleado y llamar a sus métodos y propiedades.*/

    class Persona {
        protected string nombre;
        protected int edad;

        public Persona() {
            Console.Write("Ingrese el nombre de la persona: ");
            nombre = Console.ReadLine();
            Console.Write($"Ingrese la edad de {nombre}: ");
            edad = int.Parse(Console.ReadLine());
        }

        public string Nombre
        {
            set {
                nombre = value;
            }
            get {
                return nombre;
            }
        }
        public int Edad
        {
            set {
                edad = value;
            }
            get {
                return edad;
            }
        }

        public void imprimirPer() {
            Console.Write($"Nombre de la persona: {nombre}\nEdad de {nombre}: {edad}\n");
        }
    }

    class Empleado : Persona
    {
        private float sueldo; 

        public float Sueldo
        {
            set {
                sueldo = value;
            }
            get {
                return sueldo;
            }
        }

        public Empleado() {
            Console.Write($"Ingrese el sueldo de {nombre}: ");
            sueldo = float.Parse(Console.ReadLine());
        }
        public void imprimirEmp() {
            imprimirPer();
            Console.WriteLine($"Sueldo del empleado: {sueldo}\n");
        }

        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            p1.imprimirPer();

            Empleado e1 = new Empleado();
            e1.imprimirEmp();

            Console.ReadKey();
        }
    }
}
