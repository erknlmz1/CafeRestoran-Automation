using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restoran
{
    public partial class Masa2 : Form
    {
        public Masa2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            this.Close();
            anasayfa.Show();
        }
    }
}
