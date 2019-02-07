// workspace for exercises from https://www.hackerrank.com/

using System;

namespace hackerrank_com
{
    class Program
    // https://www.hackerrank.com/challenges/climbing-the-leaderboard/problem
    {
        static int[] climbingLeaderboard(int[] scores, int[] alice)
        {
            //Console.WriteLine("---------------");
            pprint(scores);
            pprint(alice);
            int[] result = new int[alice.Length];
            int alicePos = alice.Length - 1;
            int scoresPos = 0;
            int rank = 1;

            while (alicePos >= 0)
            {
                //if (scoresPos >= scores.Length) { break; }
                Console.WriteLine($"alicePos: {alicePos}, alice: {alice[alicePos]}, scoresPos: " +
                    $"{scoresPos}, scores: {scores[scoresPos]}, rank: {rank}");
                if (alice[alicePos] >= scores[scoresPos])
                {
                    result[alicePos] = rank;
                    alicePos -= 1;
                    //scoresPos += 1;
                }
                else
                {

                    int prevScore = scores[scoresPos];
                    //alicePos -= 1;
                    scoresPos += 1;
                    if (scoresPos >= scores.Length)
                    {
                        result[alicePos] = rank+1;
                        break;
                    }
                    int curScore = scores[scoresPos];
                    rank = curScore == prevScore ? rank : rank + 1;


                }

                //alicePos -= 1;
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
            /*
            int[] s1 = { 100, 100, 50, 40, 40, 20, 10 };
            int[] a1 = { 5, 25, 50, 120 };
            int[] r1 = climbingLeaderboard(s1, a1);
            Console.WriteLine("[6, 4, 2, 1] ->");
            pprint(r1);
            
            int[] s2 = { 100, 90, 90, 80, 75, 60 };
            int[] a2 = { 50, 65, 77, 90, 102 };
            int[] r2 = climbingLeaderboard(s2, a2);
            Console.WriteLine("[6, 5, 4, 2, 1] ->");
            pprint(r2);

            int[] s3 = { 100, 75, 50, 25 };
            int[] r3 = climbingLeaderboard(s3, a1);
            Console.WriteLine("[5, 4, 3, 1] ->");
            pprint(r3);
            */

            int[] s4 = { 10, 9, 8 };
            int[] a4 = { 1, 2, 3 };
            int[] r4 = climbingLeaderboard(s4, a4);
            Console.WriteLine("[4, 4, 4] >");
            pprint(r4);


            Console.ReadKey();
        }
    }
}
