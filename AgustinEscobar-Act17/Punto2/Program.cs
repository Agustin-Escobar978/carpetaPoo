using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*2. Catálogo de Películas (Encapsulación, Validación y Composición)
        Plantear una clase llamada Pelicula y otra clase llamada Catalogo.
        La clase Pelicula debe tener como atributos privados: Titulo, DuracionMinutos y Calificacion
        (un puntaje del 1 al 5). Definir las propiedades necesarias para acceder a estos atributos,
        asegurando mediante validaciones lógicas que:
         La duración en minutos sea estrictamente mayor a cero (0).
         La calificación se encuentre únicamente en el rango de 1 a 5 (de lo contrario, asignar
        un valor por defecto de 1).
        La clase Catalogo debe contener internamente un vector capaz de almacenar 3 objetos de
        la clase Pelicula. Definir un método dentro de Catalogo para mostrar por pantalla todas las
        películas ordenadas de mayor a menor en base a su duración. Además, el método debe
        informar el título de la película con mejor calificación y cuál es la película más corta del
        catálogo.*/

    class Pelicula
    {
        private string titulo;
        private int duracionMinutos;
        private int calificacion;

        public string Titulo
        {
            set
            {
                titulo = value;
            }
            get
            {
                return titulo;
            }
        }
        public int DuracionMinutos
        {
            set
            {
                if (value < 0)
                {
                    bool verif = false;
                    do
                    {
                        Console.Write("Ingrese una duracion de pelicula coherente (>0): ");
                        int dur = int.Parse(Console.ReadLine());
                        if (dur > 0)
                        {
                            verif = true;
                            duracionMinutos = dur;
                        }
                        else
                        {
                            verif = false;
                        }
                    } while (verif == false);
                }
                else
                {
                    duracionMinutos = value;
                    
                }
            }
            get
            {
                return duracionMinutos;
            }
        }
        public int Calificacion
        {
            set {
                if (value >= 1 && value <= 5)
                {
                    calificacion = value;
                }
                else {
                    calificacion = 1;
                }
            }
            get
            {
                return calificacion;
            }
        }
    }

    internal class Catalogo
    {
        Pelicula[] pel = new Pelicula[3];

        public Catalogo() {
            for (int i = 0; i < pel.Length; i++)
            {
                pel[i] = new Pelicula();
                Console.Write("Ingrese el nombre de la pelicula: ");
                pel[i].Titulo = Console.ReadLine();
                Console.Write($"Ingrese la duracion de {pel[i].Titulo}: ");
                pel[i].DuracionMinutos = int.Parse(Console.ReadLine());
                Console.Write($"Ingrese la calificacion de {pel[i].Titulo} (1 a 5): ");
                pel[i].Calificacion = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
        }
        public void multipleProcesos() {
            int alta = pel[0].Calificacion;
            int dur = pel[0].DuracionMinutos;
            
            for (int i = 0; i < pel.Length; i++) {
                for (int j = 0; j < pel.Length - 1; j++) {
                    if (pel[j].DuracionMinutos < pel[j + 1].DuracionMinutos) {
                        string auxT = pel[j].Titulo;
                        int auxD = pel[j].DuracionMinutos;
                        int auxC = pel[j].Calificacion;
                        pel[j].Titulo = pel[j + 1].Titulo;
                        pel[j].DuracionMinutos = pel[j + 1].DuracionMinutos;
                        pel[j].Calificacion = pel[j + 1].Calificacion;
                        pel[j + 1].Titulo = auxT;
                        pel[j + 1].DuracionMinutos = auxD;
                        pel[j + 1].Calificacion = auxC;
                    }
                }
                if (alta < pel[i].Calificacion)
                {
                    alta = pel[i].Calificacion;
                }
                if (dur > pel[i].DuracionMinutos)
                {
                    dur = pel[i].DuracionMinutos;
                }
            }
            Console.WriteLine("***Lista de peliculas ordenadas de mayor a menor***\n");
            for (int k = 0; k < pel.Length; k++) {
                Console.WriteLine($"{pel[k].Titulo} tiene una duracion de {pel[k].DuracionMinutos} con una calificacion de: {pel[k].Calificacion}\n");
            }
            Console.WriteLine("***La/las peliculas con mas alta calificacion son***\n");
            for (int j = 0; j < pel.Length; j++)
            {
                if (alta == pel[j].Calificacion)
                {
                    Console.WriteLine($"{pel[j].Titulo} con {pel[j].Calificacion}\n");
                }
            }
            Console.WriteLine("***La/las peliculas con la duracion mas corta son***\n");
            for (int j = 0; j < pel.Length; j++)
            {
                if (dur == pel[j].DuracionMinutos)
                {
                    Console.WriteLine($"{pel[j].Titulo} con {pel[j].DuracionMinutos}");
                }
            }
        }
        static void Main(string[] args)
        {
            Catalogo c1 = new Catalogo();
            c1.multipleProcesos();


            Console.ReadKey();
        }
    }
}
