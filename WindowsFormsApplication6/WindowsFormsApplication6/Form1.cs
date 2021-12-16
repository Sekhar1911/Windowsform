using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        List<Customer> listobj = new List<Customer>();
        private void BtnInsert_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.cid = int.Parse(textBox1.Text);
            c.cname = textBox2.Text;
            c.bal = int.Parse(textBox3.Text);
            listobj.Add(c);
            MessageBox.Show("customer added");
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void BtnCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listobj.Count.ToString());
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            foreach(Customer obj in listobj)
            {
                listBox1.Items.Add(obj.cid + " " + obj.cname + " " + obj.bal);
            }
        }
    }
}
