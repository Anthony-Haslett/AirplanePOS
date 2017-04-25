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
    public partial class CustomerDetails : Form
    {
        public CustomerDetails()
        {
            InitializeComponent();
        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {

        }

        private void enter_Click(object sender, EventArgs e)
        {
            SelectFood frm = new SelectFood();
            frm.Show();
            this.Visible = false;
    }

        private void back_Click(object sender, EventArgs e)
        {
            SeatNum frm = new SeatNum();
            frm.Show();
            this.Visible = false;
        }
    }
}
