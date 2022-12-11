namespace SpamBot
{
    partial class Form
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
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonDefault = new System.Windows.Forms.Button();
            this.RadioButton3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
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
            this.TextBox.Size = new System.Drawing.Size(132, 77);
            this.TextBox.TabIndex = 2;
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Location = new System.Drawing.Point(149, 25);
            this.RadioButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(54, 20);
            this.RadioButton1.TabIndex = 4;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "0,2 x";
            this.RadioButton1.UseVisualStyleBackColor = true;
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Location = new System.Drawing.Point(149, 53);
            this.RadioButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(54, 20);
            this.RadioButton2.TabIndex = 5;
            this.RadioButton2.TabStop = true;
            this.RadioButton2.Text = "0,5 x";
            this.RadioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonDefault);
            this.groupBox1.Controls.Add(this.RadioButton3);
            this.groupBox1.Controls.Add(this.TextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RadioButton2);
            this.groupBox1.Controls.Add(this.ButtonStart);
            this.groupBox1.Controls.Add(this.RadioButton1);
            this.groupBox1.Controls.Add(this.ButtonStop);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(229, 182);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type Here";
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
            // RadioButton3
            // 
            this.RadioButton3.AutoSize = true;
            this.RadioButton3.Location = new System.Drawing.Point(149, 81);
            this.RadioButton3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadioButton3.Name = "RadioButton3";
            this.RadioButton3.Size = new System.Drawing.Size(44, 20);
            this.RadioButton3.TabIndex = 6;
            this.RadioButton3.TabStop = true;
            this.RadioButton3.Text = "1 x";
            this.RadioButton3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Spam Speed";
            // 
            // Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(265, 210);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpamBot";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.RadioButton RadioButton1;
        private System.Windows.Forms.RadioButton RadioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioButton3;
        private System.Windows.Forms.Button ButtonDefault;
        private System.Windows.Forms.Label label1;
    }
}

