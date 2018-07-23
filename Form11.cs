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
    public partial class SignUp : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public SignUp()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\Fixture.accdb;
Persist Security Info=False";
        }


        private void btn_back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void btn_sign_up_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                int i = -1;
                int.TryParse(txt_age.Text, out i);
                if ((i < 10 && i > 100) || txt_country.Text == null || txt_email.Text == null || txt_fname.Text == null || txt_lname.Text == null || txt_password.Text == null || txt_username.Text == null) MessageBox.Show("Invalid input!!");
                else
                {
                    string query = "select Usernamee from UserInfo where Usernamee='" + txt_username.Text + "'";
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = query;
                    command.ExecuteNonQuery();

                    int j=0;
                    OleDbDataReader Reader = null;
                    Reader=command.ExecuteReader();
                    while (Reader.Read())
                    {
                        j++;
                    }
                    Reader.Close();
                    if (j > 0) MessageBox.Show("Username already occupied!!!");
                    else
                    {
                        query = "insert into UserInfo (Firstnamee,Lastnamee,Agee,Countryy,Usernamee,Passwordd,Emaill) values('" + txt_fname.Text + "','" + txt_lname.Text + "'," + i + ",'" + txt_country.Text + "','" + txt_username.Text + "','" + txt_password.Text + "','" + txt_email.Text + "')";
                        command.CommandText = query;
                        command.ExecuteNonQuery();

                        MessageBox.Show("Congratulations! Sign up Completed");
                    }
                }
                this.Hide();
                Form5 f5 = new Form5();
                f5.ShowDialog();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }
    }
}
