using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Punto3
{
    /*3. Crear una clase base Vehículo que contenga atributos marca y velocidadMaxima.
        Definir dos clases derivadas: Auto y Moto, que hereden de Vehículo. Cada
        una debe tener un constructor que reciba los valores de los atributos base
        mediante la palabra clave base, y un atributo propio (cantidadPuertas en
        Auto, cilindrada en Moto).
        Crear un objeto de cada clase y mostrar todos sus datos por consola.*/

    public class Vehiculo
    {
        protected string marca;
        protected float velocidadMaxima;

        public Vehiculo(string m, float vm) {
            marca = m;
            velocidadMaxima = vm;
        }


    }

    public class Auto : Vehiculo {
        private int cantPuerta;

        public Auto(string m, float vm, int cp) : base(m, vm){
            cantPuerta = cp;
            Console.WriteLine($"La marca del auto es: {marca} con una velocidad maxima de {velocidadMaxima} y {cantPuerta} puertas\n");
        }
    }

    public class Moto : Vehiculo {
        private int cilindrada;

        public Moto(string m, float vm, int c) : base(m, vm)
        {
            cilindrada = c;
            Console.WriteLine($"La marca de la moto es: {marca} con una velocidad maxima de {velocidadMaxima} y {cilindrada} cilindradas\n");
        }
    }

    class Cargar
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la marca del auto: ");
            string marca = Console.ReadLine();
            Console.Write("Ingrese la velocidad maxima del auto: ");
            float velocidadMaxima = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de puertas del auto: ");
            int cantPuerta = int.Parse(Console.ReadLine());
            Auto auto1 = new Auto(marca, velocidadMaxima, cantPuerta);

            Console.Write("Ingrese la marca de la moto: ");
            marca = Console.ReadLine();
            Console.Write("Ingrese la velocidad maxima de la moto: ");
            velocidadMaxima = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de cilindradas de la moto: ");
            int cilindrada = int.Parse(Console.ReadLine());
            Moto moto1 = new Moto(marca, velocidadMaxima, cilindrada);


            Console.ReadKey();
        }
    }
}
