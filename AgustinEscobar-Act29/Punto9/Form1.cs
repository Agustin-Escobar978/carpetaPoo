using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto9
{
    /*
     9. Cálculo de Edad (Investigación: DateTimePicker)
        ● Investigación: Investigar el control DateTimePicker (propiedad Value de tipo
        DateTime).
        ● Consigna: Permitir que el usuario elija su fecha de nacimiento. Mediante un Button,
        calcular los años cumplidos restando la fecha elegida con DateTime.Now.Year y
        mostrarlo en un Label.
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int años = DateTime.Now.Year - dateTimePicker1.Value.Year;
            label3.Visible = true;
            label3.Text = $"Tienes {años} años";
        }
    }
}
