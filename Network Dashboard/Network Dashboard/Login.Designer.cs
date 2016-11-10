namespace Network_Dashboard
{
    partial class Login
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
            this.lbl_gebruikersnaam = new System.Windows.Forms.Label();
            this.lbl_wachtwoord = new System.Windows.Forms.Label();
            this.tb_gebruikersnaam = new System.Windows.Forms.TextBox();
            this.tb_wachtwoord = new System.Windows.Forms.TextBox();
            this.btn_inloggen = new System.Windows.Forms.Button();
            this.btn_creategebruiker = new System.Windows.Forms.Button();
            this.btn_wijzigwachtwoord = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_gebruikersnaam
            // 
            this.lbl_gebruikersnaam.AutoSize = true;
            this.lbl_gebruikersnaam.Location = new System.Drawing.Point(33, 31);
            this.lbl_gebruikersnaam.Name = "lbl_gebruikersnaam";
            this.lbl_gebruikersnaam.Size = new System.Drawing.Size(117, 17);
            this.lbl_gebruikersnaam.TabIndex = 0;
            this.lbl_gebruikersnaam.Text = "Gebruikersnaam:";
            // 
            // lbl_wachtwoord
            // 
            this.lbl_wachtwoord.AutoSize = true;
            this.lbl_wachtwoord.Location = new System.Drawing.Point(33, 106);
            this.lbl_wachtwoord.Name = "lbl_wachtwoord";
            this.lbl_wachtwoord.Size = new System.Drawing.Size(90, 17);
            this.lbl_wachtwoord.TabIndex = 1;
            this.lbl_wachtwoord.Text = "Wachtwoord:";
            // 
            // tb_gebruikersnaam
            // 
            this.tb_gebruikersnaam.Location = new System.Drawing.Point(36, 52);
            this.tb_gebruikersnaam.Name = "tb_gebruikersnaam";
            this.tb_gebruikersnaam.Size = new System.Drawing.Size(200, 22);
            this.tb_gebruikersnaam.TabIndex = 2;
            // 
            // tb_wachtwoord
            // 
            this.tb_wachtwoord.Location = new System.Drawing.Point(36, 126);
            this.tb_wachtwoord.Name = "tb_wachtwoord";
            this.tb_wachtwoord.Size = new System.Drawing.Size(200, 22);
            this.tb_wachtwoord.TabIndex = 3;
            this.tb_wachtwoord.UseSystemPasswordChar = true;
            // 
            // btn_inloggen
            // 
            this.btn_inloggen.Location = new System.Drawing.Point(36, 160);
            this.btn_inloggen.Name = "btn_inloggen";
            this.btn_inloggen.Size = new System.Drawing.Size(155, 45);
            this.btn_inloggen.TabIndex = 4;
            this.btn_inloggen.Text = "Inloggen";
            this.btn_inloggen.UseVisualStyleBackColor = true;
            this.btn_inloggen.Click += new System.EventHandler(this.btn_inloggen_Click);
            // 
            // btn_creategebruiker
            // 
            this.btn_creategebruiker.Location = new System.Drawing.Point(36, 211);
            this.btn_creategebruiker.Name = "btn_creategebruiker";
            this.btn_creategebruiker.Size = new System.Drawing.Size(155, 45);
            this.btn_creategebruiker.TabIndex = 5;
            this.btn_creategebruiker.Text = "Gebruiker aanmaken";
            this.btn_creategebruiker.UseVisualStyleBackColor = true;
            this.btn_creategebruiker.Click += new System.EventHandler(this.btn_creategebruiker_Click);
            // 
            // btn_wijzigwachtwoord
            // 
            this.btn_wijzigwachtwoord.Enabled = false;
            this.btn_wijzigwachtwoord.Location = new System.Drawing.Point(36, 263);
            this.btn_wijzigwachtwoord.Name = "btn_wijzigwachtwoord";
            this.btn_wijzigwachtwoord.Size = new System.Drawing.Size(155, 45);
            this.btn_wijzigwachtwoord.TabIndex = 6;
            this.btn_wijzigwachtwoord.Text = "Wachtwoord wijzigen";
            this.btn_wijzigwachtwoord.UseVisualStyleBackColor = true;
            this.btn_wijzigwachtwoord.Visible = false;
            this.btn_wijzigwachtwoord.Click += new System.EventHandler(this.btn_wijzigwachtwoord_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 335);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_wijzigwachtwoord);
            this.Controls.Add(this.btn_creategebruiker);
            this.Controls.Add(this.btn_inloggen);
            this.Controls.Add(this.tb_wachtwoord);
            this.Controls.Add(this.tb_gebruikersnaam);
            this.Controls.Add(this.lbl_wachtwoord);
            this.Controls.Add(this.lbl_gebruikersnaam);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_gebruikersnaam;
        private System.Windows.Forms.Label lbl_wachtwoord;
        private System.Windows.Forms.TextBox tb_gebruikersnaam;
        private System.Windows.Forms.TextBox tb_wachtwoord;
        private System.Windows.Forms.Button btn_inloggen;
        private System.Windows.Forms.Button btn_creategebruiker;
        private System.Windows.Forms.Button btn_wijzigwachtwoord;
        private System.Windows.Forms.Button button1;
    }
}