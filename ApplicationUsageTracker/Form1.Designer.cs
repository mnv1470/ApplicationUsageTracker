namespace ApplicationUsageTracker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lblHours5 = new System.Windows.Forms.Label();
            this.lblAppName5 = new System.Windows.Forms.Label();
            this.picBoxTop5 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblHours4 = new System.Windows.Forms.Label();
            this.lblAppName4 = new System.Windows.Forms.Label();
            this.picBoxTop4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHours2 = new System.Windows.Forms.Label();
            this.lblAppName2 = new System.Windows.Forms.Label();
            this.picBoxTop2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblHours3 = new System.Windows.Forms.Label();
            this.lblAppName3 = new System.Windows.Forms.Label();
            this.picBoxTop3 = new System.Windows.Forms.PictureBox();
            this.pnlSquare1 = new System.Windows.Forms.Panel();
            this.lblTop1 = new System.Windows.Forms.Label();
            this.lblHours1 = new System.Windows.Forms.Label();
            this.lblAppName1 = new System.Windows.Forms.Label();
            this.picBoxTop1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlHead = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mainPanel.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTop5)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTop4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTop2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTop3)).BeginInit();
            this.pnlSquare1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTop1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.pnlHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mainPanel.Controls.Add(this.pnlBody);
            this.mainPanel.Controls.Add(this.pnlHead);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(729, 380);
            this.mainPanel.TabIndex = 0;
            // 
            // pnlBody
            // 
            this.pnlBody.AutoScroll = true;
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlBody.Controls.Add(this.tabControl1);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 73);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(729, 307);
            this.pnlBody.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(17, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(699, 289);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.pnlSquare1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(691, 263);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.label2.Location = new System.Drawing.Point(6, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Top 5 Applications Used";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.lblHours5);
            this.panel4.Controls.Add(this.lblAppName5);
            this.panel4.Controls.Add(this.picBoxTop5);
            this.panel4.Location = new System.Drawing.Point(561, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(119, 208);
            this.panel4.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(33, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 19);
            this.label10.TabIndex = 1;
            this.label10.Text = "TOP 5";
            // 
            // lblHours5
            // 
            this.lblHours5.AutoSize = true;
            this.lblHours5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours5.ForeColor = System.Drawing.Color.White;
            this.lblHours5.Location = new System.Drawing.Point(33, 181);
            this.lblHours5.Name = "lblHours5";
            this.lblHours5.Size = new System.Drawing.Size(55, 19);
            this.lblHours5.TabIndex = 1;
            this.lblHours5.Text = "label4";
            // 
            // lblAppName5
            // 
            this.lblAppName5.AutoSize = true;
            this.lblAppName5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName5.ForeColor = System.Drawing.Color.White;
            this.lblAppName5.Location = new System.Drawing.Point(33, 139);
            this.lblAppName5.Name = "lblAppName5";
            this.lblAppName5.Size = new System.Drawing.Size(55, 19);
            this.lblAppName5.TabIndex = 1;
            this.lblAppName5.Text = "label4";
            // 
            // picBoxTop5
            // 
            this.picBoxTop5.BackColor = System.Drawing.Color.White;
            this.picBoxTop5.Location = new System.Drawing.Point(11, 32);
            this.picBoxTop5.Name = "picBoxTop5";
            this.picBoxTop5.Size = new System.Drawing.Size(100, 100);
            this.picBoxTop5.TabIndex = 0;
            this.picBoxTop5.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.lblHours4);
            this.panel3.Controls.Add(this.lblAppName4);
            this.panel3.Controls.Add(this.picBoxTop4);
            this.panel3.Location = new System.Drawing.Point(423, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(119, 208);
            this.panel3.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(33, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "TOP 4";
            // 
            // lblHours4
            // 
            this.lblHours4.AutoSize = true;
            this.lblHours4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours4.ForeColor = System.Drawing.Color.White;
            this.lblHours4.Location = new System.Drawing.Point(33, 181);
            this.lblHours4.Name = "lblHours4";
            this.lblHours4.Size = new System.Drawing.Size(55, 19);
            this.lblHours4.TabIndex = 1;
            this.lblHours4.Text = "label4";
            // 
            // lblAppName4
            // 
            this.lblAppName4.AutoSize = true;
            this.lblAppName4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName4.ForeColor = System.Drawing.Color.White;
            this.lblAppName4.Location = new System.Drawing.Point(33, 139);
            this.lblAppName4.Name = "lblAppName4";
            this.lblAppName4.Size = new System.Drawing.Size(55, 19);
            this.lblAppName4.TabIndex = 1;
            this.lblAppName4.Text = "label4";
            // 
            // picBoxTop4
            // 
            this.picBoxTop4.BackColor = System.Drawing.Color.White;
            this.picBoxTop4.Location = new System.Drawing.Point(11, 32);
            this.picBoxTop4.Name = "picBoxTop4";
            this.picBoxTop4.Size = new System.Drawing.Size(100, 100);
            this.picBoxTop4.TabIndex = 0;
            this.picBoxTop4.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblHours2);
            this.panel1.Controls.Add(this.lblAppName2);
            this.panel1.Controls.Add(this.picBoxTop2);
            this.panel1.Location = new System.Drawing.Point(149, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 208);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "TOP 2";
            // 
            // lblHours2
            // 
            this.lblHours2.AutoSize = true;
            this.lblHours2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours2.ForeColor = System.Drawing.Color.White;
            this.lblHours2.Location = new System.Drawing.Point(33, 181);
            this.lblHours2.Name = "lblHours2";
            this.lblHours2.Size = new System.Drawing.Size(55, 19);
            this.lblHours2.TabIndex = 1;
            this.lblHours2.Text = "label4";
            // 
            // lblAppName2
            // 
            this.lblAppName2.AutoSize = true;
            this.lblAppName2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName2.ForeColor = System.Drawing.Color.White;
            this.lblAppName2.Location = new System.Drawing.Point(33, 139);
            this.lblAppName2.Name = "lblAppName2";
            this.lblAppName2.Size = new System.Drawing.Size(55, 19);
            this.lblAppName2.TabIndex = 1;
            this.lblAppName2.Text = "label4";
            // 
            // picBoxTop2
            // 
            this.picBoxTop2.BackColor = System.Drawing.Color.White;
            this.picBoxTop2.Location = new System.Drawing.Point(11, 32);
            this.picBoxTop2.Name = "picBoxTop2";
            this.picBoxTop2.Size = new System.Drawing.Size(100, 100);
            this.picBoxTop2.TabIndex = 0;
            this.picBoxTop2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblHours3);
            this.panel2.Controls.Add(this.lblAppName3);
            this.panel2.Controls.Add(this.picBoxTop3);
            this.panel2.Location = new System.Drawing.Point(285, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(119, 208);
            this.panel2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(33, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "TOP 3";
            // 
            // lblHours3
            // 
            this.lblHours3.AutoSize = true;
            this.lblHours3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours3.ForeColor = System.Drawing.Color.White;
            this.lblHours3.Location = new System.Drawing.Point(33, 181);
            this.lblHours3.Name = "lblHours3";
            this.lblHours3.Size = new System.Drawing.Size(55, 19);
            this.lblHours3.TabIndex = 1;
            this.lblHours3.Text = "label4";
            // 
            // lblAppName3
            // 
            this.lblAppName3.AutoSize = true;
            this.lblAppName3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName3.ForeColor = System.Drawing.Color.White;
            this.lblAppName3.Location = new System.Drawing.Point(33, 139);
            this.lblAppName3.Name = "lblAppName3";
            this.lblAppName3.Size = new System.Drawing.Size(55, 19);
            this.lblAppName3.TabIndex = 1;
            this.lblAppName3.Text = "label4";
            // 
            // picBoxTop3
            // 
            this.picBoxTop3.BackColor = System.Drawing.Color.White;
            this.picBoxTop3.Location = new System.Drawing.Point(11, 32);
            this.picBoxTop3.Name = "picBoxTop3";
            this.picBoxTop3.Size = new System.Drawing.Size(100, 100);
            this.picBoxTop3.TabIndex = 0;
            this.picBoxTop3.TabStop = false;
            // 
            // pnlSquare1
            // 
            this.pnlSquare1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.pnlSquare1.Controls.Add(this.lblTop1);
            this.pnlSquare1.Controls.Add(this.lblHours1);
            this.pnlSquare1.Controls.Add(this.lblAppName1);
            this.pnlSquare1.Controls.Add(this.picBoxTop1);
            this.pnlSquare1.Location = new System.Drawing.Point(11, 45);
            this.pnlSquare1.Name = "pnlSquare1";
            this.pnlSquare1.Size = new System.Drawing.Size(119, 208);
            this.pnlSquare1.TabIndex = 3;
            // 
            // lblTop1
            // 
            this.lblTop1.AutoSize = true;
            this.lblTop1.Font = new System.Drawing.Font("Montserrat Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop1.ForeColor = System.Drawing.Color.White;
            this.lblTop1.Location = new System.Drawing.Point(33, 10);
            this.lblTop1.Name = "lblTop1";
            this.lblTop1.Size = new System.Drawing.Size(53, 19);
            this.lblTop1.TabIndex = 1;
            this.lblTop1.Text = "TOP 1";
            // 
            // lblHours1
            // 
            this.lblHours1.AutoSize = true;
            this.lblHours1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours1.ForeColor = System.Drawing.Color.White;
            this.lblHours1.Location = new System.Drawing.Point(33, 181);
            this.lblHours1.Name = "lblHours1";
            this.lblHours1.Size = new System.Drawing.Size(55, 19);
            this.lblHours1.TabIndex = 1;
            this.lblHours1.Text = "label4";
            // 
            // lblAppName1
            // 
            this.lblAppName1.AutoSize = true;
            this.lblAppName1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName1.ForeColor = System.Drawing.Color.White;
            this.lblAppName1.Location = new System.Drawing.Point(31, 139);
            this.lblAppName1.Name = "lblAppName1";
            this.lblAppName1.Size = new System.Drawing.Size(55, 19);
            this.lblAppName1.TabIndex = 1;
            this.lblAppName1.Text = "label4";
            // 
            // picBoxTop1
            // 
            this.picBoxTop1.BackColor = System.Drawing.Color.White;
            this.picBoxTop1.Location = new System.Drawing.Point(11, 32);
            this.picBoxTop1.Name = "picBoxTop1";
            this.picBoxTop1.Size = new System.Drawing.Size(100, 100);
            this.picBoxTop1.TabIndex = 0;
            this.picBoxTop1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(691, 263);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Summary Report";
            // 
            // pnlHead
            // 
            this.pnlHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.pnlHead.Controls.Add(this.lblTime);
            this.pnlHead.Controls.Add(this.lblDate);
            this.pnlHead.Controls.Add(this.label1);
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(729, 73);
            this.pnlHead.TabIndex = 0;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Montserrat Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(585, 17);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 19);
            this.lblTime.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Montserrat Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(14, 38);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(95, 19);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date here*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usage Report for the Day";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart1
            // 
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(231, 35);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            title1.Name = "Title1";
            this.chart1.Titles.Add(title1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 380);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainPanel.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTop5)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTop4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTop2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTop3)).EndInit();
            this.pnlSquare1.ResumeLayout(false);
            this.pnlSquare1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTop1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel mainPanel;
        public System.Windows.Forms.Panel pnlBody;
        public System.Windows.Forms.Panel pnlHead;
        public System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblTime;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel pnlSquare1;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblHours5;
        private System.Windows.Forms.Label lblAppName5;
        private System.Windows.Forms.PictureBox picBoxTop5;
        public System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblHours4;
        private System.Windows.Forms.Label lblAppName4;
        private System.Windows.Forms.PictureBox picBoxTop4;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHours2;
        private System.Windows.Forms.Label lblAppName2;
        private System.Windows.Forms.PictureBox picBoxTop2;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblHours3;
        private System.Windows.Forms.Label lblAppName3;
        private System.Windows.Forms.PictureBox picBoxTop3;
        private System.Windows.Forms.Label lblTop1;
        private System.Windows.Forms.Label lblHours1;
        private System.Windows.Forms.Label lblAppName1;
        private System.Windows.Forms.PictureBox picBoxTop1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

