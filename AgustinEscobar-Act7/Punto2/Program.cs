using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*2. Realizar un programa que pida la carga de dos vectores numéricos enteros de 4
        elementos. Obtener la suma de los dos vectores, dicho resultado guardarlo en un
        tercer vector del mismo tamaño. Sumar componente a componente.*/

    internal class tresVectores
    {
        private int[] vec1;
        private int[] vec2;
        private int[] vec3;

        public void cargar()
        {
            vec1 = new int[4];
            vec2 = new int[4];
            string datoIng;

            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Ingrese un valor para la posicion {i} del primer vector: ");
                datoIng = Console.ReadLine();
                vec1[i] = int.Parse(datoIng);
            }
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Ingrese un valor para la posicion {i} del segundo vector: ");
                datoIng = Console.ReadLine();
                vec2[i] = int.Parse(datoIng);
            }
        }

        public void sumarVec()
        {
            vec3 = new int[4];
            for (int i = 0; i < 4; i++)
            {
                vec3[i] = vec1[i] + vec2[i];
                Console.WriteLine($"la posicion {i} del tercer vector es igual a: {vec3[i]}");
            }
        }

        static void Main(string[] args)
        {
            tresVectores pru1 = new tresVectores();
            pru1.cargar();
            pru1.sumarVec();

            Console.ReadKey();
        }
    }
}
