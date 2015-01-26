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
        List<string> PM = new List<string>();
        List<string> SM = new List<string>();
        static Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PM.Add("Slaughtered a ");
            PM.Add("Absolutely murdered a ");
            PM.Add("Called in an AC-130 on a ");
            PM.Add("Decimated a ");
            PM.Add("Shanked a ");
            PM.Add("Pulverized a ");
            PM.Add("Five-Seven'd a ");
            PM.Add("AWP'd a ");
            PM.Add("Knifed a ");

            SM.Add("zombie.");
            SM.Add("wanker.");
            SM.Add("cunt.");
            SM.Add("bitch called Hyperstorm.");

            int r = rand.Next(PM.Count);
            int r2 = rand.Next(SM.Count);

            label1.Text = PM[r] + SM[r2];
            betterListView1.Items.Add(PM[r] + SM[r2]);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(20);
            if (progressBar1.Value >= 100)
            {
                int r = rand.Next(PM.Count);
                int r2 = rand.Next(SM.Count);

                progressBar1.Value = 0;
                label1.Text = PM[r] + SM[r2];
                betterListView1.Items.Add(PM[r] + SM[r2]);
            }
        }
    }
}
