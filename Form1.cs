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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RadioButton1.Checked = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.TextLength >= 1)
            {
                if (RadioButton1.Checked)
                {
                    Timer1.Interval = 200;
                    Timer1.Start();
                }
                else if (RadioButton2.Checked)
                {
                    Timer1.Interval = 500;
                    Timer1.Start();
                }
                else if (RadioButton3.Checked)
                {
                    Timer1.Interval = 1000;
                    Timer1.Start();
                }
            }
            else
            {
                MessageBox.Show("Ongeldige waarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (Timer1.Enabled == false)
            {
                MessageBox.Show("Spammen is al gestopt", "Error");
            }
            else
            {
                Timer1.Stop();
                MessageBox.Show("Spammen is gestopt", "Gestopt");
            }
        }

        private void ButtonWissen_Click(object sender, EventArgs e)
        {
            TextBox1.Clear();
            TextBox1.Focus();
            RadioButton1.Checked = true;        
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(TextBox1.Text);
            SendKeys.Send("{ENTER}");
        }
    }
}
