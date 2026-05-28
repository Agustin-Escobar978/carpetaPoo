using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*2. Control de Vuelos
        Plantear una clase llamada Pasajero que tenga los atributos privados: Nombre, DNI y EquipajeKilos (peso del equipaje en kg). En su constructor, solicitar
        la carga de estos tres datos.
        Luego, confeccionar una clase llamada Vuelo que administre un vector de 4 objetos de la clase Pasajero. Su constructor debe inicializar el vector y solicitar 
        la carga por teclado de cada uno de los 4 pasajeros.
        Agregar los siguientes métodos en la clase Vuelo:
            Un método que muestre un listado completo con los datos de todos los pasajeros del vuelo.
            Un método que calcule y muestre el peso total de equipaje que transporta el avión (la suma de todos los pesos).
            Un método que informe si algún pasajero excede el límite permitido de equipaje (mayor a 23 kg), imprimiendo su nombre y su DNI.
*/
    class Pasajero{
        private string Nombre;
        private int DNI;
        private float EquipajeKilos;

        public Pasajero(){
            Console.Write("\nIngrese el nombre del pasajero: ");
            Nombre = Console.ReadLine();
            Console.Write($"Ingrese el DNI de {Nombre}: ");
            DNI = int.Parse(Console.ReadLine());
            Console.Write($"Ingrese el peso del equipaje (kg) de {Nombre}: ");
            EquipajeKilos = float.Parse(Console.ReadLine());
        }

        public string RetornarNom() {
            return Nombre;
        }

        public int RetornarDNI() {
            return DNI;
        }

        public float RetornarPeso() {
            return EquipajeKilos;
        }
    }

    class Vuelo
    {
        Pasajero[] Pasajeros = new Pasajero[4];

        public Vuelo() {
            for (int i = 0; i < Pasajeros.Length; i++)
            {
                Pasajeros[i] = new Pasajero();
            }
        }

        public void Imprimir() {
            for (int i = 0; i < Pasajeros.Length; i++) {
                Console.WriteLine($"\nEl nombre del {i + 1}° pasajero es: {Pasajeros[i].RetornarNom()}\nSu DNI es: {Pasajeros[i].RetornarDNI()}\nY su equipaje pesa: {Pasajeros[i].RetornarPeso()} Kg");
            }
        }

        public void PesoT() {
            float pesoTot = 0;
            for (int i = 0; i < Pasajeros.Length; i++) {
                pesoTot += Pasajeros[i].RetornarPeso();
            }
            Console.WriteLine($"\nEl peso total que transporta el avios es: {pesoTot} Kg");
        }

        public void Exceso() {
            Console.WriteLine("\n***Nomre y DNI de los pasajeros que superaron el limite(23Kg)***");
            for (int i = 0; i < Pasajeros.Length; i++) {
                if (Pasajeros[i].RetornarPeso() > 23) {
                    Console.WriteLine($"{Pasajeros[i].RetornarNom()} y su DNi es: {Pasajeros[i].RetornarDNI()}");
                }                
            }
        }

        static void Main(string[] args)
        {
            Vuelo v1 = new Vuelo();
            v1.Imprimir();
            v1.PesoT();
            v1.Exceso();

            Console.ReadKey();
        }
    }
}
