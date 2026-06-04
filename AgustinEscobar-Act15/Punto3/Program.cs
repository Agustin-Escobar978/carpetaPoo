using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Punto3
{
    /*3. Geolocalización de Reservas Naturales
        Un centro de ecología realiza mapeos de biodiversidad para contabilizar el avistamiento de
        especies protegidas en cuadrículas de territorio.
        ● Confeccionar la clase ReservaNatural que tenga como atributos privados el
        NombreReserva y una matriz llamada avistamientos de 3x3 (que representa un
        mapa de coordenadas o sectores de 3 filas y 3 columnas, donde se almacena la
        cantidad de animales avistados en cada sector). El constructor de la clase debe
        cargar por teclado el nombre y rellenar el mapa de avistamientos.
        ● Confeccionar la clase colaboradora CentroEcologico que contenga un vector de 3
        objetos de la clase ReservaNatural.
        La clase CentroEcologico debe implementar los siguientes métodos:
            1. Un constructor que solicite la carga secuencial de las 3 reservas.
            2. Un método que enliste cada reserva junto a la cantidad total de avistamientos que
            registró en toda su superficie (la suma de toda su matriz rectangular).
            3. Un método que determine e informe cuál fue la coordenada o sector específico ([fila,
            columna]) que registró la mayor concentración de avistamientos de toda la red de
            reservas, indicando a qué reserva pertenece.*/

    class ReservaNatural {
        private string NombreReserva;
        private int[,] avistamientos;

        public ReservaNatural() {
            avistamientos = new int[3, 3
                ];
            Console.Write("Ingrese el nombre de la reserva: ");
            NombreReserva = Console.ReadLine();
            for (int i = 0; i < avistamientos.GetLength(0); i++) {
                for (int j = 0; j < avistamientos.GetLength(1); j++) {
                    Console.Write($"Ingrese la cantidad de avistamientos de la cordenada {i + 1}:{j + 1}: ");
                    avistamientos[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
        }

        public string RetornarNom() {
            return NombreReserva;
        }

        public int[,] RetornarMat() {
            return avistamientos;
        }
    }

    class CentroEcologico
    {

        private ReservaNatural[] reservas = new ReservaNatural[3];

        public CentroEcologico() {
            for (int i = 0; i < reservas.Length; i++)
            {
                reservas[i] = new ReservaNatural();
            }
        }

        public void Imprimir() {
            Console.WriteLine("***Las reservas y sus avistamientos totales***\n");
            for (int i = 0; i < reservas.Length; i++) {
                int total = 0;
                int[,] matriz = reservas[i].RetornarMat();
                for (int j = 0; j < matriz.GetLength(0); j++) {
                    for (int k = 0; k < matriz.GetLength(1); k++) {
                        total += matriz[j, k];
                    }
                }
                Console.WriteLine($"{reservas[i].RetornarNom()} con {total}\n");
            }
        }

        public void MasAvistamientos() {
            Console.WriteLine("***La/las reserva con mas avistamientos fue***");
            int max = 0;
            for (int h = 0; h < 2; h++) {
                for (int i = 0; i < reservas.Length; i++) {
                    int[,] matriz = reservas[i].RetornarMat();
                    for (int j = 0; j < matriz.GetLength(0); j++) {
                        for (int k = 0; k < matriz.GetLength(1); k++) {
                            if (h == 0)
                            {
                                if (max < matriz[j, k])
                                {
                                    max = matriz[j, k];
                                }
                            }
                            else if(h == 1)
                            {
                                if (max == matriz[j,k]) {
                                    Console.WriteLine($"{reservas[i].RetornarNom()} en la cordenada {j + 1}:{k+1} con {max}");
                                }
                            }
                        }
                    }
                } 
            }
        }

        static void Main(string[] args)
        {
            CentroEcologico ce1 = new CentroEcologico();
            ce1.Imprimir();
            ce1.MasAvistamientos();

            Console.ReadKey();
        }
    }
}
