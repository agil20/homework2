using System;

namespace home3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 reqemli eded verilib. Bu ededin evvel 18 % sonra ise 3 % tap.
            double
                a = 12345;
            if (!(a>=10000 && a<100000))
            {
                Console.WriteLine("eded 5 reqemli deyi;l");
                return;
            }
            double b = a * 18 / 100;
            double c = b * 3 / 100;
            Console.WriteLine(c);

        }
    }
}
