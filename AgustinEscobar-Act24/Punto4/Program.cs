using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    /*
        10- Un estacionamiento medido administra el ingreso y la salida de los vehículos que
        utilizan su playa por orden de llegada.
         Crear la clase Ticket que contenga como atributos privados: patente
        (string) y horasEstadia (int). Definir sus propiedades de solo lectura y un
        constructor que reciba pat y hs.
         Crear la clase GestionEstacionamiento que administre una lista
        dinámica de tickets (List).
         Métodos en GestionEstacionamiento:
        o RegistrarIngreso(): Solicitar por teclado los datos de un ticket y
        agregarlo al final de la lista utilizando .Add().
        o ProcesarSalida(): Si la lista no está vacía, simular la salida del
        primer vehículo de la lista (mostrar sus datos en consola) y
        removerlo de la colección mediante .RemoveAt(0). Si está vacía,
        advertir que no hay vehículos esperando salida.
        o MostrarVehiculosEstacionados(): Listar todos los vehículos
        alojados en la playa y la cantidad total de unidades presentes
        utilizando la propiedad .Count.
     */
    class Ticket
    {
        private string patente;
        private int horasEstadia;

        public string Patente
        {
            get { return patente; }
        }
        public int HorasEstadia
        {
            get { return horasEstadia; }
        }

        public Ticket(string pat, int hs)
        {
            patente = pat;
            horasEstadia = hs;
        }
    }

    class GestionEstacionamiento
    {
        List<Ticket> tickets = new List<Ticket>();

        public void registrarIngreso()
        {
            Console.Write("Ingrese la patente del vehiculo: ");
            string pat = Console.ReadLine();
            Console.Write("Ingrese las horas de estadias del vehiculo: ");
            int hs = int.Parse(Console.ReadLine());
            Ticket nuevoTicket = new Ticket(pat, hs);
            tickets.Add(nuevoTicket);
            Console.WriteLine();
        }

        public void procesarSalida()
        {
            int cantidad = tickets.Count;
            if (cantidad == 0)
            {
                Console.WriteLine("No hay vehiculos esperando salir\n");
            }
            else
            {
                Console.WriteLine($"-{tickets[0].Patente} con {tickets[0].HorasEstadia} hs a salido del estacionamiento\n");
                tickets.RemoveAt(0);
            }
        }

        public void MostrarVehiculosEstacionados()
        {
            Console.WriteLine("***Lista de vehiculos estacionados***\n");
            for (int i = 0; i < tickets.Count; i++)
            {
                Console.WriteLine($"-{tickets[i].Patente} con {tickets[i].HorasEstadia} hs");
            }
            Console.WriteLine($"\nEl estacionamiento cuenta con {tickets.Count} vehiculos estacionados\n");
        }
    }

    class Cargar
    {
        static void Main(string[] args)
        {
            GestionEstacionamiento ge1 = new GestionEstacionamiento();
            ge1.procesarSalida();
            ge1.registrarIngreso();
            ge1.registrarIngreso();
            ge1.registrarIngreso();
            ge1.MostrarVehiculosEstacionados();
            ge1.procesarSalida();
            ge1.MostrarVehiculosEstacionados();

            Console.ReadKey();
        }
    }
}
