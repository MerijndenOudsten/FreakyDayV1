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
            this.lb_dgHelpStart = new System.Windows.Forms.Label();
            this.pb_dgHelpStart = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dgHelpStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_shownetworkdevices
            // 
            this.lb_shownetworkdevices.FormattingEnabled = true;
            this.lb_shownetworkdevices.ItemHeight = 16;
            this.lb_shownetworkdevices.Location = new System.Drawing.Point(35, 22);
            this.lb_shownetworkdevices.Name = "lb_shownetworkdevices";
            this.lb_shownetworkdevices.Size = new System.Drawing.Size(771, 260);
            this.lb_shownetworkdevices.TabIndex = 0;
            // 
            // btn_getalldevices
            // 
            this.btn_getalldevices.Location = new System.Drawing.Point(15, 386);
            this.btn_getalldevices.Name = "btn_getalldevices";
            this.btn_getalldevices.Size = new System.Drawing.Size(234, 82);
            this.btn_getalldevices.TabIndex = 1;
            this.btn_getalldevices.Text = "Startscan";
            this.btn_getalldevices.UseVisualStyleBackColor = true;
            this.btn_getalldevices.Click += new System.EventHandler(this.btn_getalldevices_Click);
            // 
            // tb_subnet
            // 
            this.tb_subnet.Location = new System.Drawing.Point(15, 358);
            this.tb_subnet.Name = "tb_subnet";
            this.tb_subnet.Size = new System.Drawing.Size(234, 22);
            this.tb_subnet.TabIndex = 4;
            // 
            // btn_stopscan
            // 
            this.btn_stopscan.Location = new System.Drawing.Point(15, 474);
            this.btn_stopscan.Name = "btn_stopscan";
            this.btn_stopscan.Size = new System.Drawing.Size(234, 82);
            this.btn_stopscan.TabIndex = 5;
            this.btn_stopscan.Text = "Stop scan";
            this.btn_stopscan.UseVisualStyleBackColor = true;
            this.btn_stopscan.Click += new System.EventHandler(this.btn_stopscan_Click);
            // 
            // pgb_scanning
            // 
            this.pgb_scanning.Location = new System.Drawing.Point(35, 294);
            this.pgb_scanning.Maximum = 255;
            this.pgb_scanning.Name = "pgb_scanning";
            this.pgb_scanning.Size = new System.Drawing.Size(771, 23);
            this.pgb_scanning.TabIndex = 6;
            // 
            // lbl_scan
            // 
            this.lbl_scan.AutoSize = true;
            this.lbl_scan.Location = new System.Drawing.Point(33, 320);
            this.lbl_scan.Name = "lbl_scan";
            this.lbl_scan.Size = new System.Drawing.Size(79, 17);
            this.lbl_scan.TabIndex = 7;
            this.lbl_scan.Text = "Scanning...";
            // 
            // lbl_ipadres
            // 
            this.lbl_ipadres.AutoSize = true;
            this.lbl_ipadres.Location = new System.Drawing.Point(118, 320);
            this.lbl_ipadres.Name = "lbl_ipadres";
            this.lbl_ipadres.Size = new System.Drawing.Size(55, 17);
            this.lbl_ipadres.TabIndex = 8;
            this.lbl_ipadres.Text = "ipadres";
            // 
            // cb_poortblokkeren
            // 
            this.cb_poortblokkeren.FormattingEnabled = true;
            this.cb_poortblokkeren.Location = new System.Drawing.Point(275, 356);
            this.cb_poortblokkeren.Name = "cb_poortblokkeren";
            this.cb_poortblokkeren.Size = new System.Drawing.Size(181, 24);
            this.cb_poortblokkeren.TabIndex = 9;
            // 
            // lbl_teblokkerenpoort
            // 
            this.lbl_teblokkerenpoort.AutoSize = true;
            this.lbl_teblokkerenpoort.Location = new System.Drawing.Point(255, 335);
            this.lbl_teblokkerenpoort.Name = "lbl_teblokkerenpoort";
            this.lbl_teblokkerenpoort.Size = new System.Drawing.Size(132, 17);
            this.lbl_teblokkerenpoort.TabIndex = 10;
            this.lbl_teblokkerenpoort.Text = "Te blokkeren poort:";
            // 
            // btn_blokkeerpoort
            // 
            this.btn_blokkeerpoort.Location = new System.Drawing.Point(275, 388);
            this.btn_blokkeerpoort.Name = "btn_blokkeerpoort";
            this.btn_blokkeerpoort.Size = new System.Drawing.Size(181, 79);
            this.btn_blokkeerpoort.TabIndex = 11;
            this.btn_blokkeerpoort.Text = "Blokkeer poort";
            this.btn_blokkeerpoort.UseVisualStyleBackColor = true;
            // 
            // lb_dgHelpStart
            // 
            this.lb_dgHelpStart.AutoSize = true;
            this.lb_dgHelpStart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_dgHelpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dgHelpStart.Location = new System.Drawing.Point(561, 483);
            this.lb_dgHelpStart.MaximumSize = new System.Drawing.Size(200, 0);
            this.lb_dgHelpStart.Name = "lb_dgHelpStart";
            this.lb_dgHelpStart.Size = new System.Drawing.Size(50, 17);
            this.lb_dgHelpStart.TabIndex = 45;
            this.lb_dgHelpStart.Text = "Advies";
            this.lb_dgHelpStart.Visible = false;
            // 
            // pb_dgHelpStart
            // 
            this.pb_dgHelpStart.Image = global::Network_Dashboard.Properties.Resources.help;
            this.pb_dgHelpStart.Location = new System.Drawing.Point(15, 22);
            this.pb_dgHelpStart.Name = "pb_dgHelpStart";
            this.pb_dgHelpStart.Size = new System.Drawing.Size(16, 16);
            this.pb_dgHelpStart.TabIndex = 44;
            this.pb_dgHelpStart.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Network_Dashboard.Properties.Resources.help;
            this.pictureBox1.Location = new System.Drawing.Point(462, 364);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Network_Dashboard.Properties.Resources.help;
            this.pictureBox2.Location = new System.Drawing.Point(462, 451);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Network_Dashboard.Properties.Resources.help;
            this.pictureBox3.Location = new System.Drawing.Point(253, 451);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.TabIndex = 48;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Network_Dashboard.Properties.Resources.help;
            this.pictureBox4.Location = new System.Drawing.Point(253, 539);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(16, 16);
            this.pictureBox4.TabIndex = 49;
            this.pictureBox4.TabStop = false;
            // 
            // Blacklisting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 607);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_dgHelpStart);
            this.Controls.Add(this.pb_dgHelpStart);
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
            this.Name = "Blacklisting";
            this.Text = "Blacklisting";
            ((System.ComponentModel.ISupportInitialize)(this.pb_dgHelpStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private System.Windows.Forms.Label lb_dgHelpStart;
        private System.Windows.Forms.PictureBox pb_dgHelpStart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}