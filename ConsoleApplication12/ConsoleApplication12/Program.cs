using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    partial class Sample
    {
        public void m1()
        {
            Console.WriteLine("method m1 invoked");
        }
    }
    partial class Sample
    {
        public void m2()
        {
            Console.WriteLine("method m2 invoked");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample obj = new Sample();
            obj.m1();
            obj.m2();
            Console.ReadKey();
        }
    }
}
