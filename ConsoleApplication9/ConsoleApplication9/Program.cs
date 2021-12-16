using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    interface A
    {
        void f1();
    }
    interface B
    {
        void f1();
    }
    class C:A,B
    {
        public void f1()
        {
            Console.WriteLine("THIS IS THE OVERRIDE FUNCTION OF A,B");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            C obj = new C();
            C.f1();
            Console.ReadKey();

        }
    }
}
