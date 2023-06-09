using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restoran
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Masa1 masa1= new Masa1();
            masa1.Show();
            this.Hide();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Masa2 masa2 = new Masa2();
            masa2.Show();
            this.Hide();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Masa3 masa3 = new Masa3();
            masa3.Show();
            this.Hide();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Masa4 masa4 = new Masa4();
            masa4.Show();
            this.Hide();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Masa5 masa5 = new Masa5();
            masa5.Show();
            this.Hide();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Masa6 masa6 = new Masa6();
            masa6.Show();
            this.Hide();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Masa7 masa7 = new Masa7();
            masa7.Show();
            this.Hide();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Masa8 masa8 = new Masa8();
            masa8.Show();
            this.Hide();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Background_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
