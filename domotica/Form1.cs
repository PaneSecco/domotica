using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace domotica
{
    public partial class Form1 : Form
    {
        private telecomando t;
        private televisione tv;
        public Form1()
        {
            InitializeComponent();
            string[] connettori = { "HDMI1", "HDMI2", "HDMIside", "antenna" };
            tv = new televisione("samsung", "akakaka", connettori, "1080pX720p");
            t = new telecomando("samsung", "ert5", "infrarossi", tv);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
        public void canale(string num)
        {
            if (label1.Text == "0")
            {
                label1.Text = num;
            }
            else
            {
                int a = Convert.ToInt32(label1.Text) * 10;
                a = a + int.Parse(num);
                label1.Text = Convert.ToString(a);
            }
        }
    }
}
