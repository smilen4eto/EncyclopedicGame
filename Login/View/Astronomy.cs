﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.View;

namespace Login.View
{
    public partial class Astronomy : Form
    {
        public Astronomy()
        {
            InitializeComponent();
        }

        private void Astronomy_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.AntiqueWhite;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AstonomyTests newForm = new AstonomyTests();
            this.Close();
            newForm.Show();
        }


    }
}
