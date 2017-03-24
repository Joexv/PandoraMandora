namespace PandoraMandora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button16 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.station10 = new System.Windows.Forms.Button();
            this.station9 = new System.Windows.Forms.Button();
            this.station8 = new System.Windows.Forms.Button();
            this.station7 = new System.Windows.Forms.Button();
            this.station6 = new System.Windows.Forms.Button();
            this.station5 = new System.Windows.Forms.Button();
            this.station4 = new System.Windows.Forms.Button();
            this.station3 = new System.Windows.Forms.Button();
            this.station2 = new System.Windows.Forms.Button();
            this.station1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SongTimer = new System.ComponentModel.BackgroundWorker();
            this.RevertLabel = new System.ComponentModel.BackgroundWorker();
            this.RefreshSong = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(258, 244);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button16);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button10);
            this.tabPage1.Controls.Add(this.button11);
            this.tabPage1.Controls.Add(this.button12);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(250, 218);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Controls";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(127, 6);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(36, 23);
            this.button16.TabIndex = 13;
            this.button16.Text = "⏸";
            this.button16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 95);
            this.label1.TabIndex = 12;
            this.label1.Text = "Now Playing";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.label1, "Click me to update!");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(169, 93);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 11;
            this.button10.Text = "High";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(88, 94);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 10;
            this.button11.Text = "Mid";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(7, 94);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 9;
            this.button12.Text = "Low";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(7, 65);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "🔉 Vol Down";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(88, 65);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "🔉Mute🔉";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(169, 64);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 6;
            this.button9.Text = "Vol Up 🔊";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(169, 35);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Dislike 👎";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(88, 36);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Skip ➥";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 36);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "👍 Like";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(169, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(88, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "➧";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.station10);
            this.tabPage2.Controls.Add(this.station9);
            this.tabPage2.Controls.Add(this.station8);
            this.tabPage2.Controls.Add(this.station7);
            this.tabPage2.Controls.Add(this.station6);
            this.tabPage2.Controls.Add(this.station5);
            this.tabPage2.Controls.Add(this.station4);
            this.tabPage2.Controls.Add(this.station3);
            this.tabPage2.Controls.Add(this.station2);
            this.tabPage2.Controls.Add(this.station1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(250, 218);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stations";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hover or button for Station Information";
            // 
            // station10
            // 
            this.station10.Location = new System.Drawing.Point(87, 6);
            this.station10.Name = "station10";
            this.station10.Size = new System.Drawing.Size(75, 23);
            this.station10.TabIndex = 9;
            this.station10.Text = "10";
            this.station10.UseVisualStyleBackColor = true;
            this.station10.Click += new System.EventHandler(this.station10_Click);
            // 
            // station9
            // 
            this.station9.Location = new System.Drawing.Point(168, 92);
            this.station9.Name = "station9";
            this.station9.Size = new System.Drawing.Size(75, 23);
            this.station9.TabIndex = 8;
            this.station9.Text = "9";
            this.station9.UseVisualStyleBackColor = true;
            this.station9.Click += new System.EventHandler(this.station9_Click);
            // 
            // station8
            // 
            this.station8.Location = new System.Drawing.Point(87, 92);
            this.station8.Name = "station8";
            this.station8.Size = new System.Drawing.Size(75, 23);
            this.station8.TabIndex = 7;
            this.station8.Text = "8";
            this.station8.UseVisualStyleBackColor = true;
            this.station8.Click += new System.EventHandler(this.station8_Click);
            // 
            // station7
            // 
            this.station7.Location = new System.Drawing.Point(6, 92);
            this.station7.Name = "station7";
            this.station7.Size = new System.Drawing.Size(75, 23);
            this.station7.TabIndex = 6;
            this.station7.Text = "7";
            this.station7.UseVisualStyleBackColor = true;
            this.station7.Click += new System.EventHandler(this.station7_Click);
            // 
            // station6
            // 
            this.station6.Location = new System.Drawing.Point(168, 63);
            this.station6.Name = "station6";
            this.station6.Size = new System.Drawing.Size(75, 23);
            this.station6.TabIndex = 5;
            this.station6.Text = "6";
            this.station6.UseVisualStyleBackColor = true;
            this.station6.Click += new System.EventHandler(this.station6_Click);
            // 
            // station5
            // 
            this.station5.Location = new System.Drawing.Point(87, 63);
            this.station5.Name = "station5";
            this.station5.Size = new System.Drawing.Size(75, 23);
            this.station5.TabIndex = 4;
            this.station5.Text = "5";
            this.station5.UseVisualStyleBackColor = true;
            this.station5.Click += new System.EventHandler(this.station5_Click);
            // 
            // station4
            // 
            this.station4.Location = new System.Drawing.Point(6, 63);
            this.station4.Name = "station4";
            this.station4.Size = new System.Drawing.Size(75, 23);
            this.station4.TabIndex = 3;
            this.station4.Text = "4";
            this.station4.UseVisualStyleBackColor = true;
            this.station4.Click += new System.EventHandler(this.station4_Click);
            // 
            // station3
            // 
            this.station3.Location = new System.Drawing.Point(168, 34);
            this.station3.Name = "station3";
            this.station3.Size = new System.Drawing.Size(75, 23);
            this.station3.TabIndex = 2;
            this.station3.Text = "3";
            this.station3.UseVisualStyleBackColor = true;
            this.station3.Click += new System.EventHandler(this.station3_Click);
            // 
            // station2
            // 
            this.station2.Location = new System.Drawing.Point(87, 34);
            this.station2.Name = "station2";
            this.station2.Size = new System.Drawing.Size(75, 23);
            this.station2.TabIndex = 1;
            this.station2.Text = "2";
            this.station2.UseVisualStyleBackColor = true;
            this.station2.Click += new System.EventHandler(this.station2_Click);
            // 
            // station1
            // 
            this.station1.Location = new System.Drawing.Point(7, 35);
            this.station1.Name = "station1";
            this.station1.Size = new System.Drawing.Size(75, 23);
            this.station1.TabIndex = 0;
            this.station1.Text = "1";
            this.station1.UseVisualStyleBackColor = true;
            this.station1.Click += new System.EventHandler(this.station1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button15);
            this.tabPage3.Controls.Add(this.button14);
            this.tabPage3.Controls.Add(this.button13);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(250, 218);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(6, 63);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 2;
            this.button15.Text = "Unlock phone";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click_1);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(6, 33);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 1;
            this.button14.Text = "Mini player";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(6, 4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 0;
            this.button13.Text = "Open config";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 254);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(264, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(19, 17);
            this.toolStripStatusLabel1.Text = "....";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            this.toolStripStatusLabel1.TextChanged += new System.EventHandler(this.toolStripStatusLabel1_TextChanged);
            // 
            // SongTimer
            // 
            this.SongTimer.WorkerSupportsCancellation = true;
            this.SongTimer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SongTimer_DoWork);
            this.SongTimer.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SongTimer_RunWorkerCompleted);
            // 
            // RevertLabel
            // 
            this.RevertLabel.WorkerSupportsCancellation = true;
            this.RevertLabel.DoWork += new System.ComponentModel.DoWorkEventHandler(this.RevertLabel_DoWork);
            // 
            // RefreshSong
            // 
            this.RefreshSong.DoWork += new System.ComponentModel.DoWorkEventHandler(this.RefreshSong_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 276);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pandora Mandora";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button station10;
        private System.Windows.Forms.Button station9;
        private System.Windows.Forms.Button station8;
        private System.Windows.Forms.Button station7;
        private System.Windows.Forms.Button station6;
        private System.Windows.Forms.Button station5;
        private System.Windows.Forms.Button station4;
        private System.Windows.Forms.Button station3;
        private System.Windows.Forms.Button station2;
        private System.Windows.Forms.Button station1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.BackgroundWorker SongTimer;
        private System.ComponentModel.BackgroundWorker RevertLabel;
        private System.ComponentModel.BackgroundWorker RefreshSong;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
    }
}

