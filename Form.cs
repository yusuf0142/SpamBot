using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
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

        /* This variable will be the loop counter */
        private int counter;

        /* Start Button */
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if (TextBox.TextLength >= 1)
            {
                TimerLength.Interval = SpamSpeedTrackBar.Value;
                TimerLength.Start();
            }
            else
            {
                /* Show error if textfield is empty */
                MessageBox.Show("Please enter a value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        /* Stop Button */
        private void ButtonStop_Click(object sender, EventArgs e)
        {
            if (TimerLength.Enabled == false)
            {
                MessageBox.Show("The spammer is currently not running", "");
            }
            else
            {
                TimerLength.Stop();
                MessageBox.Show("The spammer has been stopped", "");
            }
        }

        /* Default Values Button */
        private void ButtonDefault_Click(object sender, EventArgs e)
        {
            TextBox.Clear();
            TextBox.Focus();

            SpamSpeedTrackBar.Value = 10;
            SpamLengthTrackBar.Value = 1;
            LabelSpamSpeed.Text = "1 message / 10 ms";
            LabelSpamLength.Text = "1 second";
        }

        /* Timer Tick */
        private void TimerLength_Tick(object sender, EventArgs e)
        {
            if (counter == SpamLengthTrackBar.Value)
            {
                /* Exit loop code */
                TimerLength.Stop();
                counter = 0;
            }
            else
            {
                /* Spams input text and presses enter */
                SendKeys.Send(TextBox.Text);
                SendKeys.Send("{ENTER}");

                /* Increment counter */
                counter++;
            }
        }

        /* Menu Strip */
        private void CloseMenuStrip_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void TwitterMenuStrip_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/Ce9Fc4x");
        }
        private void GithubMenuStrip_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/yusuftuncay");
        }

        /* TrackBar */
        private void SpamSpeedTrackBar_Scroll(object sender, EventArgs e)
        {
            string text;
            if (SpamSpeedTrackBar.Value == 1000)
                text = "1 message / second";
            else
                text = $"1 message / {SpamSpeedTrackBar.Value} ms";
            LabelSpamSpeed.Text = text;
        }
        private void SpamLengthTrackBar_Scroll(object sender, EventArgs e)
        {
            string text;
            if (SpamLengthTrackBar.Value == 1)
                text = "1 second";
            else if (SpamLengthTrackBar.Value == 60)
                text = "1 minute";
            else
                text = SpamLengthTrackBar.Value.ToString() + " seconds";
            LabelSpamLength.Text = text;
        }

        private void InfoMenuStrip_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There are 1000 milliseconds in one second, the slider provided for Spam Speed only goes up to 1000 milliseconds (1 second)" + "\n \n" + "The maximum value that can be selected for Spam Speed would be 1 message / 1000 milliseconds (1 second)", "");
        }
    }
}
