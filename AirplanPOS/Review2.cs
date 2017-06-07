using System;
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
    public partial class Review2 : Form
    {
        public Review2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Payment frm = new Payment();
            frm.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelectFood frm = new SelectFood();
            frm.Show();
            this.Visible = false;
        }
    }
}
