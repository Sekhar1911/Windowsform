using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
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
        void A.f1
        {
         Console.writelin("THIS IS OVERRIDING METHOD OF INTERFACE A");
        }
        void B.f1()
        {
            Console.WriteLine("THIS IS OVERRIDING METHOD OF INTERFACE B");
    }
    }
    class Program
    {
        static void Main(string[] args)
        {
            C obj =new C();
            A obj1=obj;
            obj1.f1();
            B obj2=obj;
            obj2.f1();
            Console.ReadKey();
        }
    }
}
