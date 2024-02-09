using System;

namespace ConsoleApp5
{
    internal class Program
    {
        private static double GetSum(int x, int n = 9)
        {
            if (n == 0) return Math.Sin(n * x) / (n + 2.0);

            return Math.Sin(n * x) / (n + 2.0) + GetSum(x, --n);
        }
        private static void Main()
        {
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine($"{GetSum(x)}");
        }
    }
}
