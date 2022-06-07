﻿namespace WindowsFormsApplication4
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.StopBtn = new System.Windows.Forms.Button();
            this.LaunchBtn = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.WeatherLabel = new System.Windows.Forms.Label();
            this.HistoryLabel = new System.Windows.Forms.Label();
            this.FineLabel = new System.Windows.Forms.Label();
            this.CloudyLabel = new System.Windows.Forms.Label();
            this.RainyLabel = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.trackBar1);
            this.panel.Controls.Add(this.TimeLabel);
            this.panel.Controls.Add(this.StopBtn);
            this.panel.Controls.Add(this.LaunchBtn);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(642, 114);
            this.panel.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(605, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "16x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "4x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "1x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "0.5x";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "0.25x";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(257, 12);
            this.trackBar1.Maximum = 4;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(372, 45);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.Value = 2;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(530, 87);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(79, 13);
            this.TimeLabel.TabIndex = 8;
            this.TimeLabel.Text = "Время: 0 дней";
            // 
            // StopBtn
            // 
            this.StopBtn.Enabled = false;
            this.StopBtn.Location = new System.Drawing.Point(113, 34);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(96, 23);
            this.StopBtn.TabIndex = 7;
            this.StopBtn.Text = "Стоп";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.Stop_Click);
            // 
            // LaunchBtn
            // 
            this.LaunchBtn.Location = new System.Drawing.Point(11, 34);
            this.LaunchBtn.Name = "LaunchBtn";
            this.LaunchBtn.Size = new System.Drawing.Size(96, 23);
            this.LaunchBtn.TabIndex = 6;
            this.LaunchBtn.Text = "Запустить";
            this.LaunchBtn.UseVisualStyleBackColor = true;
            this.LaunchBtn.Click += new System.EventHandler(this.Launch_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // WeatherLabel
            // 
            this.WeatherLabel.AutoSize = true;
            this.WeatherLabel.Location = new System.Drawing.Point(12, 128);
            this.WeatherLabel.Name = "WeatherLabel";
            this.WeatherLabel.Size = new System.Drawing.Size(135, 13);
            this.WeatherLabel.TabIndex = 15;
            this.WeatherLabel.Text = "Погода сейчас: солнечно";
            // 
            // HistoryLabel
            // 
            this.HistoryLabel.AutoSize = true;
            this.HistoryLabel.Location = new System.Drawing.Point(12, 151);
            this.HistoryLabel.Name = "HistoryLabel";
            this.HistoryLabel.Size = new System.Drawing.Size(56, 13);
            this.HistoryLabel.TabIndex = 16;
            this.HistoryLabel.Text = "История: ";
            // 
            // FineLabel
            // 
            this.FineLabel.AutoSize = true;
            this.FineLabel.Location = new System.Drawing.Point(12, 177);
            this.FineLabel.Name = "FineLabel";
            this.FineLabel.Size = new System.Drawing.Size(177, 13);
            this.FineLabel.TabIndex = 18;
            this.FineLabel.Text = "% ясных дней (теоретически 38%)";
            // 
            // CloudyLabel
            // 
            this.CloudyLabel.AutoSize = true;
            this.CloudyLabel.Location = new System.Drawing.Point(12, 203);
            this.CloudyLabel.Name = "CloudyLabel";
            this.CloudyLabel.Size = new System.Drawing.Size(194, 13);
            this.CloudyLabel.TabIndex = 20;
            this.CloudyLabel.Text = "% облачных дней (теоретически 30%)";
            // 
            // RainyLabel
            // 
            this.RainyLabel.AutoSize = true;
            this.RainyLabel.Location = new System.Drawing.Point(12, 229);
            this.RainyLabel.Name = "RainyLabel";
            this.RainyLabel.Size = new System.Drawing.Size(202, 13);
            this.RainyLabel.TabIndex = 22;
            this.RainyLabel.Text = "% пасмурных дней (теоретически 32%)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 259);
            this.Controls.Add(this.RainyLabel);
            this.Controls.Add(this.CloudyLabel);
            this.Controls.Add(this.FineLabel);
            this.Controls.Add(this.HistoryLabel);
            this.Controls.Add(this.WeatherLabel);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button LaunchBtn;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label WeatherLabel;
        private System.Windows.Forms.Label HistoryLabel;
        private System.Windows.Forms.Label FineLabel;
        private System.Windows.Forms.Label CloudyLabel;
        private System.Windows.Forms.Label RainyLabel;
    }
}

