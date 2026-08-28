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
     Actividad 3: Elección de Paquete de Viaje
        Problema:
        Una agencia de viajes ofrece distintos tipos de paquetes turísticos.
        Requisitos:
        ● Usar tres RadioButton para seleccionar el destino principal: &quot;Playa&quot;, &quot;Montaña&quot; o
        &quot;Ciudad&quot;.

        ● Agregar un ComboBox para elegir la duración del viaje (ejemplo: &quot;3 días&quot;, &quot;7 días&quot;,
        &quot;15 días&quot;).
        ● Un botón &quot;Confirmar&quot; debe mostrar en un Label la opción seleccionada.
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
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
            {
                label3.Text = $"Eligue una opcion de destino";
            }
            else
            {
                label3.Text = "Tu destino es: ";
                if (radioButton1.Checked == true)
                {
                    label3.Text += "Playa";
                }else if (radioButton2.Checked == true)
                {
                    label3.Text += "Montaña";
                }else if (radioButton3.Checked == true)
                {
                    label3.Text += "Ciudad";
                }
                label3.Text += $"\nLa duracion del viaje es: {comboBox1.Text}";
            }
            label3.Visible = true;
            
            
        }
    }
}
