using System;

namespace home13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*   5 dene eded verilib.Bunlardan 3 denesi 5 reqemli. 2 denesi ise 3 reqemlidir. 5 reqemli ededlerin 5 % tap ,neticeleri vur bir birine.
   Sonra 3 reqemli ededlerin 3 % tap ,neticeleri topla. Sonra yekunda alinan iki cavalarin her birinin 10 % -ni tapib topla*/

            double a = 10000;
            double b = 10000;
            double c = 10000;
            double d = 500;
            double e = 500;
            if (!(a>=10000 && a < 100000))
            {
                Console.WriteLine(" 1 ci eded  5 reqemli deyil");
                return;
            }
            if (!(b >= 10000 && b < 100000))
            {
                Console.WriteLine(" 2 ci eded  5 reqemli deyil"); return;
            }
            if (!(c >= 10000 && c < 100000))
            {
                Console.WriteLine(" 3 ci eded  5 reqemli deyil");return;
            }
            if (!(d >= 100 && d < 1000)) 
            { Console.WriteLine("4 cu eded 3 reqemli deyul"); }
            if (!(e >= 100 && e < 1000))
            { Console.WriteLine("5 cu eded 3 reqemli deyul"); }

            /*  5 reqemli ededlerin 5 % tap ,neticeleri vur bir birine.
     Sonra 3 reqemli ededlerin 3 % tap ,neticeleri topla. Sonra yekunda alinan iki cavalarin her birinin 10 % -ni tapib topla*/

            a = a * 5 / 100;
            b = b * 5 / 100;        
            c = c * 5 / 100;
            double w5 = a * b * c;
            d = d * 3 / 100;
            e = e * 3 / 100;
            double w3 = d + e;
            w5 = w5 * 10 / 100;
            w3 = w3 * 10 / 100;
            double w6 = w5 + w3;
            Console.WriteLine(w6);











        }
    }
}
