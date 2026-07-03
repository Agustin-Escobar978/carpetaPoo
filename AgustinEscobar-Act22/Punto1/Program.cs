using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*Actividad 1: Control de horarios en un gimnasio
    Problema:
    Crear una clase ClaseGimnasio con atributos: nombreClase, horaInicio y horaFin (usar
    DateTime).
     Implementar un constructor que permita cargar los datos desde consola y otro
    que cargue valores por defecto (sobrecarga de constructores).
     Incluir un método para calcular la duración de la clase usando TimeSpan.
     Crear un vector de 3 clases de gimnasio y mostrar:
        1. La clase que tenga la mayor duración.
        2. El nombre y el horario de inicio de la clase más temprana.*/

    class ClaseGimnasio
    {
        private string nombreClase;
        DateTime horaInicio = new DateTime();
        DateTime horaFin = new DateTime();
        public ClaseGimnasio()
        {
            Console.Write("Ingrese el nombre de la clase: ");
            nombreClase = Console.ReadLine();
            Console.Write($"Ingrese la hora de inicio de {nombreClase}: ");
            horaInicio = DateTime.Parse(Console.ReadLine());
            Console.Write($"Ingrese la hora de cuando termina la clase: ");
            horaFin = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        public ClaseGimnasio(string n, string hi, string hf)
        {
            nombreClase = n;
            horaInicio = DateTime.Parse(hi);
            horaFin = DateTime.Parse(hf);
        }

        public TimeSpan calcularDur()
        {
            TimeSpan duracion = horaFin - horaInicio;
            return duracion;
        }
        static void Main(string[] args)
        {
            ClaseGimnasio[] cg1 = new ClaseGimnasio[3];
            cg1[0] = new ClaseGimnasio();
            cg1[1] = new ClaseGimnasio("Yoga", "20: 00: 00", "21:30:00");
            cg1[2] = new ClaseGimnasio();

            TimeSpan MayorDur = cg1[0].calcularDur();
            for (int i = 0; i < cg1.Length; i++)    // Mas duracion
            {
                TimeSpan duracionAct = cg1[i].calcularDur();
                if (MayorDur < duracionAct)
                {
                    MayorDur = duracionAct;
                }
            }
            Console.WriteLine("***La/las clases con mayor duracion son***\n");
            for (int j = 0; j < cg1.Length; j++)
            {
                TimeSpan duracionAct = cg1[j].calcularDur();
                if (MayorDur == duracionAct) {
                    Console.WriteLine($"{cg1[j].nombreClase} tiene la mayor duracion con {duracionAct}\n");
                }
            }

            DateTime masTemprano = cg1[0].horaInicio;   // Mas temprano
            for (int k = 0; k < cg1.Length; k++)
            {
                if (masTemprano > cg1[k].horaInicio)
                {
                    masTemprano = cg1[k].horaInicio;
                }
            }
            Console.WriteLine("***La/las clases que empiezan mas temprano son***\n");
            for (int l = 0; l < cg1.Length; l++)
            {
                if(masTemprano == cg1[l].horaInicio)
                {
                    Console.WriteLine($"{cg1[l].nombreClase} que empieza a las {cg1[l].horaInicio.ToString("T")}");
                }
            }

            Console.ReadKey();
        }
    }
}
