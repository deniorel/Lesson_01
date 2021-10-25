using System;

namespace Prog02
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, max;
            Console.Write("x = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y = ");
            y = Convert.ToInt32(Console.ReadLine());
            if (x >= y)
                max = x;
            else
                max = y;
            Console.WriteLine("max = " + max);
        }
    }
}