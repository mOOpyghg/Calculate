using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;
        double memory = 0;
        bool operation = false;
        public Form1()
        {
            InitializeComponent();
        }

        //цифры
        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }
        //кнопка +/-
        private void button11_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                double x = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(-x);
            }
        }
        // кнопка ,
        private void button9_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += ".";
            }
        }

        //+
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "0";
            }
            else
            {
                FirstNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
                Operation = "+";
            }
            
        }
        //-
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "0";
            }
            else
            {
                FirstNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
                Operation = "-";
            }
        }
        //*
        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "0";
            }
            else
            {
                FirstNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
                Operation = "*";
            }
        }
        ///
        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "0";
            }
            else
            {
                FirstNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
                Operation = "/";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {

            textBox1.Text = "0";

        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
        // =
        private void button1_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(textBox1.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    MessageBox.Show("Деление на ноль невозможно");
                    textBox1.Text = "0";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }
        //sqrt
        private void button6_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double number))
            {
                if (number < 0)
                {
                    MessageBox.Show("ошибка: отрицательное число не имеет корня");
                    return;
                }

                textBox1.Text = Math.Sqrt(number).ToString();
                
            }
            else
            {
                MessageBox.Show("ошибка ввода числа");
            }
        }
        //квадрат
        private void button7_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(textBox1.Text);
            textBox1.Text = (number * number).ToString();
        }
        //куб
        private void button8_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(textBox1.Text);
            textBox1.Text = (number * number* number).ToString();
        }
        //удаление последнего числа
        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                if (textBox1.Text == "")
                {
                    textBox1.Text = "0";
                }
            }
        }
        // процент
        private void button24_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(textBox1.Text);
            textBox1.Text = (number / 100).ToString();
        }
        //Mc
        private void button25_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text = memory.ToString();
            operation = true;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            memory += Double.Parse(textBox1.Text);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            memory -= Double.Parse(textBox1.Text);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            memory = Double.Parse(textBox1.Text);
        }
    }
}
