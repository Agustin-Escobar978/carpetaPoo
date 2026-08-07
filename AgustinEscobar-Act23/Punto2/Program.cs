using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*  2- Una empresa de logística autónoma monitorea el estado y nivel de batería de sus
        drones de entrega en vuelo de regreso a la base.
         Crear la clase Dron que contenga los atributos privados: codigo (string) y
        nivelBateria (int, de 0 a 100). Definir sus propiedades correspondientes.
        Su constructor debe recibir cod y bat.
         Crear la clase CentroControl que administre una lista de objetos
        List&lt;Dron&gt;.
         Métodos en CentroControl:
            1. Un constructor que cargue por teclado una lista inicial de 4 drones
            ingresando sus códigos y baterías.
            2. ListarFlota(): Mostrar la lista de drones en pantalla.
            3. RemoverDronesBajos(): Recorrer la lista y remover por
            completo de la flota a todos aquellos drones cuyo nivel de batería
            sea menor o igual al 15% (ya que requieren mantenimiento
            automático urgente).
            4. MostrarDronesRestantes(): Imprimir la flota actualizada y la
            cantidad de drones operativos utilizando la propiedad .Count.*/

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
            Console.WriteLine($"Todos los drones con bateria menor a 16% fueron eliminados\n");
        }

        public void mostrarDronesRestantes()
        {
            Console.WriteLine("***Flota actualizada***\n");
            foreach(Dron dron in drones)
            {
                Console.WriteLine($"- El dron {dron.Codigo} tiene {dron.NivelBateria}% bateria");
            }
            Console.WriteLine($"\nLa cantidad de drones operativos ahora son: {drones.Count}");
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
