using System;
using System.Windows.Forms;

namespace Proyecto_TDP___Equipo_3
{
    public partial class Muestra_productos : Form
    {
        public Muestra_productos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Form1 = new Indice();
            Form1.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form form11 = new Munu2();
            form11.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form muestra = new Form11();
            muestra.Show();
            this.Close();
        }
    }
}
