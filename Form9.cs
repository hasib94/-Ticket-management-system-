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
    public partial class Form9 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        private string group;
        private string username1;
        public Form9(string username)
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\Fixture.accdb;
Persist Security Info=False";
            username1 = username;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7(username1);
            f7.ShowDialog();
        }

        private void btn_groupA_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from PointTableGroupA";
                command.CommandText = query;
                group = "PointTableGroupA";

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

        private void btn_groupB_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from PointTableGroupB";
                command.CommandText = query;
                group = "PointTableGroupB";

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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dataGridView1.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                txt_teamid.Text = row.Cells[0].Value.ToString();
                txt_teamname.Text = row.Cells[1].Value.ToString();
                txt_played.Text = row.Cells[2].Value.ToString();
                txt_won.Text = row.Cells[3].Value.ToString();
                txt_lost.Text = row.Cells[4].Value.ToString();
                txt_points.Text = row.Cells[5].Value.ToString();
            }
        }
    }
}
