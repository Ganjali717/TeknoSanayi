using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace GanjaliTeknoKaucuk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(); 
            form.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= 200; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    if (i < 100)
                    {
                        sb.Append("zigzag, ");
                    }
                    sb.Append("zagzig, ");
                }
                else if (i % 3 == 0)
                {
                    sb.Append("zig, ");
                }
                else if (i % 5 == 0)
                {
                    sb.Append("zag, ");
                }
                else
                {
                    sb.Append(i.ToString() + ", ");
                }
            }
            MessageBox.Show(sb.ToString());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string[] lines = File.ReadAllLines(filePath);
                List<decimal> numbers = new List<decimal>();
                foreach (string line in lines)
                {
                    string[] parts = line.Split(' ');
                    foreach (string part in parts)
                    {
                        if (decimal.TryParse(part, out decimal number))
                        {
                            numbers.Add(number);
                        }
                    }
                }
                numbers.Sort();
                numbers.Reverse();
                string message = "";
                foreach (decimal number in numbers)
                {
                    message += number.ToString() + "\n";
                }
                MessageBox.Show(message, "Sıralanmış Sayı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.ShowDialog();
        }
    }
}
