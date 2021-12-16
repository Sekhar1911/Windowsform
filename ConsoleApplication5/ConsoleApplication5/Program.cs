using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class student
    {
        public student()
        {
            Console.WriteLine("this is constructor");
        }
        public void Display()
        {
            Console.WriteLine("this is .net technology");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student obj = new student();
            obj.Display();
            Console.ReadKey();
        }
    }
}
