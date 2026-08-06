using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    class Documento
    {
        private string nombreArchivo;
        private int cantidadPaginas;

        public string NombreArchivo
        {
            get {  return nombreArchivo; }
        }
        public int CantidadPaginas
        {
            get { return cantidadPaginas; }
        }

        public Documento(string nom, int pag)
        {
            nombreArchivo = nom;
            cantidadPaginas = pag;
        }
    }

    class ServidorImpresion
    {
        List <Documento> documentos = new List<Documento> ();

        public void agregarDocumento()
        {
            string nombre;
            int paginas;
            Console.Write("Ingrese el nombre de archivo del documento: ");
            nombre = Console.ReadLine ();
            Console.Write("Ingrese la cantidad de paginas de un documento: ");
            paginas = int.Parse(Console.ReadLine());
            Documento nuevoDocumento = new Documento(nombre, paginas);
            documentos.Add(nuevoDocumento);
            Console.WriteLine();
        }

        public void imprimirSiguiente()
        {
            if (documentos.Count == 0)
            {
                Console.WriteLine("No hay trabajos pendientes\n");
            }
            else
            {
                Console.WriteLine($"Nombre archivo: {documentos[0].NombreArchivo}\nCantidad de paginas: {documentos[0].CantidadPaginas}\n");
                documentos.RemoveAt(0);
            }
        }

        public void mostrarColaPendiente()
        {
            int paginasTotales = 0;
            foreach(Documento doc in documentos)
            {
                Console.WriteLine($"- {doc.NombreArchivo}");
                paginasTotales += doc.CantidadPaginas;
            }
            Console.WriteLine($"La cantidad total de paginas acumuladas en la cola son: {paginasTotales}");
        }
    }

    class Cargar
    {
        static void Main(string[] args)
        {
            ServidorImpresion si1 = new ServidorImpresion();
            si1.imprimirSiguiente();

            si1.agregarDocumento();
            si1.imprimirSiguiente();
            si1.imprimirSiguiente();

            si1.agregarDocumento();
            si1.agregarDocumento();
            si1.agregarDocumento();
            si1.mostrarColaPendiente();

            Console.ReadKey();
        }
    }
}
