﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirplanPOS
{
    public partial class Recall_Complete : Form
    {
        public Recall_Complete()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Landing_page frm = new Landing_page();
            frm.Show();
            this.Visible = false;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exit_pop_up frm = new Exit_pop_up();
            frm.Show();
        }
    }
}
