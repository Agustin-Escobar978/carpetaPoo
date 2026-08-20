using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*
        8-Una farmacia controla el nivel de stock de sus medicamentos para evitar el
        desabastecimiento de insumos esenciales.
         Crear la clase Medicamento que contenga los atributos privados: nombre
        (string) y stock (int). Definir sus propiedades correspondientes. Su
        constructor debe recibir nom y stk.
         Crear la clase ControlFarmacia que administre una lista de objetos List.
         Métodos en ControlFarmacia:
        o Un constructor que cargue por teclado una lista inicial de 4
        medicamentos ingresando sus nombres y stock.
        o ListarStock(): Mostrar la lista de medicamentos en pantalla.

        o RemoverAgotados(): Recorrer la lista y remover por completo de
        la colección a todos aquellos medicamentos cuyo stock sea igual a 0.
        o MostrarMedicamentosDisponibles(): Imprimir la lista
        actualizada y la cantidad de productos disponibles en el inventario
        utilizando la propiedad .Count.
     */
    class Medicamento
    {
        private string nombre;
        private int stock;

        public string Nombre
        {
            get { return nombre; }
        }
        public int Stock
        {
            get { return stock; }
        }

        public Medicamento(string nom, int stk)
        {
            nombre = nom;
            stock = stk;
        }
    }

    class ControlFarmacia
    {
        List <Medicamento> medicamentos = new List<Medicamento>();

        public ControlFarmacia()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Ingrese el nombre del {i + 1}° primeer medicamento: ");
                string nom = Console.ReadLine();
                Console.Write($"Ingrese el stock de {nom}: ");
                int stk = int.Parse(Console.ReadLine());
                Medicamento nuevoMedicamento = new Medicamento(nom, stk);
                medicamentos.Add(nuevoMedicamento);
            }
            Console.WriteLine();
        }

        public void listarStock()
        {
            Console.WriteLine("***Lista de medicamentos***\n");
            for(int i = 0; i < medicamentos.Count; i++)
            {
                Console.WriteLine($"-{medicamentos[i].Nombre} tiene un stock de: {medicamentos[i].Stock}");
            }
            Console.WriteLine();
        }

        public void removerAgotados()
        {
            medicamentos.RemoveAll(med => med.Stock == 0);
            Console.WriteLine("***Todos los medicamentos con un stock de 0 fueron eliminados***\n");
        }

        public void MostrarMedicamentosDisponibles()
        {
            Console.WriteLine("***Lista de medicamentos actualizada***");
            for (int i = 0; i < medicamentos.Count; i++)
            {
                Console.WriteLine($"-{medicamentos[i].Nombre} tiene un stock de: {medicamentos[i].Stock}");
            }
            Console.WriteLine();
        }
    }


    class Cargar
    {
        static void Main(string[] args)
        {
            ControlFarmacia cf1 = new ControlFarmacia();
            cf1.listarStock();
            cf1.removerAgotados();
            cf1.MostrarMedicamentosDisponibles();

            Console.ReadKey();
        }
    }
}
