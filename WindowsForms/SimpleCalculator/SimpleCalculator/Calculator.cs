using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandardCalculator
{
    public partial class Calculator : Form
    {

        string text = string.Empty;
        string op1 = string.Empty;
        string op2 = string.Empty;
        char operation;
        double result = 0.0;


        public Calculator()
        {
            InitializeComponent();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            text += "7";
            this.textBox.Text += text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            text += "8";
            this.textBox.Text += text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            text += "9";
            this.textBox.Text += text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            text += "4";
            this.textBox.Text += text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            text += "5";
            this.textBox.Text += text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            text += "6";
            this.textBox.Text += text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            text += "1";
            this.textBox.Text += text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            text += "2";
            this.textBox.Text += text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            text += "3";
            this.textBox.Text += text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            text += "0";
            this.textBox.Text += text;
        }


        private void btnDot_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            text += ".";
            this.textBox.Text += text;
        }


        private void btnDiv_Click(object sender, EventArgs e)
        {
            op1 = text;
            operation = '/';
            this.textBox1.Text = text + "/";
            text = string.Empty;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            op1 = text;
            operation = '*';
            this.textBox1.Text = text + "*";
            text = string.Empty;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            op1 = text;
            operation = '-';
            this.textBox1.Text = text + "-";
            text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            op1 = text;
            operation = '+';
            this.textBox1.Text = text + "+";
            text = string.Empty;
        }


        private void btnIsEq_Click(object sender, EventArgs e)
        {
            op2 = text;
            this.textBox1.Text += op2 + "=";
            double num1, num2;
            double.TryParse(op1, out num1);
            double.TryParse(op2, out num2);

            this.textBox.Text = "";
            this.text = string.Empty;
            this.op1 = string.Empty;
            this.op2 = string.Empty;

            if (operation == '+')
            {
                result = num1 + num2;
                textBox.Text = result.ToString();
            }

            if (operation == '-')
            {
                result = num1 - num2;
                textBox.Text = result.ToString();
            }

            if (operation == '/')
            {
                if(num2 != 0)
                {
                    result = num1 / num2;
                    textBox.Text = result.ToString();
                }
                else
                {
                    textBox.Text = "Cannot divide by zero";
                }
            }

            if (operation == '*')
            {
                result = num1 * num2;
                textBox.Text = result.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            this.textBox1.Text = "";
            this.text = string.Empty;
            this.op1 = string.Empty;
            this.op2 = string.Empty;
        }

    }
}
