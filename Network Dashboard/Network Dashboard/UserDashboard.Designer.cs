﻿namespace Network_Dashboard
{
    partial class UserDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart_Dataverbruik = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.btn_LoadGraph = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Dataverbruik)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_Dataverbruik
            // 
            this.chart_Dataverbruik.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.CursorX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea1.Name = "suh";
            this.chart_Dataverbruik.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.SystemColors.Control;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Dataverbruik";
            this.chart_Dataverbruik.Legends.Add(legend1);
            this.chart_Dataverbruik.Location = new System.Drawing.Point(12, 64);
            this.chart_Dataverbruik.Name = "chart_Dataverbruik";
            this.chart_Dataverbruik.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "suh";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series1.Legend = "Dataverbruik";
            series1.Name = "Upload";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.ChartArea = "suh";
            series2.Color = System.Drawing.Color.Lime;
            series2.Legend = "Dataverbruik";
            series2.Name = "Download";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series3.BorderWidth = 4;
            series3.ChartArea = "suh";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Red;
            series3.CustomProperties = "IsXAxisQuantitative=False";
            series3.Legend = "Dataverbruik";
            series3.Name = "Datalimiet";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series3.YValuesPerPoint = 2;
            this.chart_Dataverbruik.Series.Add(series1);
            this.chart_Dataverbruik.Series.Add(series2);
            this.chart_Dataverbruik.Series.Add(series3);
            this.chart_Dataverbruik.Size = new System.Drawing.Size(613, 459);
            this.chart_Dataverbruik.TabIndex = 0;
            this.chart_Dataverbruik.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.DarkCyan;
            title1.Name = "Dataverbruik";
            title1.Text = "Hoeveel data heb je verbruikt?";
            this.chart_Dataverbruik.Titles.Add(title1);
            this.chart_Dataverbruik.Click += new System.EventHandler(this.chart1_Click);
            // 
            // btn_Menu
            // 
            this.btn_Menu.Location = new System.Drawing.Point(12, 12);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(107, 46);
            this.btn_Menu.TabIndex = 1;
            this.btn_Menu.Text = "Menu";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // btn_LoadGraph
            // 
            this.btn_LoadGraph.Location = new System.Drawing.Point(444, 64);
            this.btn_LoadGraph.Name = "btn_LoadGraph";
            this.btn_LoadGraph.Size = new System.Drawing.Size(98, 37);
            this.btn_LoadGraph.TabIndex = 2;
            this.btn_LoadGraph.Text = "LoadGraph";
            this.btn_LoadGraph.UseVisualStyleBackColor = true;
            this.btn_LoadGraph.Click += new System.EventHandler(this.btn_LoadGraph_Click);
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 535);
            this.Controls.Add(this.btn_LoadGraph);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.chart_Dataverbruik);
            this.Name = "UserDashboard";
            this.Text = "UserDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.chart_Dataverbruik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Dataverbruik;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Button btn_LoadGraph;
    }
}