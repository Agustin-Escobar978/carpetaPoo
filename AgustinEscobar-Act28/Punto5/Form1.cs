using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Punto5
{
    /*
     5. Visor Dinámico de Imágenes (Investigación: PictureBox)
        ● Investigación: Investigar la clase PictureBox y sus propiedades ImageLocation y
        SizeMode.
        ● Consigna: Cargar en un ComboBox tres opciones. Al cambiar la selección mediante
        el evento SelectedIndexChanged, mostrar la imagen correspondiente dentro del
        PictureBox.
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Argentina")
            {
                pictureBox1.ImageLocation = $"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSolkH48jp1W1zo9dRQVd0vqgpt88DtCD8pS82YqGQtpz6ss_rCxSRaXA&s=10";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if(comboBox1.Text == "Brasil")
            {
                pictureBox1.ImageLocation = $"https://cdn0.uncomo.com/es/posts/1/2/5/significado_de_la_bandera_y_escudo_de_brasil_49521_orig.jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (comboBox1.Text == "Uruguay")
            {
                pictureBox1.ImageLocation = $"https://cdn.pixabay.com/photo/2016/06/16/04/21/uruguay-1460612_640.jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
