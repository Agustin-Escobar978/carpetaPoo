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
    partial class JuegoArcade
    {
        private string nombreJuego;
        private int puntajeMaximo;
        private int nivelDificultad;

        public string NombreJuego
        {
            set { nombreJuego = value; }
            get { return nombreJuego; }
        }
        public int PuntajeMaximo
        {
            set { puntajeMaximo = value; }
            get { return puntajeMaximo; }
        }
        public int NivelDificultad
        {
            set
            {
                if (value >= 1 && value <= 5) {
                    nivelDificultad = value;
                }
                else
                {
                    bool verificacion = false;
                    do
                    {
                        Console.Write("Ingrese un valor entre 1 y 5: ");
                        nivelDificultad = int.Parse(Console.ReadLine());
                        if (nivelDificultad >= 1 && nivelDificultad <= 5)
                        {
                            verificacion = true;
                        }
                        else
                        {
                            verificacion = false;
                        }
                    } while (verificacion == false);
                }
            }
            get { return nivelDificultad; }
        }

        public JuegoArcade()
        {
            Console.Write("Ingrese el nombre del juego: ");
            NombreJuego = Console.ReadLine();
            Console.Write($"Ingrese el puntaje maximo de {NombreJuego}: ");
            PuntajeMaximo = int.Parse(Console.ReadLine());
            Console.Write($"Ingrese el nivel de dificultad del juego (1 al 5): ");
            NivelDificultad = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
    }
}
