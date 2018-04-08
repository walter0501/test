using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Fib(60);
            Console.WriteLine(a);
        }

        static int Fib(int a)
        {
            Func<int, int, int,int> FibIter = null;
            FibIter = (x, y, z) => {
                if (z == 0) return y;
                else
                {
                    return FibIter(x + y, x, z - 1);
                }
                 };
            return FibIter(1, 0, a);
        }
    }
}
