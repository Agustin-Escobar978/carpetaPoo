using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto5
{
    public partial class Form1 : Form
    {
        /*
         5. Solicitar el ingreso de una clave de hasta 10 caracteres en un control de
            tipo TextBox (inicializar la propiedad MaxLength con el valor 10)
            Mostrar en un cuadro de mensajes la clave ingresada al presionar un
            botón.
         */
        public Form1()
        {
            InitializeComponent();
            textBox1.MaxLength = 10;
            textBox1.UseSystemPasswordChar = true;
            label2.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label2.Text = textBox1.Text;
        }
    }
}
