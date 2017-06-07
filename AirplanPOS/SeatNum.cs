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
    public partial class SeatNum : Form
    {
        Review review = new Review();
        public static string passingText;
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
            //review.reviewText.Text = "Set from form1";



            if (seatNumText == null)
            {
                System.Windows.Forms.MessageBox.Show("Please enter seat number!");
            }
            else
            {
                CustomerDetails frm = new CustomerDetails();
                frm.Show();
                this.Visible = false;
            }
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

        private void seatNumText_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
