﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_group
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label2.Text == "enasahmed")
            {
                MessageBox.Show("welcom " + label1.Text);
                var Form2 = new Form_check();
                this.Hide();
                Form2.ShowDialog();

            }
            else
            {
                MessageBox.Show("Error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }
    }
}
