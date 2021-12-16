using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    static class Testdemo
    {
        public static string mymethod(this string str)
        {
            char[] ch=str.To char Array();
            Array Reverse(ch);
            return new string(ch);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string s = "nit";
            Console.WriteLine(s.mymethod());
            Console.ReadKey();
        }
    }
}
