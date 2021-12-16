using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class USA
    {
        public void showcountry()
        {
            Console.WriteLine("THIS IS UNITED STATE OF AMERICA");
        }
    }
        class INDIA:USA
        {
            public new void showcountry()
            {
                Console.WriteLine("THIS IS INDIA");
            }
        }
    class Program
    {
        static void Main(string[] args)
        {
            INDIA obj = new INDIA();
            obj.showcountry();
            Console.ReadKey();
        }
    }
}
