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
    public partial class EditOrder : Form
    {
        public EditOrder()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditOrder frm = new EditOrder();
            frm.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Review2 frm = new Review2();
            frm.Show();
            this.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Review frm = new Review();
            frm.Show();
            this.Visible = false;
        }
    }
}
