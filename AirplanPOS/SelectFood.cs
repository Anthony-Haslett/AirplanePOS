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
    public partial class SelectFood : Form
    {
        public SelectFood()
        {
            InitializeComponent();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            Review frm = new Review();
            frm.Show();
            this.Visible = false;
        }
        private void back_Click(object sender, EventArgs e)
        {
            CustomerDetails frm = new CustomerDetails();
            frm.Show();
            this.Visible = false;
        }

        private void back_Click_1(object sender, EventArgs e)
        {
            CustomerDetails frm = new CustomerDetails();
            frm.Show();
            this.Visible = false;
        }
    }
}
