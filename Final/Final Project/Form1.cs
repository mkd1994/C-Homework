using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            textBox4.Enabled = false;
            button2.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = true;
            button2.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = true;
            button2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Check c = new Check();
            c.FirstCheck(textBox1.Text);

            using (StreamWriter sw = new StreamWriter("Project.txt",true))
            {
                MainClass main = new MainClass()
                {
                    Country = textBox1.Text,
                    Capital = textBox2.Text,
                    Size = int.Parse(textBox3.Text)
                };

                sw.WriteLine(main.ToString());
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Database.MainList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1 != null)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
            }

            var list = Database.MainList();

            if (radioButton1.Checked)
            {
                List<MainClass> emp = list.FindAll(EMP => EMP.Country.ToLower() == textBox4.Text.ToLower());
                dataGridView1.DataSource = emp;
            }
            if (radioButton2.Checked)
            {
                List<MainClass> emp = list.FindAll(EMP => EMP.Capital.ToLower() == textBox4.Text.ToLower());
                dataGridView1.DataSource = emp;
            }
            if (radioButton3.Checked)
            {
                List<MainClass> emp = list.FindAll(EMP => EMP.Size > numericUpDown1.Value && EMP.Size < numericUpDown2.Value);
                dataGridView1.DataSource = emp;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

    }
}
