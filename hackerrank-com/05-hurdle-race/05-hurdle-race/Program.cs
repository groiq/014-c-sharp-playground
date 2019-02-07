// workspace for exercises from https://www.hackerrank.com/
// https://www.hackerrank.com/challenges/the-hurdle-race/problem

using System;

namespace hackerrank_com
{
    class Program
    {

        static int hurdleRace(int k, int[] height)
        {
            int result = 0;
            int currMax = k;
            foreach (var item in height)
            {
                if (item > currMax) { currMax = item; }
            }
            result = currMax - k;

            return result;

        }

        // quick way to print an array
        static void pprint(int[] input)
        {
            Console.WriteLine("[{0}]", string.Join(", ", input));
        }

        static void Main(string[] args)
        {
            int[] h0 = { 1,6,3,5,2};
            Console.WriteLine("2: " + hurdleRace(4, h0));

            int[] h1 = { 2, 5, 4, 5, 2 };
            Console.WriteLine("0: " + hurdleRace(7, h1));
            

            Console.ReadKey();
        }
    }
}
