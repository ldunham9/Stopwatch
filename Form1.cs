using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stopwatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime startTime;
        DateTime endTime;
        TimeSpan elapsedTime;

        private void btnStart_Click(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
            lblStart.Text = startTime.ToLongTimeString();
            lblStop.Text = "";
            lblElapsed.Text = "";
            

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            endTime = DateTime.Now;
            lblStop.Text = endTime.ToLongTimeString();
            elapsedTime = endTime - startTime;
            lblElapsed.Text = elapsedTime.Seconds.ToString();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
