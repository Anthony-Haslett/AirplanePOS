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
    public partial class Exit_pop_up : Form
    {
        public Exit_pop_up()
        {
            InitializeComponent();
        }

        private void Exit_pop_up_Load(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            
            SeatNum frm = new SeatNum();
            if (frm != null)
            {
                frm.Show();
                this.Visible = false;
            }
            
        }
    }
}
