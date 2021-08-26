using System;

namespace Recursion
{
    class Program
    {
        static int Fucktorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Fucktorial(x - 1);
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Input the number:");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine($"Result of {x}! is " + Fucktorial(x));
                Console.ReadLine();
                Console.Clear();
                
            }
        }
    }
}
