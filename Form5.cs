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
    public partial class Form5 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form5()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\Fixture.accdb;
Persist Security Info=False";
            label_bat.Text = "";
            label_bat.BackColor = Color.Transparent;
            label_bowl.Text = "";
            label_bowl.BackColor = Color.Transparent;
            label_over.Text = "";
            label_over.BackColor = Color.Transparent;
            label_run.Text = "";
            label_run.BackColor = Color.Transparent;
            label_team1.Text = "";
            label_team1.BackColor = Color.Transparent;
            label_team2.Text = "";
            label_team2.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label10.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogIn ad = new AdminLogIn();
            ad.ShowDialog();
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp f11 = new SignUp();
            f11.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand("select * from Live_score", connection);
            command.Connection = connection;
            OleDbDataReader Reader = null;
            Reader=command.ExecuteReader();
            while (Reader.Read())
            {
                label_bat.Text = Reader["Batting_team"].ToString();
                label_bowl.Text = Reader["Bowling_team"].ToString();
                label_team1.Text = Reader["Team1"].ToString();
                label_team2.Text = Reader["Team2"].ToString();
                label_over.Text = Reader["Overr"].ToString();
                label_run.Text = Reader["Runn"].ToString() + "/" + Reader["Wickett"].ToString();
            }

            connection.Close();
        }

    }
}
