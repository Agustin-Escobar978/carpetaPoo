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
        private string titulo;
        private string autor;
        private int paginas;

        public string Titulo
        {
            set { titulo = value; }
            get { return titulo; }
        }
        public string Autor {
            set { autor = value; }
            get { return autor; }
        }
        public int Paginas {
            set
            {
                if(value > 10)
                {
                    paginas = value;
                }
                else
                {
                    bool verificacion = false;
                    do
                    {
                        Console.Write("Ingrese una cantidad de paginas mayor a 10: ");
                        paginas = int.Parse(Console.ReadLine());
                        if(paginas > 10)
                        {
                            verificacion = true;
                        }
                        else
                        {
                            verificacion = false;
                        }
                    } while (verificacion == false);
                }
            }
            get { return paginas; }
        }

        public Libro()
        {
            Console.Write("Ingres el titulo del libro: ");
            Titulo = Console.ReadLine();
            Console.Write($"Ingrese el autor de {Titulo}: ");
            Autor = Console.ReadLine();
            Console.Write($"Ingrese la cantidad de paginas de {Titulo}: ");
            Paginas = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
    }
}
