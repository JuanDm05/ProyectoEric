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
    public partial class Colas : Form
    {
        public Colas()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aqui se mostrara el registro de los datos guardados en la cola  en un futuro", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
