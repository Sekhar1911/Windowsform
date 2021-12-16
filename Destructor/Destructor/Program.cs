using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructor
{
    class A
    {
        public A()
        {
            Console.WriteLine("crearing A");
        }
        ~A()
        {
            Console.WriteLine("Destroying A");
        }
    }
    class B:A
    {
        public B()
        {
            Console.WriteLine("creating B");
        }
        ~B()
        {
            Console.WriteLine("Destroying B");
        }
    }
    class c:B
    {
        public c()
        {
            Console.WriteLine("creating c");
        }
        ~c()
        {
            Console.WriteLine("Destroying c");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            c obj = new c();
            Console.WriteLine("PRESS ANY KEY TO DESTROY THE OBJECT");
            Console.ReadKey();
        }
    }
}
