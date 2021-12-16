using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num1 value:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Result is:" + (num1 + num2));
            Console.ReadKey();
                
        }
    }
}
