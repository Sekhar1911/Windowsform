using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    partial class Employee
    {
        public int empno { get; set; }
        public string ename { get; set; }
        public int salary { get; set; }
        public int experience { get; set; }
        public static void promoteemployee(Employee[] objlist)
        {
            for(int i=0;i<objlist.Length;i++)
            {
                Employee e = objlist[i];
                if (e.salary >= 7000)
                {
                    Console.WriteLine(e.empno + " " + e.ename + " " + e.salary + " " + e.experience);
                    Console.WriteLine("----------------------");
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj1 = new Employee() { empno = 1001, ename = "Ganesh", salary = 5000, experience = 3 };
            Employee obj2 = new Employee() { empno = 1002, ename = "satish", salary = 6000, experience = 5 };
            Employee obj3 = new Employee() { empno = 1003, ename = "rajesh", salary = 7500, experience = 6 };
            Employee obj4 = new Employee() { empno = 1004, ename = "akhil", salary = 8000, experience = 7 };
            Employee[] emparray = new Employee[4];
            emparray[0] = obj1;
            emparray[1] = obj2;
            emparray[2] = obj3;
            emparray[3] = obj4;
            Employee.promoteemployee(emparray);
            Console.ReadKey();
        }
    }
}
