using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto5
{
    /*Actividad 5: Gestión de Carreras Deportivas
    Consigna:
    Crear un sistema para gestionar carreras deportivas. Cada carrera tiene un código,
    una hora de inicio y una hora de fin. Cada carrera puede registrar varios corredores.
    Se pide:
    1. Crear una clase Carrera con:
        o Atributos: código, hora de inicio, hora de fin y lista de corredores ya
        definidos.
        o Dos constructores (uno por defecto y otro con parámetros).
        o Método para calcular la duración de la carrera usando TimeSpan.
    2. Crear una clase Corredor con:
        o Atributos: nombre, número de dorsal y tiempo total.
        o Sobrecarga de métodos para registrar el tiempo total (en minutos o en
        horas y minutos).
    3. Mostrar en consola (usando Console.SetCursorPosition()):
        o La carrera con mayor duración.
        o El corredor más rápido.
    4. Utilizar this en los constructores o métodos donde corresponda.*/

    class Corredor
    {
        private string nombre;
        private int numeroDorsal;
        private double tiempoTotal;

        public void registrarTiempo(int horas, int minutos)
        {
            TimeSpan tiempo = new TimeSpan(horas, minutos, 0);
            tiempoTotal = tiempo.TotalMinutes;
        }
        public void registrarTiempo(int minutos)
        {
            tiempoTotal = minutos;
        }
    }

    class Carrera
    {
        private string codigo;
        DateTime horaInicio = new DateTime();
        DateTime horaFin = new DateTime();
        List<Corredor> c = new List<Corredor>();

        public Carrera()
        {
            Console.WriteLine("Ingrese el codigo de la carrera: ");
            codigo = Console.ReadLine();
            Console.WriteLine("Ingese la hora de inicio de la carrera: ");
            horaInicio = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la hora de fin de la carrera: ");
            horaFin = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            cargarCorrerores();
        }
        public Carrera(string c, DateTime hi, DateTime hf)
        {
            codigo = c;
            horaInicio = hi;
            horaFin = hf;
            Console.WriteLine();
        }


        public void cargarCorrerores()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Ingrese el nombre del correror: ");
                string nombre = Console.ReadLine();
                Console.Write($"Ingrese el numero de {nombre}: ");
                int dorsal = int.Parse(Console.ReadLine());
                Console.Write($"Ingrese el tiempo en terminar la carrera de {nombre}: ");
                TimeSpan tiempo = TimeSpan.Parse(Console.ReadLine());
                TimeSpan unaHora = new TimeSpan(1, 0, 0);
                if (tiempo >= unaHora)
                {
                    int horas = tiempo.Hours;
                    int minutos = tiempo.Minutes;
                    (horas, minutos);
                }
                else
                {
                    int minutos = durAct.Minutes;
                    registrarDuracion(minutos);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
