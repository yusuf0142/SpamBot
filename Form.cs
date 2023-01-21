using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;
using System.Timers;
using System.Threading.Tasks;

namespace SpamBot
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        /* Start Button */
        private async void ButtonStart_Click(object sender, EventArgs e)
        {
            if (TextBox.TextLength >= 1)
            {
                /* Timer for spamming */
                TimerLength.Interval = SpamSpeedTrackBar.Value;
                TimerLength.Start();

                /* Timer for spamming */
                await Task.Delay(SpamLengthTrackBar.Value * 1000);

                /* Exit loop code */
                TimerLength.Stop();
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
            /* Clear text field and set focus */
            TextBox.Clear();
            TextBox.Focus();

            /* Bring default values to the sliders and correct the labels */
            SpamSpeedTrackBar.Value = 10;
            SpamLengthTrackBar.Value = 1;
            LabelSpamSpeed.Text = "1 message / 10 ms";
            LabelSpamLength.Text = "1 second";
        }

        /* Timer Tick */
        private void TimerLength_Tick(object sender, EventArgs e)
        {
            /* Spams input text and presses enter */
            SendKeys.Send(TextBox.Text);
            SendKeys.Send("{ENTER}");
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

        /* Menu Strip */
        private void CloseMenuStrip_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void InfoMenuStrip_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There are 1000 milliseconds in one second, the slider provided for Spam Speed only goes up to 1000 milliseconds (1 second)" + "\n \n" + "The maximum value that can be selected for Spam Speed would be 1 message / 1000 milliseconds (1 second)", "");
        }
        private void TutorialMenuStrip_Click(object sender, EventArgs e)
        {
            MessageBox.Show("How to use the Spambot program:\r\n\r\n1. Enter the text you want to spam in the designated text field.\r\n2. Choose an interval for the spam speed by using the slider.\r\n3. Choose a duration for the spamming, ranging from 1 to 60 seconds.\r\n4. Press the \"start\" button to begin the spamming process.\r\n5. Focus on the text field you want the spam to be sent to.\r\n6. To stop the program, press the \"stop\" button.\r\n7. To set everything back to the default values, use the \"default values\" button.\n\r\nPlease note that spamming is illegal and unethical. Therefore, it is important to use this program only for legitimate and lawful purposes and to obtain proper consent before sending any messages.", "");
        }
        private void TwitterMenuStrip_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/Ce9Fc4x");
        }
        private void GithubMenuStrip_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/yusuftuncay");
        }
    }
}
