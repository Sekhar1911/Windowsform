using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class student
    {
        public int sid { get; set; }
        public string sname { get; set; }
        public string course { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student obj1 = new student(){ sid=1001,sname="ramesh",course="cpp" };
            student obj2 = new student() { sid = 1002, sname = "lokesh", course = "java" };
            Queue<student> queobj = new Queue<student>();
            queobj.Enqueue(obj1);
            queobj.Enqueue(obj2);
            student s1 = queobj.Dequeue();
            Console.WriteLine(s1.sid + " " + s1.sname + " " + s1.course);
            Console.ReadLine();

        }
    }
}
