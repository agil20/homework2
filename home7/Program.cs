using System;

namespace home7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    2 dene 5 reqemli eded verilib.Bu ededleri toplayib.Alinan cavabin evveline ve axirina 5 artir.Neticenin 5 % ta

            double a = 12345;
            double b = 12345;
            
            if (!(a >= 10000 && a < 100000))
            {
                Console.WriteLine("eded 5 reqemli deyil");
                return;
            }
            else if (!(b >= 10000 && b < 100000))
            {
                Console.WriteLine("eded 5 reqemli deyil");
                return ;
            }

            if (a+b >= 10000 && a+b < 100000)
            {
                double c = a + b;
                c = c + 500000;
                c = (c * 10) + 5;
                c = c * 5 / 100;


                Console.WriteLine(c);



                

            }
            else
            {
                double c = a + b;
                c = c + 50000000;
                c= (c * 10) + 5;
                c= c * 5 / 100;
                Console.WriteLine(c);
            }
            


        }
    }
}
