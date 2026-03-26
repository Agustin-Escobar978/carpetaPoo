using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4. En un banco se procesan datos de las cuentas corrientes de sus clientes. De cada cuenta corriente se conoce: número de cuenta y saldo actual. El ingreso de 
             datos debe finalizar al ingresar un valor negativo en el número de cuenta. Se pide confeccionar un programa que lea los datos de las cuentas corrientes e informe:
             a) De cada cuenta: número de cuenta y estado de la cuenta según su saldo, sabiendo que: 
                Estado de la cuenta:
                    ○ “Acreedor” si el saldo es > 0.
                    ○ “Deudor” si el saldo es < 0.
                    ○ “Nulo” si el saldo es = 0.
            b) La suma total de los saldos acreedores.*/
            int numCuen, saldoAct, suma;
            string numCuenIng, saldoActIng;

            suma = 0;

            do
            {
                Console.Write("Ingresa el numero de cuenta: ");
                numCuenIng = Console.ReadLine();
                numCuen = int.Parse(numCuenIng);
                if (numCuen >= 0)
                {
                Console.Write("Ingresa el saldo de la cuenta: ");
                saldoActIng = Console.ReadLine();
                saldoAct = int.Parse(saldoActIng);

               
                    Console.WriteLine("El numero de cuenta es: " + numCuen);
                    if (saldoAct > 0)
                    {
                        Console.WriteLine("El estado de cuenta es Acreedor");
                        suma += saldoAct;
                    }
                    else
                    {
                        if (saldoAct == 0)
                        {
                            Console.WriteLine("El estado de cuenta es Nulo");
                        }
                        else
                        {
                            if (saldoAct < 0)
                            {
                                Console.WriteLine("El estado de cuenta es Deudor");
                            }
                        }
                    } 
                }

            } while (numCuen >= 0);

            Console.WriteLine("La suma de los Acreedores es: " + suma);
        }
    }
}
