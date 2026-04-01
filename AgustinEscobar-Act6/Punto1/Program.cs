using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Plano

    /*1. Desarrollar una clase que represente un punto en el plano y tenga los siguientes métodos: cargar los valores de x e y, imprimir en que cuadrante se
        encuentra dicho punto (concepto matemático, primer cuadrante si x e y son positivas, si x > 0 e y > 0 segundo cuadrante, etc.)*/
    {
        public void cargarValores()
        {
            int x, y;
            string xIng, yIng;
            Console.WriteLine("Escribe un punto de un plano para saber en que cuadrante va a estar: ");
            Console.Write("Ingresa la posicion de x: ");
            xIng = Console.ReadLine();
            x = int.Parse(xIng);
            Console.Write("Ingresa la posicion de y: ");
            yIng = Console.ReadLine();
            y = int.Parse(yIng);
            imprimirCuadrante(x, y);

        }

        public void imprimirCuadrante(int x, int y)
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("El punto se encuentra en el 1° cuadrante");
            }
            else
            {
                if (x < 0 && y > 0)
                {
                    Console.WriteLine("El punto se encuentra en el 2° cuadrante");
                }
                else
                {
                    if (x < 0 && y < 0)
                    {
                        Console.WriteLine("El punto se encuentra en el 3° cuadrante");
                    }
                    else
                    {
                        if (x > 0 && y < 0)
                        {
                            Console.WriteLine("El punto se encuentra en el 4° cuadrante");
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Plano punto1 = new Plano();
            punto1.cargarValores();
            Console.ReadKey();
        }
    }
}
