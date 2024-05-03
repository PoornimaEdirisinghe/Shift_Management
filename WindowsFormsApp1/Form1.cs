using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Apply")
            {
                using (popup pp = new popup())
                {
                    pp.ShowDialog();
                    if (pp.Result == "Confirm")
                    {
                        button1.Text = "Applied";
                        status.Text = "Pending";
                    }
                }
            }
            else if (button1.Text == "Applied")
            {
                button1.Text = "Apply";
                status.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            status.Text = "";
            L2.Text = "";
            L3.Text = "";
            L4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            if (button2.Text == "Apply")
            {
                using (popup pp = new popup())
                {
                    pp.ShowDialog();
                    if (pp.Result == "Confirm")
                    {
                        button2.Text = "Applied";
                        status.Text = "Pending";
                    }
                }
            }
            else if (button2.Text == "Applied")
            {
                button2.Text = "Apply";
                status.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "Apply")
            {
                using (popup pp = new popup())
                {
                    pp.ShowDialog();
                    if (pp.Result == "Confirm")
                    {
                        button4.Text = "Applied";
                        L2.Text = "Pending";
                    }
                }
            }
            else if (button4.Text == "Applied")
            {
                button4.Text = "Apply";
                L2.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Apply")
            {
                using (popup pp = new popup())
                {
                    pp.ShowDialog();
                    if (pp.Result == "Confirm")
                    {
                        button3.Text = "Applied";
                        L2.Text = "Pending";
                    }
                }
            }
            else if (button3.Text == "Applied")
            {
                button3.Text = "Apply";
                L2.Text = "";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "Apply")
            {
                using (popup pp = new popup())
                {
                    pp.ShowDialog();
                    if (pp.Result == "Confirm")
                    {
                        button6.Text = "Applied";
                        L3.Text = "Pending";
                    }
                }
            }
            else if (button6.Text == "Applied")
            {
                button6.Text = "Apply";
                L3.Text = "";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Apply")
            {
                using (popup pp = new popup())
                {
                    pp.ShowDialog();
                    if (pp.Result == "Confirm")
                    {
                        button5.Text = "Applied";
                        L3.Text = "Pending";
                    }
                }
            }
            else if (button5.Text == "Applied")
            {
                button5.Text = "Apply";
                L3.Text = "";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "Apply")
            {
                using (popup pp = new popup())
                {
                    pp.ShowDialog();
                    if (pp.Result == "Confirm")
                    {
                        button8.Text = "Applied";
                        L4.Text = "Pending";
                    }
                }
            }
            else if (button8.Text == "Applied")
            {
                button8.Text = "Apply";
                L4.Text = "";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button8.Text == "Apply")
            {
                using (popup pp = new popup())
                {
                    pp.ShowDialog();
                    if (pp.Result == "Confirm")
                    {
                        button8.Text = "Applied";
                        L4.Text = "Pending";
                    }
                }
            }
            else if (button8.Text == "Applied")
            {
                button8.Text = "Apply";
                L4.Text = "";
            }
        }

        private void status_Click(object sender, EventArgs e)
        {
           statusform sf = new statusform();
           sf.ShowDialog();
        }

        private void L2_Click(object sender, EventArgs e)
        {
            statusform sf = new statusform();
            sf.ShowDialog();
        }

        private void L3_Click(object sender, EventArgs e)
        {
            statusform sf = new statusform();
            sf.ShowDialog();
        }

        private void L4_Click(object sender, EventArgs e)
        {
            statusform sf = new statusform();
            sf.ShowDialog();
        }
    }
}
