using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*3. Competencia de Atletismo
        Plantear una clase llamada Atleta que tenga como atributos privados el Nombre y el TiempoSegundos (tiempo que tardó en completar una carrera). Definir un constructor para ingresar ambos datos.
        Luego, crear una clase llamada Carrera que administre 3 objetos de la clase Atleta como atributos de la clase.
        Definir los siguientes métodos en la clase Carrera:
            Un constructor que cargue los datos de los 3 atletas de la carrera.
            Un método que imprima los nombres de los atletas junto con sus marcas de tiempo.
            Un método que calcule e imprima el tiempo promedio de la carrera.
            Un método que informe el nombre del atleta ganador de la carrera (aquel que completó la prueba en el menor tiempo).
            Un método que muestre a los atletas que superaron el promedio.
*/
    class Atleta {
        private string Nombre;
        private float Tiempo;

        public Atleta() {
            Console.Write("\nIngrese el nombre del atleta: ");
            Nombre = Console.ReadLine();
            Console.Write($"Ingrese el tiempo de {Nombre}: ");
            Tiempo = float.Parse(Console.ReadLine());
        }

        public string RetornarNom() {
            return Nombre;
        }

        public float RetornarTie() {
            return Tiempo;
        }
    }

    class Carrera
    {
        Atleta[] Atletas = new Atleta[3];

        public Carrera() {
            for (int i = 0; i < Atletas.Length; i++) {
                Atletas[i] = new Atleta();
            }
        }

        public void Imprimir() {
            for (int i = 0; i < Atletas.Length; i++) {
                Console.WriteLine($"\nEl nombre del {i + 1}° atleta es {Atletas[i].RetornarNom()} y su tiempo es {Atletas[i].RetornarTie()}");
            }
        }

        public void Promedio() {
            float prom = 0;
            for (int i = 0; i < Atletas.Length; i++) {
                prom += Atletas[i].RetornarTie();
            }
            prom /= Atletas.Length;
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            Carrera c1 = new Carrera();
            c1.Imprimir();

            Console.ReadKey();
        }
    }
}
