using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    /*4. Cargar en un vector los nombres de 5 países y en otro vector paralelo la cantidad de
        habitantes de este. Ordenar alfabéticamente e imprimir los resultados. Por último
        ordenar con respecto a la cantidad de habitantes (de mayor a menor) e imprimir
        nuevamente.*/
    internal class paisPob
    {
        private string[] vectorPa;
        private int[] vectorPo;

        public void cargar()
        {
            vectorPa = new string[5];
            vectorPo = new int[5];
            string datoIng;
            for (int i = 0; i<5; i++) {
                Console.Write($"Ingresa el nombre del {i + 1}° país: ");
                datoIng = Console.ReadLine();
                vectorPa[i] = datoIng;
                Console.Write($"Ingrese la poblacion de {vectorPa[i]}: ");
                datoIng = Console.ReadLine();
                vectorPo[i] = int.Parse(datoIng);
            }
        }

        public void ordenarAlf()
        {
            string auxStr;
            int auxNum;
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 4 - j; i++)
                {
                    if (vectorPa[i].CompareTo(vectorPa[i + 1]) > 0)
                    {
                        auxStr = vectorPa[i];
                        vectorPa[i] = vectorPa[i + 1];
                        vectorPa[i + 1] = auxStr;
                        auxNum = vectorPo[i];
                        vectorPo[i] = vectorPo[i + 1];
                        vectorPo[i + 1] = auxNum;
                    }
                }
            }
            imprimir("*** Ordenado alfabeticamente ***");
        }

        public void ordenarPob()
        {
            string auxStr;
            int auxNum;
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 4 - j; i++)
                {
                    if (vectorPo[i] < vectorPo[i + 1])
                    {
                        auxStr = vectorPa[i];
                        vectorPa[i] = vectorPa[i + 1];
                        vectorPa[i + 1] = auxStr;
                        auxNum = vectorPo[i];
                        vectorPo[i] = vectorPo[i + 1];
                        vectorPo[i + 1] = auxNum;
                    }
                }
            }
            imprimir("*** Ordenado Poblacionalmente ***");
        }

        public void imprimir(string m)
        {
            Console.WriteLine(m);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{vectorPa[i]}---{vectorPo[i]}");
            }
        }
        static void Main(string[] args)
        {
            paisPob p1 = new paisPob();
            p1.cargar();
            p1.ordenarAlf();
            p1.ordenarPob();

            Console.ReadKey();
        }
    }
}
