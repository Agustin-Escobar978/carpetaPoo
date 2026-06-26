using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*Actividad 2: Administración de entregas logísticas
        Problema:
        Una empresa de envíos desea registrar sus entregas mediante colaboración de
        clases.
        Crear una clase Paquete con propiedades: código, peso y destino. Crear una clase
        Despachador que contenga una lista de paquetes y un método para registrar nuevos
        paquetes.
        Desde el método Main, instanciar un Despachador, cargar 5 paquetes y mostrar:
             Todos los paquetes registrados.
             Cuántos superan los 10 kg de peso.
             Cuántos tienen destino nacional (por ejemplo, “Argentina”).*/
    class Paquete
    {
        private int codigo;
        private float peso;
        private string destino;

        public int Codigo
        {
            set { codigo = value; }
            get { return codigo; }
        }
        public float Peso
        {
            set { peso = value; }
            get { return peso; }
        }
        public string Destino
        {
            set { destino = value; }
            get { return destino; }
        }

        public Paquete(int c, float p, string d)
        {
            Codigo = c;
            Peso = p;
            Destino = d;
        }

    }

    class Despachador
    {
        List<Paquete> paquetes = new List<Paquete>();

        public void crearPaquete()
        {
            Console.Write("Ingrese el codigo del paquete: ");
            int cod = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el peso del paquete: ");
            float pes = float.Parse(Console.ReadLine());
            Console.Write("Ingrese el destino del paquete: ");
            string des = Console.ReadLine();
            Paquete paq = new Paquete(cod, pes, des);
            paquetes.Add(paq);
            Console.WriteLine();

        }

        public void imprimir()
        {
            Console.WriteLine("***Los paquetes y sus datos***\n");
            foreach (Paquete paq in paquetes)
            {
                Console.WriteLine($"El paquete {paq.Codigo} tiene un peso de {paq.Peso} kg y su destino es {paq.Destino}\n");
            }
        }

        public void superarPeso()
        {
            Console.WriteLine("***El/Los paquetes que superaron los 10 kg fueron***\n");
            foreach (Paquete paq in paquetes)
            {
                if (paq.Peso > 10)
                {
                    Console.WriteLine($"{paq.Codigo} con {paq.Peso}\n");
                }
            }
        }

        public void destinoNacional()
        {
            Console.WriteLine("***El/los paquetes con destino nacional son***\n");
            foreach (Paquete paq in paquetes)
            {
                if (paq.Destino == "Argentina")
                {
                    Console.WriteLine($"Codigo: {paq.Codigo}\n");
                }
            }
        }
    }

    class Cargar
    {
        static void Main(string[] args)
        {
            Despachador des1 = new Despachador();

            for (int i = 0; i < 5; i++)
            {
                des1.crearPaquete();
            }
            des1.imprimir();
            des1.superarPeso();
            des1.destinoNacional();

            Console.ReadKey();
        }
    }
}
