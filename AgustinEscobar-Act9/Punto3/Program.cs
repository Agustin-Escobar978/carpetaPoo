using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*3. Se registran los nombres de 5 atletas y sus tiempos (en segundos) en una
        carrera de 100 metros. El programa debe cargar los datos en dos vectores
        paralelos, calcular y mostrar el promedio de los tiempos, mostrar el nombre del
        atleta con mejor y peor tiempo, y mostrar los nombres de quienes superaron el
        promedio.*/
    internal class Atletismo
    {
        private string[] nombres;
        private float[] tiempos;
        private float prom = 0;
        public void cargar() {
            nombres = new string[5];
            tiempos = new float[5];
            string datoIng;
            for(int i = 0; i<nombres.Length; i++)
            {
                Console.Write($"Ingrese el nombre del {i + 1}° atleta: ");
                nombres[i] = Console.ReadLine();
                Console.Write($"Ingrese el tiempo de {nombres[i]}: ");
                datoIng = Console.ReadLine();
                tiempos[i] = float.Parse(datoIng);
            }
        }

        public void promedio()
        {
            for(int i = 0; i<tiempos.Length; i++)
            {
                prom += tiempos[i];
            }
            prom = prom / tiempos.Length;
            Console.WriteLine($"El promedio de los tiempos es de {prom} segundos");
        }

        public void tiemposMyP()
        {
            float mej = tiempos[0], peor = tiempos[0];
            int posM = 0, posP = 0;
            for(int i = 0; i<tiempos.Length; i++)
            {
                if(mej > tiempos[i])
                {
                    mej = tiempos[i];
                    posM = i;
                }if(peor < tiempos[i])
                {
                    peor = tiempos[i];
                    posP = i;
                }
            }
            Console.WriteLine($"***El/Los mejores atletas con mejores tiempos***");
            for(int j = 0; j<tiempos.Length; j++)
            {
                if (tiempos[j] == mej)
                {
                    Console.WriteLine(nombres[j]);
                }
            }
            Console.WriteLine();
            Console.WriteLine($"***El/Los atletas con peores tiempos***");
            for (int k = 0; k < tiempos.Length; k++)
            {
                if (tiempos[k] == peor)
                {
                    Console.WriteLine(nombres[k]);
                }
            }
        }

        public void promedioSup()
        {
            Console.WriteLine("***Nombre/s que superaron el promedio***");
            for(int i = 0; i < tiempos.Length; i++)
            {
                if(prom > tiempos[i])
                {
                    Console.WriteLine(nombres[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            Atletismo car1 = new Atletismo();
            car1.cargar();
            car1.promedio();
            car1.tiemposMyP();
            car1.promedioSup();

            Console.ReadKey();
        }
    }
}
