using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto6
{
    /*  6- Una biblioteca pública gestiona de forma digital su catálogo de obras literarias
        para organizar la consulta de ejemplares por parte de los lectores.
         Crear la clase Libro que contenga como atributos privados: titulo
        (string) y anioPublicacion (int). Definir sus propiedades de solo lectura y
        un constructor que reciba tit y anio.
         Crear la clase BibliotecaCentral que administre una lista de objetos
        List.
         Métodos en BibliotecaCentral:
        1. CargarCatalogo(): Solicitar por teclado títulos y años de
        publicación para agregar libros a la lista mediante .Add(). La carga
        finaliza cuando el usuario ingresa la palabra &quot;FIN&quot; como título.
        2. ListarCatalogo(): Mostrar en pantalla todos los libros del catálogo
        junto a la cantidad total de obras registradas mediante la propiedad
        .Count.
        3. FiltrarPorAnio(): Solicitar al usuario un año determinado e
        imprimir en consola únicamente aquellos libros cuyo año de
        publicación sea menor a dicho valor.
        4. RemoverLibro(): Pedir al usuario el título de un libro y, utilizando
        los métodos de búsqueda y remoción de listas, eliminarlo de la
        colección si se encuentra presente.*/

    class Libro
    {
        private string titulo;
        private int añioPublicacion;

        public string Titulo
        {
            get { return titulo; }
        }
        public int AñioPublicacion
        {
            get { return añioPublicacion; }
        }

        public Libro(string tit, int añio)
        {
            titulo = tit;

            añioPublicacion = añio;
        }
    }

    class BibliotecaCentral
    {

        List<Libro> libros = new List<Libro>();

        public void cargarCatalogo()
        {
            bool bucle = true;
            do
            {
                Console.Write("Ingrese el titulo del libro para agregar al catalogo o ponga *FIN* para dejar de ingresar: ");
                string titulo = Console.ReadLine();
                if (titulo == "FIN")
                {
                    bucle = false;
                }
                else {
                    Console.Write($"Ingrese el año en que se publico {titulo}: ");
                    int año = int.Parse(Console.ReadLine());
                    Libro nuevoLibro = new Libro(titulo, año);
                    libros.Add(nuevoLibro); 
                }
            } while (bucle == true);
            Console.WriteLine();
        }

        public void listarCatalogo()
        {
            Console.WriteLine("***Catalogo***\n");
            foreach(Libro lib in libros)
            {
                Console.WriteLine($"- {lib.Titulo} se publico en el {lib.AñioPublicacion}");
            }
            Console.WriteLine($"El catalogo cuenta con un total de {libros.Count} libros\n");
        }

        public void filtrarPorAñio()
        {
            Console.Write("Ingrese un año para imprimir todos los libros publicados antes: ");
            int año = int.Parse(Console.ReadLine());
            foreach (Libro lib in libros)
            {
                if(lib.AñioPublicacion < año)
                {
                    Console.WriteLine($"- {lib.Titulo} se publico en el año {lib.AñioPublicacion}");
                }
            }
            Console.WriteLine();
        }

        public void removerLibro()
        {
            Console.Write("Ingrese el titulo de un libro para eliminarlo del catalogo: ");
            string texto = Console.ReadLine();
            int existe = 0;
            foreach (Libro lib in libros)
            {
                if (texto == lib.Titulo)
                {
                    libros.Remove(lib);
                    Console.WriteLine("Eliminado con exito");
                    break;
                }
                else
                {
                    existe++;
                    if (existe == libros.Count)
                    {
                        Console.WriteLine("El libro no esta en el catalogo");
                    }
                }
            }
            Console.WriteLine();
        }
    }



    class Cargar
    {
        static void Main(string[] args)
        {
            BibliotecaCentral bc1 = new BibliotecaCentral();
            bc1.cargarCatalogo();
            bc1.listarCatalogo();
            bc1.filtrarPorAñio();
            bc1.removerLibro();
            bc1.listarCatalogo();

            Console.ReadKey();
        }
    }
}
