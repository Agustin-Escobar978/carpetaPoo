using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*2. Crear una clase parcial Libro.
        En el primer archivo, declarar las propiedades Título, Autor y Páginas. Validar que la
        cantidad de páginas sea mayor a 10. Valores cargados desde consola
        En el segundo archivo, agregar un método Resumen() que muestre el título, autor y
        si el libro es corto (menos de 100 páginas) o largo.
        Desde la clase principal, cargar 2 libros y mostrar cuál es el más extenso.*/
    class Cargar
    {
        Libro[] libros = new Libro[2];

        public Cargar()
        {
            for (int i = 0; i < libros.Length; i++)
            {
                libros[i] = new Libro();
            }
            Console.WriteLine("***Libros***");
            for (int j = 0; j < libros.Length; j++) {
                libros[j].resumen();
            }
        }

        public void masExtenso()
        {
            Console.WriteLine("***El/los libro con mas pagina son***\n");
            int masP = libros[0].Paginas;
            for(int i = 0; i < libros.Length; i++)
            {
                if (masP < libros[i].Paginas)
                {
                    masP = libros[i].Paginas;
                }
            }for(int j = 0; j < libros.Length; j++)
            {
                if(masP == libros[j].Paginas)
                {
                    Console.WriteLine($"{libros[j].Titulo} con {libros[j].Paginas}\n");
                }
            }
        }

        static void Main(string[] args)
        {
            Cargar c1 = new Cargar();
            c1.masExtenso();

            Console.ReadKey();
        }
    }
}
