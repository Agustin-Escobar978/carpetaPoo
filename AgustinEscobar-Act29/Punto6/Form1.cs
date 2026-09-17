using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto6
{
    /*
     6. Simulador de Carrito de Compras
        ● Consigna: Disponer tres CheckBox con productos y precios fijos. Un Button
        &quot;Calcular Total&quot; debe evaluar los controles seleccionados (Checked == true), sumar
        sus costos y mostrar el monto final en un Label.
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total = 0;
            if (checkBox1.Checked == true)
            {
                total += 2000;
            }
            if (checkBox2.Checked == true)
            {
                total += 800;
            }
            if (checkBox3.Checked == true)
            {
                total += 1500;
            }
            label2.Text = $"Precio total: {total}";
        }
    }
}
