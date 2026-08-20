using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*  7-Un restaurante automatizado procesa la comanda de una mesa para controlar la
        preparación y el cobro de los platos pedidos.
         Crear la clase Plato que contenga como atributos privados: nombrePlato
        (string) y precio (double). Definir sus propiedades correspondientes y un
        constructor que reciba nom y pre.
         Crear la clase GestionComandas que administre una lista de objetos List.
         Métodos en GestionComandas:
        o AgregarPlato():Solicitar por teclado los datos de un plato y
        agregarlo a la lista utilizando .Add().
        o MostrarComanda(): Listar todos los platos agregados hasta el
        momento junto a la cantidad total de ítems pedidos utilizando la
        propiedad .Count.
        o CalcularTotalMesa(): Calcular y mostrar en pantalla el monto
        total a cobrar sumando los precios de la lista.
        o CancelarPlato(): Solicitar al usuario el nombre de un plato y, si
        se encuentra en la lista, removerlo mediante .Remove() para
        actualizar la comanda.*/

    class Plato
    {
        private string nombrePlato;
        private double precio;

        public string NombrePlato
        {
            get { return nombrePlato; }
        }
        public double Precio
        {
            get { return precio; }
        }

        public Plato(string nom, double pre)
        {
            nombrePlato = nom;
            precio = pre;
        }

    }

    class GestionComandas
    {
        List<Plato> platos = new List<Plato>();

        public void agregarPlato()
        {
            Console.Write("Ingrese el nombre del plato: ");
            string nombrePlato = Console.ReadLine();
            Console.Write($"Ingrese el precio de {nombrePlato}: ");
            double precio = double.Parse(Console.ReadLine());
            Plato nuevoPlato = new Plato(nombrePlato, precio);
            platos.Add(nuevoPlato);
            Console.WriteLine();
        }

        public void mostrarComanda()
        {
            Console.WriteLine("***Lista de pedidos***\n");
            for (int i = 0; i < platos.Count; i++)
            {
                Console.WriteLine($"- {platos[i].NombrePlato} cuesta {platos[i].Precio}$");
            }
            Console.WriteLine($"En total se pidieron {platos.Count} platos\n");
        }

        public void calcularTotalMesa()
        {
            double totalMesa = 0; 
            for (int i = 0; i < platos.Count; i++)
            {
                totalMesa += platos[i].Precio;
            }
            Console.WriteLine($"El total de la meza es: {totalMesa}$\n");
        }

        public void cancelarPlato() 
        {
            Console.Write("Ingrese el nombre de un plato para eliminarlo: ");
            string platoN = Console.ReadLine();
            for (int i = 0; i < platos.Count; i++)
            {
                if (platos[i].NombrePlato == platoN)
                {
                    platos.Remove(platos[i]);
                    Console.WriteLine("Plato eliminado con exito\n");
                    break;
                }else if(i == platos.Count - 1){
                    Console.WriteLine("Plato no encontrado\n");
                }
                
            }
        }

    }

    class Cargar
    {
        static void Main(string[] args)
        {
            GestionComandas gc1 = new GestionComandas();
            gc1.agregarPlato();
            gc1.agregarPlato();
            gc1.agregarPlato();
            gc1.agregarPlato();
            gc1.mostrarComanda();
            gc1.calcularTotalMesa();
            gc1.cancelarPlato();

            Console.ReadKey();
        }
    }
}
