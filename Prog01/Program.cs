using System;

namespace Prog01
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b,c,d,S;
            Console.Write("a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("d = ");
            d = Convert.ToInt32(Console.ReadLine());
            S = (a + b + c + d)/4;
            Console.Write("Arr = ");
            Console.WriteLine(S);
        }
    }
}