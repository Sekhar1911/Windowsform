using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
   abstract class Employee
    {
        public int Eid { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Annualsalary { get; set; }
        public string getEmpname()
        {
            return Fname + Lname;
        }
        public abstract void getMonthlySalary();
    }
    class FullTimeEmployee:Employee
    {
        public override void getMonthlySalary()
        {
            int salary = Annualsalary / 12;
            Console.WriteLine("\n monthly salary of fulltime employee is:"+salary);
        }

    }
    class ParttimeEmployee:Employee
    {
       public  int Totwrkhours { get; set; }
        public int hourlypay{get;set;}
        public override void getMonthlySalary()
        {
            int Salary = Totwrkhours * hourlypay;
            Console.WriteLine("\n The parttime employee salary per month is:" + Salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee obj1 = new FullTimeEmployee();
            obj1.Eid = 123;
            obj1.Fname = "Sappa";
            obj1.Lname = "Chandrasekhar";
            obj1.Annualsalary = 600000;
            Console.WriteLine(obj1.getEmpname());
            obj1.getMonthlySalary();
            ParttimeEmployee obj2 = new ParttimeEmployee();
            obj2.Eid = 333;
            obj2.Fname = "Datla";
            obj2.Lname = "Sindhu";
            obj2.hourlypay = 360;
            obj2.Totwrkhours = 100;
            Console.WriteLine("\n\n\n"+obj2.getEmpname());
            obj2.getMonthlySalary();
            Console.ReadKey();
        }
    }
}
