using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto7
{
    /*
     7. Selector de Color con Valores Numéricos (Investigación: NumericUpDown)
        ● Investigación: Explicar el control NumericUpDown (propiedades Minimum,
        Maximum y Value) y sus ventajas frente al TextBox.
        ● Consigna: Crear tres NumericUpDown restringidos entre 0 y 255 (Rojo, Verde,
        Azul). Un Button cambiará la propiedad BackColor del Form aplicando
        Color.FromArgb().
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Color colorF = Color.FromArgb((int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value);
            this.BackColor = colorF;
        }
    }
}
