using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
    interface Addition
    {
        int add();
    }
    interface Multiplication
    {
        int mul();
    }
    class SampleDemo:Addition,Multiplication
    {
        int a, b;
        public SampleDemo(int x,int y)
        {
            a = x;
            b = y;
        }
        public int add()
        {
            return a + b;
        }
        public int mul()
        {
            return a * b;
        }
    }
}
