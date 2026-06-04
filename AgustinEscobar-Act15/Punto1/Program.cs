using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*1. Monitoreo Clínico de Pacientes
        En una sala de cuidados intensivos, se requiere realizar un seguimiento constante del ritmo
        cardíaco de los pacientes.
        ● Plantear una clase llamada Paciente que tenga como atributos privados:
            1. Nombre (de tipo string).
            2. Una matriz llamada ritmoCardiaco de tamaño 3x4 (representando los
            registros de pulsaciones tomados durante 3 días diferentes, en 4 momentos
            clave de cada día: mañana, mediodía, tarde y noche).
            3. El constructor de Paciente debe pedir su nombre y solicitar la carga por
            teclado de las 12 lecturas cardíacas.

        ● Confeccionar la clase colaboradora SalaMonitoreo que administre un vector de 3
        objetos de la clase Paciente. Su constructor debe inicializar el vector y solicitar la
        carga de los 3 pacientes. Implementar los siguientes métodos dentro de
        SalaMonitoreo:
            1. Un método que imprima la grilla de lecturas cardíacas completa de cada
            paciente organizada por día y momento.
            2. Un método que calcule e imprima el promedio de pulsaciones de cada
            paciente a lo largo de todo su monitoreo.
            3. Un método que verifique si algún paciente registró un evento de taquicardia
            severa (cualquier lectura individual que sea estrictamente mayor a 120
            pulsaciones), mostrando por consola su nombre y la lectura detectada.*/

    class Paciente
    {
        private string Nombre;
        private int[,] RitmoCardiaco;

        public Paciente()
        {
            RitmoCardiaco = new int[3, 4];
            Console.Write("Ingrese el nombre del paciente: ");
            Nombre = Console.ReadLine();
            for (int i = 0; i < RitmoCardiaco.GetLength(0); i++)
            {
                for (int j = 0; j < RitmoCardiaco.GetLength(1); j++)
                {
                    Console.Write($"Ingrese el ritmo cardiaco del {i + 1}° dia y el {j + 1}° momento del dia: ");
                    RitmoCardiaco[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

        }

        public string RetornarNom()
        {
            return Nombre;
        }

        public int[,] RetornarRit()
        {
            return RitmoCardiaco;
        }
    }

    class SalaMonitoreo
    {
        private Paciente[] pacientes = new Paciente[3];

        public SalaMonitoreo()
        {
            for (int i = 0; i < pacientes.Length; i++)
            {
                pacientes[i] = new Paciente();
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("\n***Grilla de los pacientes***");
            for (int i = 0; i < pacientes.Length; i++)
            {
                Console.WriteLine($"\n{pacientes[i].RetornarNom()} y su grilla:");
                int[,] matrizAct = pacientes[i].RetornarRit();
                for (int j = 0; j < matrizAct.GetLength(0); j++)
                {
                    Console.WriteLine($"Dia {j + 1}: ");
                    for (int k = 0; k < matrizAct.GetLength(1); k++)
                    {
                        if (k == 0)
                        {
                            Console.WriteLine($"Mañana: {matrizAct[j, k]}");
                        }
                        else if (k == 1)
                        {
                            Console.WriteLine($"Mediodia: {matrizAct[j, k]}");
                        }
                        else if (k == 2)
                        {
                            Console.WriteLine($"Tarde: {matrizAct[j, k]}");
                        }
                        else if (k == 3)
                        {
                            Console.WriteLine($"Noche: {matrizAct[j, k]}");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }

        public void Promedio()
        {
            Console.WriteLine("***Promedio de cada paciente***");
            for (int i = 0; i < pacientes.Length; i++)
            {
                int[,] MatrizAct = pacientes[i].RetornarRit();
                float prom = 0;
                for (int j = 0; j < MatrizAct.GetLength(0); j++)
                {
                    for (int k = 0; k < MatrizAct.GetLength(1); k++)
                    {
                        prom += MatrizAct[j, k];
                    }
                }
                prom /= MatrizAct.GetLength(0) + MatrizAct.GetLength(1);
                Console.WriteLine($"El paciente {pacientes[i].RetornarNom()} tuvo un promedio de: {prom}");
            }
        }

        public void taquicardia()
        {
            Console.WriteLine("\n***Pacintes con taquicardia");
            for (int i = 0; i < pacientes.Length; i++)
            {
                int[,] MatrizAct = pacientes[i].RetornarRit();
                for (int j = 0; j < MatrizAct.GetLength(0); j++)
                {
                    for (int k = 0; k < MatrizAct.GetLength(1); k++)
                    {
                        if (MatrizAct[j, k] > 120)
                        {
                            Console.WriteLine($"{pacientes[i].RetornarNom()} tuvo taquicardia severa con una pulsacion de {MatrizAct[j, k]}");
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            SalaMonitoreo sm1 = new SalaMonitoreo();
            sm1.Imprimir();
            sm1.Promedio();
            sm1.taquicardia();


            Console.ReadKey();
        }
    }
}