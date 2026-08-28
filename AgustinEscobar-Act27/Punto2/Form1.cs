using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto2
{
    /*
     Actividad 2: Encuesta de Preferencias de Música
        Problema:
        Una aplicación quiere conocer los gustos musicales de los usuarios.
        Requisitos:
        ● Mostrar un ComboBox con 5 géneros musicales distintos.
        ● Incluir tres CheckBox que representen actividades relacionadas (por ejemplo:
        &quot;Escuchar en vivo&quot;, &quot;Escuchar en streaming&quot;, &quot;Comprar discos&quot;).
        ● Al presionar un botón &quot;Mostrar Preferencias&quot;, en un Label se debe mostrar el género
        seleccionado y las actividades marcadas.
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
            label3.Visible = true;
            label3.Text = $"Tu genero favorito es: {comboBox1.Text}\nTus actividades favoritas son: \n";
            if (checkBox1.Checked == true)
            {
                label3.Text += $"- {checkBox1.Text}\n";
            }
            if (checkBox2.Checked == true)
            {
                label3.Text += $"- {checkBox2.Text}\n";
            }
            if (checkBox3.Checked == true)
            {
                label3.Text += $"- {checkBox3.Text}\n";
            }
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false)
            {
                label3.Text += "Ninguna";
            }
        }
    }
}
