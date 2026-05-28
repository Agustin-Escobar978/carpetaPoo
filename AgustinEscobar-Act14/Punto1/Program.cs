using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*1. El Sistema de Peaje.
        Plantear una clase llamada Vehiculo y otra clase llamada CabinaPeaje.
        La clase Vehiculo debe tener los siguientes atributos privados:
        Patente (de tipo string).
        Tipo (puede ser "Auto", "Camion" o "Moto").
        Tarifa (un valor decimal que representa el costo de su pase).
        El constructor de Vehiculo debe solicitar y cargar estos tres datos por teclado.
        La clase CabinaPeaje debe tener como atributos privados:
        El número o identificador de la cabina.
        Tres objetos de la clase Vehiculo (que representan los últimos 3 vehículos que pagaron en esa cabina).
        Definir en la clase CabinaPeaje un constructor para inicializar su identificador y solicitar la carga de los 3 vehículos. Además, implementar los 
        siguientes métodos dentro de CabinaPeaje:
        Un método que imprima la patente y el tipo de los 3 vehículos registrados en la cabina.
        Un método que calcule y muestre la recaudación total acumulada por esos 3 vehículos.
        Un método que muestre la patente del vehículo que pagó la tarifa más cara.
*/
    class Vehiculo
    {
        private string Patente;
        private string Tipo;
        private float Tarifa;

        public Vehiculo()
        {
            Console.Write("\nIngrese la patente del vehiculo: ");
            Patente = Console.ReadLine();
            Console.Write($"Ingrese el tipo de vehiculo con la patente {Patente}: ");
            Tipo = Console.ReadLine();
            Console.Write($"La tariafa que pago el vehiculo con la patente {Patente}: ");
            Tarifa = float.Parse(Console.ReadLine());
        }

        public string RetornarPat()
        {
            return Patente;
        }

        public string RetornarTip() {
            return Tipo;
        }

        public float RetornarTar() {
            return Tarifa;
        }
    }


    class CabinaPeaje {
        private int IdCabina;
        Vehiculo[] Vehiculos = new Vehiculo[3];

        public CabinaPeaje() {
            Console.Write("Ingrese el id de la cabina: ");
            IdCabina = int.Parse(Console.ReadLine());
            for (int i = 0; i < Vehiculos.Length; i++) {
                Vehiculos[i] = new Vehiculo();
            }
        }

        public void Imprimir(){
            for (int i = 0; i < Vehiculos.Length; i++) {
                Console.WriteLine($"\nEl {i + 1}° Vehiculo tiene la patente: {Vehiculos[i].RetornarPat()} y es de tipo {Vehiculos[i].RetornarTip()}");
            }
        }

        public void Recaudacion() {
            float Recau = 0;
            for (int i = 0; i < Vehiculos.Length; i++) {
                Recau += Vehiculos[i].RetornarTar();
            }
            Console.WriteLine($"\nLa recaudacion total es de: {Recau}");
        }

        public void TarifaCara() {
            float max = Vehiculos[0].RetornarTar();
            float TarifaAct = max;
            for (int i = 0; i < Vehiculos.Length; i++) {
                TarifaAct = Vehiculos[i].RetornarTar();
                if (max < TarifaAct) {
                    max = TarifaAct;
                }
            }
            Console.WriteLine("\n***La/las patente que pago mas tarifa son***");
            for (int j = 0; j < Vehiculos.Length; j++) {
                if (max == Vehiculos[j].RetornarTar()) {
                    Console.WriteLine($"\n{Vehiculos[j].RetornarPat()} con {max}");
                }
            }
        }

        static void Main(string[] args)
        {
            CabinaPeaje cabina1 = new CabinaPeaje();
            cabina1.Imprimir();
            cabina1.Recaudacion();
            cabina1.TarifaCara();

            Console.ReadKey();
        }
    }
    
        
    
}
