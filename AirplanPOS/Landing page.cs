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
    public partial class Landing_page : Form
    {
        public Landing_page()
        {
            InitializeComponent();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            SeatNum frm = new SeatNum();
            frm.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Recall frm = new Recall();
            frm.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            SeatNum frm = new SeatNum();
            frm.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Recall frm = new Recall();
            frm.Show();
            this.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
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
    }
    }

