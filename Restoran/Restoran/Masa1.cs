﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restoran
{
    public partial class Masa1 : Form
    {
        public Masa1()
        {
            InitializeComponent();
        }

        private void Masa1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            this.Close();
            anasayfa.Show();
        }
    }
}
