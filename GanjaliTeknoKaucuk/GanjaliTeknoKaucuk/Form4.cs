using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GanjaliTeknoKaucuk
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBox1.Text);
            int fibonacciNumber = CalculateFibonacci(number);
            label2.Text = fibonacciNumber.ToString();
        }
        private int CalculateFibonacci(int number)
        {
            if (number <= 1)
            {
                return number;
            }
            else
            {
                return CalculateFibonacci(number - 1) + CalculateFibonacci(number - 2);
            }
        }
    }
}
