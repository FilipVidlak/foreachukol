using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonMENU_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f0 = new Form1();
            f0.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonVypocet_Click(object sender, EventArgs e)
        {
            listBoxVystup.Items.Clear();
            int min, max;
       
            try
            {
                min = int.Parse(textBoxMIN.Text);
                max = int.Parse(textBoxMAX.Text);   
                if (min >= max) { MessageBox.Show("Zadej minimalní a pak až maximalní hodnotu Ondro:)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else
                {
                    for (int i = min; i <= max; i++) {
                        bool lol = true;
                        if (i > 0) {
                            for (int j = 2; j <= i / 2 && lol; j++) {
                                if (i % j == 0) { lol = false; } //pokud se najde ještě jeden dělitel, není to prvočíslo
                            }
                            if (lol) { listBoxVystup.Items.Add(i.ToString()); }
                        } 
                    }

                }
            }
            catch { MessageBox.Show("Zadej číslo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxVystup.Items.Clear();
            int min, max;
            bool pocet = true;
            try
            {
                min = int.Parse(textBoxMIN.Text);
                max = int.Parse(textBoxMAX.Text);
                if (min >= max) { MessageBox.Show("Zadej minimalní a pak až maximalní hodnotu Ondro:)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else {
                    while (min <= max) {
                        if ((min % 7 == 0) && pocet) { listBoxVystup.Items.Add(min.ToString()); pocet = false; }
                        min++;
                    }

                }
            } catch { MessageBox.Show("Zadej číslo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public static int NSD(int x, int y)
        {
            if (y == 0) return x;
            return NSD(y, x % y);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBoxVystup.Items.Clear();
            int min, max;
            try
            {
                min = int.Parse(textBoxMIN.Text);
                max = int.Parse(textBoxMAX.Text);
                if (min == 0) { listBoxVystup.Items.Add("Min je nula.".ToString()); }
                else { listBoxVystup.Items.Add(NSD(min, max).ToString()); }
            }
            catch { MessageBox.Show("Zadej číslo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
