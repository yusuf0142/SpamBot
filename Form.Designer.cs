using System;

namespace SpamBot
{
    partial class Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonDefault = new System.Windows.Forms.Button();
            this.LabelSpamLength = new System.Windows.Forms.Label();
            this.SpamLengthTrackBar = new System.Windows.Forms.TrackBar();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.OptionsMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.Seperator = new System.Windows.Forms.ToolStripSeparator();
            this.InfoMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.SocialsMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.GithubMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.TwitterMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.SpamSpeedTrackBar = new System.Windows.Forms.TrackBar();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.LabelSpamSpeed = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.TimerLength = new System.Windows.Forms.Timer(this.components);
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpamLengthTrackBar)).BeginInit();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpamSpeedTrackBar)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(8, 110);
            this.ButtonStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(105, 27);
            this.ButtonStart.TabIndex = 0;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonStop
            // 
            this.ButtonStop.Location = new System.Drawing.Point(121, 110);
            this.ButtonStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(100, 27);
            this.ButtonStop.TabIndex = 1;
            this.ButtonStop.Text = "Stop";
            this.ButtonStop.UseVisualStyleBackColor = true;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(8, 25);
            this.TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(213, 77);
            this.TextBox.TabIndex = 2;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.ButtonDefault);
            this.GroupBox1.Controls.Add(this.TextBox);
            this.GroupBox1.Controls.Add(this.ButtonStart);
            this.GroupBox1.Controls.Add(this.ButtonStop);
            this.GroupBox1.Location = new System.Drawing.Point(13, 29);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox1.Size = new System.Drawing.Size(230, 182);
            this.GroupBox1.TabIndex = 6;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Type Here";
            // 
            // ButtonDefault
            // 
            this.ButtonDefault.Location = new System.Drawing.Point(8, 145);
            this.ButtonDefault.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonDefault.Name = "ButtonDefault";
            this.ButtonDefault.Size = new System.Drawing.Size(213, 27);
            this.ButtonDefault.TabIndex = 7;
            this.ButtonDefault.Text = "Default Values";
            this.ButtonDefault.UseVisualStyleBackColor = true;
            this.ButtonDefault.Click += new System.EventHandler(this.ButtonDefault_Click);
            // 
            // LabelSpamLength
            // 
            this.LabelSpamLength.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F);
            this.LabelSpamLength.Location = new System.Drawing.Point(9, 18);
            this.LabelSpamLength.Name = "LabelSpamLength";
            this.LabelSpamLength.Size = new System.Drawing.Size(126, 20);
            this.LabelSpamLength.TabIndex = 10;
            this.LabelSpamLength.Text = "1 second";
            this.LabelSpamLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpamLengthTrackBar
            // 
            this.SpamLengthTrackBar.Location = new System.Drawing.Point(6, 41);
            this.SpamLengthTrackBar.Maximum = 60;
            this.SpamLengthTrackBar.Minimum = 1;
            this.SpamLengthTrackBar.Name = "SpamLengthTrackBar";
            this.SpamLengthTrackBar.Size = new System.Drawing.Size(129, 45);
            this.SpamLengthTrackBar.TabIndex = 8;
            this.SpamLengthTrackBar.TickFrequency = 3;
            this.SpamLengthTrackBar.Value = 1;
            this.SpamLengthTrackBar.Scroll += new System.EventHandler(this.SpamLengthTrackBar_Scroll);
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MenuStrip.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionsMenuStrip,
            this.SocialsMenuStrip});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(404, 24);
            this.MenuStrip.TabIndex = 7;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // OptionsMenuStrip
            // 
            this.OptionsMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseMenuStrip,
            this.Seperator,
            this.InfoMenuStrip});
            this.OptionsMenuStrip.Name = "OptionsMenuStrip";
            this.OptionsMenuStrip.Size = new System.Drawing.Size(61, 20);
            this.OptionsMenuStrip.Text = "Options";
            // 
            // CloseMenuStrip
            // 
            this.CloseMenuStrip.Name = "CloseMenuStrip";
            this.CloseMenuStrip.Size = new System.Drawing.Size(102, 22);
            this.CloseMenuStrip.Text = "Close";
            this.CloseMenuStrip.Click += new System.EventHandler(this.CloseMenuStrip_Click);
            // 
            // Seperator
            // 
            this.Seperator.Name = "Seperator";
            this.Seperator.Size = new System.Drawing.Size(99, 6);
            // 
            // InfoMenuStrip
            // 
            this.InfoMenuStrip.Name = "InfoMenuStrip";
            this.InfoMenuStrip.Size = new System.Drawing.Size(102, 22);
            this.InfoMenuStrip.Text = "Info";
            this.InfoMenuStrip.Click += new System.EventHandler(this.InfoMenuStrip_Click);
            // 
            // SocialsMenuStrip
            // 
            this.SocialsMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GithubMenuStrip,
            this.TwitterMenuStrip});
            this.SocialsMenuStrip.Name = "SocialsMenuStrip";
            this.SocialsMenuStrip.Size = new System.Drawing.Size(54, 20);
            this.SocialsMenuStrip.Text = "Socials";
            // 
            // GithubMenuStrip
            // 
            this.GithubMenuStrip.Name = "GithubMenuStrip";
            this.GithubMenuStrip.Size = new System.Drawing.Size(110, 22);
            this.GithubMenuStrip.Text = "Github";
            this.GithubMenuStrip.Click += new System.EventHandler(this.GithubMenuStrip_Click);
            // 
            // TwitterMenuStrip
            // 
            this.TwitterMenuStrip.Name = "TwitterMenuStrip";
            this.TwitterMenuStrip.Size = new System.Drawing.Size(110, 22);
            this.TwitterMenuStrip.Text = "Twitter";
            this.TwitterMenuStrip.Click += new System.EventHandler(this.TwitterMenuStrip_Click);
            // 
            // SpamSpeedTrackBar
            // 
            this.SpamSpeedTrackBar.LargeChange = 200;
            this.SpamSpeedTrackBar.Location = new System.Drawing.Point(6, 41);
            this.SpamSpeedTrackBar.Maximum = 1000;
            this.SpamSpeedTrackBar.Minimum = 10;
            this.SpamSpeedTrackBar.Name = "SpamSpeedTrackBar";
            this.SpamSpeedTrackBar.Size = new System.Drawing.Size(129, 45);
            this.SpamSpeedTrackBar.SmallChange = 10;
            this.SpamSpeedTrackBar.TabIndex = 10;
            this.SpamSpeedTrackBar.TickFrequency = 100;
            this.SpamSpeedTrackBar.Value = 10;
            this.SpamSpeedTrackBar.Scroll += new System.EventHandler(this.SpamSpeedTrackBar_Scroll);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.LabelSpamSpeed);
            this.GroupBox2.Controls.Add(this.SpamSpeedTrackBar);
            this.GroupBox2.Location = new System.Drawing.Point(251, 29);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(141, 92);
            this.GroupBox2.TabIndex = 12;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Spam Speed";
            // 
            // LabelSpamSpeed
            // 
            this.LabelSpamSpeed.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F);
            this.LabelSpamSpeed.Location = new System.Drawing.Point(6, 18);
            this.LabelSpamSpeed.Name = "LabelSpamSpeed";
            this.LabelSpamSpeed.Size = new System.Drawing.Size(129, 20);
            this.LabelSpamSpeed.TabIndex = 12;
            this.LabelSpamSpeed.Text = "1 message / 10 ms";
            this.LabelSpamSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.SpamLengthTrackBar);
            this.GroupBox3.Controls.Add(this.LabelSpamLength);
            this.GroupBox3.Location = new System.Drawing.Point(251, 121);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(141, 92);
            this.GroupBox3.TabIndex = 13;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Spam Length";
            // 
            // TimerLength
            // 
            this.TimerLength.Tick += new System.EventHandler(this.TimerLength_Tick);
            // 
            // Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(404, 225);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.MenuStrip);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpamLengthTrackBar)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpamSpeedTrackBar)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.Button ButtonDefault;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem OptionsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CloseMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem SocialsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem GithubMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem TwitterMenuStrip;
        private System.Windows.Forms.TrackBar SpamLengthTrackBar;
        private System.Windows.Forms.Label LabelSpamLength;
        private System.Windows.Forms.TrackBar SpamSpeedTrackBar;
        private System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.Label LabelSpamSpeed;
        private System.Windows.Forms.GroupBox GroupBox3;
        private System.Windows.Forms.ToolStripSeparator Seperator;
        private System.Windows.Forms.ToolStripMenuItem InfoMenuStrip;
        private System.Windows.Forms.Timer TimerLength;
    }
}

