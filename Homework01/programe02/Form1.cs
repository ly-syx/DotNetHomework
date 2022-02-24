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
            float num1 = Convert.ToSingle(textBox1.Text);
            float num2 = Convert.ToSingle(textBox2.Text);
            string oper = comboBox1.Text;
            switch (oper)
            {
                case "+":
                    textBox3.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    textBox3.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    textBox3.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    textBox3.Text = (num1 / num2).ToString();
                    break;
            }
        }
    }
}
