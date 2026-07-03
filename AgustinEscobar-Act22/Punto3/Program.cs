using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*Actividad 3: Registro de entrenamientos
    Problema:
    Plantear una clase Entrenamiento con atributos: deportista y duración (en minutos).
     Incluir dos métodos RegistrarDuracion (sobrecarga de métodos):
        1. Uno que reciba horas y minutos y los convierta a minutos.
        2. Otro que reciba directamente los minutos.
     Crear una lista con 5 entrenamientos y mostrar el entrenamiento más largo y el
    más corto.*/
    class Entrenamiento
    {
        private string deportista;
        private double duracion;

        public void registrarDuracion(int horas, int minutos)
        {
            TimeSpan tiempo = new TimeSpan(horas, minutos, 0);
            duracion = tiempo.TotalMinutes;
        }
        public void registrarDuracion(double minutos)
        {
            duracion = minutos;
        }
        public Entrenamiento()
        {
            Console.Write("Ingrese el nombre del deportista: ");
            deportista = Console.ReadLine();
            Console.Write("Ingrese la duracion del entrenamiento: ");
            TimeSpan durAct = TimeSpan.Parse(Console.ReadLine());
            TimeSpan unaHora = new TimeSpan(1,0,0);
            if (durAct >= unaHora)
            {
                int horas = durAct.Hours;
                int minutos = durAct.Minutes;
                registrarDuracion(horas, minutos);
            }
            else
            {
                int minutos = durAct.Minutes;
                registrarDuracion(minutos);
            }
            Console.WriteLine();
            
        }
        static void Main(string[] args)
        {
            Entrenamiento[] e1 = new Entrenamiento[5];
            for (int i = 0; i < e1.Length; i++)
            {
                e1[i] = new Entrenamiento();
            }

            double masLargo = e1[0].duracion;   
            double masCorto = e1[0].duracion;
            for (int i = 0; i < e1.Length; i++) // obtener duracion mas larga y corta
            {
                if (masLargo < e1[i].duracion)
                {
                    masLargo = e1[i].duracion;
                }
                if (masCorto > e1[i].duracion)
                {
                    masCorto = e1[i].duracion;
                }
            }

            Console.WriteLine("***El/Los entrenamientos mas largos son***");    //Imprimir duracion mas larga
            for (int j = 0; j < e1.Length; j++)
            {
                if (masLargo == e1[j].duracion)
                {
                    Console.WriteLine($"{e1[j].deportista} con {e1[j].duracion}");
                }
            }
            Console.WriteLine("***El/Los entrenamientos mas cortos son***");    // Imprimir duracion mas corta
            for (int k = 0; k < e1.Length; k++)
            {
                if (masCorto == e1[k].duracion)
                {
                    Console.WriteLine($"{e1[k].deportista} con {e1[k].duracion}");
                }
            }

            Console.ReadKey();
        }
    }
}
