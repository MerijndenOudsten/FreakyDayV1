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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_InternetSnelheid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Upload = new System.Windows.Forms.Label();
            this.btn_veranderRecht = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Download = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Terug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(297, 420);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Internet snelheid:";
            // 
            // lbl_InternetSnelheid
            // 
            this.lbl_InternetSnelheid.AutoSize = true;
            this.lbl_InternetSnelheid.Location = new System.Drawing.Point(398, 211);
            this.lbl_InternetSnelheid.Name = "lbl_InternetSnelheid";
            this.lbl_InternetSnelheid.Size = new System.Drawing.Size(46, 17);
            this.lbl_InternetSnelheid.TabIndex = 2;
            this.lbl_InternetSnelheid.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Upload:";
            // 
            // lbl_Upload
            // 
            this.lbl_Upload.AutoSize = true;
            this.lbl_Upload.Location = new System.Drawing.Point(398, 290);
            this.lbl_Upload.Name = "lbl_Upload";
            this.lbl_Upload.Size = new System.Drawing.Size(46, 17);
            this.lbl_Upload.TabIndex = 4;
            this.lbl_Upload.Text = "label4";
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Beheerder",
            "Kind",
            "Standaard",
            "Onbekend"});
            this.comboBox1.Location = new System.Drawing.Point(122, 457);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "Gebruikersrecht";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Download:";
            // 
            // lbl_Download
            // 
            this.lbl_Download.AutoSize = true;
            this.lbl_Download.Location = new System.Drawing.Point(398, 341);
            this.lbl_Download.Name = "lbl_Download";
            this.lbl_Download.Size = new System.Drawing.Size(53, 17);
            this.lbl_Download.TabIndex = 10;
            this.lbl_Download.Text = "Upload";
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
            // Gebruikersrechten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 559);
            this.Controls.Add(this.btn_Terug);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_Download);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_veranderRecht);
            this.Controls.Add(this.lbl_Upload);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_InternetSnelheid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Gebruikersrechten";
            this.Text = "Gebruikersrechten";
            this.Load += new System.EventHandler(this.Gebruikersrechten_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_InternetSnelheid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Upload;
        private System.Windows.Forms.Button btn_veranderRecht;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Download;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Terug;
    }
}