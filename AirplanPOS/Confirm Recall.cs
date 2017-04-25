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
    public partial class Confirm_Recall : Form
    {
        public Confirm_Recall()
        {
            InitializeComponent();
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Recall frm = new Recall();
            //frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Recall_Complete frm = new Recall_Complete();
            frm.Show();
            this.Visible = false;

            Recall frm1 = new Recall();
            frm1.Hide();
            frm1.Visible = false;
        }
    }
}
