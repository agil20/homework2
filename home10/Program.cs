using System;

namespace home10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*  3 dene 4 reqemli eded verilib.I ededin 1 % -ni, II ededin 2 % , III ededin 3 % tap.
  Neticeleri bir birinden cix. Alinan cavabin ustune III ededin 7 % faizini gel
  */
            double a = 1234;
            double b = 1234;
            double c = 1234;
            if (!(a >= 1000 && a < 10000))
            {
                Console.WriteLine("eded 4 reqmli deyil"); return;
            }
           else if (!(a >= 1000 && a < 10000))
            {
                Console.WriteLine("eded 4 reqmli deyil"); return;
            }
           else if (!(c >= 1000 && c < 10000))
            {
                Console.WriteLine("eded 4 reqmli deyil"); return;
            } double e = c * 7 / 100;
            a=a*1/100;
            b=b*2/100;
            c=c*3/100;

            double d = a - b - c;
            d = d + e;
            Console.WriteLine(d);







        }
    }
}
