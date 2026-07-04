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
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public int NumeroDorsal
        {
            set { numeroDorsal = value;  }
            get { return numeroDorsal;  }
        }
        public double TiempoTotal
        {
            set {  tiempoTotal = value; }
            get { return tiempoTotal; }
        }
        public Corredor(string nombre, int numeroDorsal)
        {
            this.nombre = nombre;
            this.numeroDorsal = numeroDorsal;
        }

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
        List<Corredor> listaCorredores = new List<Corredor>();

        public string Codigo
        {
            set { codigo = value; }
            get { return codigo; }
        }
        public DateTime HoraInicio
        {
            set {  horaInicio = value; }
            get { return horaInicio;  }
        }
        public DateTime HoraFin
        {
            set {  horaFin = value; }
            get { return horaFin; }
        }

        public Carrera()
        {
            Console.Write("Ingrese el codigo de la carrera: ");
            Codigo = Console.ReadLine();
            Console.Write("Ingrese la hora de inicio de la carrera: ");
            HoraInicio = DateTime.Parse(Console.ReadLine());
            Console.Write("Ingrese la hora de fin de la carrera: ");
            HoraFin = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            cargarCorredores();
        }
        public Carrera(string codigo, string horaInicio, string horaFin)
        {
            this.Codigo = codigo;
            this.HoraInicio = DateTime.Parse(horaInicio);
            this.HoraFin = DateTime.Parse(horaFin);
            Console.WriteLine($"{Codigo}\nInicio de la carrera: {HoraInicio}\nFin de la carrera: {HoraFin}\n***Corredores***");
            Console.WriteLine();
            cargarCorredores();
        }

        public TimeSpan calcularDuracion(DateTime hi, DateTime hf)
        {
            TimeSpan duracion = hf - hi;
            return duracion;
        }

        public void cargarCorredores()
        {
            for (int i = 0; i < 6; i++)
            {
                Console.Write("Ingrese el nombre del corredor: ");
                string nombre = Console.ReadLine();
                Console.Write($"Ingrese el numero de {nombre}: ");
                int dorsal = int.Parse(Console.ReadLine());
                Corredor corre = new Corredor(nombre, dorsal);
                listaCorredores.Add(corre);
                Console.Write($"Ingrese el tiempo en terminar la carrera de {nombre}: ");
                TimeSpan tiempo = TimeSpan.Parse(Console.ReadLine());
                TimeSpan unaHora = new TimeSpan(1, 0, 0);
                if (tiempo >= unaHora)
                {
                    int horas = tiempo.Hours;
                    int minutos = tiempo.Minutes;
                    corre.registrarTiempo(horas, minutos);
                }
                else
                {
                    int minutos = tiempo.Minutes;
                    corre.registrarTiempo(minutos);
                }
                Console.WriteLine();
            }
        }

        public void masRapido()
        {
            double masRapido = listaCorredores[0].TiempoTotal;
            foreach (Corredor c in listaCorredores) 
            {
                
                if (masRapido > c.TiempoTotal )
                {
                    masRapido = c.TiempoTotal;
                }
            }
            Console.WriteLine("***El/los corredores mas rapido de esta carrera son***\n");
            foreach (Corredor c in listaCorredores)
            {
                if(masRapido == c.TiempoTotal)
                {
                    Console.WriteLine($"{c.Nombre} con un tiempo de {c.TiempoTotal}\n");
                }
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Carrera[] carreras = new Carrera[4];

            for (int i = 0; i < carreras.Length; i++)
            {
                if (i == 2)
                {
                    carreras[i] = new Carrera("cvb1233", "15:00:00", "18:00:00");
                    carreras[i].masRapido();
                }
                else
                {
                    carreras[i] = new Carrera();
                    carreras[i].masRapido();
                }
                
            }

            TimeSpan masLargo = carreras[0].calcularDuracion(carreras[0].HoraInicio, carreras[0].HoraFin); // obtengo la duracion mas larga
            for (int j = 0; j < carreras.Length; j++)
            {
                TimeSpan duracionAct = carreras[j].calcularDuracion(carreras[j].HoraInicio, carreras[j].HoraFin);
                if (masLargo < duracionAct)
                {
                    masLargo = duracionAct;
                }
            }
            Console.WriteLine("***La/las carreras con mas duracion son***");    
            for (int k = 0; k < carreras.Length; k++)
            {
                TimeSpan duracionAct = carreras[k].calcularDuracion(carreras[k].HoraInicio, carreras[k].HoraFin);
                if (masLargo == duracionAct)
                {
                    Console.WriteLine($"{carreras[k].Codigo} con una duracion de {duracionAct}");
                }
            }



            Console.ReadKey();
        }
    }
}
