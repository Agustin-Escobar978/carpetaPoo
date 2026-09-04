using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto4
{
    /*
     4. Temporizador de Clics (Investigación: Timer)
        ● Investigación: Explicar el componente Timer (propiedades Interval, Enabled y
        evento Tick) con un breve ejemplo explicativo.
        ● Consigna: Crear un mini-juego donde un Button cuente cuántos clics realiza el
        usuario en 10 segundos. Al finalizar el tiempo mediante el Timer, deshabilitar el
        botón (Enabled = false) y mostrar el puntaje acumulado en un MessageBox.Show.
     */
    public partial class Form1 : Form
    {
        private int clicks = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Espere";
            label2.ForeColor = Color.Blue;
            timer1.Interval = 1500;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = "Apriete";
            label2.ForeColor = Color.Green;
            timer2.Interval = 10000;
            timer2.Enabled = true;
            clicks = 0;
            timer1.Enabled = false;
            button2.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clicks++;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            MessageBox.Show($"Haz apretado {clicks.ToString()} veces el boton");
            button2.Enabled = false;
            timer2.Enabled = false;
            label2.Text = "Quieto";
            label2.ForeColor = Color.Red;
        }
    }
}
