﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restoran
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Kullanıcı_Formu k = new Kullanıcı_Formu();
        private void button1_Click(object sender, EventArgs e)
            
        {
            k.kullanıcı(txtKullanıcıAdı, txtŞifre);
        }
    }
}
