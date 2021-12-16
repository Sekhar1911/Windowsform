using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Demo
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public string Getmesage()
        {
            return "welcome";
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Demo obj = new Demo();
            Console.WriteLine(obj.Getmesage());
            Console.WriteLine(obj.add(10, 20));
            Console.ReadKey();
        }
    }
}