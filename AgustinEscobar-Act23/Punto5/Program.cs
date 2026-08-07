using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto5
{
    /*  5-Un taller mecánico automatizado administra la recepción y egreso de automóviles
        que se encuentran en el sector de reparaciones.
         Crear la clase Vehiculo que contenga como atributos privados: patente
        (string) y costoReparacion (double). Definir sus propiedades
        correspondientes y un constructor que reciba pat y costo.
         Crear la clase GestionTaller que administre una lista de objetos List.
         Métodos en GestionTaller:
        o IngresarVehiculo(): Solicitar por teclado la patente y el costo de
        reparación de un vehículo para agregarlo a la lista mediante .Add().
        o BuscarVehiculo(): Pedir al operador que ingrese una patente y,
        recorriendo la lista, informar si el vehículo está en el taller y mostrar
        su costo asociado.
        o EntregarVehiculo(): Solicitar una patente por teclado, buscar el
        vehículo en la lista y, si existe, removerlo de la colección mediante
        .Remove() confirmando la entrega del automóvil.

        o CalcularRecaudacionPendiente(): Listar los vehículos
        actualmente en reparación, la cantidad total de unidades alojadas en
        el taller mediante la propiedad .Count y la suma total acumulada por
        cobrar.*/

    class Vehiculo
    {
        private string patente;
        private double costoReparacion;

        public string Patente
        {
            get { return patente; }
        }
        public double CostoReparacion
        {
            get { return costoReparacion; }
        }

        public Vehiculo(string pat, double costo)
        {
            patente = pat;
            costoReparacion = costo;
        }
    }

    class GestionTaller
    {
        List<Vehiculo> vehiculos = new List<Vehiculo>();

        public void ingresarVehiculo()
        {
            Console.Write("Ingrese la patente del vehiculo para añadirlo al taller: ");
            string patente = Console.ReadLine();
            Console.Write($"Ingrese el costo de reparacion del vehiculo con la patente {patente}: ");
            double costo = double.Parse(Console.ReadLine());
            Vehiculo nuevoVehiculo = new Vehiculo(patente, costo);
            vehiculos.Add(nuevoVehiculo);
            Console.WriteLine();
        }

        public void buscarVehiculo()
        {
            Console.Write("Ingrese una patente para saber si esta en el taller: ");
            string texto = Console.ReadLine();
            bool existe = false;
            double abonado = 0;
            foreach (Vehiculo veh in vehiculos)
            {
                if(texto == veh.Patente)
                {
                    existe = true;
                    abonado = veh.CostoReparacion;
                }
            }
            if (existe)
            {
                Console.WriteLine($"El vehiculo esta en el taller y debe abonar {abonado}\n");
            }
            else
            {
                Console.WriteLine("El vehiculo no esta en el taller\n");
            }
        }

        public void entregarVehiculo()
        {
            Console.Write("Ingrese la patente del vehiculo para hacer su entrega: ");
            string texto = Console.ReadLine();
            bool existe = false;
            foreach (Vehiculo veh in vehiculos)
            {
                if(veh.Patente == texto)
                {
                    existe = true;
                    Console.WriteLine("El vehiculo fue entregado con exito\n");
                    vehiculos.Remove(veh);
                    break;
                }
            }
            if (!existe)
            {
                Console.WriteLine("El vehiculo ingresado no se encuentra en el taller\n");
            }
        }

        public void calcularRecaudacionPendiente()
        {
            Console.WriteLine("***Listado de vehiculos y total recibido***\n");
            double total = 0;
            foreach(Vehiculo veh in vehiculos)
            {
                Console.WriteLine($"- {veh.Patente} abona {veh.CostoReparacion}");
                total += veh.CostoReparacion;
            }
            Console.WriteLine($"\nEn total el taller cuenta con un total de {vehiculos.Count} vehiculos\nPor todos los vehiculos en reparacion el taller va a recibir {total}$\n");

        }
    }


    class Cargar
    {
        static void Main(string[] args)
        {
            GestionTaller gt1 = new GestionTaller();
            gt1.ingresarVehiculo();
            gt1.ingresarVehiculo();
            gt1.ingresarVehiculo();
            gt1.buscarVehiculo();
            gt1.entregarVehiculo();
            gt1.calcularRecaudacionPendiente();

            Console.ReadKey();
        }
    }
}
