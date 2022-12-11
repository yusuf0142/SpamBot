using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Xsl;

namespace SpamBot
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        /* Form Load */
        private void Form_Load(object sender, EventArgs e)
        {
            RadioButton1.Checked = true;
        }

        /* Start Button */
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if (TextBox.TextLength >= 1)
            {
                /* 0.2x Speed */
                if (RadioButton1.Checked)
                {
                    Timer.Interval = 200;
                    Timer.Start();
                }
                /* 0.5x Speed */
                else if (RadioButton2.Checked)
                {
                    Timer.Interval = 500;
                    Timer.Start();
                }
                /* 1x Speed */
                else if (RadioButton3.Checked)
                {
                    Timer.Interval = 1000;
                    Timer.Start();
                }
            }
            else
            {
                MessageBox.Show("Not a Valid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        /* Stop Button */
        private void ButtonStop_Click(object sender, EventArgs e)
        {
            if (Timer.Enabled == false)
            {
                MessageBox.Show("Timer not Running", "Error");
            }
            else
            {
                Timer.Stop();
                MessageBox.Show("Spamming Stopped", "Stopped");
            }
        }

        private void ButtonDefault_Click(object sender, EventArgs e)
        {
            TextBox.Clear();
            TextBox.Focus();
            RadioButton1.Checked = true;        
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(TextBox.Text);
            SendKeys.Send("{ENTER}");
        }
    }
}
