using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    /*
        4- Un sistema central de domótica gestiona el consumo de los artefactos inteligentes vinculados a una red hogareña.
         Crear la clase DispositivoInteligente que contenga como atributos
        privados: nombreDispositivo (string) y consumoWatts (double). Definir
        sus propiedades y un constructor que reciba nom y watts.
         Crear la clase colaboradora PanelDomotico que administre un objeto
        List&lt;DispositivoInteligente&gt;.
         Métodos en PanelDomotico:
            1. Un constructor que permita al usuario cargar dinámicamente
            dispositivos por teclado. El sistema preguntará después de cada
            carga si se desea agregar otro dispositivo.
            2. MostrarDispositivos(): Listar todos los dispositivos
            configurados junto a sus consumos.
            3. CalcularConsumoTotal(): Calcular y mostrar en pantalla los
            Watts totales que consume la casa sumando los valores de la lista.
            4. DesconectarDispositivo(): Solicitar al usuario el nombre de
            un dispositivo y, si existe en la lista, removerlo de forma dinámica
            para simular su apagado remoto.*/
    
    class DispositivoInteligente
    {
        private string nombreDispositivo;
        private double consumoWatts;

        public string NombreDispositivo
        {
            get { return nombreDispositivo; }
        }
        public double ConsumoWatts
        {
            get { return consumoWatts; }
        }

        public DispositivoInteligente(string nom, double watts)
        {
            nombreDispositivo = nom;
            consumoWatts = watts;
        }
    }

    class PanelDomotico
    {
        List<DispositivoInteligente> dispositivos = new List<DispositivoInteligente>();

        public PanelDomotico()
        {
            bool bucle = true;
            do
            {
                Console.Write("Ingrese un dispositivo que controle el panel: ");
                string dispositivo = Console.ReadLine();
                Console.Write($"Ingrese el consumo de watts de {dispositivo}: ");
                double consumo = double.Parse(Console.ReadLine());
                DispositivoInteligente nuevoDispositivo = new DispositivoInteligente(dispositivo, consumo);
                dispositivos.Add(nuevoDispositivo);
                Console.Write("Desea agregar otro dispositivo Y/N: ");
                string texto = Console.ReadLine();
                if(texto != "Y")
                {
                    bucle = false;
                }
            } while (bucle == true);
            Console.WriteLine();
        }

        public void mostrarDispositivos()
        {
            foreach(DispositivoInteligente dispositivo in dispositivos)
            {
                Console.WriteLine($"- {dispositivo.NombreDispositivo} tiene un consumo de {dispositivo.ConsumoWatts}W");
            }
            Console.WriteLine();
        }

        public void calcularConsumoTotal()
        {
            double consumoTotal = 0;
            foreach(DispositivoInteligente dispositivo in dispositivos)
            {
                consumoTotal += dispositivo.ConsumoWatts;
            }
            Console.WriteLine($"La casa consume un total de {consumoTotal}W\n");
        }

        public void desconectarDispositivo()
        {
            Console.Write("Ingrese el nombre de un dispositivo para apagarlo: ");
            string texto = Console.ReadLine();
            bool verificarExistencia = false;
            foreach (DispositivoInteligente dispositivo in dispositivos)
            {
                if (texto == dispositivo.NombreDispositivo)
                {
                    dispositivos.Remove(dispositivo);
                    verificarExistencia = true;
                    break;
                }
            }
            if (verificarExistencia)
            {
                Console.WriteLine("***El dispositivo fue apagado***\n");
            }
            else
            {
                Console.WriteLine("El dispositivo no esta en el panel");
            }
        }
    }


    class Cargar
    {
        static void Main(string[] args)
        {
            PanelDomotico pd1 = new PanelDomotico();
            pd1.mostrarDispositivos();
            pd1.calcularConsumoTotal();
            pd1.desconectarDispositivo();

            Console.ReadKey();
        }
    }
}
