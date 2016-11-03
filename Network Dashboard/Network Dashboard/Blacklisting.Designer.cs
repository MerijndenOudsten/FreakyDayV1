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
            this.SuspendLayout();
            // 
            // lb_shownetworkdevices
            // 
            this.lb_shownetworkdevices.FormattingEnabled = true;
            this.lb_shownetworkdevices.ItemHeight = 16;
            this.lb_shownetworkdevices.Location = new System.Drawing.Point(13, 22);
            this.lb_shownetworkdevices.Name = "lb_shownetworkdevices";
            this.lb_shownetworkdevices.Size = new System.Drawing.Size(233, 404);
            this.lb_shownetworkdevices.TabIndex = 0;
            // 
            // btn_getalldevices
            // 
            this.btn_getalldevices.Location = new System.Drawing.Point(253, 22);
            this.btn_getalldevices.Name = "btn_getalldevices";
            this.btn_getalldevices.Size = new System.Drawing.Size(214, 82);
            this.btn_getalldevices.TabIndex = 1;
            this.btn_getalldevices.Text = "Show devices";
            this.btn_getalldevices.UseVisualStyleBackColor = true;
            this.btn_getalldevices.Click += new System.EventHandler(this.btn_getalldevices_Click);
            // 
            // btn_addtoblacklist
            // 
            this.btn_addtoblacklist.Location = new System.Drawing.Point(253, 127);
            this.btn_addtoblacklist.Name = "btn_addtoblacklist";
            this.btn_addtoblacklist.Size = new System.Drawing.Size(214, 82);
            this.btn_addtoblacklist.TabIndex = 2;
            this.btn_addtoblacklist.Text = "Add to blacklist";
            this.btn_addtoblacklist.UseVisualStyleBackColor = true;
            // 
            // btn_removefromblacklist
            // 
            this.btn_removefromblacklist.Location = new System.Drawing.Point(253, 238);
            this.btn_removefromblacklist.Name = "btn_removefromblacklist";
            this.btn_removefromblacklist.Size = new System.Drawing.Size(214, 82);
            this.btn_removefromblacklist.TabIndex = 3;
            this.btn_removefromblacklist.Text = "Remove from blacklist";
            this.btn_removefromblacklist.UseVisualStyleBackColor = true;
            // 
            // Blacklisting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 465);
            this.Controls.Add(this.btn_removefromblacklist);
            this.Controls.Add(this.btn_addtoblacklist);
            this.Controls.Add(this.btn_getalldevices);
            this.Controls.Add(this.lb_shownetworkdevices);
            this.Name = "Blacklisting";
            this.Text = "Blacklisting";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_shownetworkdevices;
        private System.Windows.Forms.Button btn_getalldevices;
        private System.Windows.Forms.Button btn_addtoblacklist;
        private System.Windows.Forms.Button btn_removefromblacklist;
    }
}