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
    public partial class Form1 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        private string username1;
        private int matchno;
        public Form1(string username)
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
        }


        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
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
                txt_winner.Text = row.Cells[5].Value.ToString();
                txt_win.Text = row.Cells[6].Value.ToString();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7(username1);
            f7.ShowDialog();
        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                int match;
                int.TryParse(txt_match.Text, out match);
                matchno = match;
                if (txt_winner.Text == txt_team1.Text || txt_winner.Text == txt_team2.Text)
                {
                    string query = "update Fixtures set Team11='" + txt_team1.Text + "' ,Team22='" + txt_team2.Text + "' ,Venuee='" + txt_venue.Text + "' ,Stagee='" + txt_stage.Text + "' ,Winnerr='" + txt_winner.Text + "' ,WinByy='" + txt_win.Text + "'  where MatchNo=" + match + "";
                    command.CommandText = query;
                    command.ExecuteNonQuery();

                    

                    if (txt_team1.Text == txt_winner.Text)
                    {
                        query = "update PointTableGroupA set Playedd=Playedd+1, Winn=Winn+1, Pointss=Pointss+2 where TeamNamee='" + txt_winner.Text + "'";
                        command.CommandText = query;
                        command.ExecuteNonQuery();
                        query = "update PointTableGroupB set Playedd=Playedd+1, Winn=Winn+1, Pointss=Pointss+2 where TeamNamee='" + txt_winner.Text + "'";
                        command.CommandText = query;
                        command.ExecuteNonQuery();
                        query = "update PointTableGroupA set Playedd=Playedd+1, Lostt=Lostt+1 where TeamNamee='" + txt_team2.Text + "'";
                        command.CommandText = query;
                        command.ExecuteNonQuery();
                        query = "update PointTableGroupB set Playedd=Playedd+1, Lostt=Lostt+1 where TeamNamee='" + txt_team2.Text + "'";
                        command.CommandText = query;
                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        query = "update PointTableGroupA set Playedd=Playedd+1, Winn=Winn+1, Pointss=Pointss+2 where TeamNamee='" + txt_winner.Text + "'";
                        command.CommandText = query;
                        command.ExecuteNonQuery();
                        query = "update PointTableGroupB set Playedd=Playedd+1, Winn=Winn+1, Pointss=Pointss+2 where TeamNamee='" + txt_winner.Text + "'";
                        command.CommandText = query;
                        command.ExecuteNonQuery();
                        query = "update PointTableGroupA set Playedd=Playedd+1, Lostt=Lostt+1 where TeamNamee='" + txt_team1.Text + "'";
                        command.CommandText = query;
                        command.ExecuteNonQuery();
                        query = "update PointTableGroupB set Playedd=Playedd+1, Lostt=Lostt+1 where TeamNamee='" + txt_team1.Text + "'";
                        command.CommandText = query;
                        command.ExecuteNonQuery();
                    }
                }
                else
                    MessageBox.Show("Please provide correct information");

                connection.Close();

                this.Hide();
                Form1 f1 = new Form1(username1);
                f1.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query1 = "select * from Fixtures";
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

        private void btn_add_Click(object sender, EventArgs e)
        {
                connection.Open();
                int i;
                int.TryParse(txt_match.Text, out i);
                if (txt_match.Text == null || txt_stage.Text == null || txt_team1.Text == null || txt_team2.Text == null || txt_venue.Text == null || txt_win.Text == null || txt_winner.Text == null) MessageBox.Show("Please fill up all the fields");
                else
                {
                    OleDbCommand command = new OleDbCommand("insert into Fixtures (MatchNo,Team11,Team22,Venuee,Stagee,Winnerr,WinByy) values(" + i + ",'" + txt_team1.Text + "','" + txt_team2.Text + "','" + txt_venue.Text + "','" + txt_stage.Text + "','" + txt_winner.Text + "','" + txt_win.Text + "')", connection);
                    command.ExecuteNonQuery();

                    OleDbCommand command2 = new OleDbCommand("insert into Ticket (MatchNo,Team11,Team22,Venuee,Stagee,Availibilityy) values(" + i + ",'" + txt_team1.Text + "','" + txt_team2.Text + "','" + txt_venue.Text + "','" + txt_stage.Text + "','Yes')", connection);
                    command2.ExecuteNonQuery();

                    OleDbCommand command1 = new OleDbCommand("insert into Venue_Capacity (MatchNo,Venuee) values(" + i + ",'" + txt_venue.Text + "')", connection);
                    command1.ExecuteNonQuery();

                    connection.Close();
                }
                this.Hide();
                Form1 f1 = new Form1(username1);
                f1.ShowDialog();
        }

        private void btn_live_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form17 f17 = new Form17(username1,matchno);
            f17.ShowDialog();
        }
    }
}
