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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox5.Text, out int number) || number < 1 || number > 15)
            {
                MessageBox.Show("Lütfen 1 ile 15 arasında bir tamsayı giriniz!");
                return;
            }
            dataGridView1.DataSource = null;
            
            DataTable table = new DataTable();
            table.Columns.Add(" ", typeof(int));
            for (int i = 1; i <= number; i++)
            {
                table.Columns.Add(i.ToString(), typeof(int));
            }
            for (int i = 0; i <= number; i++)
            {
                DataRow row = table.NewRow();
                row[0] = i;
                for (int j = 1; j <= number; j++)
                {
                    row[j] = i * j;
                }
                table.Rows.Add(row);
            }

            dataGridView1.DataSource = table;
        }
    }
}
