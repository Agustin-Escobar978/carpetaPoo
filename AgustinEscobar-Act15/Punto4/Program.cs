using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    /*4. Línea de Ensamblaje Robótico
        En una planta de fabricación automatizada, cada robot industrial realiza tareas de
        ensamblaje complejas divididas en operaciones secundarias de duración variable.
        ● Diseñar la clase RobotEnsamblador que tenga como atributos privados:
        1. ModeloRobot.
        2. Una matriz irregular de tipo float (float[][] tiemposOperacion) donde cada
        fila representa una de las 4 fases principales del proceso (Estructura,
        Cableado, Pintura y Testeo), y cada columna los segundos que demoró en
        completar las distintas subtareas de esa fase (por ejemplo, en la fase de
        Estructura el robot puede tener 3 sub-tareas, pero en la de Testeo solo tiene
        1).
        3. El constructor de RobotEnsamblador debe pedir su modelo, preguntar para
        cada una de las 4 fases de fabricación cuántas sub-tareas requirió realizar

        (definiendo el tamaño de cada fila) y cargar la duración en segundos de cada
        una de ellas.

        ● Diseñar la clase colaboradora PlantaIndustrial que gestione a 3 objetos de la clase
        RobotEnsamblador. Implementar en PlantaIndustrial:
        1. Un constructor que cargue la información de los 3 robots instalados en la
        planta.
        2. Un método que muestre un reporte detallado con los tiempos de operación
        de cada robot fase por fase.
        3. Un método que calcule el promedio general de tiempo por tarea de cada
        robot y declare al "Robot más Eficiente" (aquel que registre el promedio de
        tiempo por operación más bajo de la planta).*/

    class RobotEnsamblador {
        private string ModeloRobot;
        private float[][] tiemposOperacion;

        public RobotEnsamblador() {
            tiemposOperacion = new float[4][];
            Console.Write("Ingrese el modelo del robot: ");
            ModeloRobot = Console.ReadLine();
            for (int i = 0; i < tiemposOperacion.Length; i++) {
                if (i == 0) {
                    Console.Write("Cuantas sub-tareas requirio Estructura: ");
                }else if (i == 1)
                {
                    Console.Write("Cuantas sub-tareas requirio Cableado: ");
                }else if (i == 2)
                {
                    Console.Write("Cuantas sub-tareas requirio Pintura: ");
                }else if (i == 3)
                {
                    Console.Write("Cuantas sub-tareas requirio Testeo: ");
                }
                tiemposOperacion[i] = new float [int.Parse(Console.ReadLine())];
                for (int j = 0; j < tiemposOperacion[i].Length; j++) {
                    Console.Write($"Cuantos segundos demoro la {j + 1}º sub-tarea: ");
                    tiemposOperacion[i][j] = float.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public string RetornarMod() {
            return ModeloRobot;
        }

        public float[][] RetornarMat() {
            return tiemposOperacion;
        }
    }

    class PlantaIndustrial
    {
        RobotEnsamblador[] robots = new RobotEnsamblador[3];
        public PlantaIndustrial() {
            for (int i = 0; i < robots.Length; i++)
            {
                robots[i] = new RobotEnsamblador();
            }
        }

        public void Imprimir() {
            Console.WriteLine("***Los robots y sus tiempos de operacion***\n");
            for (int i = 0; i < robots.Length; i++) {
                float[][] matriz = robots[i].RetornarMat();
                Console.WriteLine($"{robots[i].RetornarMod()}: ");
                for (int j = 0; j < matriz.Length; j++) {
                    if (j == 0)
                    {
                        Console.WriteLine("**Estructura: ");
                    }
                    else if (j == 1)
                    {
                        Console.WriteLine("**Cableado: ");
                    }
                    else if (j == 2)
                    {
                        Console.WriteLine("**Pintura: ");
                    }
                    else if (j == 3)
                    {
                        Console.WriteLine("**Testeo: ");
                    }
                    for (int k = 0; k < matriz[j].Length; k++) {
                        Console.WriteLine($"{k + 1}º tarea => {matriz[j][k]}s  ");
                    }
                }
                Console.WriteLine();
            }
        }

        public void PromedioTarea() {
            Console.WriteLine("***El/los Robot mas eficiiente**");
            float PromBajo = 0;
            for (int i = 0; i < robots.Length; i++)
            {
                float[][] Matriz = robots[i].RetornarMat();
                float PromRob = 0;
                int Cant = 0;
                for (int j = 0; j < Matriz.Length; j++) {
                    for (int k = 0; k < Matriz[j].Length; k++) {
                        PromRob += Matriz[j][k];
                        Cant++;
                    }
                }
                PromRob /= Cant;
                if (PromRob < PromBajo || i == 0) {
                    PromBajo = PromRob;
                }
            }
            for (int i = 0; i < robots.Length; i++)
            {
                float[][] Matriz = robots[i].RetornarMat();
                float PromRob = 0;
                int Cant = 0;
                for (int j = 0; j < Matriz.Length; j++)
                {
                    for (int k = 0; k < Matriz[j].Length; k++)
                    {
                        PromRob += Matriz[j][k];
                        Cant++;
                    }
                }
                PromRob /= Cant;
                if (PromRob == PromBajo)
                {
                    Console.WriteLine($"{robots[i].RetornarMod()} con un tiempo promedio de {PromBajo}s");
                }
            }
        }

        static void Main(string[] args)
        {
            PlantaIndustrial pi1 = new PlantaIndustrial();
            pi1.Imprimir();
            pi1.PromedioTarea();

            Console.ReadKey();
        }
    }
}
