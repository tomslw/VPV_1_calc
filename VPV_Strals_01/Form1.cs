using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPV_Strals_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox.Text += 9;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length == 0)
                return;

            if (Char.IsNumber(textBox.Text, textBox.Text.Length - 1))
                this.textBox.Text += 0;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            this.textBox.Text += '+';
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            this.textBox.Text += '*';
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            this.textBox.Text += '-';
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            this.textBox.Text += '/';
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            // nope
            //this.textBox.Text += "√(";
        }

        // solve function essentially
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            int symbolLoco = firstNonNumberIndex(this.textBox.Text);
            double v1 = ;
            double v2 = 0;

        }

        private int firstNonNumberIndex(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (!Char.IsNumber(text[i]))
                    return i;
            }
            return -1;
        }
    }
}
