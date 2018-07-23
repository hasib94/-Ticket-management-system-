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
    public partial class Form14 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        private string username1;
        public Form14(string username)
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\Fixture.accdb;
Persist Security Info=False";
            username1 = username;
            label1.BackColor = Color.Transparent;
        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7(username1);
            f7.ShowDialog();
        }

        private void combo_team_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string count = combo_team.Text;
                string query = "select * from " + count + "";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }

        private void Form14_Load_1(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string query = "Select * from CountryName";
            command.CommandText = query;

            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                combo_team.Items.Add(reader["TeamNamee"].ToString());
            }

            connection.Close();
        }
    }
}
