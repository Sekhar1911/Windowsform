using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emply_details
{
    class Details
    {
        int empno, sal;
        string ename, job;
        public void ReadData()
        {

            Console.WriteLine("ENTER EMPLOYEE DETAILS:");
            Console.WriteLine("ENTER EMPLOYEE NUMBER:");
            empno=int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER EMPLOYEE SALARY:")
            sal=int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER EMPLOYEE NAME:");
            ename=Console.ReadLine();
            Console.WriteLine("ENTER EMPLOYEE JOB:");
            job=Console.ReadLine();
        }
            public void DisplayData()
        { 
                Console.writeline("Eno={0}",empno);
                Console.WriteLine("Sal={0}",sal);
                Console.WriteLine("Ename={0}",ename);
                Console.WriteLine("Job={0}",job);
            }
                class program
                {
        static void Main(string[] args)
        {
            employee obj=new employee();
            obj.ReadData();
            obj.DisplayData();
            Console.ReadKey();
        }
    }
}
