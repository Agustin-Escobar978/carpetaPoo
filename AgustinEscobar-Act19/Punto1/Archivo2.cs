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
        public int pagoT()
        {
            int tipoP = 0;
            if (TipoHabitacion == "Simple") {
                tipoP = 5000;
            }
            else if(TipoHabitacion == "Doble")
            {
                tipoP = 8000;
            }else if(TipoHabitacion == "Suite")
            {
                tipoP = 12000;
            }
            int total = tipoP * CantidadNoches;
            return total;
        }
    }
}
