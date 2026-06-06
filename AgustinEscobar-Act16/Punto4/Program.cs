using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Punto4
{
    /*4. Armar tres clases: Animal, Mamífero y Perro.
        La clase Animal debe tener un atributo especie.
        La clase Mamífero, que hereda de Animal, debe tener un atributo
        tipoAlimentacion.
        La clase Perro, que hereda de Mamífero, debe tener un atributo nombre.
        Cada clase debe tener un constructor que reciba los datos correspondientes
        y los imprima indicando a qué clase pertenecen. Los datos deben ser
        asignados previamente
        Crear un objeto de la clase Perro y verificar la ejecución en cadena de los
        constructores.*/

    public class Animal {
        protected string especie;

        public Animal(string e) {
            especie = e;
            Console.WriteLine($"La especie del animal es: {especie} y pertenece a la clase Animal");
        }
    }

    public class Mamifero : Animal {
        protected string tipoAlimentacion;

        public Mamifero(string e, string ta) : base(e) {
            tipoAlimentacion = ta;
            Console.WriteLine($"El tipo de alimentacion de las/los {especie} es: {tipoAlimentacion} y pertenece a la clase Mamifero");
        }
    }

    public class Perro : Mamifero{
        private string nombre;

        public Perro(string e, string ta, string n) : base(e, ta) {
            nombre = n;
            Console.WriteLine($"El nombre del Perro es: {nombre} y pertenece a la clase Perro");
        }
    }

    class Cargar
    {
        static void Main(string[] args)
        {
            Perro p1 = new Perro("Canidos", "Carne", "Marley");

            Console.ReadKey();
        }
    }
}
