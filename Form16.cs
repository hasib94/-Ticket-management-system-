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
    public partial class Form16 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        private string username1;
        private int matchno;
        public Form16(string username)
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\Fixture.accdb;
Persist Security Info=False";
            username1 = username;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query1 = "select MatchNo,Team11,Team22,Ticket_type,No_of_ticketss from Booking where Usernamee='" + username1 + "'";
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

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            int match,ticket;
            int.TryParse(txt_match.Text, out match);
            int.TryParse(txt_ticket.Text, out ticket);
            string query = "delete from Booking where MatchNo=" + match + " and Usernamee='" + username1 + "'";
            command.CommandText = query;
            command.ExecuteNonQuery();

            if (txt_ticket_type.Text == "GrandStand") query = "update Venue_Capacity set Grand_Stand=Grand_Stand+" + ticket + " where MatchNo=" + matchno + "";
            else if (txt_ticket_type.Text == "Business") query = "update Venue_Capacity set Business_Class=Business_Class+" + ticket + " where MatchNo=" + matchno + "";
            else if (txt_ticket_type.Text == "Lawn") query = "update Venue_Capacity set Lawn=Lawn+" + ticket + " where MatchNo=" + matchno + "";
            else if (txt_ticket_type.Text == "Economy") query = "update Venue_Capacity set Economy_Class=Economy_Class+" + ticket + " where MatchNo=" + matchno + "";

            command.CommandText = query;
            command.ExecuteNonQuery();

            connection.Close();

            this.Hide();
            Form16 f16 = new Form16(username1);
            f16.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f8 = new Form8(username1);
            f8.ShowDialog();
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
                txt_ticket_type.Text = row.Cells[3].Value.ToString();
                txt_ticket.Text = row.Cells[4].Value.ToString();
                int.TryParse(txt_ticket_type.Text, out matchno);
            }
        }
    }
}
