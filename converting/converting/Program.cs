using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converting
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            float b;
            char c;
            long l;
            double d;

            Console.WriteLine("...........converting mechanism in ;c#.........");
            Console.WriteLine("the integer number is:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("the float value is:");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("the char value is:");
            c = char.Parse(Console.ReadLine());
            Console.WriteLine("the long value is:");
            l = long.Parse(Console.ReadLine());
            Console.WriteLine("the double value is:");
            d = double.Parse(Console.ReadLine());
            Console.ReadKey();


        }
    }
}
