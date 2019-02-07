// workspace for exercises from https://www.hackerrank.com/

using System;

namespace hackerrank_com
{
    class Program
    // https://www.hackerrank.com/challenges/climbing-the-leaderboard/problem
    {
        static int[] climbingLeaderboard(int[] scores, int[] alice)
        {
            pprint(scores);
            pprint(alice);
            int[] result = new int[alice.Length];
            int pos = alice.Length - 1;

            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine("i: " + i + ", scores[i]: " + scores[i] + ", pos: " + pos + ", alice[pos]: " + alice[pos]);
                if (alice[pos] >= scores[i])
                {
                    result[pos] = i + 1;
                    pos -= 1;
                }
            }
            //Console.WriteLine(scores[scores.Length-1]);
            if (alice[0] < scores[scores.Length-1])
            {
                result[0] = scores.Length + 1;
            }

            //pprint(result);
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
            //Console.WriteLine("[6, 4, 2, 1] ->");
            //pprint(climbingLeaderboard(s1, a1));
            
            int[] s2 = { 100, 90, 90, 80, 75, 60 };
            int[] a2 = { 50, 65, 77, 90, 102 };
            //Console.WriteLine("[6, 5, 4, 2, 1] ->");
            //pprint(climbingLeaderboard(s2, a2));

            int[] s3 = { 100, 75, 50, 25 };
            Console.WriteLine("[5, 4, 3, 1] ->");
            pprint(climbingLeaderboard(s3, a1));

            Console.ReadKey();
        }
    }
}
