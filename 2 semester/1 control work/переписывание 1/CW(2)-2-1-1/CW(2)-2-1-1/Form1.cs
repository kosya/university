using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_2__2_1_1
{
    public partial class Form1 : Form
    {
        private const int n = 3;
        private int NumOfElements = 0;
        private int [,]matrix = new int[n, n];

        public void ZeroingMatrix()
        {
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    matrix[j, i] = 0;
                }
            }
        }

        public bool ColumnCheck(int column)
        {
            return matrix[column, 0] == matrix[column, 1] && matrix[column, 1] == matrix[column, 2] && matrix[column, 0] != 0;
        }

        public bool LineCheck(int line)
        {
            return matrix[0, line] == matrix[1, line] && matrix[1, line] == matrix[2, line] && matrix[0, line] != 0;
        }

        public bool DiagonalCheck(int column, int line)
        {
            if (matrix[column, line] != 0 && (column + line) % 2 == 0)
            {
                if (column == 1)
                {
                    return matrix[0, 0] == matrix[1, 1] && matrix[1, 1] == matrix[2, 2] || matrix[1, 1] == matrix[2, 0] && matrix[1, 1] == matrix[0, 2];
                }
                else
                {
                    if (column + line == 2)
                    {
                        return matrix[1, 1] == matrix[2, 0] && matrix[1, 1] == matrix[0, 2];
                    }
                    else
                    {
                        return matrix[0, 0] == matrix[1, 1] && matrix[1, 1] == matrix[2, 2];
                    }
                }
            }
            else
            {
                return false;
            }
        }

        public void UsingMatrix(int value, int column, int line)
        {
            matrix[column, line] = value;
            if (ColumnCheck(column) || LineCheck(line) || DiagonalCheck(column, line))
            {
                if (matrix[column, line] == 1)
                {
                    this.button1.Text = "";
                    this.button2.Text = "";
                    this.button3.Text = "";
                    this.button4.Text = "";
                    this.button5.Text = "X WINS";
                    this.button6.Text = "";
                    this.button7.Text = "";
                    this.button8.Text = "";
                    this.button9.Text = "";
                    this.button1.Enabled = false;
                    this.button2.Enabled = false;
                    this.button3.Enabled = false;
                    this.button4.Enabled = false;
                    this.button5.Enabled = false;
                    this.button6.Enabled = false;
                    this.button7.Enabled = false;
                    this.button8.Enabled = false;
                    this.button9.Enabled = false;
                }
                else
                {
                    this.button1.Text = "";
                    this.button2.Text = "";
                    this.button3.Text = "";
                    this.button4.Text = "";
                    this.button5.Text = "O WINS";
                    this.button6.Text = "";
                    this.button7.Text = "";
                    this.button8.Text = "";
                    this.button9.Text = "";
                    this.button1.Enabled = false;
                    this.button2.Enabled = false;
                    this.button3.Enabled = false;
                    this.button4.Enabled = false;
                    this.button5.Enabled = false;
                    this.button6.Enabled = false;
                    this.button7.Enabled = false;
                    this.button8.Enabled = false;
                    this.button9.Enabled = false;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NumOfElements == 0)
            {
                ZeroingMatrix();
            }
            if (button1.Text == "")
            {
                if (NumOfElements % 2 == 0)
                {
                    this.button1.Text = "X";
                    UsingMatrix(1, 0, 0);
                }
                else
                {
                    this.button1.Text = "O";
                    UsingMatrix(2, 0, 0);
                }
            }
            NumOfElements++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (NumOfElements == 0)
            {
                ZeroingMatrix();
            }
            if (button2.Text == "")
            {
                if (NumOfElements % 2 == 0)
                {
                    this.button2.Text = "X";
                    UsingMatrix(1, 1, 0);
                }
                else
                {
                    this.button2.Text = "O";
                    UsingMatrix(2, 1, 0);
                }
            }
            NumOfElements++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (NumOfElements == 0)
            {
                ZeroingMatrix();
            }
            if (button3.Text == "")
            {
                if (NumOfElements % 2 == 0)
                {
                    this.button3.Text = "X";
                    UsingMatrix(1, 2, 0);
                }
                else
                {
                    this.button3.Text = "O";
                    UsingMatrix(2, 2, 0);
                }
            }
            NumOfElements++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (NumOfElements == 0)
            {
                ZeroingMatrix();
            }
            if (button4.Text == "")
            {
                if (NumOfElements % 2 == 0)
                {
                    this.button4.Text = "X";
                    UsingMatrix(1, 0, 1);
                }
                else
                {
                    this.button4.Text = "O";
                    UsingMatrix(2, 0, 1);
                }
            }
            NumOfElements++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (NumOfElements == 0)
            {
                ZeroingMatrix();
            }
            if (button5.Text == "")
            {
                if (NumOfElements % 2 == 0)
                {
                    this.button5.Text = "X";
                    UsingMatrix(1, 1, 1);
                }
                else
                {
                    this.button5.Text = "O";
                    UsingMatrix(2, 1, 1);
                }
            }
            NumOfElements++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (NumOfElements == 0)
            {
                ZeroingMatrix();
            }
            if (button6.Text == "")
            {
                if (NumOfElements % 2 == 0)
                {
                    this.button6.Text = "X";
                    UsingMatrix(1, 2, 1);
                }
                else
                {
                    this.button6.Text = "O";
                    UsingMatrix(2, 2, 1);
                }
            }
            NumOfElements++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (NumOfElements == 0)
            {
                ZeroingMatrix();
            }
            if (button7.Text == "")
            {
                if (NumOfElements % 2 == 0)
                {
                    this.button7.Text = "X";
                    UsingMatrix(1, 0, 2);
                }
                else
                {
                    this.button7.Text = "O";
                    UsingMatrix(2, 0, 2);
                }
            }
            NumOfElements++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (NumOfElements == 0)
            {
                ZeroingMatrix();
            }
            if (button8.Text == "")
            {
                if (NumOfElements % 2 == 0)
                {
                    this.button8.Text = "X";
                    UsingMatrix(1, 1, 2);
                }
                else
                {
                    this.button8.Text = "O";
                    UsingMatrix(2, 1, 2);
                }
            }
            NumOfElements++;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (NumOfElements == 0)
            {
                ZeroingMatrix();
            }
            if (button9.Text == "")
            {
                if (NumOfElements % 2 == 0)
                {
                    this.button9.Text = "X";
                    UsingMatrix(1, 2, 2);
                }
                else
                {
                    this.button9.Text = "O";
                    UsingMatrix(2, 2, 2);
                }
            }
            NumOfElements++;
        }
    }
}
