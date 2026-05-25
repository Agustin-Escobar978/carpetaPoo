using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    /*4. Plantear una clase Alumno que tenga los atributos privados: nombre y un
        vector de 4 notas. Definir un constructor que solicite el ingreso del nombre del
        alumno y sus 4 calificaciones.
        Luego, confeccionar una clase Curso que contenga un vector de 3 objetos
        Alumno.
        Agregar los siguientes métodos:
        a) Un método que imprima el nombre de cada alumno y su promedio.
        b) Un método que muestre el nombre del alumno con el promedio más
        alto.
        c) Un método que indique qué alumnos tienen al menos una nota
        desaprobada (nota menor a 6)*/
    class Alumno {
        private string nombre;
        private int[] notas;

        public Alumno(){
            notas = new int[4];
            Console.Write("Ingrese el nombre del alumno: ");
            nombre = Console.ReadLine();
            for (int i = 0; i < notas.Length; i++) {
                bool verif = false;
                do {
                    Console.Write($"Ingrese la {i + 1}º nota de {nombre}: ");
                    notas[i] = int.Parse(Console.ReadLine());
                    if (notas[i] <= 10 && notas[i] >= 0)
                    {
                        verif = true;
                    }
                    else {
                        Console.WriteLine("***Ingrese un valor de 0 a 10 y que sea entero***");
                    }
                } while (verif == false);
            }
            Console.WriteLine();
        }

        public string retornarNom() {
            return nombre;
        }

        public float retornarProm() {
            float prom = 0;
            for (int i = 0; i < notas.Length; i++) {
                prom += notas[i];
            }
            prom /= notas.Length;
            return prom;
        }

        public bool verificacion() {
            for (int i = 0; i < notas.Length; i++) {
                if (notas[i] < 6) {
                    return false;
                }
            }
            return true;
        }

        
    }
    class Curso
    {
        Alumno[] alumnos = new Alumno[3];
        public Curso() {
            for (int i = 0; i < alumnos.Length; i++) {
                alumnos[i] = new Alumno();
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("***Los alumnos y sus promedios***\n");
            for (int i = 0; i < alumnos.Length; i++) {
                Console.WriteLine($"{alumnos[i].retornarNom()}: {alumnos[i].retornarProm()}\n");
            }
        }

        public void promedioAlt() {
            float promAlt = alumnos[0].retornarProm();
            for (int i = 0; i < alumnos.Length; i++)
            {
                float promAct = alumnos[i].retornarProm();
                if (promAlt < promAct) {
                    promAlt = promAct;
                }
            }
            Console.WriteLine("***El/los alumnos con el promedio mas alto son***");
            for (int j = 0; j < alumnos.Length; j++) {
                float promAct = alumnos[j].retornarProm();
                if (promAlt == promAct) {
                    Console.WriteLine(alumnos[j].retornarNom());
                }
            }
        }

        public void verificacionNot() {
            Console.WriteLine("***Alumno con almenos una prueba desaprobada***");
            for (int i = 0; i < alumnos.Length; i++) {
                if (alumnos[i].verificacion() == false) {
                    Console.WriteLine(alumnos[i].retornarNom());
                }
            }
        }

        static void Main(string[] args)
        {
            Curso c1 = new Curso();
            c1.Imprimir();
            c1.promedioAlt();
            c1.verificacionNot();

            Console.ReadKey();
        }
    }
}
