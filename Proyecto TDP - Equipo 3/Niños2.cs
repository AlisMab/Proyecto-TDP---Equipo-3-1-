﻿using System;
using System.Windows.Forms;

namespace Proyecto_TDP___Equipo_3
{
    public partial class Niños2 : Form
    {
        public Niños2()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            Form form11 = new Munu2();
            form11.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form muestra = new Muestra_productos();
            muestra.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form fomr = new Indice();
            fomr.Show();
            this.Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

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
