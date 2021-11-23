using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foreachukol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Sude = false;
            int i = 0;
            int min = 0;
            try
            {
                while (i < textBox1.Lines.Length && Sude == false) 
                {
                    if (Int32.Parse(textBox1.Lines[i]) % 2 == 0)
                    {
                        Sude = true;
                        min = Int32.Parse(textBox1.Lines[i]);
                    }
                    i++;
                }
                i = 0;
                while (i < textBox1.Lines.Length && Sude == true)
                {
                    if (Int32.Parse(textBox1.Lines[i]) < min && Int32.Parse(textBox1.Lines[i]) % 2 == 0)
                    {
                        min = Int32.Parse(textBox1.Lines[i]);
                    }
                    i++;
                }
                if (Sude == true)
                {
                    label1.Text = "Nejmenší sudý číslo je: " + min.ToString();
                }
                else
                { 
                    MessageBox.Show("Nezadal jsi žádné sudé číslo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Špatná hodnota", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
   
                
}
