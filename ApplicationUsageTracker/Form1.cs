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
using System.Windows.Forms.DataVisualization.Charting;

namespace ApplicationUsageTracker
{
    public partial class Form1 : Form
    {
        List<string> processName = new List<string>();
        List<string> timeAmount = new List<string>();
        List<Label> lblAppName = new List<Label>();
        List<Label> lblHours = new List<Label>();
            
            
        
        public Form1()
        {
            InitializeComponent();

            //lblAppNames retrieve data
            lblAppName.Add(lblAppName1);
            lblAppName.Add(lblAppName2);
            lblAppName.Add(lblAppName3);
            lblAppName.Add(lblAppName4);
            lblAppName.Add(lblAppName5);

            //lblHours retrieve data
            lblHours.Add(lblHours1);
            lblHours.Add(lblHours2);
            lblHours.Add(lblHours3);
            lblHours.Add(lblHours4);
            lblHours.Add(lblHours5);
        }

        
        

        private void Form1_Load(object sender, EventArgs e)
        {
            //DB Connection
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Victorio\Desktop\DatabaseApplicationUsageTracker.accdb");
            
            lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            timer1.Interval = (1000) * (1);              // Timer will tick evert second
            timer1.Enabled = true;                       // Enable the timer
            timer1.Start(); // Start the timer


            //*****UPON LOAD: RETRIEVE DATA FROM DATABASE
            //Retrive data to be inserted
            TextBox txtProcess = new TextBox();
            int i = 0;
            
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select * from tblProcess order by Time_Amount Desc";
            OleDbDataReader dr = cmd.ExecuteReader();
            


                while (dr.Read())
                {
                    if (i <= 5)
                    {

                     
                    txtProcess.Text = dr["Process"].ToString();
                    string timeAmt = dr["Time_Amount"].ToString();



                    processName.Add(txtProcess.Text);
                    timeAmount.Add(timeAmt);

                  for (int a = 0; a < i; a++)
            {
                lblAppName[a].Text = processName[a];
                lblHours[a].Text = timeAmount[a] + " HR(S)";


            }
                  i++;
                    }
                }
            con.Close();

           
            //Pie chart summary
            pieChart.Titles.Add("Time Spent on Device VS. Your Rest/Sleep");
            pieChart.Series.Add("s1");
            pieChart.Series["s1"].ChartType = SeriesChartType.Pie;
            pieChart.Series["s1"].Color = Color.FromArgb(5, 100, 146);
            



            //*****UPON LOAD: RETRIEVE DATA FROM DATABASE LAHAT
            //Retrive data to be inserted
            List<string> listProcess = new List<string>();
            List<double> listTimeAmount= new List<double>();

            TextBox txtProcess1 = new TextBox();
            int i1 = 0;

            con.Open();
            OleDbCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;

            cmd1.CommandText = "select * from tblProcess where Time_Amount is not null";
            OleDbDataReader dr1 = cmd1.ExecuteReader();



            while (dr1.Read())
            {
               


                    txtProcess1.Text = dr1["Process"].ToString();
                    string timeAmt = dr1["Time_Amount"].ToString();



                    listProcess.Add(txtProcess1.Text);
                    listTimeAmount.Add(Double.Parse(timeAmt));


                   // pieChart initialize loop
                    pieChart.Series["s1"].Points.AddXY(listProcess[i1], Math.Round(((listTimeAmount[i1]/24)*100),1));
                    pieChart.Series["s1"].IsValueShownAsLabel = true;
                    pieChart.Series["s1"].LabelBackColor = Color.FromArgb(255, 255, 255);

                    i1++;
                
            }
           


            //Accumulate activity hrs then subtract to sleeptime
            double hrsActivity=0;
            
            for (int z = 0; z < listProcess.Count; z++)
            {
                hrsActivity =hrsActivity+ listTimeAmount[z];
            }
            double hrsSleep = 24 - hrsActivity;
            //piechart sleep
            pieChart.Series["s1"].Points.AddXY("Rest/Sleep", Math.Round(((hrsSleep / 24) * 100), 1));
            pieChart.Series["s1"].IsValueShownAsLabel = true;
            pieChart.Series["s1"].LabelBackColor = Color.FromArgb(255, 255, 255);
            con.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

      
            
     

    
    }
}
