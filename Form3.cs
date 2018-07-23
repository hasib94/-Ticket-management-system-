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
    public partial class Form3 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        private string username1;
        public Form3(string username)
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\Fixture.accdb;
Persist Security Info=False";
            label4.Text = "Logged in as " + username + "";
            username1 = username;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlSearch = "select * from AdminPassword where Adm='" + username1 + "'";
                OleDbCommand command = new OleDbCommand(sqlSearch, connection);
                connection.Open();
                command.Connection = connection;
                OleDbDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    if (txt_new.Text == txt_confirm.Text)
                    {
                        string sqlUpdate = "update AdminPassword set Pass='"+txt_new.Text+"' where Adm='"+username1+"'";
                        OleDbCommand cmdd = new OleDbCommand(sqlUpdate, connection);
                        cmdd.ExecuteNonQuery();
                        MessageBox.Show("Successfully updated");

                        this.Hide();
                        Form7 f7 = new Form7(username1);
                        f7.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Please retype your new password correctly");
                    }
                }
                else
                {
                    MessageBox.Show("No record found");
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error   " + ex);
            }
            this.Hide();
            Form3 f3 = new Form3(username1);
            f3.ShowDialog();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7(username1);
            f7.ShowDialog();
        }
    }
}
