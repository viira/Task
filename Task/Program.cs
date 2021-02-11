using System;
using System.Linq;

namespace Task
{
    class Task
    {
        static void Main(string[] args)
        {
            int count = Task1();
            Console.WriteLine("Count of tickets = {0}", count);
        }

        static int Task1()
        {
            int count = 0;      // counter of tickets
            int n = 100001;     // min

            while (n <= 999999) // max = 999999
            {
                int[] part1 = {
                    n / 100000,
                    (n % 100000) / 10000,
                    (n % 10000) / 1000
                };
                int[] part2 = {
                    (n % 1000) / 100,
                    (n % 100) / 10,
                    n % 10
                };
                if (part1.Sum() == part2.Sum())
                {
                    ++count;
                }
                ++n;
            }
            return count;
        }
    }
}
