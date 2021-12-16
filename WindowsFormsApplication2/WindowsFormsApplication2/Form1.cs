using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        if(radioButton1.Checked==true)
            {
                FullTimeEmployee obj = new FullTimeEmployee();
                obj.id = int.Parse(textBox3.Text);
                obj.name = textBox2.Text;
                obj.job = textBox1.Text;
                obj.Add();
                listBox1.Items.Add("Emp no:" + obj.id);
                listBox1.Items.Add("Ename:" + obj.name);
                listBox1.Items.Add("Job:" + obj.job);
                listBox1.Items.Add("Total salary:" + obj.Totalsalary);

            }
        else if(radioButton2.Checked==true)
        {
            PartTimeEmployee obj = new PartTimeEmployee();
            obj.id = int.Parse(textBox3.Text);
            obj.name = textBox2.Text;
            obj.job = textBox1.Text;
            obj.Add();
            listBox1.Items.Add("Emp no:" + obj.id);
            listBox1.Items.Add("Ename:" + obj.name);
            listBox1.Items.Add("Job:" + obj.job);
            listBox1.Items.Add("Totalsalary=" + obj.Totalsalary);

        }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
