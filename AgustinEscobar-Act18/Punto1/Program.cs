using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*1.Confeccionar una clase llamada DispositivoEnergia que tenga como atributos privados el
        CodigoIdentificador (string) y la GeneracionKwh (double, que representa los Kilowatts-hora
        generados). Definir sus respectivas propiedades de lectura y escritura, validando que la
        generación no sea un valor negativo (en caso de serlo, asignarle 0). Plantear un método para
        imprimir estos datos básicos.
        Luego, crear una segunda clase llamada PanelSolar que herede de DispositivoEnergia. Añadir
        un atributo propio privado llamado AreaMetros (double, que representa la superficie del panel
        en metros cuadrados) con su propiedad correspondiente (validando que sea mayor a cero).
        Implementar un método para imprimir todos los datos del panel, incluyendo los heredados.
        En el programa principal (Main):
            ● Crear un objeto de la clase DispositivoEnergia, ingresar valores y probar su impresión.
            ● Crear un objeto de la clase PanelSolar, cargar sus datos por consola y comprobar que
        puede acceder tanto a sus propiedades heredadas como a las propias para realizar la
        muestra de información.*/

    public class DispositivoEnergia {
        private string codigoIdentificador;
        private double generacionKwh;

        public DispositivoEnergia()
        {
            Console.Write("Ingrese el codigo del dispositivo: ");
            CodigoIdentificador = Console.ReadLine();
            Console.Write($"Ingrese la generacion Kwh del dispositivo {codigoIdentificador}: ");
            GeneracionKwh = double.Parse(Console.ReadLine());
        }

        public string CodigoIdentificador {
            set
            {
                codigoIdentificador = value;
            }
            get
            {
                return codigoIdentificador;
            }
        }

        public double GeneracionKwh {
            set
            {
                if(value >= 0)
                {
                    generacionKwh = value;
                }
                else
                {
                    generacionKwh = 0;
                }
            }
        }

        public void imprimirDis()
        {
            Console.WriteLine($"El codigo del dispositivo es {codigoIdentificador}\nGenera {generacionKwh}Kwh");
        }
    }

    public class PanelSolar : DispositivoEnergia{
        private double areaMetros;

        public PanelSolar()
        {
            Console.Write("Ingrese el area en metros cuadrados del panel solar: ");
            AreaMetros = double.Parse(Console.ReadLine());
        }

        public double AreaMetros {
            set
            {
                if (value > 0) {
                    areaMetros = value;
                }
                else
                {
                    bool verificacion = false;
                    do
                    {
                        Console.Write("Ingrese un area mayor a 0: ");
                        areaMetros = double.Parse(Console.ReadLine());
                        if(areaMetros > 0)
                        {
                            verificacion = true;
                        }
                        else
                        {
                            verificacion = false;
                        }
                    } while (verificacion == false);
                }
            }
            get
            {
                return areaMetros;
            }
        }

        public void imprimirPan()
        {
            imprimirDis();
            Console.WriteLine($"El area del panel solar es {areaMetros} m2");
        }
    }

    class Cargar
    {
        static void Main(string[] args)
        {
            DispositivoEnergia de1 = new DispositivoEnergia();
            de1.imprimirDis();
            PanelSolar ps1 = new PanelSolar();
            ps1.imprimirPan();

            Console.ReadKey();
        }
    }
}
