using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto2
{
    /*
     2. Conversor de Temperatura
        ● Consigna: Disponer un TextBox para el ingreso numérico y dos RadioButton:
        &quot;Celsius a Fahrenheit&quot; y &quot;Fahrenheit a Celsius&quot;. Al presionar un Button, realizar la
        fórmula correspondiente y mostrar el resultado en un Label.
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                label2.Visible = true;
                label2.Text = "Eliga una de las dos opciones";
            }
            else
            {

                double temperatura = double.Parse(textBox1.Text);
                if (radioButton1.Checked == true)
                {
                    temperatura = (temperatura * 9 / 5) + 32;
                }
                else if (radioButton2.Checked == true)
                {
                    temperatura = (temperatura - 32) * 5 / 9;
                }
                temperatura = Math.Round(temperatura, 3);
                label2.Visible = true;
                label2.Text = temperatura.ToString();
            }
        }
    }
}
