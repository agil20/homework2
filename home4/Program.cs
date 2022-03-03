using System;

namespace home4
{
    internal class Program
    {
        static void Main(string[] args)
        { double a = 108;
            //3 reqemli eded verilib. Bu ededin axirina 7 artir. Sonra cavabin 7% tap;
            if (!(a>=100 && a < 999))
            {
                Console.WriteLine(" eded 3 reqemli deyil");
            } return;
            a = a * 10 + 7;
            a = a * 7 / 100; Console.WriteLine(a);
        }
    }
}
