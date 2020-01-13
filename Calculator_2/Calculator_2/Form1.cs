using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_2
{

    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed;

        public Form1()
        {
            InitializeComponent();
        }


        private void button_click(object sender, EventArgs e)
        {
            if(textBox1_Result.Text == "0" || isOperationPerformed)
            {
                textBox1_Result.Clear();
            }
            isOperationPerformed = false;
            Button button = (Button)sender;
            if(button.Text == ".")
            {
                if(!textBox1_Result.Text.Contains("."))
                {
                    textBox1_Result.Text += button.Text;
                }
            }
            else
            {
                textBox1_Result.Text += button.Text;
            }
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(resultValue != 0)
            {
                button11.PerformClick();
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = double.Parse(textBox1_Result.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed.ToString();
                isOperationPerformed = true;
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1_Result.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1_Result.Text = "0";
            resultValue = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBox1_Result.Text = (resultValue + Double.Parse(textBox1_Result.Text)).ToString();
                    break;
                case "-":
                    textBox1_Result.Text = (resultValue - Double.Parse(textBox1_Result.Text)).ToString();
                    break;
                case "*":
                    textBox1_Result.Text = (resultValue * Double.Parse(textBox1_Result.Text)).ToString();
                    break;
                case "÷":
                    textBox1_Result.Text = (resultValue / Double.Parse(textBox1_Result.Text)).ToString();
                    break;

                default:
                    break;
            }
            resultValue = Double.Parse(textBox1_Result.Text);
            labelCurrentOperation.Text = "";
        }
    }
}
