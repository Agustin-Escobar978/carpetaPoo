using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto3
{
    /*
     3. Solicitar el ingreso del nombre de una persona y seleccionar de un control
        ComboBox un país. Al presionar un botón mostrar en la barra del título del
        Form el nombre ingresado y el país seleccionado.
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string pais = comboBox1.Text;
            Text = $"{nombre} - {pais}";
        }
    }
}
