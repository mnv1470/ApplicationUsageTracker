using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.OleDb;

namespace ApplicationUsageTracker
{
    public partial class Form1 : Form
    {
        List<string> processName = new List<string>();
        List<string> timeAmount = new List<string>();
        List<Label> lblAppName = new List<Label>();
            
            
        
        public Form1()
        {
            InitializeComponent();

            lblAppName.Add(lblAppName1);
            lblAppName.Add(lblAppName2);
            lblAppName.Add(lblAppName3);
            lblAppName.Add(lblAppName4);
            lblAppName.Add(lblAppName5);
        }

        
        

        private void Form1_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Victorio\Desktop\DatabaseApplicationUsageTracker.accdb");
            
            lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            timer1.Interval = (1000) * (1);              // Timer will tick evert second
            timer1.Enabled = true;                       // Enable the timer
            timer1.Start(); // Start the timer


            //*****UPON LOAD: RETRIEVE DATA FROM DATABASE
            Cursor = Cursors.WaitCursor;
            //Retrive data to be inserted
            TextBox txtProcess = new TextBox();
            TextBox txtTimeAmount = new TextBox();

            
            int i = 0;
            
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select * from tblProcess order by Time_Amount Desc";
            OleDbDataReader dr = cmd.ExecuteReader();
            


                while (dr.Read())
                {

                    txtProcess.Text = dr["Process"].ToString();
                    string timeAmt = dr["Time_Amount"].ToString();



                    processName.Add(txtProcess.Text);
                    timeAmount.Add(timeAmt);

                    if (i <= 5)
                    {


                        i++;
                    }
                    for (int a = 0; a < i; a++)
                    {
                        lblAppName[a].Text = processName[a];



                    }
                }
            

            con.Close();

           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(processName[2]);
        }
            
     

    
    }
}
