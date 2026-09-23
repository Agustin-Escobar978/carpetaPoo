using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto10
{
    /*
     10. Administrador de Roles y Permisos
        ● Consigna: Incluir un ComboBox con opciones: &quot;Administrador&quot;, &quot;Editor&quot; e &quot;Invitado&quot;.
        En el evento SelectedIndexChanged, modificar dinámicamente la propiedad Enabled
        de tres CheckBox (&quot;Crear&quot;, &quot;Modificar&quot;, &quot;Eliminar&quot;) según el perfil elegido.
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
            }else if(comboBox1.SelectedIndex == 1)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = true;
                checkBox3.Enabled = false;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
            }
        }
    }
}
