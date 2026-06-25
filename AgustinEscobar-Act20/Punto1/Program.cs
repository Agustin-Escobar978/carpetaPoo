using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*Actividad 1: Sistema de control de vuelos
        Problema:
        Una aerolínea administra los vuelos programados mediante un sistema orientado a
        objetos.
        Plantear una clase base Vuelo que contenga como propiedades: número de vuelo,
        destino y duración en horas. Luego definir una clase derivada VueloInternacional que
        herede de Vuelo e incluya una propiedad adicional llamada paisDestino.
        Crear una lista de objetos de tipo VueloInternacional, cargar 5 vuelos con sus datos
        desde consola y luego:
             Mostrar los vuelos registrados y el país de destino.
             Informar cuál es el vuelo con mayor duración.
             Mostrar el orden de ejecución de los constructores.*/ 
    class Vuelo
    {
        private int numeroVuelo;
        private string destino;
        private int duracionHoras;

        public int NumeroVuelo
        {
            get { return numeroVuelo;  }
        }
        public string Destino
        {
            get { return destino;  }
        }
        public int DuracionHoras
        {
            get { return duracionHoras; }
        }

        public Vuelo(int nv, string d, int dh)
        {
            numeroVuelo = nv;
            destino = d;
            duracionHoras = dh;
        }

    }

    class VueloInternacional : Vuelo
    {
        private string paisDestino;

        public string PaisDestino
        {
            get { return paisDestino;  }
        }

        public VueloInternacional(int nv, string d, int dh, string pd) : base(nv, d, dh)
        {
            paisDestino = pd;
        }
    }

    class Cargar
    {
        List <VueloInternacional> vuelos = new List <VueloInternacional>();

        public Cargar()
        {
            Console.WriteLine("***Cargar los datos de los vuelos***\n");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese el numero de vuelo: ");
                int numeroV = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el destino del vuelo: ");
                string dest = Console.ReadLine();
                Console.Write("Ingrese la duracion del vuelo en horas: ");
                int hors = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el pais del destino: ");
                string paisD = Console.ReadLine();
                VueloInternacional vueloInt = new VueloInternacional(numeroV, dest, hors, paisD);
                vuelos.Add(vueloInt);
                Console.WriteLine();
            }
        }

        public void imprimir()
        {
            Console.WriteLine("***Los vuelos con su destino y pais***\n");
            foreach(VueloInternacional vl in vuelos)
            {
                Console.WriteLine($"{vl.NumeroVuelo} se dirige a {vl.Destino} de {vl.PaisDestino}\n");
            }
            
        }
        public void masDuracion()
        {
            int masD = vuelos[0].DuracionHoras;
            foreach(VueloInternacional vl in vuelos)
            {
                if (vl.DuracionHoras > masD)
                {
                    masD = vl.DuracionHoras;
                }
            }
            Console.WriteLine("***El/los vuelos con mas duracion***\n");
            foreach(VueloInternacional vl in vuelos)
            {
                if(masD == vl.DuracionHoras)
                {
                    Console.WriteLine($"El vuelo {vl.NumeroVuelo} con {vl.DuracionHoras}hs\n");
                }
            }
        }

        static void Main(string[] args)
        {
            Cargar c1 = new Cargar();
            c1.imprimir();
            c1.masDuracion();

            Console.ReadKey();
        }
    }
}
