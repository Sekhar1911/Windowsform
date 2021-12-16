using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class TestDemo
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
        public string GetMessage()
        {
            return "welcome";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TestDemo obj = new TestDemo();
            Console.WriteLine("\n\n\nEnter two values:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(obj.Add(num1, num2));
            Console.WriteLine(obj.GetMessage());
            Console.ReadKey();

        }
    }
}
