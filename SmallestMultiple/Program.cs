using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallestMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            int found = 0;

            for (int j = 21; j < int.MaxValue; j++)
            {
                if (IsDivisibleToTwenty(j))
                {
                    found = j;
                    break;
                }
            }

            Console.WriteLine("Found smallest number: {0}", found);
            Console.ReadLine();
        }

        private static bool IsDivisibleToTwenty(int i)
        {
            for (int j = 1; j <= 20; j++)
            {
                if (!IsModDiv(i, j))
                    return false;
            }
            return true;
        }

        private static bool IsModDiv(int i, int mod)
        {
            if (i % mod == 0)
                return true;
            return false;
        }
    }
}
