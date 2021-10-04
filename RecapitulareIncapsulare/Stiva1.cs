using System;
using System.Collections.Generic;
using System.Text;



namespace RecapitulareIncapsulare
{
    class Stiva1
    {
       public int f3(int a)
        {
            int i = a + 2;
            return i;
        }

        public int f2(int x, int y)
        {
            return f3(x) + y;
        }

        public int f(int a, int b)

        {
            //cand intalneste apelul f2, merge la functia f2
            int y = f2(a, b);
            int t = f3(5);
            return f2(y, t);
        }

    }
}
