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
    public partial class show_fix_user : Form
    {
        private OleDbConnection connection = new OleDbConnection();           
        private string username1;
        public show_fix_user(string username)
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\Fixture.accdb;
Persist Security Info=False";
            username1 = username;
        }

        private void btn_back1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f8 = new Form8(username1);
            f8.ShowDialog();
        }

        private void show_fix_user_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Fixtures";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }
    }
}
