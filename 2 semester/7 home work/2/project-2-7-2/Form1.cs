using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_2_7_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            String currentTimeStr = DateTime.Now.ToString("HH:mm:ss");
            label.Text = currentTimeStr;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            String currentTimeStr = DateTime.Now.ToString("HH:mm:ss");
            label.Text = currentTimeStr;
        }
    }
}
