// workspace for exercises from https://www.hackerrank.com/

using System;

namespace hackerrank_com
{
    class Program
    // https://www.hackerrank.com/challenges/climbing-the-leaderboard/problem
    {
        static int[] climbingLeaderboard(int[] scores, int[] alice)
        {
            int[] result = new int[alice.Length];


            return result;
        }

        // quick way to print an array
        static void pprint(int[] input)
        {
            Console.WriteLine("[{0}]", string.Join(", ", input));
        }


        static void Main(string[] args)
        {
            //Console.WriteLine("Output goes here...");
            int[] s1 = { 100, 100, 50, 40, 40, 20, 10 };
            int[] a1 = { 5, 25, 50, 120 };
            Console.WriteLine("[6, 4, 2, 1] ->");
            pprint(climbingLeaderboard(s1, a1));
            
            int[] s2 = { 100, 90, 90, 80, 75, 60 };
            int[] a2 = { 50, 65, 77, 90, 102 };
            Console.WriteLine("[6, 5, 4, 2, 1] ->");
            pprint(climbingLeaderboard(s2, a2));
            
            Console.ReadKey();
        }
    }
}
