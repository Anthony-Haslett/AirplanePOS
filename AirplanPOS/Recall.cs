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
    public partial class Recall : Form
    {
        public Recall()
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
            Confirm_Recall frm = new Confirm_Recall();
            frm.Show();
            //this.Hide();        
        }
    }
}
