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
                pictureBox1.ImageLocation = $"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTbmjcks8sA7OplVwZszl932rVi5HMz3a5tIWtzXJ76qA&s=10";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if(comboBox1.Text == "Brasil")
            {
                pictureBox1.ImageLocation = $"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTKJJqPsIbZcRrfu5SBdh6igDyvjgZ48zL5Oh_W13EbUA&s=10";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (comboBox1.Text == "Uruguay")
            {
                pictureBox1.ImageLocation = $"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR8tpmlQvbgL4_csEEh4xpUnDMJ6HbqM79AE8QVSd571g&s=10";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
