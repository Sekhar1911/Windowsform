using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Dept1
    {
        public int basicsalary;
        public virtual void Add()
        {
            basicsalary=5000;
        }
    }
    class Dept2:Dept1
    {
        public override void Add()
{
 	 base.Add();
           int bonus=5000;
            int totalsalary=basicsalary+bonus;
            Console.WriteLine("TOTAL SALARY:="+totalsalary);
}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dept2 obj=new Dept2();
            obj.Add();
            Console.ReadKey();
        }
    }
}
