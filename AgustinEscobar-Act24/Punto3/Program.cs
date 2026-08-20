using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*
        9-Un instituto de enseñanza registra de forma dinámica a sus estudiantes para
        realizar el seguimiento académico de sus materias.
         Crear la clase Estudiante que contenga como atributos privados:
        nombreCompleto (string) y calificacion (double). Definir sus propiedades
        de solo lectura y un constructor que reciba nom y cal.
         Crear la clase GestionAcademica que administre una lista de objetos
        List.
         Métodos en GestionAcademica:
        o CargarEstudiantes(): Solicitar por teclado nombres y
        calificaciones para agregar estudiantes a la lista mediante .Add(). La
        carga finaliza cuando el usuario ingresa la palabra &quot;FIN&quot; como
        nombre.
        o ListarEstudiantes(): Mostrar en pantalla todos los alumnos
        junto a la cantidad total de inscriptos mediante la propiedad .Count.
        o FiltrarAprobados(): Recorrer la lista e imprimir en consola
        únicamente aquellos estudiantes cuya calificación sea mayor o igual
        a 6.0.
        o DarDeBaja(): Pedir al operador el nombre de un estudiante y,
        utilizando los métodos de búsqueda y remoción de listas, eliminarlo
        de la colección si se encuentra presente.
     */
    class Estudiante
    {
        private string nombreCompleto;
        private double calificacion;

        public string NombreCompleto
        {
            get { return nombreCompleto; }
        }
        public double Calificacion
        {
            get { return calificacion; }
        }

        public Estudiante(string nom, double cal)
        {
            nombreCompleto = nom;
            calificacion = cal;
        }
    }

    class GestionAcademica
    {
        List<Estudiante> estudiantes = new List<Estudiante>();

        public void cargarEstudiantes()
        {
            bool bucle = true;
            do
            {
                Console.Write("Ingrese el nombre del estudiante o 'FIN' para dejar de ingresar: ");
                string nom = Console.ReadLine();
                if (nom != "FIN")
                {
                    Console.Write($"Ingrese la  calificacion de {nom}: ");
                    double cal = double.Parse(Console.ReadLine());
                    Estudiante nuevoEstudiante = new Estudiante(nom, cal);
                    estudiantes.Add(nuevoEstudiante);
                }
                else
                {
                    bucle = false;
                }
                Console.WriteLine();
            } while (bucle == true);
        }

        public void listarEstudiantes()
        {
            for (int i = 0; i < estudiantes.Count; i++)
            {
                Console.WriteLine($"-{estudiantes[i].NombreCompleto} tiene una nota de: {estudiantes[i].Calificacion}");
            }
            Console.WriteLine($"\nEn total hay {estudiantes.Count} estudiantes inscriptos\n");
        }

        public void filtrarAprobados()
        {
            Console.WriteLine("***Alumnos aprobados***");
            for (int i = 0; i < estudiantes.Count; i++)
            {
                if (estudiantes[i].Calificacion >= 6.0)
                {
                    Console.WriteLine($"-{estudiantes[i].NombreCompleto} aprobo con {estudiantes[i].Calificacion}");
                }
            }
            Console.WriteLine();
        }

        public void darDeBaja()
        {
            Console.Write("Ingrese el nombre de un estudiante para darlo de baja: ");
            string nom = Console.ReadLine();
            for (int i = 0; i < estudiantes.Count; i++)
            {
                if (nom == estudiantes[i].NombreCompleto)
                {
                    estudiantes.Remove(estudiantes[i]);
                    Console.WriteLine("Estudiante dado de baja");
                    break;
                } else if (i == estudiantes.Count - 1)
                {
                    Console.WriteLine("Nombre no encontrado");
                }
            }
        }
    }

    class Cargar
    {
        static void Main(string[] args)
        {
            GestionAcademica ga1 = new GestionAcademica();
            ga1.cargarEstudiantes();
            ga1.listarEstudiantes();
            ga1.filtrarAprobados();
            ga1.darDeBaja();

            Console.ReadKey();
        }
    }
}
