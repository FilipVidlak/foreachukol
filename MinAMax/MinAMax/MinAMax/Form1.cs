using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinAMax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int min = int.Parse(textBox1.Text);
            int max = int.Parse(textBox3.Text);
            int i = min;
            int j = 2;
            while (i <= max)
            {
                bool p = false;
                if (i > 1)
                {
                    p = true;
                    while (j <= i / 2 && p == true)
                    {
                        if (i % j == 0 || i % 2 == 0)
                        {
                            p = false;
                        }
                        j++;
                    }
                }
                if (p == true)
                {
                    listBox1.Items.Add(Convert.ToString(i));
                }
                i++;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {           

            int min = int.Parse(textBox1.Text);
            int max = int.Parse(textBox3.Text);
            int i = min;
            
            while (i % 7 != 0)
            {
                i++;
                if (i % 7 == 0)
                {
                    string p = Convert.ToString(i);
                    label4.Text = p;
                }
            }
            if (i % 7 == 0)
            {
                string p = Convert.ToString(i);
                label4.Text = p;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int min = int.Parse(textBox1.Text);
            int max = int.Parse(textBox3.Text);
            bool NSD = false;
            for (int i = min; !NSD; i--)
            {
                if (min % i == 0 && max % i == 0)
                {
                    label3.Text = i.ToString();
                    NSD = true;
                }
            }
        }
    }
}
