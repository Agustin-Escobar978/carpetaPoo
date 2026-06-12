using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*1. Personal de un Gimnasio (Herencia Simple y Propiedades)
        Confeccionar una clase llamada PersonaGimnasio que tenga como atributos privados el
        Nombre y el DNI (definir sus respectivas propiedades de lectura y escritura). Plantear un
        método para imprimir estos datos básicos.
        Luego, crear una segunda clase llamada Profesor que herede de PersonaGimnasio. Añadir
        un atributo propio llamado Especialidad (con su propiedad correspondiente) y un método
        para imprimir todos los datos del profesor (incluyendo los heredados).
        En el programa principal (Main):
         Definir un objeto de la clase PersonaGimnasio, asignar valores a sus propiedades y
        llamar a su método de impresión.
         Crear un objeto de la clase Profesor, interactuar con sus propiedades y comprobar
        que puede acceder tanto a sus métodos propios como a los de la clase base.*/
    public class PersonaGimnasio {
        private string nombre;
        private int dni;

        public string Nombre
        {
            set { 
                nombre = value; 
            }
            get {
                return nombre; 
            }
        }

        public int Dni
        {
            set {
                dni = value;
            }
            get {
                return dni;
            }
        }

        public void imprimir() {
            Console.WriteLine($"El nombre de la persona es: {nombre}\nY su dni es: {dni}");
        }

    }

    public class Profesor : PersonaGimnasio{
        private string especialidad;

        public string Especialidad
        {
            set {
                especialidad = value;
            }
            get {
                return especialidad;
            }
        }

        public void imprimirProf() {
            imprimir();
            Console.WriteLine($"La especialidad del profesor es: {especialidad}");
        }
    }

    class Cargar
    {
        static void Main(string[] args)
        {
            PersonaGimnasio p1 = new PersonaGimnasio();
            p1.Nombre = "Jose";
            p1.Dni = 2435;
            p1.imprimir();

            Profesor pr1 = new Profesor();
            pr1.Nombre = "Pepe";
            pr1.Dni = 5769;
            pr1.Especialidad = "Fuerza";
            pr1.imprimirProf();

            Console.ReadKey();
        }
    }
}
