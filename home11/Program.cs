using System;

namespace home11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             4 dene 5 reqemli eded verilib. Her I ededin ustune III ededi gel . II ededin usutune IV eeddi gel.
  Sonra cavablari vur birbirine. Alinan neticeden III ededin 3%-ni cix


           */
            double a = 10000;
            double b = 10000;
            double c = 11111;
            double d = 10000;
            if (!(a>=10000 && a<100000))
            {
                Console.WriteLine( " eded 5 reqemli deyil"); return; 

            }
            else  if (!(b >= 10000 && b < 100000))
            {
                Console.WriteLine(" eded 5 reqemli deyil"); return;

            }
           else if (!(c >= 10000 && c < 100000))
            {
                Console.WriteLine(" eded 5 reqemli deyil"); return;

            }
            if (!(d >= 10000 && d < 100000))
            {
                Console.WriteLine(" eded 5 reqemli deyil"); return;

            }
            /* Her I ededin ustune III ededi gel.II ededin usutune IV eeddi gel.
   Sonra cavablari vur birbirine. Alinan neticeden III ededin 3 % -ni cix*/
            double e = c * 3 / 100;
          double  a1 = a + c;
            double b1 = b + d;
            double cavab = a1 * b1;

            cavab = cavab - e;
            Console.WriteLine(cavab);













        }
    }
}
