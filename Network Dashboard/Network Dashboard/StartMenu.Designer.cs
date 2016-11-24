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
            this.SuspendLayout();
            // 
            // btn_poortscanner
            // 
            this.btn_poortscanner.Location = new System.Drawing.Point(13, 13);
            this.btn_poortscanner.Name = "btn_poortscanner";
            this.btn_poortscanner.Size = new System.Drawing.Size(242, 65);
            this.btn_poortscanner.TabIndex = 0;
            this.btn_poortscanner.Text = "Poortscanner";
            this.btn_poortscanner.UseVisualStyleBackColor = true;
            this.btn_poortscanner.Click += new System.EventHandler(this.btn_poortscanner_Click);
            // 
            // btn_Blacklisting
            // 
            this.btn_Blacklisting.Location = new System.Drawing.Point(13, 99);
            this.btn_Blacklisting.Name = "btn_Blacklisting";
            this.btn_Blacklisting.Size = new System.Drawing.Size(242, 65);
            this.btn_Blacklisting.TabIndex = 1;
            this.btn_Blacklisting.Text = "Blacklisting";
            this.btn_Blacklisting.UseVisualStyleBackColor = true;
            this.btn_Blacklisting.Click += new System.EventHandler(this.btn_Blacklisting_Click);
            // 
            // btn_gebruikersrechten
            // 
            this.btn_gebruikersrechten.Location = new System.Drawing.Point(13, 187);
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
            this.lbl_ingelogdeGebruiker.Location = new System.Drawing.Point(10, 360);
            this.lbl_ingelogdeGebruiker.Name = "lbl_ingelogdeGebruiker";
            this.lbl_ingelogdeGebruiker.Size = new System.Drawing.Size(46, 17);
            this.lbl_ingelogdeGebruiker.TabIndex = 3;
            this.lbl_ingelogdeGebruiker.Text = "label1";
            // 
            // btn_datagebruik
            // 
            this.btn_datagebruik.Location = new System.Drawing.Point(13, 274);
            this.btn_datagebruik.Name = "btn_datagebruik";
            this.btn_datagebruik.Size = new System.Drawing.Size(242, 65);
            this.btn_datagebruik.TabIndex = 4;
            this.btn_datagebruik.Text = "Datagebruik";
            this.btn_datagebruik.UseVisualStyleBackColor = true;
            this.btn_datagebruik.Click += new System.EventHandler(this.btn_datagebruik_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 403);
            this.Controls.Add(this.btn_datagebruik);
            this.Controls.Add(this.lbl_ingelogdeGebruiker);
            this.Controls.Add(this.btn_gebruikersrechten);
            this.Controls.Add(this.btn_Blacklisting);
            this.Controls.Add(this.btn_poortscanner);
            this.Name = "StartMenu";
            this.Text = "StartMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_poortscanner;
        private System.Windows.Forms.Button btn_Blacklisting;
        private System.Windows.Forms.Button btn_gebruikersrechten;
        private System.Windows.Forms.Label lbl_ingelogdeGebruiker;
        private System.Windows.Forms.Button btn_datagebruik;
    }
}