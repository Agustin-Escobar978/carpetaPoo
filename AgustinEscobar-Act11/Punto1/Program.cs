using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
        /*1. Se desea saber la temperatura media trimestral de cuatro paises. Para ello se tiene como
            dato las temperaturas medias mensuales de dichos paises.
            Se pide ingresar el nombre del país y seguidamente las tres temperaturas medias
            mensuales.
            Seleccionar las estructuras de datos adecuadas para el almacenamiento de los datos en
            memoria.
            a. Cargar por teclado los nombres de los paises y las temperaturas medias mensuales.
            b. Imprimir los nombres de las paises y las temperaturas medias mensuales de las
            mismas.
            c. Calcular la temperatura media trimestral de cada país.
            d. Imprimir los nombres de los paises y las temperaturas medias trimestrales.
            e. Imprimir el nombre del país con la temperatura media trimestral mayor.*/
    internal class Temperatura
    {
        private string[] pais;
        private int[,] temperatura;
        private float[] tempTri;

        public void cargar()
        {
            pais = new string[4];
            temperatura = new int[4, 3];
            for (int i = 0; i < pais.Length; i++)
            {
                Console.Write($"Ingresar el nombre del {i + 1}° pais: ");
                pais[i] = Console.ReadLine();
                for(int j = 0; j < temperatura.GetLength(1); j++)
                {
                    Console.Write($"Ingrese la {j + 1}° temperatura media mensual de {pais[i]}: ");
                    temperatura[i, j] = int.Parse(Console.ReadLine());
                }
            }
            
        }

        public void imprimir()
        {
            Console.WriteLine("\n***Paises y sus temperaturas medias mensuales***");
            for(int i = 0; i<pais.Length; i++)
            {
                Console.Write($"{pais[i]}");
                for(int j = 0; j < temperatura.GetLength(1); j++)
                {
                    Console.Write($" ---{j + 1}°T: {temperatura[i,j]}");
                }
                Console.WriteLine();
            }
            
        }

        public void trimestral()
        {
            tempTri = new float[4];
            
            for(int i = 0; i<pais.Length; i++)
            {
                float prom = 0;
                for (int j = 0; j<temperatura.GetLength(1); j++)
                {
                    prom += temperatura[i, j];
                }
                prom /= 3;
                tempTri[i] = prom;
            }
            Console.WriteLine("\n***Paises y sus temperaturas medias trimestrales***");
            for (int k = 0; k < pais.Length; k++)
            {
                Console.WriteLine($"{pais[k]} --- {tempTri[k]}");       
            }
        }

        public void mayorTri()
        {
            float max = tempTri[0];
            for(int i = 0; i<tempTri.Length; i++)
            {
                if (tempTri[i] > max)
                {
                    max = tempTri[i];
                }
            }
            Console.WriteLine("\n*** El/Los paises con la temperatura media trimestral mas alta son ***");
            for(int j = 0; j<tempTri.Length; j++)
            {
                if(tempTri[j] == max)
                {
                    Console.WriteLine($"{pais[j]} --- {tempTri[j]}");
                } 
            }
        }
        static void Main(string[] args)
        {
            Temperatura t1 = new Temperatura();

            t1.cargar();
            t1.imprimir();
            t1.trimestral();
            t1.mayorTri();
        }
    }
}
