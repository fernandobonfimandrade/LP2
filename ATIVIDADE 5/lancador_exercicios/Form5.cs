﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lancador_exercicios
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random objRandom = new Random();
            int numero = objRandom.Next(Convert.ToInt32(box1.Text), Convert.ToInt32(box2.Text));
            MessageBox.Show("O numero sorteado é : " + numero);
        }
    }
}
