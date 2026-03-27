using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*2. Realizar un programa que lea los lados de n triángulos, e informar:
                a) De cada uno de ellos, qué tipo de triángulo es: equilátero (tres lados iguales), isósceles (dos lados iguales), o escaleno (ningún lado igual) 
                b) Cantidad de triángulos de cada tipo. 
                c) Tipo de triángulo que posee menor cantidad.*/
            int tringulosCant, equilaT = 0, isosT = 0, escalT = 0, triangMenCant, i, lado1, lado2, lado3;
            string triangulosCantIng, lado1Ing, lado2Ing, lado3Ing;

            Console.Write("Ingrese la cantidad de triangulos: ");
            triangulosCantIng = Console.ReadLine();
            tringulosCant = int.Parse(triangulosCantIng);

            for (i = 1; i <= tringulosCant; i++) {

                Console.WriteLine("Ingrese los lados del rectangulo " + i);
                Console.Write("Lado 1: ");
                lado1Ing = Console.ReadLine();
                lado1 = int.Parse(lado1Ing);
                Console.Write("Lado 2: ");
                lado2Ing = Console.ReadLine();
                lado2 = int.Parse(lado2Ing);
                Console.Write("Lado 3: ");
                lado3Ing = Console.ReadLine();
                lado3 = int.Parse(lado3Ing);

                if (lado1 == lado2 && lado2 == lado3) {
                    equilaT++;
                    Console.WriteLine("El triangulo es equilatero");
                }
                else
                {
                    if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
                    {
                        isosT++;
                        Console.WriteLine("El triangulo es isósceles");
                    }
                    else
                    {
                        escalT++;
                        Console.WriteLine("El triangulo es escaleno");
                    }
                }
            }
            Console.WriteLine("La cantidad de triangulos equilateros es: " + equilaT);
            Console.WriteLine("La cantidad de triangulos isósceles es: " + isosT);
            Console.WriteLine("La cantidad de triangulos escalenos es: " + escalT);

            if (equilaT < isosT && equilaT < escalT) {
                Console.Write("El tipo de triangulo que menos se repite es el equilatero");
            }else
            {
                if (isosT < equilaT && isosT < escalT)
                {
                    Console.Write("El tipo de triangulo que menos se repite es el isósceles");
                }
                else
                {
                    if (escalT < equilaT && escalT < isosT)
                    {
                        Console.Write("El tipo de triangulo que menos se repite es el escaleno");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
