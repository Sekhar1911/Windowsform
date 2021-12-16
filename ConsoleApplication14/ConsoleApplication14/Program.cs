using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Sample
    {
        int a, b;
        public int A
        {
            set
            {
                a = value;
            }
            get
            {
                return a;
            }
        }
            public int B
            {
                set
                {
                    b= value;

                }
                get
                {
                    return b;
                }
            }
        public int Add()
            {
                return A + B;
            }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample obj = new Sample();
            obj.A=100;
            obj.B=200;
            Console.WriteLine(obj.Add());
            Console.ReadKey();
        }
    }
}
