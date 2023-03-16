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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                double sayi1 = Convert.ToDouble(textBox1.Text);
                double sayi2 = Convert.ToDouble(textBox2.Text);
                double sayi3 = Convert.ToDouble(textBox3.Text);
                double sonuc = (sayi1 + sayi2) * sayi3;
                textBox4.Text = sonuc.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen gerekli tüm alanları doldurun!");
            }
        }
    }
}
