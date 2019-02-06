// workspace for exercises from https://www.hackerrank.com/

using System;
using System.Collections.Generic;

namespace hackerrank_com
{
    class Program
    // https://www.hackerrank.com/challenges/picking-numbers
    {

        public static int pickingNumbers(List<int> a)
        {
            int result = 0;

            // loop through input: count all numbers
            // save to dict


            // loop through dict


            return result;

        }

        static void Main(string[] args)
        {
            List<int> i0 = new List<int>() { 4, 6, 5, 3, 3, 1 };
            Console.WriteLine("3: " + pickingNumbers(i0));
            List<int> i1 = new List<int>() { 1, 2, 2, 3, 1, 2 };
            Console.WriteLine("5: " + pickingNumbers(i1));

            Console.ReadKey();
        }
    }
}
