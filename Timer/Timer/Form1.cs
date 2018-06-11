using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Time time1 = new Time();

        private void button1_Click(object sender, EventArgs e)
        {
            time1.Hour = int.Parse(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            time1.Minute = int.Parse(textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            time1.Second = int.Parse(textBox3.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.DateTime currentTime = System.DateTime.Now;
            Time time2 = new Time(currentTime);

            time2.DisplayTime();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            time1.DisplayTime();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
