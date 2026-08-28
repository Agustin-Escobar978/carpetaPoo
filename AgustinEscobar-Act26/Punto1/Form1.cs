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
     1. Disponer tres objetos de la clase CheckBox con nombres de navegadores web.
        Cuando se presione un botón mostrar en el título del Form los programas
        seleccionados.
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Text = "";
            if (checkBox1.Checked == true)
            {
                Text = Text + checkBox1.Text;
            }if (checkBox2.Checked == true)
            {
                Text = Text + checkBox2.Text;
            }if (checkBox3.Checked == true)
            {
                Text = Text + checkBox3.Text;
            }
        }
    }
}
