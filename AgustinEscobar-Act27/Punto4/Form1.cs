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
     Actividad 4: Sistema de Opinión sobre un Producto
        Problema:
        Se quiere crear un formulario de opinión para un producto.
        Requisitos:
        ● Un Label debe indicar: &quot;Escribe tu opinión&quot;.
        ● Incluir un TextBox grande (multilínea) donde el usuario escriba su comentario.
        ● Dos RadioButton deben permitir seleccionar sí recomiendan el producto: &quot;Sí&quot; o &quot;No&quot;.
        ● Al hacer clic en el botón &quot;Enviar&quot;, se debe mostrar un Label con el mensaje: &quot;Opinión
        recibida: [texto] – Recomendación: [Sí/No]&quot;.
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                label3.Text = "Seleciona una opcion (Si/No) para recomendar";
            }
            else
            {
                label3.Text = $"Opinion recibida: {textBox1.Text} - Recomendacion: ";
                if (radioButton1.Checked == true)
                {
                    label3.Text += "Si";
                }
                if (radioButton2.Checked == true)
                {
                    label3.Text += "No";
                }
            }

            label3.Visible = true;
        }
    }
}
