using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {




        double num1 = 0;
        
        char a = '+';


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += '1';
        }

        


        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text += '2';
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += '3';
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += '4';
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += '5';
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += '6';
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += '7';
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += '8';
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += '9';
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text += '0';
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            textBox1.Text += '.';
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
                if (a == '+')
                {
                    textBox1.Text = Convert.ToString(num1 + Convert.ToDouble(textBox1.Text));
                }
                if (a == '-')
                {
                    textBox1.Text = Convert.ToString(num1 - Convert.ToDouble(textBox1.Text));
                }

                if (a == '*')
                {
                    textBox1.Text = Convert.ToString(num1 * Convert.ToDouble(textBox1.Text));
                }
                if (a == '/')
                {
                    textBox1.Text = Convert.ToString(num1 / Convert.ToDouble(textBox1.Text));
                }
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * -1);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                a = '+';
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                a = '-';
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                a = '*';
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                a = '/';
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            num1 = 0;
            textBox1.Text = "";
        }

       
    }
}
