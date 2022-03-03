using System;

namespace home2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 reqemli eded verilib.Bu ededin axirina hemin ededdin ozunu yapishdir.example: 333 = 333333
            int a = 35;
            if (!(a>99 && a<1000))
            { Console.WriteLine("eded 3 reqemli deyil");  return;   }            

            
            int b = a * 1000 +a ;
            Console.WriteLine(b);
        }
    }
}
