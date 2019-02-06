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
            var counter = new Dictionary<int, int>();
            foreach (var item in a)
            {
                if (counter.ContainsKey(item)) { counter[item] += 1; }
                else { counter.Add(item, 1); }
            }

            foreach (var pair in counter)
            {
                Console.WriteLine(pair);
            }

            // loop through dict
            
            foreach (var curKey in counter.Keys)
            {
                int nextKey = curKey + 1;
                Console.WriteLine(curKey + " -> " + nextKey);
                if (counter.ContainsKey(nextKey))
                {
                    int curPicking = counter[curKey] + counter[nextKey];
                    Console.WriteLine(curKey + " -> " + counter[curKey] + ", " 
                        + nextKey + " -> " + counter[nextKey] + " => " + curPicking);
                    if (curPicking > result)
                    {
                        result = curPicking;
                    }
                }
            }

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
