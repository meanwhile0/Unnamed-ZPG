using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Unnamed_ZPG
{
    public partial class Form1 : Form
    {
        int banter = new int();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = " Witty Banters: " + banter;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(20);
            if (progressBar1.Value >= 100)
            {
                string[] lines = File.ReadAllLines("wit.txt");
                Random rand = new Random();

                progressBar1.Value = 0;
                banter += 1;
                label1.Text = lines[rand.Next(lines.Length)];
                label2.Text = " Witty Banters: " + banter;
            }
        }
    }
}
