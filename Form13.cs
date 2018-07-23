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
    public partial class Form13 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        private string username1,team11,team22,venue;
        private string radiobutton;
        public Form13(string username)
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
            label8.BackColor = Color.Transparent;
            radioButton1.BackColor = Color.Transparent;
            radioButton2.BackColor = Color.Transparent;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f8 = new Form8(username1);
            f8.ShowDialog();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            int i;
            int.TryParse(txt_match.Text, out i);
            if (radiobutton == "Yes" && txt_available.Text == "Yes")
            {
                this.Hide();
                Form15 f15 = new Form15(username1, i, team11, team22, venue);
                f15.ShowDialog();
            }
            else if (txt_available.Text == "No") MessageBox.Show("Ticket not available");
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query1 = "select * from Ticket";
                command.CommandText = query1;

                OleDbDataAdapter da1 = new OleDbDataAdapter(command);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;

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
                txt_match.Text = row.Cells[0].Value.ToString();
                txt_team1.Text = row.Cells[1].Value.ToString();
                txt_team2.Text = row.Cells[2].Value.ToString();
                txt_venue.Text = row.Cells[3].Value.ToString();
                txt_stage.Text = row.Cells[4].Value.ToString();
                txt_available.Text = row.Cells[5].Value.ToString();
                team11 = txt_team1.Text;
                team22 = txt_team2.Text;
                venue = txt_venue.Text;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radiobutton = "Yes";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radiobutton = "No";
        }
    }
}
