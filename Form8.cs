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
    public partial class Form8 : Form
    {
        private string username1;
        public Form8(string username)
        {
            InitializeComponent();
            username1 = username;
            label1.Text = username;
            label1.BackColor = Color.Transparent;
        }

        private void btn_fixture_Click(object sender, EventArgs e)
        {
            this.Hide();
            show_fix_user f2 = new show_fix_user(username1);
            f2.ShowDialog();
        }

        private void btn_booking_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form13 f13 = new Form13(username1);
            f13.ShowDialog();
        }

        private void btn_team_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 f10 = new Form10(username1);
            f10.ShowDialog();
        }

        private void btn_point_Click(object sender, EventArgs e)
        {
            this.Hide();
            user_point_table f9 = new user_point_table(username1);
            f9.ShowDialog();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 f12 = new Form12(username1);
            f12.ShowDialog();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void btn_view_booking_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form16 f16 = new Form16(username1);
            f16.ShowDialog();
        }

        private void btn_live_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form18 f18 = new Form18(username1);
            f18.ShowDialog();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
