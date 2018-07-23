using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Form7 : Form
    {
        private string username1;

        public Form7()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
        }

        public Form7(string username)
        {
            InitializeComponent();
            label1.Text = username;
            label1.BackColor = Color.Transparent;
            username1 = username;
        }

        private void btn_viewfixture_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2(username1);
            f2.ShowDialog();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void btn_updatefixture_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1(username1);
            f1.ShowDialog();
        }

        private void btn_point_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 f9 = new Form9(username1);
            f9.ShowDialog();
        }

        private void btn_changepass_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3(username1);
            f3.ShowDialog();
        }

        private void btn_teamdetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form14 f14 = new Form14(username1);
            f14.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
