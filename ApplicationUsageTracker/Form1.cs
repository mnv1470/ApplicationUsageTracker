﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace ApplicationUsageTracker
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        struct ProcessStartTimePair
        {

            public Process Process { get; set; }
            public DateTime StartTime { get; set; }
            public DateTime ExitTime
            {
                get
                {
                    return DateTime.Now; // approximate value
                }
            }

            public ProcessStartTimePair(Process p)
                : this()
            {
                Process = p;
                try
                {
                    StartTime = p.StartTime;
                }
                catch (System.ComponentModel.Win32Exception)
                {
                    StartTime = DateTime.Now; // approximate value
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            timer1.Interval = (1000) * (1);              // Timer will tick evert second
            timer1.Enabled = true;                       // Enable the timer
            timer1.Start(); // Start the timer

            //PROCESS
            Form1 frm1 = new Form1();
            List<ProcessStartTimePair> knownProcesses = new List<ProcessStartTimePair>();
            while (true)
            {
                foreach (Process p in Process.GetProcesses())
                {
                    if (!knownProcesses.Select(x => x.Process.Id).Contains(p.Id))
                    {
                        knownProcesses.Add(new ProcessStartTimePair(p));
                        frm1.lblTest.Text = "Detected new process: " + p.ProcessName;
                    }
                }

                for (int i = 0; i < knownProcesses.Count; i++)
                {
                    ProcessStartTimePair pair = knownProcesses[i];
                    try
                    {
                        if (pair.Process.HasExited)
                        {
                            frm1.lblTest.Text = pair.Process.ProcessName + " has exited (alive from " + pair.StartTime.ToString() + " to " + pair.ExitTime.ToString();
                            knownProcesses.Remove(pair);
                            i--; // List was modified, 1 item less
                            // TODO: Store in the info in the database
                        }
                    }
                    catch (System.ComponentModel.Win32Exception)
                    {
                        // Would have to check whether the process still exists in Process.GetProcesses().
                        // The process probably is a system process.
                    }
                }
                System.Threading.Thread.Sleep(1000);
            }
            //PROCESS END

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
            
     

    
    }
}
