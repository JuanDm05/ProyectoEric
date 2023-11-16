using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEric
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\Violin.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Matrices matrices = new Matrices();
            matrices.Show();
            this.Hide();
            //MessageBox.Show("Seleccionar una fila de la tabla para eliminar registro", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pilas pilas = new Pilas();
            pilas.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Colas colas = new Colas();
            colas.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Listas listas = new Listas();
            listas.Show();
            this.Hide();    
        }
    }
}
