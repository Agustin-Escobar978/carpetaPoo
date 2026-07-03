using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    /*Actividad 4: Gestión de vuelos
    Problema:
    Definir una clase Vuelo con atributos: codigo, horaSalida y horaLlegada (DateTime).
     Usar la palabra clave this en el constructor para diferenciar los parámetros de
    los atributos.
     Crear un método para calcular la duración del vuelo (TimeSpan).
     Cargar un vector con 4 vuelos y mostrar:
        1. El código y duración del vuelo más largo.
        2. El código del vuelo que salga más temprano.*/
    class Vuelo
    {
        private string codigo;
        DateTime horaSalida = new DateTime();
        DateTime horaLlegada = new DateTime();

        public Vuelo(string codigo, DateTime horaSalida, DateTime horaLlegada)
        {
            this.codigo = codigo;
            this.horaSalida = horaSalida;
            this.horaLlegada = horaLlegada;
        }

        public TimeSpan duracionVuelo(DateTime hs, DateTime hl)
        {
            TimeSpan duracion = hl - hs;
            return duracion;
        }

        static void Main(string[] args)
        {
            Vuelo[] v1 = new Vuelo[4];
            for(int i = 0; i < v1.Length; i++) // Creo objetos
            {
                Console.Write("Ingrese el codigo del vuelo: ");
                string c = Console.ReadLine();
                Console.Write($"Ingrese la hora de salida del vuelo {c}: ");
                DateTime hs = DateTime.Parse(Console.ReadLine());
                Console.Write($"Ingrese la hora de llegada del vuelo {c}: ");
                DateTime hl = DateTime.Parse(Console.ReadLine());
                v1[i] = new Vuelo(c, hs, hl);
                Console.WriteLine();
            }

            TimeSpan masLargo = v1[0].duracionVuelo(v1[0].horaSalida, v1[0].horaLlegada);
            DateTime masTemprano = v1[0].horaSalida;
            for (int j = 0; j < v1.Length; j++) // Vuelo mas largo
            {
                TimeSpan duracionAct = v1[j].duracionVuelo(v1[j].horaSalida, v1[j].horaLlegada);
                if (masLargo < duracionAct)
                {
                    masLargo = duracionAct;
                }
                if(masTemprano > v1[j].horaSalida)
                {
                    masTemprano = v1[j].horaSalida;
                }
                
            }
            Console.WriteLine("***El/Los vuelos mas largos son***\n");  // 
            for (int k = 0; k < v1.Length; k++)
            {
                TimeSpan duracionAct = v1[k].duracionVuelo(v1[k].horaSalida, v1[k].horaLlegada);
                if (masLargo == duracionAct)
                {
                    Console.WriteLine($"{v1[k].codigo} con una duracion de {duracionAct}\n");
                }
            }
            Console.WriteLine("***El/los vuelos con la salida mas temprana son***");
            for (int l = 0; l < v1.Length; l++)
            {
                if (masTemprano == v1[l].horaSalida)
                {
                    Console.WriteLine($"{v1[l].codigo} en la hora {v1[l].horaSalida}");
                }
            }
        }
    }
}
