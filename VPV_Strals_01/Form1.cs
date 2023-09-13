using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            textBox.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox.Text += 9;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length == 0)
                return;

            if (Char.IsNumber(textBox.Text, textBox.Text.Length - 1))
                textBox.Text += 0;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            // check for if there already is a symbol in the string
            if (firstNonNumberIndex(textBox.Text) > 0 || textBox.Text.Length == 0)
                return;
            // replace current symbol if at it?
            textBox.Text += '+';
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            // check for if there already is a symbol in the string
            if (firstNonNumberIndex(textBox.Text) > 0 || textBox.Text.Length == 0)
                return;
            textBox.Text += '*';
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            // check for if there already is a symbol in the string
            if (firstNonNumberIndex(textBox.Text) > 0 || textBox.Text.Length == 0)
                return;
            textBox.Text += '-';
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            // check for if there already is a symbol in the string
            if (firstNonNumberIndex(textBox.Text) > 0 || textBox.Text.Length == 0)
                return;
            textBox.Text += '/';
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length == 0)
                return;
            buttonEquals_Click(null, null);
            double v1 = Double.Parse(textBox.Text);
            textBox.Text = "" + Math.Sqrt(v1);
        }

        // solve function essentially
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            int symbolLoco = firstNonNumberIndex(textBox.Text);
            if (symbolLoco < 0)
                return;

            double v1 = Double.Parse(textBox.Text.Substring(0, symbolLoco));
            double v2 = Double.Parse(textBox.Text.Substring(symbolLoco+1, textBox.Text.Length-symbolLoco-1));

            switch(textBox.Text[symbolLoco])
            {
                case '+':
                    textBox.Text = "" + (v1 + v2);
                    break;
                case '-':
                    textBox.Text = "" + (v1 - v2);
                    break;
                case '*':
                    textBox.Text = "" + (v1 * v2);
                    break;
                case '/':
                    textBox.Text = "" + (v1 / v2);
                    break;
                default:
                    textBox.Text = "err";
                    break;
            }
            
        }

        // not counting '.'
        private int firstNonNumberIndex(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (!Char.IsNumber(text[i]) && text[i] != '.')
                    return i;
            }
            return -1;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
        }

    }
}
