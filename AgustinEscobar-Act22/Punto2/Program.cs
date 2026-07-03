using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*Actividad 2: Posicionamiento de elementos en consola
    Problema:
    Definir una clase ElementoPantalla con atributos: nombre, posX y posY.
     Implementar propiedades y un constructor que cargue valores.
     Crear un método Mostrar() que use Console.SetCursorPosition() para ubicar el
    nombre en pantalla y Console.CursorVisible para ocultar el cursor.
     Generar un vector de 4 elementos y mostrarlos en distintas posiciones en la
    consola.*/
    class ElementoPantalla
    {
        private string nombre;
        private int posX;
        private int posY;
        
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public int PosX
        {
            set { posX = value; }
            get { return posX; }
        }
        public int PosY
        {
            set { posY = value; }
            get { return posY; }
        }

        public ElementoPantalla()
        {
            Console.Write("Ingrese un nombre: ");
            Nombre = Console.ReadLine();
            Console.Write($"Ingrese la posicion x de {Nombre}: ");
            PosX = int.Parse(Console.ReadLine());
            Console.Write($"Ingrese la posicion y de {Nombre}: ");
            PosY = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        public void Mostrar() {
            Console.CursorVisible = false;
            Console.SetCursorPosition(PosX, PosY);
            Console.Write(nombre);
        }

        static void Main(string[] args)
        {
            ElementoPantalla[] ep1 = new ElementoPantalla[4];
            for(int i = 0; i < 4; i++)
            {
                ep1[i] = new ElementoPantalla();
            }

            Console.Clear();
            for(int j = 0; j < ep1.Length; j++)
            {
                ep1[j].Mostrar();

            }
            Console.ReadKey();

        }
    }
}
