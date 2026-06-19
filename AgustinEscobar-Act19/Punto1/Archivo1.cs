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
    partial class ReservaHotel
    {
        private string nombreCliente;
        private int cantidadNoches;
        private string tipoHabitacion;

        public string NombreCliente
        {
            set
            {
                nombreCliente = value;
            }
            get
            {
                return nombreCliente;
            }
        }
        public int CantidadNoches
        {
            set
            {
                if(value > 0)
                {
                    cantidadNoches = value;
                }
                else
                {
                    bool verificacion = false;
                    do
                    {
                        Console.Write("Ingrese una estadia correcta (>0): ");
                        cantidadNoches = int.Parse(Console.ReadLine());
                        if(cantidadNoches > 0)
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
            get
            {
                return cantidadNoches;
            }
        }
        public string TipoHabitacion
        {
            set
            {
                tipoHabitacion = value;
            }
            get { 
                return tipoHabitacion; 
            }
        }

        public ReservaHotel(){
            Console.Write("Ingrese el nombre del cliente: ");
            NombreCliente = Console.ReadLine();
            Console.Write($"Ingrese la cantidad de noches que se quedara {NombreCliente}: ");
            CantidadNoches = int.Parse(Console.ReadLine());
            Console.Write($"Ingrese el tipo de habitacion donde se quedara {NombreCliente} (Simple, Doble, Suite): ");
            TipoHabitacion = Console.ReadLine();
            Console.WriteLine();
        }
    }
}
