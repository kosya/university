using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_7_1
{
    public partial class Form1 : Form
    {
        private int operation = 0; // 1 - "+", 2 - "-", 3 - "*", 4 - "/"
        private int value1 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void CopyPaste()
        {
            value1 = Convert.ToInt32(textBox.Text);
            textBox.Text = "";
            label.Text = "";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            CopyPaste();
            operation = 1;
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            CopyPaste();
            operation = 2;
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            CopyPaste();
            operation = 3;
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            CopyPaste();
            operation = 4;
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            int value2 = Convert.ToInt32(textBox.Text);
            switch (operation)
            {
                case 1:
                    {
                        label.Text = "Result: " + Convert.ToString(value1 + value2);
                        textBox.Text = "";
                        break;
                    }
                case 2:
                    {
                        label.Text = "Result: " + Convert.ToString(value1 - value2);
                        textBox.Text = "";
                        break;
                    }
                case 3:
                    {
                        label.Text = "Result: " + Convert.ToString(value1 * value2);
                        textBox.Text = "";
                        break;
                    }
                case 4:
                    {
                        float tmp = value1 / value2;
                        label.Text = "Result: " + Convert.ToString(tmp);
                        textBox.Text = "";
                        break;
                    }
            }
            value1 = 0;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox.Text += "9";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
        }
    }
}
