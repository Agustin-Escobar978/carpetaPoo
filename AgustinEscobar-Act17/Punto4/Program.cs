using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    /*4. Cadena de Herramientas (Herencia Multinivel y Orden de Constructores)
        Armar una estructura jerárquica compuesta por tres clases consecutivas en una línea de
        herencia: Material, Herramienta y Martillo.
         La clase Material (base) debe tener un atributo TipoMaterial (ej: Madera, Acero,
        Plástico).
         La clase Herramienta (que hereda de Material) debe añadir el atributo
        FuncionPrincipal.
         La clase Martillo (que hereda de Herramienta) debe añadir el atributo PesoGramos.
        Cada una de las tres clases debe contar con un constructor encargado de recibir sus datos
        correspondientes. Al momento de ejecutarse, cada constructor debe realizar la asignación y,
        acto seguido, imprimir un mensaje en consola indicando a qué clase pertenece
        (ejemplo: "Constructor de la clase Material ejecutado").
        En el método Main, crear únicamente un objeto de la clase final Martillo pasándole todos los
        parámetros requeridos. Observar y verificar en la consola el orden secuencial de ejecución
        en cadena de los constructores (desde la raíz hasta la clase derivada).*/

    public class Material{
        protected string tipoMaterial;

        public Material(string tm) {
            tipoMaterial = tm;
            Console.WriteLine($"Constructor de la clase material ejecutado - {tipoMaterial}");
        }
    }

    public class Herramienta : Material{
        protected string funcionPrincipal;
        
        public Herramienta(string tp, string fp) : base(tp)
        {
            funcionPrincipal = fp;
            Console.WriteLine($"Constructor de la clase herramienta ejecutado - {funcionPrincipal}");
        }
    }

    public class Martillo : Herramienta{
        protected float pesoGramo;

        public Martillo(string tp, string fp, float pg) : base(tp, fp) {
            pesoGramo = pg;
            Console.WriteLine($"Constructor de la clase martillo ejecutado - {pesoGramo} g");
        }
    }

    internal class Cargar
    {
        static void Main(string[] args)
        {
            Martillo m1 = new Martillo("Madera", "golpear", 500);

            Console.ReadKey();
        }
    }
}
