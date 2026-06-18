using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*2.Plantear una clase llamada CriaturaMarina y otra clase llamada HabitatAcuatico.
        La clase CriaturaMarina debe tener como atributos privados: Especie (string),
        ProfundidadOptima (int, en metros) y NivelSalinidad (un valor de 1 a 100). Definir las
        propiedades necesarias para acceder a estos atributos asegurando mediante validaciones que:
        ● La profundidad óptima sea estrictamente mayor a cero (0).
        ● El nivel de salinidad se encuentre únicamente en el rango de 1 a 100 (de lo contrario,
        asignar un valor por defecto de 35, que representa la salinidad promedio del océano).
        La clase HabitatAcuatico debe contener como atributo un vector capaz de almacenar 3 objetos
        de la clase CriaturaMarina. Definir un método dentro de HabitatAcuatico para cargar las 3
        criaturas y otro método para mostrar todas las criaturas ordenadas de menor a mayor en base
        a su profundidad óptima. Además, el programa debe informar la especie que requiere el mayor
        nivel de salinidad para sobrevivir.*/

    class CriaturaMarina {
        private string especie;
        private int profundidadOptima;
        private int nivelSalinidad;

        public CriaturaMarina()
        {
            Console.Write("Ingrese la especie de la criatura marina: ");
            Especie = Console.ReadLine();
            Console.Write($"Ingrese la profundidad optima de {especie}: ");
            ProfundidadOptima = int.Parse(Console.ReadLine());
            Console.Write($"Ingrese el nivel de salinidad de {especie}: ");
            NivelSalinidad = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        public string Especie
        {
            set
            {
                especie = value;
            }
            get
            {
                return especie;
            }
        }
        public int ProfundidadOptima
        {
            set
            {
                if(value > 0)
                {
                    profundidadOptima = value;
                }
                else
                {
                    bool verificacion = false;
                    do
                    {
                        Console.Write("Ingrese una profundidad optima mayor a 0: ");
                        profundidadOptima = int.Parse(Console.ReadLine());
                        if (profundidadOptima > 0)
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
                return profundidadOptima;
            }
        }

        public int NivelSalinidad {
            set
            {
                if(value >= 1 && value <= 100)
                {
                    nivelSalinidad = value;
                }
                else
                {
                    nivelSalinidad = 35;
                }
            }
            get
            {
                return nivelSalinidad;
            }
        }
    }

    class HabitatAcuatico
    {
        CriaturaMarina[] criaturas = new CriaturaMarina[3];

        public HabitatAcuatico()
        {
            for (int i = 0; i < criaturas.Length; i++) {
                criaturas[i] = new CriaturaMarina();
            }
        }

        public void imprimirCri()
        {
            Console.WriteLine("***Criaturas marinas***\n");
            for (int i = 0; i < criaturas.Length; i++)
            {
                Console.WriteLine($"{criaturas[i].Especie}:\nTiene una profundidad optima de {criaturas[i].ProfundidadOptima}\nY un nivel de salinidad de {criaturas[i].NivelSalinidad}\n");
            }
        }
        public void profundidadOrd()
        {
            for (int i = 1; i < criaturas.Length; i++)
            {
                for (int j = 0; j < criaturas.Length - i; j++)
                {
                    if (criaturas[j].ProfundidadOptima > criaturas[j + 1].ProfundidadOptima)
                    {
                        string auxEs = criaturas[j].Especie;
                        int auxPo = criaturas[j].ProfundidadOptima;
                        int auxNs = criaturas[j].NivelSalinidad;
                        criaturas[j].Especie = criaturas[j + 1].Especie;
                        criaturas[j].ProfundidadOptima = criaturas[j + 1].ProfundidadOptima;
                        criaturas[j].NivelSalinidad = criaturas[j + 1].NivelSalinidad;
                        criaturas[j + 1].Especie = auxEs;
                        criaturas[j + 1].ProfundidadOptima = auxPo;
                        criaturas[j + 1].NivelSalinidad = auxNs;
                    }
                }
            }
            Console.WriteLine("***orden de menor a mayor segun la profundidad optima de cada especie***\n");
            for (int k = 0; k < criaturas.Length; k++) {
                Console.WriteLine($"{criaturas[k].Especie} con un nivel de profundidad de {criaturas[k].ProfundidadOptima}\n");
            }
        }

        public void mayorSal()
        {
            int mayorS = criaturas[0].NivelSalinidad;
            for (int i = 0; i < criaturas.Length; i++) {
                if(mayorS < criaturas[i].NivelSalinidad)
                {
                    mayorS = criaturas[i].NivelSalinidad;
                }
            }
            Console.WriteLine("***La/las criaturas que necesitan mas nivel de salinidad para sobrevivir***");
            for (int j = 0; j < criaturas.Length; j++) {
                if (mayorS == criaturas[j].NivelSalinidad)
                {
                    Console.WriteLine($"{criaturas[j].Especie} con {criaturas[j].NivelSalinidad}\n");
                }
            }
        }
        static void Main(string[] args)
        {
            HabitatAcuatico ha1 = new HabitatAcuatico();
            ha1.imprimirCri();
            ha1.profundidadOrd();
            ha1.mayorSal();

            Console.ReadKey();
        }
    }
}
