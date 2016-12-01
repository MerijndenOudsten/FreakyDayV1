namespace Network_Dashboard
{
    partial class Blacklisting
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
            this.lb_shownetworkdevices = new System.Windows.Forms.ListBox();
            this.btn_getalldevices = new System.Windows.Forms.Button();
            this.tb_subnet = new System.Windows.Forms.TextBox();
            this.btn_stopscan = new System.Windows.Forms.Button();
            this.pgb_scanning = new System.Windows.Forms.ProgressBar();
            this.lbl_scan = new System.Windows.Forms.Label();
            this.lbl_ipadres = new System.Windows.Forms.Label();
            this.cb_poortblokkeren = new System.Windows.Forms.ComboBox();
            this.lbl_teblokkerenpoort = new System.Windows.Forms.Label();
            this.btn_blokkeerpoort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_shownetworkdevices
            // 
            this.lb_shownetworkdevices.FormattingEnabled = true;
            this.lb_shownetworkdevices.Location = new System.Drawing.Point(10, 18);
            this.lb_shownetworkdevices.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lb_shownetworkdevices.Name = "lb_shownetworkdevices";
            this.lb_shownetworkdevices.Size = new System.Drawing.Size(579, 212);
            this.lb_shownetworkdevices.TabIndex = 0;
            // 
            // btn_getalldevices
            // 
            this.btn_getalldevices.Location = new System.Drawing.Point(11, 314);
            this.btn_getalldevices.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_getalldevices.Name = "btn_getalldevices";
            this.btn_getalldevices.Size = new System.Drawing.Size(176, 67);
            this.btn_getalldevices.TabIndex = 1;
            this.btn_getalldevices.Text = "Startscan";
            this.btn_getalldevices.UseVisualStyleBackColor = true;
            this.btn_getalldevices.Click += new System.EventHandler(this.btn_getalldevices_Click);
            // 
            // tb_subnet
            // 
            this.tb_subnet.Location = new System.Drawing.Point(11, 291);
            this.tb_subnet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_subnet.Name = "tb_subnet";
            this.tb_subnet.Size = new System.Drawing.Size(176, 20);
            this.tb_subnet.TabIndex = 4;
            // 
            // btn_stopscan
            // 
            this.btn_stopscan.Location = new System.Drawing.Point(11, 385);
            this.btn_stopscan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_stopscan.Name = "btn_stopscan";
            this.btn_stopscan.Size = new System.Drawing.Size(176, 67);
            this.btn_stopscan.TabIndex = 5;
            this.btn_stopscan.Text = "Stop scan";
            this.btn_stopscan.UseVisualStyleBackColor = true;
            this.btn_stopscan.Click += new System.EventHandler(this.btn_stopscan_Click);
            // 
            // pgb_scanning
            // 
            this.pgb_scanning.Location = new System.Drawing.Point(10, 239);
            this.pgb_scanning.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pgb_scanning.Maximum = 255;
            this.pgb_scanning.Name = "pgb_scanning";
            this.pgb_scanning.Size = new System.Drawing.Size(578, 19);
            this.pgb_scanning.TabIndex = 6;
            // 
            // lbl_scan
            // 
            this.lbl_scan.AutoSize = true;
            this.lbl_scan.Location = new System.Drawing.Point(9, 260);
            this.lbl_scan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_scan.Name = "lbl_scan";
            this.lbl_scan.Size = new System.Drawing.Size(61, 13);
            this.lbl_scan.TabIndex = 7;
            this.lbl_scan.Text = "Scanning...";
            // 
            // lbl_ipadres
            // 
            this.lbl_ipadres.AutoSize = true;
            this.lbl_ipadres.Location = new System.Drawing.Point(73, 260);
            this.lbl_ipadres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ipadres.Name = "lbl_ipadres";
            this.lbl_ipadres.Size = new System.Drawing.Size(41, 13);
            this.lbl_ipadres.TabIndex = 8;
            this.lbl_ipadres.Text = "ipadres";
            // 
            // cb_poortblokkeren
            // 
            this.cb_poortblokkeren.FormattingEnabled = true;
            this.cb_poortblokkeren.Items.AddRange(new object[] {
            "21",
            "23",
            "80",
            "443",
            "8080"});
            this.cb_poortblokkeren.Location = new System.Drawing.Point(191, 291);
            this.cb_poortblokkeren.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_poortblokkeren.Name = "cb_poortblokkeren";
            this.cb_poortblokkeren.Size = new System.Drawing.Size(137, 21);
            this.cb_poortblokkeren.TabIndex = 9;
            // 
            // lbl_teblokkerenpoort
            // 
            this.lbl_teblokkerenpoort.AutoSize = true;
            this.lbl_teblokkerenpoort.Location = new System.Drawing.Point(191, 272);
            this.lbl_teblokkerenpoort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_teblokkerenpoort.Name = "lbl_teblokkerenpoort";
            this.lbl_teblokkerenpoort.Size = new System.Drawing.Size(100, 13);
            this.lbl_teblokkerenpoort.TabIndex = 10;
            this.lbl_teblokkerenpoort.Text = "Te blokkeren poort:";
            // 
            // btn_blokkeerpoort
            // 
            this.btn_blokkeerpoort.Location = new System.Drawing.Point(191, 316);
            this.btn_blokkeerpoort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_blokkeerpoort.Name = "btn_blokkeerpoort";
            this.btn_blokkeerpoort.Size = new System.Drawing.Size(136, 64);
            this.btn_blokkeerpoort.TabIndex = 11;
            this.btn_blokkeerpoort.Text = "Blokkeer poort";
            this.btn_blokkeerpoort.UseVisualStyleBackColor = true;
            this.btn_blokkeerpoort.Click += new System.EventHandler(this.btn_blokkeerpoort_Click);
            // 
            // Blacklisting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 493);
            this.Controls.Add(this.btn_blokkeerpoort);
            this.Controls.Add(this.lbl_teblokkerenpoort);
            this.Controls.Add(this.cb_poortblokkeren);
            this.Controls.Add(this.lbl_ipadres);
            this.Controls.Add(this.lbl_scan);
            this.Controls.Add(this.pgb_scanning);
            this.Controls.Add(this.btn_stopscan);
            this.Controls.Add(this.tb_subnet);
            this.Controls.Add(this.btn_getalldevices);
            this.Controls.Add(this.lb_shownetworkdevices);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Blacklisting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_shownetworkdevices;
        private System.Windows.Forms.Button btn_getalldevices;
        private System.Windows.Forms.TextBox tb_subnet;
        private System.Windows.Forms.Button btn_stopscan;
        private System.Windows.Forms.ProgressBar pgb_scanning;
        private System.Windows.Forms.Label lbl_scan;
        private System.Windows.Forms.Label lbl_ipadres;
        private System.Windows.Forms.ComboBox cb_poortblokkeren;
        private System.Windows.Forms.Label lbl_teblokkerenpoort;
        private System.Windows.Forms.Button btn_blokkeerpoort;
    }
}