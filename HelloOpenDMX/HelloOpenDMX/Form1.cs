using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloOpenDMX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            OpenDMX.start();

            scroll(1, 0);
            scroll(2, 0);
            scroll(3, 0);
            scroll(4, 0);

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            scroll(1, trackBar1.Value);
            label3.Text = "1:" + trackBar1.Value;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            scroll(2, trackBar2.Value);
            label4.Text = "2:" + trackBar2.Value;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            scroll(3, trackBar3.Value);
            label5.Text = "3:" + trackBar3.Value;
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            scroll(4, trackBar4.Value);
            label6.Text = "4:" + trackBar4.Value;
        }

        private void scroll(int channel, int value)
        {
            byte valueByte = byte.Parse(value.ToString());
            OpenDMX.setDmxValue(channel, valueByte);
        }
    }
}
