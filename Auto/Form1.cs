﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto
{
    public partial class Form1 : Form
    {
        int xWeite = 10;
        int yWeite = 0;
        int y2Weite = 10;
        Image AmpelRot;
        Image AmpelGruen;
        bool stop = false;
        public Form1()
        {
            InitializeComponent();

            pictureBox1.Image = Image.FromFile("UllapoolHarbour.jpg");
            pictureBox3.Image = Image.FromFile("UllapoolHarbour.jpg");
            AmpelRot = Image.FromFile("Ampelrot.jpg");
            AmpelGruen = Image.FromFile("Ampelgruen.jpg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x1 = pictureBox1.Location.X - xWeite;
            int y1 = pictureBox1.Location.Y - yWeite;
            int x2 = pictureBox3.Location.X - xWeite;
            int y2 = pictureBox3.Location.Y - yWeite;

            if (stop
            && pictureBox1.Location.X >= pictureBox2.Location.X + pictureBox2.Width
            && pictureBox1.Location.X <= pictureBox2.Location.X + pictureBox2.Width + 50)
                pictureBox1.Location = pictureBox1.Location;
            else
                pictureBox1.Location = new Point(x1, y1);

            if (x1 + pictureBox1.Width <= 0)
            {
                pictureBox1.Location = new Point(this.Width, pictureBox1.Location.Y);
            }

            pictureBox3.Location = 
                new Point(pictureBox3.Location.X, pictureBox3.Location.Y + y2Weite);

            if (y2 + pictureBox3.Height >= this.Height)
            {
                pictureBox3.Location = new Point(pictureBox3.Location.X, -pictureBox3.Height);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yWeite = 0;
            xWeite = -10;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yWeite = 0;
            xWeite = 10;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            xWeite = 0;
            yWeite = 10;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            xWeite = 0;
            yWeite = -10;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            stop = !stop;

            if (stop)
                pictureBox2.Image = AmpelRot;
            else
                pictureBox2.Image = AmpelGruen;
        }

        
    }
}
