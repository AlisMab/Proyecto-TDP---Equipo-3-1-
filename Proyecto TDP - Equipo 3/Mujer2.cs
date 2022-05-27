using System;
using System.Windows.Forms;

namespace Proyecto_TDP___Equipo_3
{
    public partial class Mujer2 : Form
    {
        public Mujer2()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            Form form11 = new Munu2();
            form11.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form fomr = new Indice();
            fomr.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form muestra = new Muestra_productos();
            muestra.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Se agregó";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "Se agregó";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "Se agregó";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "Se agregó";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = "Se agregó";
        }
    }
}
