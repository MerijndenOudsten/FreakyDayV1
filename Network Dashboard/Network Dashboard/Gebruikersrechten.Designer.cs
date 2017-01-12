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
            this.btn_veranderRecht = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_Recht = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Terug = new System.Windows.Forms.Button();
            this.pb_dgHelpStart = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dgHelpStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // btn_veranderRecht
            // 
            this.btn_veranderRecht.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_veranderRecht.Location = new System.Drawing.Point(277, 454);
            this.btn_veranderRecht.Name = "btn_veranderRecht";
            this.btn_veranderRecht.Size = new System.Drawing.Size(105, 45);
            this.btn_veranderRecht.TabIndex = 6;
            this.btn_veranderRecht.Text = "Verander recht";
            this.btn_veranderRecht.UseVisualStyleBackColor = false;
            this.btn_veranderRecht.Click += new System.EventHandler(this.btn_veranderRecht_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 463);
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
            this.btn_Terug.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Terug.Location = new System.Drawing.Point(332, 12);
            this.btn_Terug.Name = "btn_Terug";
            this.btn_Terug.Size = new System.Drawing.Size(105, 45);
            this.btn_Terug.TabIndex = 12;
            this.btn_Terug.Text = "Terug";
            this.btn_Terug.UseVisualStyleBackColor = false;
            this.btn_Terug.Click += new System.EventHandler(this.btn_Terug_Click);
            // 
            // pb_dgHelpStart
            // 
            this.pb_dgHelpStart.Image = global::Network_Dashboard.Properties.Resources.help;
            this.pb_dgHelpStart.Location = new System.Drawing.Point(13, 449);
            this.pb_dgHelpStart.Margin = new System.Windows.Forms.Padding(4);
            this.pb_dgHelpStart.Name = "pb_dgHelpStart";
            this.pb_dgHelpStart.Size = new System.Drawing.Size(16, 16);
            this.pb_dgHelpStart.TabIndex = 45;
            this.pb_dgHelpStart.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Network_Dashboard.Properties.Resources.help;
            this.pictureBox1.Location = new System.Drawing.Point(122, 483);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Network_Dashboard.Properties.Resources.help;
            this.pictureBox2.Location = new System.Drawing.Point(277, 497);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // Gebruikersrechten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(454, 559);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pb_dgHelpStart);
            this.Controls.Add(this.btn_Terug);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_Recht);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_veranderRecht);
            this.Controls.Add(this.lb_Gebruikers);
            this.Name = "Gebruikersrechten";
            this.Text = "Gebruikersrechten";
            this.Load += new System.EventHandler(this.Gebruikersrechten_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_dgHelpStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Gebruikers;
        private System.Windows.Forms.Button btn_veranderRecht;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_Recht;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Terug;
        private System.Windows.Forms.PictureBox pb_dgHelpStart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}