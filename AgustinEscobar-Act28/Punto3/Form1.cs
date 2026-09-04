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
     3. Gestor de Tareas Simplificado (Investigación: ListBox)
        ● Investigación: Investigar el control ListBox (propiedad Items, métodos Add() y
        RemoveAt()). Explicar brevemente su funcionamiento e incluir un ejemplo resuelto.
        ● Consigna: Armar una interfaz con un TextBox, un Button &quot;Agregar&quot;, un Button
        &quot;Eliminar&quot; y un ListBox. Permitir añadir el texto tipeado a la lista y borrar el elemento
        que el usuario seleccione.
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (textBox1.Text == listBox1.Items[i].ToString())
                {
                    listBox1.Items.RemoveAt(i);
                    break;
                }
            }
        }
    }
}
