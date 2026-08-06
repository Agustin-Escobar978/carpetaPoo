using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    class Dron
    {
        private string codigo;
        private int nivelBateria;

        public string Codigo
        {
            set { codigo = value; }
            get { return codigo; }
        }
        public int NivelBateria
        {
            set
            {
                if (value >= 0 && value <= 100 )
                {
                    nivelBateria = value;
                }
                else
                {
                    bool ciclo = true;
                    do
                    {
                        Console.Write("Ingrese un nivel de bateria valido (0 al 100): ");
                        int nuevaBateria = int.Parse(Console.ReadLine());
                        if (nuevaBateria >= 0 && nuevaBateria <= 100)
                        {
                            nivelBateria = nuevaBateria;
                            ciclo = false;
                        }
                    } while (ciclo == true);
                    Console.WriteLine();
                }
            }
            get { return nivelBateria;  }
        }

        public Dron(string cod, int bat)
        {
            Codigo = cod;
            NivelBateria = bat;
        }
    }

    class CentroControl
    {
        List<Dron> drones = new List<Dron>();

        public CentroControl()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Ingrese el codigo del {i + 1}° dron: ");
                string cod = Console.ReadLine();
                Console.Write($"Ingrese el nivel de bateria del {i + 1}° dron: ");
                int bat = int.Parse(Console.ReadLine());
                Dron nuevoDron = new Dron(cod, bat);
                drones.Add(nuevoDron);
                Console.WriteLine();
            }
        }

        public void listarFlota()
        {
            foreach(Dron dron in drones)
            {
                Console.WriteLine($"- El dron {dron.Codigo} tiene {dron.NivelBateria}% bateria");
            }
            Console.WriteLine();
        }

        public void removerDronesBajos()
        {
            drones.RemoveAll(n => n.NivelBateria <= 15);
            Console.WriteLine($"Todos los drones con bateria menor a 16% fueron eliminados");
        }

        public void mostrarDronesRestantes()
        {
            Console.WriteLine("***Flota actualizada***");
            foreach(Dron dron in drones)
            {
                Console.WriteLine($"- El dron {dron.Codigo} tiene {dron.NivelBateria}% bateria");
            }
            Console.WriteLine($"La cantidad de drones operativos ahora son: {drones.Count}");
        }
    }

    class Cargar
    {
        static void Main(string[] args)
        {
            CentroControl cc1 = new CentroControl();

            cc1.listarFlota();
            cc1.removerDronesBajos();
            cc1.mostrarDronesRestantes();

            Console.ReadKey();
        }
    }
}
