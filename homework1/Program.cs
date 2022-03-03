using System;

namespace homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4 reqemli eded verilib. Bu ededin eveline 7 reqemini , axirinada 8 reqemini artir. Example1: 333= 73338
            int a = 124;
            if (!(a >= 1000 && a < 10000))
            { Console.WriteLine("eded 4 reqemli deyil"); }  return;
          int   b = a + 70000;
            Console.WriteLine(b*10+8);
        }
    }
}
