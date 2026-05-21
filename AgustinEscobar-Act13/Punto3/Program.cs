using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*3. Plantear una clase Club y otra clase Socio.
        La clase Socio debe tener los siguientes atributos privados: nombre y la
        antigüedad en el club (en años). En el constructor pedir la carga del nombre y
        su antigüedad. La clase Club debe tener como atributos 3 objetos de la clase
        Socio. Definir una responsabilidad para imprimir el nombre del socio con mayor
        antigüedad en el club.*/

    class Socio
    {
        private string nombre;
        private int antiguedad;

        public Socio()
        {
            Console.Write("Ingrese el nombre del socio: ");
            nombre = Console.ReadLine();
            Console.Write($"Ingrese la antiguedad de {nombre}: ");
            antiguedad = int.Parse(Console.ReadLine());
        }

        public int RetornarAnt()
        {
            return antiguedad;
        }

        public string RetornarNom()
        {
            return nombre;
        }
    }
    class Club
    {
        private Socio socio1, socio2, socio3;

        public Club()
        {
            socio1 = new Socio();
            socio2 = new Socio();
            socio3 = new Socio();
        }

        public void Responsabilidad() {
            if(socio1.RetornarAnt() > socio2.RetornarAnt() && socio1.RetornarAnt() > socio3.RetornarAnt())
            {
                Console.WriteLine($"La edad mas antigua la tiene {socio1.RetornarNom()} con {socio1.RetornarAnt()} años");
            }else if (socio2.RetornarAnt() > socio1.RetornarAnt() && socio2.RetornarAnt() > socio3.RetornarAnt())
            {
                Console.WriteLine($"La edad mas antigua la tiene {socio2.RetornarNom()} con {socio2.RetornarAnt()} años");
            }else if (socio3.RetornarAnt() > socio1.RetornarAnt() && socio3.RetornarAnt() > socio1.RetornarAnt())
            {
                Console.WriteLine($"La edad mas antigua la tiene {socio3.RetornarNom()} con {socio3.RetornarAnt()} años");
            }
        }


        static void Main(string[] args)
        {
            Club c1 = new Club();
            c1.Responsabilidad();

            Console.ReadKey();
        }
    }
}
