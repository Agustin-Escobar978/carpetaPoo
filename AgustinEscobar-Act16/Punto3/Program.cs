using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*3. Crear una clase base Vehículo que contenga atributos marca y velocidadMaxima.
        Definir dos clases derivadas: Auto y Moto, que hereden de Vehículo. Cada
        una debe tener un constructor que reciba los valores de los atributos base
        mediante la palabra clave base, y un atributo propio (cantidadPuertas en
        Auto, cilindrada en Moto).
        Crear un objeto de cada clase y mostrar todos sus datos por consola.*/

    class Vehiculo
    {
        protected string marca;
        protected float velocidadMaxima;


        public string Marca
        {
            set {
                marca = value;
            }
            get {
                return marca;
            }
        }
        public float VelocidadMaxima
        {
            set
            {
                velocidadMaxima = value;
            }
            get
            {
                return velocidadMaxima;
            }
        }

    }

    class Auto : Vehiculo {
        private int cantPuerta;

        public int CantPuerta {
            set {
                cantPuerta = value;
            }
            get {
                return cantPuerta;
            }
        }

        public Auto() {
            Console.Write("Ingrese la marca del auto: ");
            marca = Console.ReadLine();
            Console.Write("Ingrese la velocidad maxima del auto: ");
            velocidadMaxima = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de puertas del auto: ");
            cantPuerta = int.Parse(Console.ReadLine());
        }
    }

    class Moto : Vehiculo {
        private int cilindrada;

        public int Cilindrada {
            set {
                cilindrada = value;
            }
            get {
                return cilindrada;
            }
        }

        public Moto()
        {
            Console.Write("Ingrese la marca de la moto: ");
            marca = Console.ReadLine();
            Console.Write("Ingrese la velocidad maxima de la moto: ");
            velocidadMaxima = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de cilindradas de la moto: ");
            cilindrada = int.Parse(Console.ReadLine());
        }
    }

    class Cargar
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto();
            Console.WriteLine($"La marca del auto es: {auto1.Marca} con una velocidad maxima de {auto1.VelocidadMaxima} y {auto1.CantPuerta}\n");

            Moto moto1 = new Moto();
            Console.WriteLine($"La marca de la moto es: {moto1.Marca} con una velocidad maxima de {moto1.VelocidadMaxima} y {moto1.Cilindrada}\n");

            Console.ReadKey();
        }
    }
}
