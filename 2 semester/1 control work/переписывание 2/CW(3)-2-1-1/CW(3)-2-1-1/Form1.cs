using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_3__2_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method, which changes button position
        /// </summary>
        public void Changer()
        {
            Random Rand = new Random();
            button1.Location = new Point(Rand.Next(0, this.Size.Width - 2 * this.button1.Size.Width), Rand.Next(0, this.Size.Height - 2 * this.button1.Size.Height));
        }

        /// <summary>
        /// Event of button click, which close the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Event which changes button position, when cursor is entering button area
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Changer();
        }

        /// <summary>
        /// Event which changes button position, when cursor is in button area for a some time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_MouseHover(object sender, EventArgs e)
        {
            Changer();
        }
    }
}
