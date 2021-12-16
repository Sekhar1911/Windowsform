using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int Totalsalary { get; set; }
        public string job { get; set; }
        public int Basicsalary;
        public virtual void Add()
        {
            Basicsalary = 5000;
        }
    }
        class FullTimeEmployee : Employee
        {
           public override void Add()
           {
            base.Add();
            int bonus = 3000;
            Totalsalary=Basicsalary+bonus;

           }
        }
            
            class PartTimeEmployee:Employee
            {
                public override void Add()
                {
                    base.Add();
                    int bonus=1000;
                    Totalsalary=Basicsalary+bonus;
                }
            }
        }
    

