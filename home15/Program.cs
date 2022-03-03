using System;

namespace home15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             7 dene eded verilib.Bunlardan 2 denesi 3 reqemlidir. 2 denesi 4 reqemlidir. 2 denesi 5 reqemlidir.1 denesi ise 6 reqemlidir.
 3 reqemli ededleri topla , sonra bunlarin ustune gel 4 reqemli ededlerin bir birine vurulmasindan alinan cavabi.
 Sonra neticenin axirina 7 reqemini artir. Sonra cavabin ustune gel 5 reqemli ededlerin cemini.
 Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini.
 Sonra alinan cavabin ustune gel 6 reqemli ededi.
 Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.
 Sonra alinan cavabin 18% -ni sonra 3%-ni sonra 1% tap.
 Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel.
             */
            double a = 123;
            double b = 123;
            double c = 1234;
            double d = 1234;
            double e = 12345;
            double f = 12345;
            double g = 123456;
            if (!(a>=100 && a<1000))
            {
                Console.WriteLine("1 ci eded 3 reqemli deyil"); return; 
            }
            if(!(b >= 100 && b < 1000))
            {
                Console.WriteLine("2 ci eded 3 reqemli deyil"); return;
            }
            if (!(c>=1000 && c<10000))
            {
                Console.WriteLine("3 ci eded 4 reqemli deyil");
                return;

            }
            if (!(d>= 1000 && d < 10000))
            {
                Console.WriteLine("4 ci eded 4 reqemli deyil");
                    return;

            }
            if (!(e>=10000 && e < 100000))
            {
                Console.WriteLine(("5 ci eded 5 reqemli deyul")); return ;
            }
            if (!(f >= 10000 && f < 100000))
            {
                Console.WriteLine(("6 ci eded 5 reqemli deyul")); return;
            }
            if (!(g>=100000 && g<1000000))
            {
                Console.WriteLine(("eded 6 reqemli deyil")); return;
            }
            /* 3 reqemli ededleri topla , sonra bunlarin ustune gel 4 reqemli ededlerin bir birine vurulmasindan alinan cavabi.
  Sonra neticenin axirina 7 reqemini artir. Sonra cavabin ustune gel 5 reqemli ededlerin cemini.
  Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini.
  Sonra alinan cavabin ustune gel 6 reqemli ededi.
  Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.
  Sonra alinan cavabin 18 % -ni sonra 3 % -ni sonra 1 % tap.
  Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel.
              */

         double    a1 = a + b;
            
           a1 = (a+b)+(c*d);
            a1 = (a1 * 10) + 7;
            /*  Sonra cavabin ustune gel 5 reqemli ededlerin cemini.
    Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini.
    Sonra alinan cavabin ustune gel 6 reqemli ededi.
    Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.
    Sonra alinan cavabin 18 % -ni sonra 3 % -ni sonra 1 % tap.
    Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel.*/


            
            a1 = a1+ (e+f); 
            /*   Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini.
       Sonra alinan cavabin ustune gel 6 reqemli ededi.
       Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.
       Sonra alinan cavabin 18 % -ni sonra 3 % -ni sonra 1 % tap.
       Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel.*/
            
            
            a1 = a1 - ((a * b * 10) + 1);
            a1 = a1 + g;
            /*    Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.
           Sonra alinan cavabin 18 % -ni sonra 3 % -ni sonra 1 % tap.
           Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel.*/
             
            a1 = a1 -( a + b + c + d); ;
            /*    Sonra alinan cavabin 18 % -ni sonra 3 % -ni sonra 1 % tap.
               Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel.*/
            a1 = a1 * 18 / 100;
            a1 = a1 * 3 / 100;
            a1 = a1 * 1 / 100;
            /*  Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel.*/

            
            a1 = a1 + e + f; 
            Console.WriteLine(a1);

        }
    }
}
