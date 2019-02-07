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

        static void arrOut(String test, int[] solution)
        {
            Console.Write(test + ": ");
            //Console.WriteLine("[{0}]", string.Join(", ", yourArray));
            Console.Write("[{0}]", string.Join(", ", solution));
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            //Console.WriteLine("Output goes here...");
            int[] s1 = { 100, 100, 50, 40, 40, 20, 10 };
            int[] a1 = { 5, 25, 50, 120 };

            arrOut("6,4,2,1", climbingLeaderboard(s1, a1));
            //Console.WriteLine("6,4,2,1: " + climbingLeaderboard(s1, a1));

            int[] s2 = { 100, 90, 90, 80, 75, 60 };
            int[] a2 = { 50, 65, 77, 90, 102 };

            //Console.WriteLine("6,5,4,2,1: " + climbingLeaderboard(s2, a2));
            arrOut("6,5,4,2,1", climbingLeaderboard(s2, a2));



            Console.ReadKey();
        }
    }
}
