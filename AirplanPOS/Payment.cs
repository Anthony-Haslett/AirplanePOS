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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Review frm = new Review();
            frm.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderComplete frm = new OrderComplete();
            frm.Show();
            this.Visible = false;
        }
    }
}
