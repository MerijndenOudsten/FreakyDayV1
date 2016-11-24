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
            this.lb_shownetworkdevices.ItemHeight = 16;
            this.lb_shownetworkdevices.Location = new System.Drawing.Point(14, 22);
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
            this.pgb_scanning.Location = new System.Drawing.Point(14, 294);
            this.pgb_scanning.Maximum = 255;
            this.pgb_scanning.Name = "pgb_scanning";
            this.pgb_scanning.Size = new System.Drawing.Size(771, 23);
            this.pgb_scanning.TabIndex = 6;
            // 
            // lbl_scan
            // 
            this.lbl_scan.AutoSize = true;
            this.lbl_scan.Location = new System.Drawing.Point(12, 320);
            this.lbl_scan.Name = "lbl_scan";
            this.lbl_scan.Size = new System.Drawing.Size(79, 17);
            this.lbl_scan.TabIndex = 7;
            this.lbl_scan.Text = "Scanning...";
            // 
            // lbl_ipadres
            // 
            this.lbl_ipadres.AutoSize = true;
            this.lbl_ipadres.Location = new System.Drawing.Point(97, 320);
            this.lbl_ipadres.Name = "lbl_ipadres";
            this.lbl_ipadres.Size = new System.Drawing.Size(55, 17);
            this.lbl_ipadres.TabIndex = 8;
            this.lbl_ipadres.Text = "ipadres";
            // 
            // cb_poortblokkeren
            // 
            this.cb_poortblokkeren.FormattingEnabled = true;
            this.cb_poortblokkeren.Location = new System.Drawing.Point(255, 358);
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
            this.btn_blokkeerpoort.Location = new System.Drawing.Point(255, 389);
            this.btn_blokkeerpoort.Name = "btn_blokkeerpoort";
            this.btn_blokkeerpoort.Size = new System.Drawing.Size(181, 79);
            this.btn_blokkeerpoort.TabIndex = 11;
            this.btn_blokkeerpoort.Text = "Blokkeer poort";
            this.btn_blokkeerpoort.UseVisualStyleBackColor = true;
            // 
            // Blacklisting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 607);
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