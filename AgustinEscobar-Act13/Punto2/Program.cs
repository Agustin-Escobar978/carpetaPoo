using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*2. Implementar la clase operaciones. Se deben cargar dos valores enteros en el
        constructor, calcular su suma, resta, multiplicación y división, cada una en un
        método, imprimir dichos resultados.*/
    internal class Operaciones
    {
        private int num1;
        private int num2;
        public Operaciones() {
            Console.Write("Ingrese el valor del primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor del segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
            
        }

        public void suma()
        {
            int res = num1 + num2;
            Console.WriteLine($"La suma de ambos numeros es: {res}");
        }
        public void resta()
        {
            int res = num1 - num2;
            Console.WriteLine($"La resta de ambos numeros es: {res}");
        }
        public void multiplicacion()
        {
            int res = num1 * num2;
            Console.WriteLine($"La multiplicacion de ambos numeros es: {res}");
        }
        public void division()
        {
            int res = num1 / num2;
            Console.WriteLine($"La division de ambos numeros es: {res}");
        }

        static void Main(string[] args)
        {
            Operaciones op1 = new Operaciones();
            op1.suma();
            op1.resta();
            op1.multiplicacion();
            op1.division();


            Console.ReadKey();
        }
    }
}
