namespace Network_Dashboard
{
    partial class UserDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart_Dataverbruik = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.btn_Uitloggen = new System.Windows.Forms.Button();
            this.cb_smtpclosed = new System.Windows.Forms.CheckBox();
            this.lbl_smtp25 = new System.Windows.Forms.Label();
            this.cb_smtpopen = new System.Windows.Forms.CheckBox();
            this.cb_pop3closed = new System.Windows.Forms.CheckBox();
            this.lbl_pop3110 = new System.Windows.Forms.Label();
            this.cb_pop3open = new System.Windows.Forms.CheckBox();
            this.cb_telnetclosed = new System.Windows.Forms.CheckBox();
            this.lbl_telnet23 = new System.Windows.Forms.Label();
            this.cb_telnetopen = new System.Windows.Forms.CheckBox();
            this.cb_ftpclosed = new System.Windows.Forms.CheckBox();
            this.lbl_ftp21 = new System.Windows.Forms.Label();
            this.cb_ftpopen = new System.Windows.Forms.CheckBox();
            this.lbl_httpclosed = new System.Windows.Forms.Label();
            this.cb_httpclosed = new System.Windows.Forms.CheckBox();
            this.lbl_http8080 = new System.Windows.Forms.Label();
            this.lbl_portopen = new System.Windows.Forms.Label();
            this.cb_httpopen = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Dataverbruik)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_Dataverbruik
            // 
            this.chart_Dataverbruik.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.CursorX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea1.Name = "suh";
            this.chart_Dataverbruik.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.SystemColors.Control;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Dataverbruik";
            this.chart_Dataverbruik.Legends.Add(legend1);
            this.chart_Dataverbruik.Location = new System.Drawing.Point(12, 64);
            this.chart_Dataverbruik.Name = "chart_Dataverbruik";
            this.chart_Dataverbruik.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "suh";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series1.CustomProperties = "DrawingStyle=LightToDark";
            series1.Legend = "Dataverbruik";
            series1.Name = "Upload";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.ChartArea = "suh";
            series2.Color = System.Drawing.Color.Lime;
            series2.CustomProperties = "DrawingStyle=LightToDark";
            series2.Legend = "Dataverbruik";
            series2.Name = "Download";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chart_Dataverbruik.Series.Add(series1);
            this.chart_Dataverbruik.Series.Add(series2);
            this.chart_Dataverbruik.Size = new System.Drawing.Size(613, 459);
            this.chart_Dataverbruik.TabIndex = 0;
            this.chart_Dataverbruik.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.DarkCyan;
            title1.Name = "Dataverbruik";
            title1.Text = "Hoeveel data heb je verbruikt?";
            this.chart_Dataverbruik.Titles.Add(title1);
            this.chart_Dataverbruik.Click += new System.EventHandler(this.chart1_Click);
            // 
            // btn_Menu
            // 
            this.btn_Menu.Location = new System.Drawing.Point(12, 12);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(107, 46);
            this.btn_Menu.TabIndex = 1;
            this.btn_Menu.Text = "Menu";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // btn_Uitloggen
            // 
            this.btn_Uitloggen.Location = new System.Drawing.Point(923, 12);
            this.btn_Uitloggen.Name = "btn_Uitloggen";
            this.btn_Uitloggen.Size = new System.Drawing.Size(100, 46);
            this.btn_Uitloggen.TabIndex = 3;
            this.btn_Uitloggen.Text = "Uitloggen";
            this.btn_Uitloggen.UseVisualStyleBackColor = true;
            this.btn_Uitloggen.Click += new System.EventHandler(this.btn_Uitloggen_Click);
            // 
            // cb_smtpclosed
            // 
            this.cb_smtpclosed.AutoSize = true;
            this.cb_smtpclosed.Enabled = false;
            this.cb_smtpclosed.Location = new System.Drawing.Point(923, 352);
            this.cb_smtpclosed.Name = "cb_smtpclosed";
            this.cb_smtpclosed.Size = new System.Drawing.Size(18, 17);
            this.cb_smtpclosed.TabIndex = 34;
            this.cb_smtpclosed.UseVisualStyleBackColor = true;
            // 
            // lbl_smtp25
            // 
            this.lbl_smtp25.AutoSize = true;
            this.lbl_smtp25.Location = new System.Drawing.Point(685, 353);
            this.lbl_smtp25.Name = "lbl_smtp25";
            this.lbl_smtp25.Size = new System.Drawing.Size(70, 17);
            this.lbl_smtp25.TabIndex = 33;
            this.lbl_smtp25.Text = "SMTP: 25";
            // 
            // cb_smtpopen
            // 
            this.cb_smtpopen.AutoSize = true;
            this.cb_smtpopen.Enabled = false;
            this.cb_smtpopen.Location = new System.Drawing.Point(831, 353);
            this.cb_smtpopen.Name = "cb_smtpopen";
            this.cb_smtpopen.Size = new System.Drawing.Size(18, 17);
            this.cb_smtpopen.TabIndex = 32;
            this.cb_smtpopen.UseVisualStyleBackColor = true;
            // 
            // cb_pop3closed
            // 
            this.cb_pop3closed.AutoSize = true;
            this.cb_pop3closed.Enabled = false;
            this.cb_pop3closed.Location = new System.Drawing.Point(923, 320);
            this.cb_pop3closed.Name = "cb_pop3closed";
            this.cb_pop3closed.Size = new System.Drawing.Size(18, 17);
            this.cb_pop3closed.TabIndex = 31;
            this.cb_pop3closed.UseVisualStyleBackColor = true;
            // 
            // lbl_pop3110
            // 
            this.lbl_pop3110.AutoSize = true;
            this.lbl_pop3110.Location = new System.Drawing.Point(685, 321);
            this.lbl_pop3110.Name = "lbl_pop3110";
            this.lbl_pop3110.Size = new System.Drawing.Size(77, 17);
            this.lbl_pop3110.TabIndex = 30;
            this.lbl_pop3110.Text = "POP3: 110";
            // 
            // cb_pop3open
            // 
            this.cb_pop3open.AutoSize = true;
            this.cb_pop3open.Enabled = false;
            this.cb_pop3open.Location = new System.Drawing.Point(831, 321);
            this.cb_pop3open.Name = "cb_pop3open";
            this.cb_pop3open.Size = new System.Drawing.Size(18, 17);
            this.cb_pop3open.TabIndex = 29;
            this.cb_pop3open.UseVisualStyleBackColor = true;
            // 
            // cb_telnetclosed
            // 
            this.cb_telnetclosed.AutoSize = true;
            this.cb_telnetclosed.Enabled = false;
            this.cb_telnetclosed.Location = new System.Drawing.Point(923, 288);
            this.cb_telnetclosed.Name = "cb_telnetclosed";
            this.cb_telnetclosed.Size = new System.Drawing.Size(18, 17);
            this.cb_telnetclosed.TabIndex = 28;
            this.cb_telnetclosed.UseVisualStyleBackColor = true;
            // 
            // lbl_telnet23
            // 
            this.lbl_telnet23.AutoSize = true;
            this.lbl_telnet23.Location = new System.Drawing.Point(685, 289);
            this.lbl_telnet23.Name = "lbl_telnet23";
            this.lbl_telnet23.Size = new System.Drawing.Size(72, 17);
            this.lbl_telnet23.TabIndex = 27;
            this.lbl_telnet23.Text = "Telnet: 23";
            // 
            // cb_telnetopen
            // 
            this.cb_telnetopen.AutoSize = true;
            this.cb_telnetopen.Enabled = false;
            this.cb_telnetopen.Location = new System.Drawing.Point(831, 289);
            this.cb_telnetopen.Name = "cb_telnetopen";
            this.cb_telnetopen.Size = new System.Drawing.Size(18, 17);
            this.cb_telnetopen.TabIndex = 26;
            this.cb_telnetopen.UseVisualStyleBackColor = true;
            // 
            // cb_ftpclosed
            // 
            this.cb_ftpclosed.AutoSize = true;
            this.cb_ftpclosed.Enabled = false;
            this.cb_ftpclosed.Location = new System.Drawing.Point(923, 255);
            this.cb_ftpclosed.Name = "cb_ftpclosed";
            this.cb_ftpclosed.Size = new System.Drawing.Size(18, 17);
            this.cb_ftpclosed.TabIndex = 25;
            this.cb_ftpclosed.UseVisualStyleBackColor = true;
            // 
            // lbl_ftp21
            // 
            this.lbl_ftp21.AutoSize = true;
            this.lbl_ftp21.Location = new System.Drawing.Point(685, 256);
            this.lbl_ftp21.Name = "lbl_ftp21";
            this.lbl_ftp21.Size = new System.Drawing.Size(58, 17);
            this.lbl_ftp21.TabIndex = 24;
            this.lbl_ftp21.Text = "FTP: 21";
            // 
            // cb_ftpopen
            // 
            this.cb_ftpopen.AutoSize = true;
            this.cb_ftpopen.Enabled = false;
            this.cb_ftpopen.Location = new System.Drawing.Point(831, 256);
            this.cb_ftpopen.Name = "cb_ftpopen";
            this.cb_ftpopen.Size = new System.Drawing.Size(18, 17);
            this.cb_ftpopen.TabIndex = 23;
            this.cb_ftpopen.UseVisualStyleBackColor = true;
            // 
            // lbl_httpclosed
            // 
            this.lbl_httpclosed.AutoSize = true;
            this.lbl_httpclosed.Location = new System.Drawing.Point(911, 191);
            this.lbl_httpclosed.Name = "lbl_httpclosed";
            this.lbl_httpclosed.Size = new System.Drawing.Size(51, 17);
            this.lbl_httpclosed.TabIndex = 22;
            this.lbl_httpclosed.Text = "Closed";
            // 
            // cb_httpclosed
            // 
            this.cb_httpclosed.AutoSize = true;
            this.cb_httpclosed.Enabled = false;
            this.cb_httpclosed.Location = new System.Drawing.Point(923, 217);
            this.cb_httpclosed.Name = "cb_httpclosed";
            this.cb_httpclosed.Size = new System.Drawing.Size(18, 17);
            this.cb_httpclosed.TabIndex = 21;
            this.cb_httpclosed.UseVisualStyleBackColor = true;
            // 
            // lbl_http8080
            // 
            this.lbl_http8080.AutoSize = true;
            this.lbl_http8080.Location = new System.Drawing.Point(685, 218);
            this.lbl_http8080.Name = "lbl_http8080";
            this.lbl_http8080.Size = new System.Drawing.Size(69, 17);
            this.lbl_http8080.TabIndex = 20;
            this.lbl_http8080.Text = "HTTP: 80";
            // 
            // lbl_portopen
            // 
            this.lbl_portopen.AutoSize = true;
            this.lbl_portopen.Location = new System.Drawing.Point(819, 192);
            this.lbl_portopen.Name = "lbl_portopen";
            this.lbl_portopen.Size = new System.Drawing.Size(43, 17);
            this.lbl_portopen.TabIndex = 19;
            this.lbl_portopen.Text = "Open";
            // 
            // cb_httpopen
            // 
            this.cb_httpopen.AutoSize = true;
            this.cb_httpopen.Enabled = false;
            this.cb_httpopen.Location = new System.Drawing.Point(831, 218);
            this.cb_httpopen.Name = "cb_httpopen";
            this.cb_httpopen.Size = new System.Drawing.Size(18, 17);
            this.cb_httpopen.TabIndex = 18;
            this.cb_httpopen.UseVisualStyleBackColor = true;
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 535);
            this.Controls.Add(this.cb_smtpclosed);
            this.Controls.Add(this.lbl_smtp25);
            this.Controls.Add(this.cb_smtpopen);
            this.Controls.Add(this.cb_pop3closed);
            this.Controls.Add(this.lbl_pop3110);
            this.Controls.Add(this.cb_pop3open);
            this.Controls.Add(this.cb_telnetclosed);
            this.Controls.Add(this.lbl_telnet23);
            this.Controls.Add(this.cb_telnetopen);
            this.Controls.Add(this.cb_ftpclosed);
            this.Controls.Add(this.lbl_ftp21);
            this.Controls.Add(this.cb_ftpopen);
            this.Controls.Add(this.lbl_httpclosed);
            this.Controls.Add(this.cb_httpclosed);
            this.Controls.Add(this.lbl_http8080);
            this.Controls.Add(this.lbl_portopen);
            this.Controls.Add(this.cb_httpopen);
            this.Controls.Add(this.btn_Uitloggen);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.chart_Dataverbruik);
            this.Name = "UserDashboard";
            this.Text = "UserDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.chart_Dataverbruik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Dataverbruik;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Button btn_Uitloggen;
        private System.Windows.Forms.CheckBox cb_smtpclosed;
        private System.Windows.Forms.Label lbl_smtp25;
        private System.Windows.Forms.CheckBox cb_smtpopen;
        private System.Windows.Forms.CheckBox cb_pop3closed;
        private System.Windows.Forms.Label lbl_pop3110;
        private System.Windows.Forms.CheckBox cb_pop3open;
        private System.Windows.Forms.CheckBox cb_telnetclosed;
        private System.Windows.Forms.Label lbl_telnet23;
        private System.Windows.Forms.CheckBox cb_telnetopen;
        private System.Windows.Forms.CheckBox cb_ftpclosed;
        private System.Windows.Forms.Label lbl_ftp21;
        private System.Windows.Forms.CheckBox cb_ftpopen;
        private System.Windows.Forms.Label lbl_httpclosed;
        private System.Windows.Forms.CheckBox cb_httpclosed;
        private System.Windows.Forms.Label lbl_http8080;
        private System.Windows.Forms.Label lbl_portopen;
        private System.Windows.Forms.CheckBox cb_httpopen;
    }
}