using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosledniForEach
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
            int i = 0, min = 0;

            try
            {
                while (i < textBox1.Lines.Length && !Sude)
                {
                    if (Int32.Parse(textBox1.Lines[i]) % 2 == 0)
                    {
                        Sude = true;
                        min = Int32.Parse(textBox1.Lines[i]);
                    }
                    i++;
                }
                i = 0;
                while (i < textBox1.Lines.Length && Sude)
                {
                    if (Int32.Parse(textBox1.Lines[i]) < min && Int32.Parse(textBox1.Lines[i]) % 2 == 0)
                    {
                        min = Int32.Parse(textBox1.Lines[i]);
                    }
                    i++;
                }
                if (Sude)
                {
                    label2.Text = Convert.ToString(min);
                }
                else
                {
                    label2.Text = "";
                    MessageBox.Show("Nezadal jsi žádné sudé číslo", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch {
                label2.Text = "";
                MessageBox.Show("Špatná hodnota", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                
        }
    }
}
