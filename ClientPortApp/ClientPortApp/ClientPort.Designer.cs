namespace ClientPortApp
{
    partial class ClientPort
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
            this.btn_BlockPort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_BlockPort
            // 
            this.btn_BlockPort.Location = new System.Drawing.Point(13, 13);
            this.btn_BlockPort.Name = "btn_BlockPort";
            this.btn_BlockPort.Size = new System.Drawing.Size(173, 71);
            this.btn_BlockPort.TabIndex = 0;
            this.btn_BlockPort.Text = "Test Port Blocking";
            this.btn_BlockPort.UseVisualStyleBackColor = true;
            this.btn_BlockPort.Click += new System.EventHandler(this.btn_BlockPort_Click);
            // 
            // ClientPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 288);
            this.Controls.Add(this.btn_BlockPort);
            this.Name = "ClientPort";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_BlockPort;
    }
}

