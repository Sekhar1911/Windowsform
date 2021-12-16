using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
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
        List<Student> listobj = new List<Student>();
        private void button3_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.sid = int.Parse(textBox1.Text);
            s.sname = textBox2.Text;
            s.pyear = int.Parse(textBox3.Text);
            s.email = textBox4.Text;
            if(listBox1.Items.Contains(textBox1.Text))
            {
                MessageBox.Show("Already name existed!");
                //Environment.Exit(1);
                //this.Close();
                System.Environment.Exit(-1);
            }
            else
            {
                listBox1.Items.Add(textBox1.Text);
            }
            if(textBox4.Text.Contains("@"))
            {
                if(textBox4.Text.IndexOf(".",textBox4.Text.IndexOf("@"))>textBox4.Text.IndexOf("@"))
                {
                    listBox1.Items.Add("");
                }
                else
                {
                    MessageBox.Show("invalid email format!");
                   // Environment.Exit(1);
                    goto label;
                }
            }
                else
                {
                    MessageBox.Show("invalid format!");
                //Environment.Exit(1);
                    goto label;
                }
            listobj.Add(s);
            MessageBox.Show("student details added successfully!");
                label:
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();


                }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listobj.Count.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Student s in listobj)
            {
                listBox1.Items.Add(s.sid+" "+s.sname+" "+s.pyear+" "+s.email);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            foreach(char ch in textBox1.Text)
            {
                if((int)ch>=48 &&(int)ch<=57)
                {

                }
                else
                {
                    MessageBox.Show("enter valid character!");
                }
            }
        }
            }

        }

       
    