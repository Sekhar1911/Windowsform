using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    interface addition
    {
        int add();
    }
    interface multiplication
    {
        int mul();
    }
    class Sampledemo : addition, multiplication
    {
        int a, b;
        public Sampledemo(int x, int y)
        {
            int a = x;
            int b = y;
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
