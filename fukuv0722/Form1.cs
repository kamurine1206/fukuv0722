using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukuv0722
{
    public partial class Form1 : Form
    {
        int vx = 0;
        int vy = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vx = -5; //textBox1.Text = "-2";
            vy = 0;  //textBox2.Text = "0";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx; //+= int.Parse(textBox1.Text);
            label1.Top += vy; //+= int.Parse(textBox2.Text);
            //label1.Text = "" + (int.Parse(textBox1.Text) + int.Parse(textBox2.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vx = 0;  //textBox1.Text = "0";
            vy = -5; //textBox2.Text = "-2";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            vx = 5; //textBox1.Text = "2";
            vy = 0; //textBox2.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vx = 0; //textBox1.Text = "0";
            vy = 5; //textBox2.Text = "2";
        }
    }
}
