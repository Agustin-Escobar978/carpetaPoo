using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto4
{
    /*
     4. Elaborar una interfaz gráfica que muestre una calculadora (utilizar
        objetos de la clase Button y un objeto de la clase Label donde se
        muestra el valor ingresado), tener en cuenta que solo se debe
        implementar la interfaz y la carga de un valor de hasta 12 dígitos.
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + "1";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + "3";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + "4";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + "5";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + "6";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + "7";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + "8";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + "9";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + "0";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + ",";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + "X";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + "-";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + "+";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + "=";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + "/";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + "%";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

    }
}
