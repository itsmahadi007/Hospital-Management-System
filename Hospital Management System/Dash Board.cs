using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class Dash_Board : Form
    {
        public Dash_Board()
        {
            InitializeComponent();
        }

        private void Doctor(object sender, EventArgs e)
        {
            this.Hide();
            Doctor ss = new Doctor();
            ss.Show();
        }

        private void Billing(object sender, EventArgs e)
        {
            this.Hide();
            Patient aa = new Patient();
            aa.Show();
        }

        private void Wardboy(object sender, EventArgs e)
        {
            this.Hide();
            Wardboy dd = new Wardboy();
            dd.Show();
        }

        private void Doctor_click(object sender, EventArgs e)
        {
            this.Hide();
            Doctor qq = new Doctor();
            qq.Show();
        }

        private void Billing_click(object sender, EventArgs e)
        {
            this.Hide();
            Patient ww = new Patient();
            ww.Show();
        }

        private void Wardboy_click(object sender, EventArgs e)
        {
            this.Hide();
            Wardboy ee = new Wardboy();
            ee.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 rr = new Form1();
            rr.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {

            this.Hide();
            Doctor ss = new Doctor();
            ss.Show();
        }

        private void Patient_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
