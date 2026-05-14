using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*1. Sistema de Logística: Envíos por Sucursal
        Una empresa de correo tiene 3 sucursales principales. Cada sucursal procesa una cantidad diferente de paquetes por día dependiendo de su demanda.
        ● Definir un vector de tipo string para los nombres de las 3 sucursales.
        ● Definir una matriz irregular donde cada fila sea una sucursal y cada columna represente el peso (en kg) de cada paquete enviado.
        ● Métodos:
            1. Cargar los nombres de las sucursales y, para cada una, preguntar cuántos
            paquetes se enviaron hoy para definir el tamaño de su fila.
            2. Cargar el peso de cada paquete.
            3. Imprimir el peso de todos los paquetes organizados por sucursal.
            4. Calcular e informar el peso total despachado por cada sucursal.
            5. Informar cuál es el paquete más pesado de toda la empresa y a qué sucursal
            pertenece.*/
    internal class EmpresaC
    {
        private string[] sucursales;
        private float[][] paquetes;
        public void cargar()
        {
            sucursales = new string[3];
            paquetes = new float[3][];
            for (int i = 0; i < sucursales.Length; i++)
            {
                Console.Write($"Ingrese el nombre de la {i + 1}° sucursal: ");
                sucursales[i] = Console.ReadLine();
                Console.Write($"Cuantos paquetes envio hoy {sucursales[i]}: ");
                paquetes[i] = new float[int.Parse(Console.ReadLine())];
                for (int j = 0; j < paquetes[i].Length; j++)
                {
                    Console.Write($"Ingrese el peso del {j + 1}° paquete en Kg: ");
                    paquetes[i][j] = float.Parse(Console.ReadLine());
                }
            }

        }

        public void imprimir()
        {
            for (int i = 0; i < sucursales.Length; i++)
            {
                Console.WriteLine($"\nLa sucursal {sucursales[i]} envio {paquetes[i].Length} paquetes hoy:");
                for (int j = 0; j < paquetes[i].Length; j++)
                {
                    Console.WriteLine($"El {j + 1}° paquete pesa {paquetes[i][j]} Kg");
                }
            }
        }

        public void pesoT()
        {

            for (int i = 0; i < sucursales.Length; i++)
            {
                float total = 0;
                for (int j = 0; j < paquetes[i].Length; j++)
                {
                    total += paquetes[i][j];
                }
                Console.WriteLine($"\nLa surcusal {sucursales[i]} despacho un total de {total} Kg");
            }
        }

        public void pesoM()
        {
            float mayor = paquetes[0][0];
            for (int i = 0; i < sucursales.Length; i++)
            {
                for (int j = 0; j < paquetes[i].Length; j++)
                {
                    if (mayor < paquetes[i][j])
                    {
                        mayor = paquetes[i][j];
                    }
                }
            }

            Console.WriteLine("\n***El/los paquetes mas pesados son***");
            for (int k = 0; k < sucursales.Length; k++)
            {
                for (int l = 0; l < paquetes[k].Length; l++)
                {
                    if (mayor == paquetes[k][l])
                    {
                        Console.WriteLine($"El paquete mas pesado es el {l + 1}° de la sucursal {sucursales[k]}");
                    }
                }
            }
        }

        static void Main(string[] args)
        {


            EmpresaC d1 = new EmpresaC();
            d1.cargar();
            d1.imprimir();
            d1.pesoT();
            d1.pesoM();

            Console.ReadKey();
        }
    }
}
