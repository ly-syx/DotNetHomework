using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programe02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);
                string oper = comboBox1.Text;
                textBox3.Text = (calculate(num1, num2, oper)).ToString();
            }
            catch (Exception ex)
            {
                textBox3.Text = ex.Message;
            }
        }

        private double calculate(double num1, double num2, string oper)
        {
            double result;
            switch (oper)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                default:
                    throw new InvalidOperationException("operator can't identify." +
                        "\nPlease, choose operator in ['+','-','*','/']");
            }
            return result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
