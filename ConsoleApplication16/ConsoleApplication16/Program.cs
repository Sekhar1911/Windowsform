using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class user
    {
        string firstname, lastname;
            public void setusernames(string fname,string lname)
            {
                firstname=fname;
                lastname=lname;
            }
        public void Display()
        {
            Console.WriteLine(firstname+" "+lastname);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            user obj=new user();
            obj.setusernames(fname:"satish",lname:"ram");
            obj.Display();
            Console.ReadKey();
        }
    }
}
