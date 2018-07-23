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
    public partial class Form17 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        private string username1;
        private int MatchNo;
        public Form17(string username,int match)
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
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            username1 = username;
            MatchNo = match;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1(username1);
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            int run=0, wicket=0, over=0;
            int.TryParse(txt_run.Text, out run);
            int.TryParse(txt_over.Text, out over);
            int.TryParse(txt_wicket.Text, out wicket);
            string query;
            if((txt_bat.Text==txt_team1.Text && txt_bowl.Text==txt_team2.Text) || (txt_bat.Text==txt_team2.Text && txt_bowl.Text==txt_team1.Text))
            {
                query = "update Live_score set Team1='" + txt_team1.Text + "' ,Team2='" + txt_team2.Text + "' ,Batting_team='" + txt_bat.Text + "' ,Bowling_team='" + txt_bowl.Text + "' ,Runn=" + run + " ,Overr=" + over + " ,Wickett=" + wicket + " where MatchNo>0";
                command.CommandText = query;
                command.ExecuteNonQuery();

                query = "update Ticket set Availibilityy='No' where MatchNo=" + MatchNo + "";
                command.CommandText = query;
                command.ExecuteNonQuery();
            }
            else MessageBox.Show("Please enter the teams' names correctly");

            connection.Close();

            this.Hide();
            Form17 f17 = new Form17(username1,MatchNo);
            f17.ShowDialog();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query1 = "SELECT TOP 1 MatchNo,Team11,Team22 FROM Fixtures WHERE Winnerr is NULL";
                command.CommandText = query1;
                command.ExecuteNonQuery();

                OleDbDataAdapter da1 = new OleDbDataAdapter(command);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;

                DataGridViewCell cell = null;
                foreach (DataGridViewCell selectedCell in dataGridView1.SelectedCells)
                {
                    cell = selectedCell;
                    break;
                }
                DataGridViewRow row = cell.OwningRow;
                txt_match.Text = row.Cells[0].Value.ToString();
                txt_team1.Text = row.Cells[1].Value.ToString();
                txt_team2.Text = row.Cells[2].Value.ToString();
                int k;
                int.TryParse(txt_match.Text, out k);

                MatchNo = k;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }

    }
}
