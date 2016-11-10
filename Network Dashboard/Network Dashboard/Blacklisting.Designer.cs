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
            this.btn_addtoblacklist = new System.Windows.Forms.Button();
            this.btn_removefromblacklist = new System.Windows.Forms.Button();
            this.tb_subnet = new System.Windows.Forms.TextBox();
            this.btn_stopscan = new System.Windows.Forms.Button();
            this.pgb_scanning = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lb_shownetworkdevices
            // 
            this.lb_shownetworkdevices.FormattingEnabled = true;
            this.lb_shownetworkdevices.ItemHeight = 16;
            this.lb_shownetworkdevices.Location = new System.Drawing.Point(14, 22);
            this.lb_shownetworkdevices.Name = "lb_shownetworkdevices";
            this.lb_shownetworkdevices.Size = new System.Drawing.Size(233, 308);
            this.lb_shownetworkdevices.TabIndex = 0;
            // 
            // btn_getalldevices
            // 
            this.btn_getalldevices.Location = new System.Drawing.Point(252, 50);
            this.btn_getalldevices.Name = "btn_getalldevices";
            this.btn_getalldevices.Size = new System.Drawing.Size(102, 50);
            this.btn_getalldevices.TabIndex = 1;
            this.btn_getalldevices.Text = "Startscan";
            this.btn_getalldevices.UseVisualStyleBackColor = true;
            this.btn_getalldevices.Click += new System.EventHandler(this.btn_getalldevices_Click);
            // 
            // btn_addtoblacklist
            // 
            this.btn_addtoblacklist.Location = new System.Drawing.Point(253, 130);
            this.btn_addtoblacklist.Name = "btn_addtoblacklist";
            this.btn_addtoblacklist.Size = new System.Drawing.Size(214, 82);
            this.btn_addtoblacklist.TabIndex = 2;
            this.btn_addtoblacklist.Text = "Add to blacklist";
            this.btn_addtoblacklist.UseVisualStyleBackColor = true;
            // 
            // btn_removefromblacklist
            // 
            this.btn_removefromblacklist.Location = new System.Drawing.Point(253, 241);
            this.btn_removefromblacklist.Name = "btn_removefromblacklist";
            this.btn_removefromblacklist.Size = new System.Drawing.Size(214, 82);
            this.btn_removefromblacklist.TabIndex = 3;
            this.btn_removefromblacklist.Text = "Remove from blacklist";
            this.btn_removefromblacklist.UseVisualStyleBackColor = true;
            // 
            // tb_subnet
            // 
            this.tb_subnet.Location = new System.Drawing.Point(253, 22);
            this.tb_subnet.Name = "tb_subnet";
            this.tb_subnet.Size = new System.Drawing.Size(214, 22);
            this.tb_subnet.TabIndex = 4;
            // 
            // btn_stopscan
            // 
            this.btn_stopscan.Location = new System.Drawing.Point(360, 50);
            this.btn_stopscan.Name = "btn_stopscan";
            this.btn_stopscan.Size = new System.Drawing.Size(107, 50);
            this.btn_stopscan.TabIndex = 5;
            this.btn_stopscan.Text = "Stop scan";
            this.btn_stopscan.UseVisualStyleBackColor = true;
            this.btn_stopscan.Click += new System.EventHandler(this.btn_stopscan_Click);
            // 
            // pgb_scanning
            // 
            this.pgb_scanning.Location = new System.Drawing.Point(14, 349);
            this.pgb_scanning.Maximum = 255;
            this.pgb_scanning.Name = "pgb_scanning";
            this.pgb_scanning.Size = new System.Drawing.Size(453, 23);
            this.pgb_scanning.TabIndex = 6;
            // 
            // Blacklisting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 465);
            this.Controls.Add(this.pgb_scanning);
            this.Controls.Add(this.btn_stopscan);
            this.Controls.Add(this.tb_subnet);
            this.Controls.Add(this.btn_removefromblacklist);
            this.Controls.Add(this.btn_addtoblacklist);
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
        private System.Windows.Forms.Button btn_addtoblacklist;
        private System.Windows.Forms.Button btn_removefromblacklist;
        private System.Windows.Forms.TextBox tb_subnet;
        private System.Windows.Forms.Button btn_stopscan;
        private System.Windows.Forms.ProgressBar pgb_scanning;
    }
}