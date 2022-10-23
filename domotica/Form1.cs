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
            string num = "1";
            canale(num);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string num = "2";
            canale(num);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string num = "3";
            canale(num);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string num = "4";
            canale(num);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string num = "5";
            canale(num);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string num = "6";
            canale(num);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string num = "7";
            canale(num);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string num = "8";
            canale(num);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string num = "9";
            canale(num);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string num = "0";
            canale(num);
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

        private void button11_Click(object sender, EventArgs e)
        {
            int canale_definito = int.Parse(label1.Text);
            label1.Text = "0";
            if (canale_definito < 1000)
            {
                t.setcanale(canale_definito);
            }
            else
            {
                MessageBox.Show("Il canale inserito supera il limite di 999, si prega di scegliere un canale disponibile");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string stato;
            if (t.get_stato() == true)
            {
                stato = "on";
            }
            else
            {
                stato = "off";
            }
            string[] array = t.get_specifiche();
            string produttore = array[0], modello = array[1], modalita = array[2];

            textBox1.Text = "il produttore del telecomando è: " + produttore + "il modello del telecomando è: " + modello + "la modalita del telecomando è: " + modalita + "il canale su cui si è in questo momento è: " + Convert.ToString(t.getcanale()) + '\n' + "lo stato della televisione è: " + stato + '\n' + "il volume in questo momento impostato è: " + Convert.ToString(t.get_volume());
        }
        private void button13_Click(object sender, EventArgs e)
        {
            t.cambio_stato();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            t.volume_giu();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            t.volume_su();
        }
    }
}
