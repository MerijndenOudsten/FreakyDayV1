using System;

namespace Network_Dashboard
{
    partial class StartMenu
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
            this.btn_poortscanner = new System.Windows.Forms.Button();
            this.btn_Blacklisting = new System.Windows.Forms.Button();
            this.btn_gebruikersrechten = new System.Windows.Forms.Button();
            this.lbl_ingelogdeGebruiker = new System.Windows.Forms.Label();
            this.btn_datagebruik = new System.Windows.Forms.Button();
            this.pb_smHelpPoort = new System.Windows.Forms.PictureBox();
            this.pb_smHelpBlacklist = new System.Windows.Forms.PictureBox();
            this.pb_smHelpGebruikersrecht = new System.Windows.Forms.PictureBox();
            this.pb_smHelpData = new System.Windows.Forms.PictureBox();
            this.pb_smHelpIngelogd = new System.Windows.Forms.PictureBox();
            this.lb_smHelpGebruikersrecht = new System.Windows.Forms.Label();
            this.lb_smHelpBlacklist = new System.Windows.Forms.Label();
            this.lb_smHelpPoort = new System.Windows.Forms.Label();
            this.lb_smHelpData = new System.Windows.Forms.Label();
            this.lb_smHelpIngelogd = new System.Windows.Forms.Label();
            this.btn_uitloggen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_smHelpPoort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_smHelpBlacklist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_smHelpGebruikersrecht)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_smHelpData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_smHelpIngelogd)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_poortscanner
            // 
            this.btn_poortscanner.Location = new System.Drawing.Point(13, 37);
            this.btn_poortscanner.Name = "btn_poortscanner";
            this.btn_poortscanner.Size = new System.Drawing.Size(242, 65);
            this.btn_poortscanner.TabIndex = 0;
            this.btn_poortscanner.Text = "Poortscanner";
            this.btn_poortscanner.UseVisualStyleBackColor = true;
            this.btn_poortscanner.Click += new System.EventHandler(this.btn_poortscanner_Click);
            // 
            // btn_Blacklisting
            // 
            this.btn_Blacklisting.Location = new System.Drawing.Point(13, 123);
            this.btn_Blacklisting.Name = "btn_Blacklisting";
            this.btn_Blacklisting.Size = new System.Drawing.Size(242, 65);
            this.btn_Blacklisting.TabIndex = 1;
            this.btn_Blacklisting.Text = "Blacklisting";
            this.btn_Blacklisting.UseVisualStyleBackColor = true;
            this.btn_Blacklisting.Click += new System.EventHandler(this.btn_Blacklisting_Click);
            // 
            // btn_gebruikersrechten
            // 
            this.btn_gebruikersrechten.Location = new System.Drawing.Point(13, 211);
            this.btn_gebruikersrechten.Name = "btn_gebruikersrechten";
            this.btn_gebruikersrechten.Size = new System.Drawing.Size(242, 65);
            this.btn_gebruikersrechten.TabIndex = 2;
            this.btn_gebruikersrechten.Text = "Gebruikersrechten";
            this.btn_gebruikersrechten.UseVisualStyleBackColor = true;
            this.btn_gebruikersrechten.Click += new System.EventHandler(this.btn_gebruikersrechten_Click);
            // 
            // lbl_ingelogdeGebruiker
            // 
            this.lbl_ingelogdeGebruiker.AutoSize = true;
            this.lbl_ingelogdeGebruiker.Location = new System.Drawing.Point(-2, -2);
            this.lbl_ingelogdeGebruiker.Name = "lbl_ingelogdeGebruiker";
            this.lbl_ingelogdeGebruiker.Size = new System.Drawing.Size(46, 17);
            this.lbl_ingelogdeGebruiker.TabIndex = 3;
            this.lbl_ingelogdeGebruiker.Text = "label1";
            // 
            // btn_datagebruik
            // 
            this.btn_datagebruik.Location = new System.Drawing.Point(13, 298);
            this.btn_datagebruik.Name = "btn_datagebruik";
            this.btn_datagebruik.Size = new System.Drawing.Size(242, 65);
            this.btn_datagebruik.TabIndex = 4;
            this.btn_datagebruik.Text = "Datagebruik";
            this.btn_datagebruik.UseVisualStyleBackColor = true;
            this.btn_datagebruik.Click += new System.EventHandler(this.btn_datagebruik_Click);
            // 
            // pb_smHelpPoort
            // 
            this.pb_smHelpPoort.Image = global::Network_Dashboard.Properties.Resources.help;
            this.pb_smHelpPoort.Location = new System.Drawing.Point(15, 101);
            this.pb_smHelpPoort.Name = "pb_smHelpPoort";
            this.pb_smHelpPoort.Size = new System.Drawing.Size(16, 16);
            this.pb_smHelpPoort.TabIndex = 38;
            this.pb_smHelpPoort.TabStop = false;
            this.pb_smHelpPoort.Click += new System.EventHandler(this.pb_smPoort_Click);
            // 
            // pb_smHelpBlacklist
            // 
            this.pb_smHelpBlacklist.Image = global::Network_Dashboard.Properties.Resources.help;
            this.pb_smHelpBlacklist.Location = new System.Drawing.Point(15, 186);
            this.pb_smHelpBlacklist.Name = "pb_smHelpBlacklist";
            this.pb_smHelpBlacklist.Size = new System.Drawing.Size(16, 16);
            this.pb_smHelpBlacklist.TabIndex = 39;
            this.pb_smHelpBlacklist.TabStop = false;
            this.pb_smHelpBlacklist.Click += new System.EventHandler(this.pb_smHelpBlacklist_Click);
            // 
            // pb_smHelpGebruikersrecht
            // 
            this.pb_smHelpGebruikersrecht.Image = global::Network_Dashboard.Properties.Resources.help;
            this.pb_smHelpGebruikersrecht.Location = new System.Drawing.Point(15, 274);
            this.pb_smHelpGebruikersrecht.Name = "pb_smHelpGebruikersrecht";
            this.pb_smHelpGebruikersrecht.Size = new System.Drawing.Size(16, 16);
            this.pb_smHelpGebruikersrecht.TabIndex = 40;
            this.pb_smHelpGebruikersrecht.TabStop = false;
            this.pb_smHelpGebruikersrecht.Click += new System.EventHandler(this.pb_smHelpGebruikersrecht_Click);
            // 
            // pb_smHelpData
            // 
            this.pb_smHelpData.Image = global::Network_Dashboard.Properties.Resources.help;
            this.pb_smHelpData.Location = new System.Drawing.Point(15, 361);
            this.pb_smHelpData.Name = "pb_smHelpData";
            this.pb_smHelpData.Size = new System.Drawing.Size(16, 16);
            this.pb_smHelpData.TabIndex = 41;
            this.pb_smHelpData.TabStop = false;
            this.pb_smHelpData.Click += new System.EventHandler(this.pb_smHelpData_Click);
            // 
            // pb_smHelpIngelogd
            // 
            this.pb_smHelpIngelogd.Image = global::Network_Dashboard.Properties.Resources.help;
            this.pb_smHelpIngelogd.Location = new System.Drawing.Point(0, 18);
            this.pb_smHelpIngelogd.Name = "pb_smHelpIngelogd";
            this.pb_smHelpIngelogd.Size = new System.Drawing.Size(16, 16);
            this.pb_smHelpIngelogd.TabIndex = 42;
            this.pb_smHelpIngelogd.TabStop = false;
            this.pb_smHelpIngelogd.Click += new System.EventHandler(this.pb_smHelpIngelogd_Click);
            // 
            // lb_smHelpGebruikersrecht
            // 
            this.lb_smHelpGebruikersrecht.AutoSize = true;
            this.lb_smHelpGebruikersrecht.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_smHelpGebruikersrecht.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_smHelpGebruikersrecht.Location = new System.Drawing.Point(110, 274);
            this.lb_smHelpGebruikersrecht.MaximumSize = new System.Drawing.Size(200, 0);
            this.lb_smHelpGebruikersrecht.Name = "lb_smHelpGebruikersrecht";
            this.lb_smHelpGebruikersrecht.Size = new System.Drawing.Size(50, 17);
            this.lb_smHelpGebruikersrecht.TabIndex = 44;
            this.lb_smHelpGebruikersrecht.Text = "Advies";
            this.lb_smHelpGebruikersrecht.Visible = false;
            // 
            // lb_smHelpBlacklist
            // 
            this.lb_smHelpBlacklist.AutoSize = true;
            this.lb_smHelpBlacklist.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_smHelpBlacklist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_smHelpBlacklist.Location = new System.Drawing.Point(110, 185);
            this.lb_smHelpBlacklist.MaximumSize = new System.Drawing.Size(200, 0);
            this.lb_smHelpBlacklist.Name = "lb_smHelpBlacklist";
            this.lb_smHelpBlacklist.Size = new System.Drawing.Size(50, 17);
            this.lb_smHelpBlacklist.TabIndex = 45;
            this.lb_smHelpBlacklist.Text = "Advies";
            this.lb_smHelpBlacklist.Visible = false;
            // 
            // lb_smHelpPoort
            // 
            this.lb_smHelpPoort.AutoSize = true;
            this.lb_smHelpPoort.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_smHelpPoort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_smHelpPoort.Location = new System.Drawing.Point(110, 103);
            this.lb_smHelpPoort.MaximumSize = new System.Drawing.Size(200, 0);
            this.lb_smHelpPoort.Name = "lb_smHelpPoort";
            this.lb_smHelpPoort.Size = new System.Drawing.Size(50, 17);
            this.lb_smHelpPoort.TabIndex = 46;
            this.lb_smHelpPoort.Text = "Advies";
            this.lb_smHelpPoort.Visible = false;
            // 
            // lb_smHelpData
            // 
            this.lb_smHelpData.AutoSize = true;
            this.lb_smHelpData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_smHelpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_smHelpData.Location = new System.Drawing.Point(110, 361);
            this.lb_smHelpData.MaximumSize = new System.Drawing.Size(200, 0);
            this.lb_smHelpData.Name = "lb_smHelpData";
            this.lb_smHelpData.Size = new System.Drawing.Size(50, 17);
            this.lb_smHelpData.TabIndex = 47;
            this.lb_smHelpData.Text = "Advies";
            this.lb_smHelpData.Visible = false;
            // 
            // lb_smHelpIngelogd
            // 
            this.lb_smHelpIngelogd.AutoSize = true;
            this.lb_smHelpIngelogd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_smHelpIngelogd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_smHelpIngelogd.Location = new System.Drawing.Point(110, 17);
            this.lb_smHelpIngelogd.MaximumSize = new System.Drawing.Size(200, 0);
            this.lb_smHelpIngelogd.Name = "lb_smHelpIngelogd";
            this.lb_smHelpIngelogd.Size = new System.Drawing.Size(50, 17);
            this.lb_smHelpIngelogd.TabIndex = 48;
            this.lb_smHelpIngelogd.Text = "Advies";
            this.lb_smHelpIngelogd.Visible = false;
            // 
            // btn_uitloggen
            // 
            this.btn_uitloggen.Location = new System.Drawing.Point(13, 381);
            this.btn_uitloggen.Name = "btn_uitloggen";
            this.btn_uitloggen.Size = new System.Drawing.Size(242, 42);
            this.btn_uitloggen.TabIndex = 49;
            this.btn_uitloggen.Text = "Uitloggen";
            this.btn_uitloggen.UseVisualStyleBackColor = true;
            this.btn_uitloggen.Click += new System.EventHandler(this.btn_uitloggen_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 428);
            this.Controls.Add(this.btn_uitloggen);
            this.Controls.Add(this.lb_smHelpIngelogd);
            this.Controls.Add(this.lb_smHelpData);
            this.Controls.Add(this.lb_smHelpPoort);
            this.Controls.Add(this.lb_smHelpBlacklist);
            this.Controls.Add(this.lb_smHelpGebruikersrecht);
            this.Controls.Add(this.pb_smHelpIngelogd);
            this.Controls.Add(this.pb_smHelpData);
            this.Controls.Add(this.pb_smHelpGebruikersrecht);
            this.Controls.Add(this.pb_smHelpBlacklist);
            this.Controls.Add(this.pb_smHelpPoort);
            this.Controls.Add(this.btn_datagebruik);
            this.Controls.Add(this.lbl_ingelogdeGebruiker);
            this.Controls.Add(this.btn_gebruikersrechten);
            this.Controls.Add(this.btn_Blacklisting);
            this.Controls.Add(this.btn_poortscanner);
            this.Name = "StartMenu";
            this.Text = "StartMenu";
            this.Load += new System.EventHandler(this.StartMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_smHelpPoort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_smHelpBlacklist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_smHelpGebruikersrecht)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_smHelpData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_smHelpIngelogd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void StartMenu_Load(object sender, EventArgs e)
        {
        }

        #endregion

        private System.Windows.Forms.Button btn_poortscanner;
        private System.Windows.Forms.Button btn_Blacklisting;
        private System.Windows.Forms.Button btn_gebruikersrechten;
        private System.Windows.Forms.Label lbl_ingelogdeGebruiker;
        private System.Windows.Forms.Button btn_datagebruik;
        private System.Windows.Forms.PictureBox pb_smHelpPoort;
        private System.Windows.Forms.PictureBox pb_smHelpBlacklist;
        private System.Windows.Forms.PictureBox pb_smHelpGebruikersrecht;
        private System.Windows.Forms.PictureBox pb_smHelpData;
        private System.Windows.Forms.PictureBox pb_smHelpIngelogd;
        private System.Windows.Forms.Label lb_smHelpGebruikersrecht;
        private System.Windows.Forms.Label lb_smHelpBlacklist;
        private System.Windows.Forms.Label lb_smHelpPoort;
        private System.Windows.Forms.Label lb_smHelpData;
        private System.Windows.Forms.Label lb_smHelpIngelogd;
        private System.Windows.Forms.Button btn_uitloggen;
    }
}