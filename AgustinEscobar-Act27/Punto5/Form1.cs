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
    /*
     Actividad 5: Configuración de Suscripción
        Problema:
        Una aplicación ofrece distintos niveles de suscripción.
        Requisitos:
        ● Usar un ComboBox para elegir el tipo de plan: &quot;Gratis&quot;, &quot;Básico&quot;, &quot;Premium&quot;.
        ● Incluir dos CheckBox para elegir servicios adicionales (por ejemplo: &quot;Soporte
        técnico&quot;, &quot;Acceso anticipado&quot;).
        ● Al presionar el botón &quot;Guardar&quot;, se debe mostrar en un Label un resumen con el
        plan y los servicios elegidos.
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
            label3.Text = $"el plan elegido es: {comboBox1.Text}\nLos servicios adicionales son: ";
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false)
            {
                label3.Text += "Ninguno";
            }
            else
            {
                if (checkBox1.Checked == true)
                {
                    label3.Text += $"\n- {checkBox1.Text}";
                }
                if (checkBox2.Checked == true)
                {
                    label3.Text += $"\n- {checkBox2.Text}";
                }
                if (checkBox3.Checked == true)
                {
                    label3.Text += $"\n- {checkBox3.Text}";
                }
            }

            label3.Visible = true;
        }
    }
}
