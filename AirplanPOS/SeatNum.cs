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
    public partial class SeatNum : Form
    {
        public SeatNum()
        {
            InitializeComponent();
        }

        private void template_Click(object sender, EventArgs e)
        {

        }

        private void SeatNum_Load(object sender, EventArgs e)
        {

        }

        private void enter_Click(object sender, EventArgs e)
        {
            //Review frmR = new Review(RichTextBox.Text);
            //frmR.reviewText.Text += "gggg";

            CustomerDetails frm = new CustomerDetails();
            frm.Show();
            this.Visible = false;
        }

      
       
    }
}