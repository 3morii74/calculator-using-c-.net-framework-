using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<string> calc = new List<string>();
        private Double temp1 = 0;
        private string temp2;
        private bool temp3;
        private int flag = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temp2 += "1";

            textBox1.Text += "1";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            temp2 += "2";
            textBox1.Text += "2";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            temp2 += "3";
            textBox1.Text += "3";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            temp2 += "4";
            textBox1.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            temp2 += "5";
            textBox1.Text += "5";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            temp2 += "6";
            textBox1.Text += "6";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            temp2 += "7";
            textBox1.Text += "7";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            temp2 += "8";
            textBox1.Text += "8";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temp2 += "9";
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            temp2 += "0";
            textBox1.Text += "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                calc.Add(temp2);
            }
            textBox1.Text += "+";
            calc.Add("+");
            temp2 = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            temp2 += ".";
            textBox1.Text += ".";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                calc.Add(temp2);
            }
            textBox1.Text += "-";
            calc.Add("-");
            temp2 = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            temp2 = "";
            calc.Clear();
            flag = 0;
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                calc.Add(temp2);
            }
            textBox1.Text += "*";
            calc.Add("*");
            temp2 = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                calc.Add(temp2);
            }
            textBox1.Text += "/";
            calc.Add("/");
            temp2 = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            calc.Add(temp2);
            double def = 0;
            string op;

            for (int i = 0; i < calc.Count; i++)
            {
                if (calc[i] == "*" || calc[i] == "/")
                {
                    int k = i;
                    for (; k < calc.Count; k += 2)
                    {
                        if (calc[k] == "*")
                        {
                            def = double.Parse(calc[k - 1]) * double.Parse(calc[k + 1]);
                            op = $"{def}";
                            for (int j = i - 1; j <= k + 1; j++)
                            {
                                calc[j] = op;
                            }
                        }
                        if (calc[k] == "+" || calc[k] == "-")
                        {
                            break;
                        }

                        if (calc[k] == "/")
                        {
                            def = double.Parse(calc[k - 1]) / double.Parse(calc[k + 1]);
                            op = $"{def}";
                            for (int j = i - 1; j <= k + 1; j++)
                            {
                                calc[j] = op;
                            }
                        }
                    }
                }
            }

            double result = double.Parse(calc[0]);

            for (int i = 1; i < calc.Count; i += 2)
            {
                if (calc[i] == "+" || calc[i] == "-")
                {
                    if (calc[i] == "+")
                    {
                        result += double.Parse(calc[i + 1]);
                    }
                    if (calc[i] == "-")
                    {
                        result -= double.Parse(calc[i + 1]);
                    }
                }
            }
            textBox1.Text = $"{result}";
            calc.Clear();
            calc.Add($"{result}");
            flag = 1;
        }
    }
}