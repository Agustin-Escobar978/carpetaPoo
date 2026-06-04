using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*2. Logística de Puerto Espacial
        Una estación de acoplamiento registra el peso de los contenedores transportados en las
        bodegas de carga de las naves espaciales que llegan al puerto.
        ● Crear la clase NaveEspacial que contenga únicamente el atributo privado
        NombreNave y su constructor para cargarlo.
        ● Crear la clase colaboradora PuertoControl que contenga:
            ○ Un vector de 3 objetos de la clase NaveEspacial.
            ○ Una matriz irregular de tipo double llamado pesoContenedores, donde
            cada fila representa a una nave, el tamaño de la fila es la cantidad de
            bodegas que posee esa nave, y los valores almacenados son los pesos (en
            toneladas) de los contenedores que transporta cada bodega.

        En PuertoControl, definir los siguientes métodos:

        1. Un constructor que cargue los nombres de las 3 naves, pregunte para cada una
        cuántas bodegas activas posee (para definir el tamaño de su fila en la matriz
        irregular) y cargue el peso del contenedor asignado a cada bodega.
        2. Un método que muestre en pantalla el detalle de los pesos cargados por cada nave
        espacial.
        3. Un método que identifique e informe qué nave transporta el contenedor individual
        más pesado de todo el puerto espacial (el valor máximo absoluto de la matriz
        irregular).
        4. Un método que indique el nombre de la nave que transporta menor peso acumulado
        total (la suma de todos sus contenedores).*/

    class NaveEspacial {
        private string NombreNave;
        public NaveEspacial() {
            Console.Write("Ingrese el nombre de la nave: ");
            NombreNave = Console.ReadLine();
        }

        public string RetornarNom() {
            return NombreNave;
        }
    }

    class PuertoControl
    {
        private NaveEspacial[] naves = new NaveEspacial[3];
        private double[][] PesoContenedores;

        public PuertoControl() {
            PesoContenedores = new double[3][];
            for (int i = 0; i < naves.Length; i++) {
                naves[i] = new NaveEspacial();
                Console.Write($"Ingrese la cantidad de bodegas que tiene {naves[i].RetornarNom()}: ");
                PesoContenedores[i] = new double [int.Parse(Console.ReadLine())];
                for (int j = 0; j < PesoContenedores[i].Length; j++) {
                    Console.Write($"Ingrese el peso del contenedor (en toneladas) de la {j + 1}º bodega de {naves[i].RetornarNom()}: ");
                    PesoContenedores[i][j] = double.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }    
        }

        public void Imprimir() {
            Console.WriteLine("***Peso cargado por cada nave***\n");
            for (int i = 0; i < naves.Length; i++) {
                Console.WriteLine($"{naves[i].RetornarNom()}:");
                for (int j = 0; j < PesoContenedores[i].Length; j++) {
                    Console.Write($"{j + 1}º bodega: {PesoContenedores[i][j]}t  ");
                }
                Console.WriteLine();
            }
        }

        public void MasPesado() {
            double Max = PesoContenedores[0][0];
            for (int i = 0; i < naves.Length; i++) {
                for (int j = 0; j < PesoContenedores[i].Length; j++) {
                    if (PesoContenedores[i][j] > Max) {
                        Max = PesoContenedores[i][j];
                    }
                }
            }
            Console.WriteLine("***La/las naves con mas peso por contenedor***");
            for (int k = 0; k < naves.Length; k++) {
                for (int l = 0; l < PesoContenedores[k].Length; l++) {
                    if (Max == PesoContenedores[k][l]) {
                        Console.WriteLine($"{naves[k].RetornarNom()} en el contenedor {l + 1}");
                    }
                }
            }
        }

        public void MenosPesado() {
            double Menos = 0;
            for (int i = 0; i < naves.Length; i++)
            {
                double PesoT = 0;
                for (int j = 0; j < PesoContenedores[i].Length; j++)
                {
                    PesoT += PesoContenedores[i][j];
                }
                if (PesoT < Menos || i == 0) {
                    Menos = PesoT;
                }
            }
            Console.WriteLine("\n***La/las naves con menos pesos total son***");
            for (int k = 0; k < naves.Length; k++)
            {
                double PesoT = 0;
                for (int l = 0; l < PesoContenedores[k].Length; l++)
                {
                    PesoT += PesoContenedores[k][l];
                }
                if (PesoT == Menos) {
                    Console.WriteLine($"{naves[k].RetornarNom()} con {PesoT}t");
                }
            }
        }

        static void Main(string[] args)
        {
            PuertoControl pc1 = new PuertoControl();
            pc1.Imprimir();
            pc1.MasPesado();
            pc1.MenosPesado();

            Console.ReadKey();
        }
    }
}
