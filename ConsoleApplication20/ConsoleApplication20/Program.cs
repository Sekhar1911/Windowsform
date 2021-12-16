using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class student
    {
        public int sid { get; set; }
        public string sname { get; set; }
        public string course { get; set; }
    }
    class program
    {
        static void Main(string[] args)
        {
            student obj1 = new student() { sid = 1001, sname = "lokesh", course = "cpp" };
            student obj2 = new student() { sid = 1002, sname = "rokesh", course = "c++" };
            stack<student> staobj = new stack<student>();
            staobj.push(obj1);
            staobj.push(obj2);

        }
    }
}
