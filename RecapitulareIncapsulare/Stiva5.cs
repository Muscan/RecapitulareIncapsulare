using System;
using System.Collections.Generic;
using System.Text;

namespace RecapitulareIncapsulare
{
    class Stiva5
    {
        public int f3(int a)
        {
            int b = a + 3;
            return b;
        }
        public int f2(int b)
        {
            int a = f3(b);

            return a;
        }

        public int f1(int a, int b)
        {
            int t = f2(3);

            return t;
        }
        //cw f2(8)
    }
}
