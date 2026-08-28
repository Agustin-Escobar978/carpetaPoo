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
     2. Permitir el ingreso de dos números en controles de tipo TextBox y mediante
        dos controles de tipo RadioButton permitir seleccionar si queremos sumarlos o
        restarlos. Al presionar un botón mostrar en el título del Form el resultado de la
        operación.
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                int resultado = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
                Text = resultado.ToString();
            } else if (radioButton2.Checked == true)
            {
                int resultado = int.Parse(textBox1.Text) - int.Parse(textBox2.Text);
                Text = resultado.ToString();
            }
        }
    }
}
