using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightSystem
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cpbBearing_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cpbBearing.StartAngle = 20/*correct bearing value here*/;

            Color ErrorColor = Color.FromArgb(200, 0, 0);
            Color onCourse = Color.FromArgb(0, 100, 0);

            label1.Text = "On Course";
            label1.BackColor = onCourse;
            button1.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Color ErrorColor = Color.FromArgb(200, 0, 0);
            Color onCourse = Color.FromArgb(0, 100, 0);

            if (cpbBearing.Value != 10)
            {
                label1.Text = "Correct Bearing to: " /*+*/ /*Correct Bearing Value Here*/;
                label1.BackColor = ErrorColor;
            }
            else
            {
                label1.Text = "On Course";
                label1.BackColor = onCourse;
                button1.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Color ErrorColor = Color.FromArgb(200, 0, 0);
            Color onCourse = Color.FromArgb(0, 100, 0);

            if (cpbBearing.Value != 10)
            {
                label1.Text = "Correct Bearing to: "; //+ Correct Bearing Value Here;
                label1.BackColor = ErrorColor;
            }
            else
            {
                label1.Text = "On Course";
                label1.BackColor = onCourse;
                button1.Visible = false;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            cpbMPH.Text = Convert.ToString(trackBar1.Value*12.5);
            cpbMPH.Value = (int)((double)trackBar1.Value * 10)+cpbMPH.Minimum;
        }
    }
}
