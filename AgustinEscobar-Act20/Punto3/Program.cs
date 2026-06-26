using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*Actividad 3: Estadísticas de visitas a zonas arqueológicas
        Problema:
        Un instituto de arqueología desea registrar las visitas semanales a 3 zonas
        arqueológicas durante 4 semanas.
        Plantear una matriz de 3x4 donde las filas representan las zonas y las columnas los
        días. Luego:
             Calcular el total de visitas por zona y almacenarlo en un vector.
             Mostrar los datos en forma tabular.
             Agregar estos resultados a una lista llamada zonasVisitadas que contenga
            nombres de zonas y total de visitas.
             Determinar cuál fue la zona más visitada.*/
    class Arqueologia
    {
        private int[,] matriz;
        private int[] visitasXZona;
        List<(string nombreZona, int totalVisitas)> zonasVisitadas = new List<(string, int)>();
        public Arqueologia()
        {
            matriz = new int[3, 4];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"Ingrese la cantidad de visitas en la {i + 1}° zona y en el dia {j + 1}: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
        }

        public void totalZona() {

            visitasXZona = new int[matriz.GetLength(0)];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                int suma = 0; 
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    suma += matriz[i, j];
                }
                visitasXZona[i] = suma;
            }
        }

        public void imprimir()
        {
            Console.WriteLine("***MATRIZ***\n");
            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.Write($"Zona {i + 1}: | ");
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"Día{j + 1}: {matriz[i,j]} | ");
                }
                Console.WriteLine();
            }
        }

        public void crearLista()
        {
            Console.WriteLine("\n***Ingrese los datos de las zonas***\n");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.Write($"Ingrese el nombre de la zona {i + 1}: ");
                string nom = Console.ReadLine();
                zonasVisitadas.Add((nom, visitasXZona[i]));
            }
        }

        public void masVisitada()
        {
            int masVisit = zonasVisitadas[0].totalVisitas;
            foreach (var datos in zonasVisitadas)
            {
                if (masVisit < datos.totalVisitas)
                {
                    masVisit = datos.totalVisitas;
                }
            }
            Console.WriteLine("\n***La/las zonas con mas visitas son***\n");
            foreach(var datos in zonasVisitadas)
            {

                if(masVisit == datos.totalVisitas)
                {
                    Console.WriteLine($"{datos.nombreZona} con {datos.totalVisitas}\n");
                }
            }
        }

        static void Main(string[] args)
        {
            Arqueologia arq1 = new Arqueologia();
            arq1.totalZona();
            arq1.imprimir();
            arq1.crearLista();
            arq1.masVisitada();

            Console.ReadKey();
        }
    }
}
