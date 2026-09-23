using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto8
{
    /*
     8. Validador de Credenciales y Formato
        ● Consigna: Solicitar usuario y contraseña mediante TextBox (usando
        UseSystemPasswordChar = true). Un CheckBox &quot;Acepto términos&quot; debe habilitar
        (Enabled = true) el Button &quot;Ingresar&quot;. Si la clave coincide con &quot;admin123&quot;, mostrar
        éxito en una Label; de lo contrario, mostrar advertencia.
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            if (textBox2.Text == "admin123")
            {
                label4.Text = $"Bienvenido de nuevo {textBox1.Text}";
            }
            else
            {
                label4.Text = "Contraseña incorrecta";
            }
        }
    }
}
