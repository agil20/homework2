using System;

namespace home12
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
          4 dene 6 reqemli eded verilib. Ededlerin hamisinin 10 faizini tap ve topla. Sonra hamisinin 15 faizini tap ve topla.
Sonra yekunda alinanlar iki cavabi vur biri birine. Alinan neticenin evvel 10% tap sonra ise hemin cavabin 11% tap
          
          
          */

            double a = 100000;
            double b = 100000;
            double c = 100000;
            double d = 100000;
            if (!(a>=100000 && a<1000000 ))
            {
                Console.WriteLine( " eded 6 reqemli deyil" );
                return;
            }
            if (!(b >= 100000 && b < 1000000))
            {
                Console.WriteLine(" eded 6 reqemli deyil");
                return;
            }
            if (!(c >= 100000 && c < 1000000))
            {
                Console.WriteLine(" eded 6 reqemli deyil");
                return;
            }
            if (!(d >= 100000 && d < 1000000))
            {
                Console.WriteLine(" eded 6 reqemli deyil");
                return;
            }
            /*  Ededlerin hamisinin 10 faizini tap ve topla.
             *  Sonra hamisinin 15 faizini tap ve topla.
   Sonra yekunda alinanlar iki cavabi vur biri birine. Alinan neticenin evvel 10 % tap sonra ise hemin cavabin 11 % tap*/
            double a10 = a * 10 / 100;
            double b10 = b * 10 / 100;
            double c10= c * 10 / 100;
            double d10 = d * 10 / 100;
            double e10 = a10 + b10 + c10 + d10;
            double a15 = a * 15 / 100;
            double b15= b * 15 / 100;
            double c15=c * 15 / 100;
            double d15= d * 15 / 100;
            double e15 =  a15 + b15 + c15 + d15;
            double v = e10 * e15;
            double v10 = v * 10 / 100;
            double v11 = v10 * 11 / 100;

            Console.WriteLine(v11);




















        }
    }
}
