using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*3. Fábrica de Computadoras (Herencia y Constructores con base)
        Crear una clase base llamada Computadora que contenga los atributos Marca y
        MemoriaRAM (en GB). Definir un constructor que reciba estos dos valores obligatoriamente.
        Luego, definir dos clases derivadas de la clase base:
         Notebook: que añade el atributo propio TamanoPantalla (en pulgadas).
         Escritorio: que añade el atributo propio PotenciaFuente (en Watts).
        Cada una de estas clases derivadas debe poseer su propio constructor, el cual debe recibir
        tanto los atributos específicos como los de la clase base, transfiriendo estos últimos a la
        clase Computadora mediante el uso explícito de la palabra clave base. Instanciar un objeto
        de cada clase derivada en el Main y mostrar la totalidad de sus datos por consola.*/

    public class Computadora {
        protected string marca;
        protected int memoriaRam;

        public Computadora(string m, int mr) {
            marca = m;
            memoriaRam = mr;
        }
    }

    public class Notebook : Computadora{
        private float tamañoPantalla;

        public Notebook(string m, int mr, float tp) : base(m, mr) {
            tamañoPantalla = tp;
            Console.WriteLine($"La notebook es de marca {marca}\nTiene {memoriaRam}Gb de ram\nY su tamaño de pantalla es de {tamañoPantalla} pulgadas\n");
        }
    }

    public class Escritorio : Computadora{
        private float potenciaFuente;

        public Escritorio(string m, int mr, float w) : base(m, mr) {
            potenciaFuente = w;
            Console.WriteLine($"La computadora de escritorio es de la marca {marca}\nTiene {memoriaRam}Gb de ram\nY la potencia de la fuente es de {potenciaFuente}w\n");
        }
    }

    class Cargar
    {
        static void Main(string[] args)
        {
            Notebook n1 = new Notebook("HP", 8, 15.6f);

            Escritorio e1 = new Escritorio("Lenovo", 16, 210.5f);

            Console.ReadKey();
        }
    }
}
