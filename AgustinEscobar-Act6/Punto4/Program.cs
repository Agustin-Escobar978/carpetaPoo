using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Operaciones
    {
        /*4. Implementar la clase operaciones. Se deben cargar dos valores enteros,
        calcular su suma, resta, multiplicación y división, cada una en un método,
        imprimir dichos resultados.*/

        public void cargarValores() {
            int num1, num2, suma, resta, mul, div;
            string datoIng;
            Console.Write("Ingrese el primer numero: ");
            datoIng = Console.ReadLine();
            num1 = int.Parse(datoIng);
            Console.Write("Ingrese el segundo numero: ");
            datoIng = Console.ReadLine();
            num2 = int.Parse(datoIng);
            suma = sumar(num1, num2);
            resta = restar(num1, num2);
            mul = multiplicar(num1, num2);
            div = dividir(num1, num2);
            imprimir(suma,resta,mul,div);
        }
        public int sumar(int n1, int n2)
        {
            int sumar = n1 + n2;
            return sumar;
        }
        public int restar(int n1, int n2)
        {
            int resta = n1 - n2;
            return resta;
        }
        public int multiplicar(int n1, int n2)
        {
            int multiplicar = n1 * n2;
            return multiplicar;
        }
        public int dividir(int n1, int n2)
        {
            int dividir = n1 / n2;
            return dividir;
        }

        public void imprimir(int s, int r, int m, int d)
        {
            Console.WriteLine("La suma es: " + s);
            Console.WriteLine("La resta es: " + r);
            Console.WriteLine("La multiplicacion es: " + m);
            Console.WriteLine("La division es: " + d);
        }
        static void Main(string[] args)
        {
            Operaciones ope1 = new Operaciones();
            ope1.cargarValores();
            Console.ReadKey();
        }
    }
}
