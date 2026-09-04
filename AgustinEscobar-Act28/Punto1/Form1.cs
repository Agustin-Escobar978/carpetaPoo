using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto1
{

    /*
     1. Calculadora de Promedio de Notas
        ● Consigna: Crear un formulario con tres TextBox para ingresar notas y un Button
        &quot;Calcular&quot;. Convertir los valores con int.Parse() o double.Parse() y mostrar en una
        Label el promedio. Si la nota es mayor o igual a 6, cambiar el color del texto de la
        etiqueta a verde; de lo contrario, a rojo.
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nota1 = double.Parse(textBox1.Text);
            double nota2 = double.Parse(textBox2.Text);
            double nota3 = double.Parse(textBox3.Text);
            if (nota1 > 10 || nota1 < 0 || nota2 > 10 || nota2 < 0 || nota3 > 10 || nota3 < 0)
            {
                label4.ForeColor = Color.Black;
                label4.Text = "Ingrese numeros entre 0 y 10";
            }
            else
            {
                double promedio = (nota1 + nota2 + nota3) / 3;
                promedio = Math.Round(promedio, 2);
                string promT = promedio.ToString();
                label4.Text = "Promedio total: ";
                if (promedio >= 6)
                {
                    label4.ForeColor = Color.Green;
                    label4.Text += promT;
                }
                else
                {
                    label4.ForeColor = Color.Red;
                    label4.Text += promedio;
                }
            }
        }
    }
}
