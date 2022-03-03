using System;

namespace home8
{
    internal class Program
    {
        static void Main(string[] args)
        {          /* 2 dene eded verilib.I eded 4 reqemli II eded 7 reqemlidir.
I ededin 4 % -ni tap.
Sonra II ededin 9 % ni tap.
Sonra Cavalari toplayib 10 % ni tap.*/
            double  a = 1000;
            double b = 1000000;
            if (!(a>=1000 && a<10000))
            { Console.WriteLine("birinci eded 4 reqemli deyil");
                return;
            }
            else if(!(b>=1000000 && b<10000000))
            {
                Console.WriteLine("2 ci eded 7 reqemli deyil" );
                return;

            }
            a = a * 4 / 100;
            b = b * 9 / 100;
          double  c = a + b;
            c = c * 10 / 100;
            Console.WriteLine(c);
            
            }
    }
}
