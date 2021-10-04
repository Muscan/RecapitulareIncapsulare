using System;


namespace RecapitulareIncapsulare
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Stiva1 stiva1 = new Stiva1();
             //stiva1
             int a = 1;
             int b = 2;
             Console.WriteLine(stiva1.f(a, b));*/

            /*  //Stiva2
             //
              Stiva2 stiva2 = new Stiva2();//Apelare constructor implicit Stiva2
                                           //instantiere obiectul stiva2
              int a = 7;
              int y = 5;
              Console.WriteLine(stiva2.s(a,y));*/

            //Stiva3

            //instantiez un obiect de tipul clasei Stiva3
            //Apelare constructor implicit Stiva3() cu parameters default
            Stiva3 stiva3 = new Stiva3();
            int a = 7;
            Console.WriteLine(stiva3.f(a));
        }
    }
}

