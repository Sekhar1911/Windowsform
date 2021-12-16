using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        class Mathsdemo
        {
            public void Add(int a, int b)
            {
                Console.WriteLine("THE RESULT:=" + (a + b));
            }
            public void Add(string s1, string s2)
            {
                Console.WriteLine("THE RESULT:=" + s1 + s2);
            }
        }
        class program
        {
            static void Main(string[] args)
            {
                Mathsdemo obj = new Mathsdemo();
                obj.Add(10, 20);
                obj.Add("satish", "tentu");
                Console.ReadKey();
            }
        }
    }
}

