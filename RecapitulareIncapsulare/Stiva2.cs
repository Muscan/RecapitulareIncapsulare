using System;
using System.Collections.Generic;
using System.Text;

namespace RecapitulareIncapsulare
{
    class Stiva2
    {
        public int s(int a, int b)
        {
            int t = a + b;//12
            int x = t + f(a);//12+f(7)stop
                             //12+10 =22
            return x;//22
        }

        public int f(int y)
        {
            y = y + 3;//10
            return y;//10
        }
    }
}
