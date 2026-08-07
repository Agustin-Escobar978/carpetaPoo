using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*
        1- En un servidor de red, las solicitudes de impresión se procesan dinámicamente en orden de llegada.
         Crear la clase Documento que contenga como atributos privados:
            nombreArchivo (string) y cantidadPaginas (int). Definir sus
            propiedades de solo lectura y un constructor que reciba los parámetros nom y pag.
         Crear la clase ServidorImpresion que administre una lista dinámica de
            documentos (List&lt;Documento&gt;).
         Métodos en ServidorImpresion:
            1. AgregarDocumento(): Solicitar por teclado los datos de un
            documento y agregarlo al final de la lista utilizando .Add().
            2. ImprimirSiguiente(): Si la lista no está vacía, simular la
            impresión del primer documento de la lista (mostrar sus datos en
            consola) y removerlo de la colección mediante .RemoveAt(0). Si está
            vacía, advertir que no hay trabajos pendientes.
            3. MostrarColaPendiente(): Listar todos los documentos que
            están esperando ser impresos y la cantidad total de páginas
            acumuladas en la cola de espera utilizando .Count.
     */
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
            for(int i = 0; i < documentos.Count; i++)
            {
                Console.WriteLine($"- {documentos[i].NombreArchivo}");
                paginasTotales += documentos[i].CantidadPaginas;
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
