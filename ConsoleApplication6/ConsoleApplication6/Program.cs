using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Employee
    {
        int eno, salary;
        string ename, job;
        public Employee()
        {
            Console.WriteLine("ENTER EMPLOYEE DETAILS");
            Console.WriteLine("ENTER EMPLOYEE NUUMBER");
            eno = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER EMPLOYEE SALARY");
            salary = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER EMPLOYEE NAME");
            ename = Console.ReadLine();
            Console.WriteLine("ENTER EMPLOYEE JOB");
            job = Console.ReadLine();
        }
        public Employee(Employee tempobj)
        {
            eno = tempobj.eno;
            ename = tempobj.ename;
            salary = tempobj.salary;
            job = tempobj.job;
        }
        public void Displaydata()
        {
            Console.WriteLine("Empno=" + eno);
            Console.WriteLine("Ename=" + ename);
            Console.WriteLine("Sal=" + salary);
            Console.WriteLine("Job=" + job);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj1 = new Employee();
            Employee obj2 = new Employee(obj1);
            obj1.Displaydata();
            obj2.Displaydata();
            Console.ReadKey();
        }
    }
}
