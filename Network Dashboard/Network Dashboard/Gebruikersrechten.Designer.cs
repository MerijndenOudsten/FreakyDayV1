namespace Network_Dashboard
{
    partial class Gebruikersrechten
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
            this.lb_Gebruikers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_InternetSnelheid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Upload = new System.Windows.Forms.Label();
            this.btn_veranderRecht = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_Recht = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Download = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Terug = new System.Windows.Forms.Button();
            this.cb_NetworkInterfaces = new System.Windows.Forms.ComboBox();
            this.lbl_BytesSent = new System.Windows.Forms.Label();
            this.lbl_BytesReceived = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_TimerStart = new System.Windows.Forms.Button();
            this.btn_TimerStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Gebruikers
            // 
            this.lb_Gebruikers.FormattingEnabled = true;
            this.lb_Gebruikers.ItemHeight = 16;
            this.lb_Gebruikers.Location = new System.Drawing.Point(12, 28);
            this.lb_Gebruikers.Name = "lb_Gebruikers";
            this.lb_Gebruikers.Size = new System.Drawing.Size(297, 420);
            this.lb_Gebruikers.TabIndex = 0;
            this.lb_Gebruikers.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connectie snelheid";
            // 
            // lbl_InternetSnelheid
            // 
            this.lbl_InternetSnelheid.AutoSize = true;
            this.lbl_InternetSnelheid.Location = new System.Drawing.Point(319, 220);
            this.lbl_InternetSnelheid.Name = "lbl_InternetSnelheid";
            this.lbl_InternetSnelheid.Size = new System.Drawing.Size(46, 17);
            this.lbl_InternetSnelheid.TabIndex = 2;
            this.lbl_InternetSnelheid.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Upload:";
            // 
            // lbl_Upload
            // 
            this.lbl_Upload.AutoSize = true;
            this.lbl_Upload.Location = new System.Drawing.Point(345, 302);
            this.lbl_Upload.Name = "lbl_Upload";
            this.lbl_Upload.Size = new System.Drawing.Size(16, 17);
            this.lbl_Upload.TabIndex = 4;
            this.lbl_Upload.Text = "0";
            this.lbl_Upload.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_veranderRecht
            // 
            this.btn_veranderRecht.Location = new System.Drawing.Point(277, 454);
            this.btn_veranderRecht.Name = "btn_veranderRecht";
            this.btn_veranderRecht.Size = new System.Drawing.Size(105, 45);
            this.btn_veranderRecht.TabIndex = 6;
            this.btn_veranderRecht.Text = "Verander recht";
            this.btn_veranderRecht.UseVisualStyleBackColor = true;
            this.btn_veranderRecht.Click += new System.EventHandler(this.btn_veranderRecht_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Verander naar:";
            // 
            // cb_Recht
            // 
            this.cb_Recht.FormattingEnabled = true;
            this.cb_Recht.Items.AddRange(new object[] {
            "BEHEERDER",
            "STANDAARD",
            "BEPERKT"});
            this.cb_Recht.Location = new System.Drawing.Point(122, 457);
            this.cb_Recht.Name = "cb_Recht";
            this.cb_Recht.Size = new System.Drawing.Size(137, 24);
            this.cb_Recht.TabIndex = 8;
            this.cb_Recht.Text = "Gebruikersrecht";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Download:";
            // 
            // lbl_Download
            // 
            this.lbl_Download.AutoSize = true;
            this.lbl_Download.Location = new System.Drawing.Point(345, 369);
            this.lbl_Download.Name = "lbl_Download";
            this.lbl_Download.Size = new System.Drawing.Size(16, 17);
            this.lbl_Download.TabIndex = 10;
            this.lbl_Download.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Gebruikers";
            // 
            // btn_Terug
            // 
            this.btn_Terug.Location = new System.Drawing.Point(479, 8);
            this.btn_Terug.Name = "btn_Terug";
            this.btn_Terug.Size = new System.Drawing.Size(105, 45);
            this.btn_Terug.TabIndex = 12;
            this.btn_Terug.Text = "Terug";
            this.btn_Terug.UseVisualStyleBackColor = true;
            this.btn_Terug.Click += new System.EventHandler(this.btn_Terug_Click);
            // 
            // cb_NetworkInterfaces
            // 
            this.cb_NetworkInterfaces.FormattingEnabled = true;
            this.cb_NetworkInterfaces.Location = new System.Drawing.Point(318, 91);
            this.cb_NetworkInterfaces.Name = "cb_NetworkInterfaces";
            this.cb_NetworkInterfaces.Size = new System.Drawing.Size(121, 24);
            this.cb_NetworkInterfaces.TabIndex = 14;
            // 
            // lbl_BytesSent
            // 
            this.lbl_BytesSent.AutoSize = true;
            this.lbl_BytesSent.Location = new System.Drawing.Point(458, 302);
            this.lbl_BytesSent.Name = "lbl_BytesSent";
            this.lbl_BytesSent.Size = new System.Drawing.Size(16, 17);
            this.lbl_BytesSent.TabIndex = 15;
            this.lbl_BytesSent.Text = "0";
            // 
            // lbl_BytesReceived
            // 
            this.lbl_BytesReceived.AutoSize = true;
            this.lbl_BytesReceived.Location = new System.Drawing.Point(458, 369);
            this.lbl_BytesReceived.Name = "lbl_BytesReceived";
            this.lbl_BytesReceived.Size = new System.Drawing.Size(16, 17);
            this.lbl_BytesReceived.TabIndex = 16;
            this.lbl_BytesReceived.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Actueel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(345, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Actueel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(458, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Totaal in bytes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(458, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Totaal in bytes";
            // 
            // btn_TimerStart
            // 
            this.btn_TimerStart.Location = new System.Drawing.Point(322, 137);
            this.btn_TimerStart.Name = "btn_TimerStart";
            this.btn_TimerStart.Size = new System.Drawing.Size(75, 30);
            this.btn_TimerStart.TabIndex = 21;
            this.btn_TimerStart.Text = "Start";
            this.btn_TimerStart.UseVisualStyleBackColor = true;
            this.btn_TimerStart.Click += new System.EventHandler(this.btn_TimerStart_Click);
            // 
            // btn_TimerStop
            // 
            this.btn_TimerStop.Location = new System.Drawing.Point(431, 137);
            this.btn_TimerStop.Name = "btn_TimerStop";
            this.btn_TimerStop.Size = new System.Drawing.Size(75, 30);
            this.btn_TimerStop.TabIndex = 22;
            this.btn_TimerStop.Text = "Stop";
            this.btn_TimerStop.UseVisualStyleBackColor = true;
            this.btn_TimerStop.Click += new System.EventHandler(this.btn_TimerStop_Click);
            // 
            // Gebruikersrechten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 559);
            this.Controls.Add(this.btn_TimerStop);
            this.Controls.Add(this.btn_TimerStart);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_BytesReceived);
            this.Controls.Add(this.lbl_BytesSent);
            this.Controls.Add(this.cb_NetworkInterfaces);
            this.Controls.Add(this.btn_Terug);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_Download);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Recht);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_veranderRecht);
            this.Controls.Add(this.lbl_Upload);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_InternetSnelheid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Gebruikers);
            this.Name = "Gebruikersrechten";
            this.Text = "Gebruikersrechten";
            this.Load += new System.EventHandler(this.Gebruikersrechten_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Gebruikers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_InternetSnelheid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Upload;
        private System.Windows.Forms.Button btn_veranderRecht;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_Recht;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Download;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Terug;
        private System.Windows.Forms.ComboBox cb_NetworkInterfaces;
        private System.Windows.Forms.Label lbl_BytesSent;
        private System.Windows.Forms.Label lbl_BytesReceived;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_TimerStart;
        private System.Windows.Forms.Button btn_TimerStop;
    }
}