using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*3.Crear una clase base llamada SondaExploradora que contenga los atributos Modelo (string) y
        AutonomiaMinutos (int). Definir un constructor que reciba estos dos valores como parámetros y
        realice su asignación.
        Luego, definir dos clases derivadas de la clase base:
        ● SondaSubmarina: que añade el atributo propio PresionMaximaAtm (int, presión máxima
        soportada en atmósferas).
        ● RoverTerrestre: que añade el atributo propio CantidadRuedas (int).
        Cada una de estas clases derivadas debe poseer su propio constructor. El mismo debe recibir
        tanto el atributo específico como los heredados de la clase base, transfiriendo estos últimos a la
        clase SondaExploradora mediante el uso explícito de la palabra clave base.
        En el método Main, instanciar un objeto de cada clase derivada y mostrar la totalidad de sus
        parámetros unificados por consola.*/

    public class SondaExploradora
    {
        protected string modelo;
        protected int autonomiaMinutos;

        public SondaExploradora(string m, int am) {
            modelo = m;
            autonomiaMinutos = am;
        }
    }

    public class SondaSubmarina : SondaExploradora
    {
        protected int presionMaximaAtm;

        public SondaSubmarina(string m, int am, int pma) : base(m, am)
        {
            presionMaximaAtm = pma;
            Console.WriteLine($"La sonda submarina es del modelo: {modelo}\nTiene una autonomia por minutos de {autonomiaMinutos}m\nY soporta una presion maxima de atmosfera de {presionMaximaAtm}\n");
        }
    }

    public class RoverTerrestre : SondaExploradora
    {
        protected int cantidadRuedas;

        public RoverTerrestre(string m, int am, int cr) : base(m, am)
        {
            cantidadRuedas = cr;
            Console.WriteLine($"El rover terrestre es del modelo {modelo}\nTiene una autonomia por minutos de {autonomiaMinutos}m\nY tiene una cantidad de ruedas de {cantidadRuedas}");
        }
    }

    class Cargar
    {
        static void Main(string[] args)
        {
            SondaSubmarina ss1 = new SondaSubmarina("Garmin STRIKER Vivid 7sv", 500, 10);
            RoverTerrestre rt1 = new RoverTerrestre("ExoMy", 100, 6);
            

            Console.ReadKey();
        }
    }
}
