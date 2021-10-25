using System;

namespace Prog03
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, sum, count;
            sum = 0;
            count = 15;
            for (i=1; i <= count; i++)
            {
                if ((i % 2) != 0)
                    sum = sum + i;
            }
            Console.WriteLine("Sum = " + sum);
        }
    }
}
