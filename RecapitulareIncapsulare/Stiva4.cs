using System;
using System.Collections.Generic;
using System.Text;

namespace RecapitulareIncapsulare
{
    class Stiva4
    {
        public int f1(int x, int y)
        {
            int a = f2(x) + 2;
            int b = f3(y) + 1;

            return a + b;
        }
        public int f2(int a)
        {
            int x = a + 5;
            return x - 2;
        }
        int f3(int b)
        {
            return f2(5);
        }
        
    }
}
