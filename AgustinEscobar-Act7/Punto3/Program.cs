using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*3. Pedir al usuario que ingrese las puntuaciones obtenidas en 6 partidas seguidas de
        un videojuego. El programa debe:
         Mostrar la puntuación más alta y la más baja.
         Calcular el promedio de puntuación.
         Contar cuántas veces superó los 500 puntos.*/
    internal class puntajeVid
    {
        private int[] parts;
        public void cargar()
        {
            string datoIng;
            parts = new int[6];
            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Ingrese el puntaje obtenido en la {i + 1} partida: ");
                datoIng = Console.ReadLine();
                parts[i] = int.Parse(datoIng);
            }
        }

        public void puntAyB()
        {
            int max = 0, min = 0;
            for (int i = 0; i < 6; i++)
            {
                if (parts[i] > max)
                {
                    max = parts[i];
                }
                if (parts[i] < min  ||  i == 0)
                {
                    min = parts[i];
                }
            }
            Console.WriteLine($"El maximo puntaje es {max} y el minimo es {min}");
        }

        public void promedio()
        {
            float prom = 0;
            for (int i = 0; i < 6; i++)
            {
                prom += parts[i];
            }
            prom = prom / 6;
            Console.WriteLine($"El promedio de los puntaje es: {prom}");
        }

        public void superar500()
        {
            int cant = 0;
            for (int i = 0; i<6; i++) {
                if (parts[i] > 500)
                {
                    cant++;
                }
            }
            Console.WriteLine($"La cantidad de veces que superaste los 500 puntos fue: {cant}");
        }

        static void Main(string[] args)
        {
            puntajeVid parts1 = new puntajeVid();
            parts1.cargar();
            parts1.puntAyB();
            parts1.promedio();
            parts1.superar500();

            Console.ReadKey();
        }
    }
}