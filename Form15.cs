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
    public partial class Form15 : Form
    {
        private string username1,ticket_type,team1,team2,venue;
        private int matchNo;
        private OleDbConnection connection = new OleDbConnection();
        public Form15(string username,int match_no,string team11,string team22,string ven)
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\Fixture.accdb;
Persist Security Info=False";
            username1 = username;
            matchNo = match_no;
            team1 = team11;
            team2 = team22;
            venue = ven;
            label_price.Text= "";
            label1.BackColor = Color.Transparent;
            label_price.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            radioButton1.BackColor = Color.Transparent;
            radioButton2.BackColor = Color.Transparent;
            radioButton3.BackColor = Color.Transparent;
            radioButton4.BackColor = Color.Transparent;
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query1 = "select * from Venue_Capacity where MatchNo=" + matchNo + "";
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

        private void txt_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form13 f13 = new Form13(username1);
            f13.ShowDialog();
        }

        private void txt_confirm_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string q;
                int i,flag=0;
                int.TryParse(txt_ticket.Text, out i);
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                if (ticket_type == "GrandStand")
                {
                    if (i <= 2) 
                    {
                        command.CommandText = "update Venue_Capacity set Grand_Stand=Grand_Stand-" + i + " where MatchNo=" + matchNo + ""; 
                        flag = 1; 
                    }
                    else MessageBox.Show("Wrong Input!!");
                }
                else if (ticket_type == "Business") 
                {
                    if(i<=4) 
                    {
                        command.CommandText = "update Venue_Capacity set Business_Class=Business_Class-" + i + " where MatchNo=" + matchNo + ""; 
                        flag=1;
                    }
                    else MessageBox.Show("Wrong Input!!");
                }
                else if (ticket_type == "Lawn") 
                {   
                    if(i<=2) 
                    {
                        command.CommandText = "update Venue_Capacity set Lawn=Lawn-" + i + " where MatchNo=" + matchNo + ""; 
                        flag=1;
                    }
                    else MessageBox.Show("Wrong Input!!");
                }
                else if (ticket_type == "Economy") 
                {   
                    if(i<=5) 
                    {
                        command.CommandText = "update Venue_Capacity set Economy_Class=Economy_Class-" + i + " where MatchNo=" + matchNo + ""; 
                        flag=1;
                    }
                        else MessageBox.Show("Wrong Input!!");
                }


                if (flag == 1)
                {
                    command.ExecuteNonQuery();

                    q = "insert into Booking (Usernamee,No_of_ticketss,MatchNo,Team11,Team22,Venuee,Credit_Card_Idd,Ticket_type) values('" + username1 + "'," + i + "," + matchNo + ",'" + team1 + "','" + team2 + "','" + venue + "','" + txt_cred_card.Text + "','" + ticket_type + "')";
                    command.CommandText = q;
                    command.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Wrong Input!!");
                }
                connection.Close();

                this.Hide();
                Form8 f8 = new Form8(username1);
                f8.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ticket_type = "GrandStand";
            label_price.Text = "**No more than 2 tickets can be booked at once**";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ticket_type = "Business";
            label_price.Text = "**No more than 4 tickets can be booked at once**";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ticket_type = "Lawn";
            label_price.Text = "**No more than 2 tickets can be booked at once**";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            ticket_type = "Economy";
            label_price.Text = "**No more than 5 tickets can be booked at once**";
        }
    }
}
