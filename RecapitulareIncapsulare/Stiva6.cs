using System;
using System.Collections.Generic;
using System.Text;

namespace RecapitulareIncapsulare
{
    class Stiva6
    {
        public int f3(int b)
        {
            int a = b-2;
            return a;
        }

        public int f2(int a)
        {
            int b = f3(a);
            return a+f3(b);
        }

        public int f1(int a, int b)
        {
            int t = f3(3);
            return t;
        }

    }
}
