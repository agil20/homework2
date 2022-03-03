using System;

namespace home9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 dene 6 reqemli eded verilib. Her birinin 10 faizini tapib neticeleri topla. Alinan cavabin 10% tap.
            double a = 123456;
            double b = 123450;
            double c = 123400;
            if (!(a>=100000 && a<1000000))
            {
                Console.WriteLine(" eded 6 reqemli deyildir"); return; 
            }
            if (!(b >= 100000 && b < 1000000))
            {
                Console.WriteLine(" eded 6 reqemli deyildir"); return;
            }
            if (!(c >= 100000 && c < 1000000))
            {
                Console.WriteLine(" eded 6 reqemli deyildir");return;  
            }
            a = a * 10 / 100;
            b = b * 10 / 100;
            c = c * 10 / 100;
            double d = a + b + c;
            d=d * 10 / 100;
            Console.WriteLine(d);
        }
    }
}
