using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int b;
             char opt;
            float result;
            Console.WriteLine(".........calculator program.........");
            label:
            Console.WriteLine("Enter first number :");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your option:");
            opt = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number:");
            switch (opt)
            {
                case '+' :
                    b=int.Parse(Console.ReadLine());
                    result = a + b;
                    Console.WriteLine("{0} + {1} = {2} ", a, b, result);
                    break;
                    
                case '-' : 

                    b= int.Parse(Console.ReadLine());
                    result = a - b;
                    Console.WriteLine("{0} - {1} = {2} ", a, b, result);
                    break;
                   
                case '*' :

                    b = int.Parse(Console.ReadLine());
                    result = a * b;
                    Console.WriteLine("{0} * {1} = {2} ", a, b, result);
                    break;
                    
                case '/':

                    b = int.Parse(Console.ReadLine());
                    result = a/b;
                    Console.WriteLine("{0} / {1} = {2} ", a, b, result);
                    break;
                    
                default :

                    Console.WriteLine("\n.....Invalid Key.........");
                    goto label;


                    }
            Console.ReadKey();
        }
    }
}
