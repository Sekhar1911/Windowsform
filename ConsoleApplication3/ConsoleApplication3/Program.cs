using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER FIRST NUMBER");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER SECOND NUMBER");
            int b =int.Parse(Console.ReadLine());
            int result = a + b;
            Console.WriteLine("sum:" + result);
            Console.ReadKey();


        }
    }
}
