using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*3. Armar una clase parcial JuegoArcade.
        En el primer archivo, definir las propiedades NombreJuego, PuntajeMaximo, y
        NivelDificultad (de 1 a 5). Valores cargados desde consola
        En el segundo archivo, implementar un método que indique si un puntaje ingresado
        supera el récord o no.
        Desde Main, simular 4 partidas, mostrar qué jugador rompió el récord de su juego.*/
    class Partidas
    {
        JuegoArcade juego = new JuegoArcade();
        private int[] puntaje; 
             
        public Partidas()
        {
            Console.WriteLine($"{juego.NombreJuego}:\ntiene un puntaje maximo de {juego.PuntajeMaximo} y una dificultad de {juego.NivelDificultad} \n");
            puntaje = new int[4];
            for (int i = 0; i < puntaje.Length; i++) {
                Console.Write($"Ingrese el puntaje del {i + 1}° jugador: ");
                puntaje[i] = int.Parse(Console.ReadLine());
            }
        }

        public void superoRecord()
        {
            Console.WriteLine("***El/los jugadores que rompieron el record***");
            for (int i = 0; i < puntaje.Length; i++)
            {
                if (juego.recordSup(puntaje[i]) == true)
                {
                    Console.WriteLine($"El {i + 1}° jugador supero el record de {juego.PuntajeMaximo} con {puntaje[i]}");
                }
            }
        }

        static void Main(string[] args)
        {
            Partidas p1 = new Partidas();
            p1.superoRecord();

            Console.ReadKey();
        }
    }
}
