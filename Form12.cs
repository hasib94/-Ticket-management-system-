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
    public partial class Form12 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        private string username1;
        public Form12(string username)
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\Fixture.accdb;
Persist Security Info=False";
            username1 = username;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            try
            {            
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query1 = "select * from UserInfo where Usernamee='" + username1 + "'";
                command.CommandText = query1;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txt_fname.Text = reader["Firstnamee"].ToString();
                    txt_lname.Text = reader["Lastnamee"].ToString();
                    txt_age.Text = reader["Agee"].ToString();
                    txt_country.Text = reader["Countryy"].ToString();
                    txt_email.Text = reader["Emaill"].ToString();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                int i;
                int.TryParse(txt_age.Text, out i);
                string query = "update UserInfo set Firstnamee='" + txt_fname.Text + "' ,Lastnamee='" + txt_lname.Text + "' ,Agee=" + i + " ,Countryy='" + txt_country.Text + "' ,Emaill='" + txt_email.Text +  "' where Usernamee='" + username1 + "'";
                command.CommandText = query;

                command.ExecuteNonQuery();

                MessageBox.Show("Your info has been updated successfully");
                connection.Close();

                this.Hide();
                Form12 f12 = new Form12(username1);
                f12.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error   " + ex);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f8 = new Form8(username1);
            f8.ShowDialog();
        }
    }
}
