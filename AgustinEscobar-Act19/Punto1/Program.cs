using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*1. Plantear una clase parcial ReservaHotel.
        En el primer archivo, definir las propiedades NombreCliente, CantidadNoches y
        TipoHabitacion (puede ser “Simple”, “Doble” o “Suite”), validando que la cantidad de
        noches sea mayor a 0. Estos valores son cargados desde la consola.
        En el segundo archivo, agregar un método que calcule el total a pagar según la
        habitación elegida (por ejemplo: Simple = $5000, Doble = $8000, Suite = $12000 por
        noche).
        Desde la clase principal, cargar 3 reservas y mostrar cuál cliente pagará más.*/
    class Cargar
    {
        ReservaHotel[] reservas = new ReservaHotel[3];

        public Cargar()
        {
            for (int i = 0; i < reservas.Length; i++) {
                reservas[i] = new ReservaHotel();
            }
        }
        public void masPago() {
            int masP = reservas[0].pagoT();
            for (int i = 0; i < reservas.Length; i++) {
                if(masP < reservas[i].pagoT())
                {
                    masP = reservas[i].pagoT();
                }
            }
            Console.WriteLine("***El/los clientes que mas pagan son***\n");
            for(int j = 0; j < reservas.Length; j++)
            {
                if (masP == reservas[j].pagoT()) {
                    Console.WriteLine($"{reservas[j].NombreCliente} con un total de: {masP}$");
                }
            }
        }

        static void Main(string[] args)
        {
            Cargar c1 = new Cargar();
            c1.masPago();

            Console.ReadKey();
        }
    }
}
