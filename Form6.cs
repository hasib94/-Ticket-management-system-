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
    public partial class AdminLogIn : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public AdminLogIn()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\Fixture.accdb;
Persist Security Info=False";
        }


        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from AdminPassword where Adm='" + txt_username.Text + "' and Pass='" + txt_password.Text + "'";
            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;

            while (reader.Read())
            {
                count++;
            }
            if (count == 1)
            {
                this.Hide();
                Form7 f7 = new Form7(txt_username.Text);
                f7.ShowDialog();
            }
            else if (count > 1) MessageBox.Show("Duplicate Username and Password");
            else MessageBox.Show("Wrong Username or Password");

            connection.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
