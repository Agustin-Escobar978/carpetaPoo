using System;
using System.Collections.Generic;
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
            set { codigo = value;  }
            get { return codigo; }
        } 
        public float Peso
        {
            set {  peso = value; }
            get { return peso;  }
        }
        public string Destino
        {
            set { destino = value;  }
            get { return destino; }
        }
    }

    class Despachador
    {
        List <Paquete> paquetes = new List<Paquete>();  

        public void crearPaquete()
        {
            Console.Write("Ingrese el codigo del paquete: ");
            int cod = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el peso del paquete: ");
            float pes = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el destino del paquete: ");
            string des = Console.ReadLine();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
