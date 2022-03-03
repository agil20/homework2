using System;

namespace home14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*6 dene 6 reqemli eded verilib.Evvel hamisini topla.Sonra I ve III ededi bir birine yapishdir ve bir eded al.
 I neticeden II neticeni cix.Alinan cavabin 10 % tap.Neticenin uzerine V ve VI ededleri gel. Yekunda alinan cavabin 11 % tap*/

            double a = 123456;
            double b = 123456;
            double c = 123456;
            double d = 123456;
            double e = 123456;
            double f = 123456;
            if (!(a>=100000 && a<1000000 )) 
            {
                Console.WriteLine("eded 6 reqemli deyil"); return;
            }
            if (!(b >= 100000 && b < 1000000))
            {
                Console.WriteLine("eded 6 reqemli deyil"); return;
            }
            if (!(c >= 100000 && c < 1000000))
            {
                Console.WriteLine("eded 6 reqemli deyil"); return;
            }
            if (!(d >= 100000 && d < 1000000))
            {
                Console.WriteLine("eded 6 reqemli deyil"); return;
            }
            if (!(e >= 100000 && e < 1000000))
            {
                Console.WriteLine("eded 6 reqemli deyil"); return;
            }
            if (!(f >= 100000 && f < 1000000))
            {
                Console.WriteLine("eded 6 reqemli deyil"); return;
            }
            double a1 = a + b + c + d + e + f;

            /*  Sonra I ve III ededi bir birine yapishdir ve bir eded al.
   I neticeden II neticeni cix.Alinan cavabin 10 % tap.Neticenin uzerine V ve VI ededleri gel. Yekunda alinan cavabin 11 % tap */

            double a2 = a * 1000000 + c;
            double a3 = a1 - a2;
            a3 = a3 * 10 / 100;
            double sum = a3 + e + f;
            sum= sum * 11 / 100;
            Console.WriteLine(sum);


        }
    }
}
