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
    partial class Libro
    {
        public void resumen()
        {
            Console.Write($"{Titulo}:\npertenece a {Autor} y ");
            if (Paginas < 100)
            {
                Console.WriteLine($"Es corto porque tiene menos de 100 paginas => {Paginas} en total\n");
            }
            else
            {
                Console.WriteLine($"Es largo porque tiene 100 o mas paginas => {Paginas} en total\n");
            }
        }
    }
}
