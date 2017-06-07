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
    public partial class Review : Form
    {
        public SeatNum sn;
        public Review()
        {
            InitializeComponent();
            
        }

        private void back_Click(object sender, EventArgs e)
        {
            SelectFood frm = new SelectFood();
            frm.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Payment frm = new Payment();
            frm.Show();
            this.Visible = false;
        }

        private void Review_Load(object sender, EventArgs e)
        {

        }

        private void reviewText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditOrder frm = new EditOrder();
            frm.Show();
            this.Visible = false;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Exit_pop_up frm = new Exit_pop_up();
            frm.Show();
        }
    }
}
