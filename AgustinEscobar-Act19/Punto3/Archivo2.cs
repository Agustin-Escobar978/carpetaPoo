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
        public bool recordSup(int puntaje)
        {
            if (puntaje > puntajeMaximo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
