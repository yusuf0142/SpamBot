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
            radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength >= 1)
            {
                if (radioButton1.Checked)
                {
                    timer1.Interval = 200;
                    timer1.Start();
                }

                else if (radioButton2.Checked)
                {
                    timer1.Interval = 500;
                    timer1.Start();
                }

                else if (radioButton3.Checked)
                {
                    timer1.Interval = 1000;
                    timer1.Start();
                }
            }

            else
            {
                MessageBox.Show("Ongeldige waarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Spammen is gestopt", "Gestopt");
        }

        private void buttonWissen_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
            radioButton1.Checked = true;        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(textBox1.Text);
            SendKeys.Send("{ENTER}");
        }
    }
}
