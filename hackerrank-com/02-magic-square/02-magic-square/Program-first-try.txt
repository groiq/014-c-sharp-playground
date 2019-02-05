// workspace for exercises from https://www.hackerrank.com/

using System;

namespace hackerrank_com
{
    class Program
    {
        static int FormingMagicSquare(int[][] s)
        {
            // https://www.hackerrank.com/challenges/magic-square-forming/problem

            int result = 0;

            // calculate the sum of each row
            // calculate how much each sum is off
            // add the off values together
            foreach (int[] row in s)
            {
                int rowSum = 0;
                foreach (int cell in row) { rowSum += cell; }
                int offset = Math.Abs(15 - rowSum);
                result += offset;
            }

            return result;

        }

        static void Main(string[] args)
        {

            int[] q1a = { 5, 3, 4 };
            int[] q1b = { 1, 5, 8 };
            int[] q1c = { 6, 4, 2 };
            int[][] q1 = { q1a, q1b, q1c };

            int[] q2a = { 4, 9, 2 };
            int[] q2b = { 3, 5, 7 };
            int[] q2c = { 8, 1, 5 };
            int[][] q2 = { q2a, q2b, q2c };

            int[] q3a = { 4, 8, 2 };
            int[] q3b = { 4, 5, 7 };
            int[] q3c = { 6, 1, 6 };
            int[][] q3 = { q3a, q3b, q3c };

            Console.WriteLine("7: " + FormingMagicSquare(q1));
            Console.WriteLine("1: " + FormingMagicSquare(q2));
            Console.WriteLine("4: " + FormingMagicSquare(q3));
            Console.ReadKey();
        }
    }
}
