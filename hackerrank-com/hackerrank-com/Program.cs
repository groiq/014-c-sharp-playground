// workspace for exercises from https://www.hackerrank.com/

using System;

namespace hackerrank_com
{
    class Program
    {
        static int[] sums(int[][] s)
        {
            // return the sums in this order:
            // line 1 - line 2 - line 3 - col 1 - col 2 - col 3 - 
            // diag 1 - diag 2
            int[] result = new int[8];
            return result;
        }

        static void printMagicSqare(int[][] s)
        {
            // print the magic square like this:

            /*            | 15
             *    --------|---
             *     8  3  4| 15
             *     1  5  9| 15
             *     6  7  2| 15
             *    --------|---
             *    15 15 15| 15
             */
        }

        static int formingMagicSquare(int[][] s)
        {
            // https://www.hackerrank.com/challenges/magic-square-forming/problem



            int result = 0;

            // check input
            foreach(int[] i in s)
            {
                foreach(int j in i)
                {
                    Console.Write(j + ",");
                }
                Console.WriteLine();
            }

            // todo: generate some test output with the squares and the sums - 
            // best as an extra function


            // some thoughts:
            // find the single operation that brings us closest to our goal.

            // for that, find the horizontal / vertical sums that are least off.
            // also, if two sums are the same, take those.





            return result;

        }


        static void Main(string[] args)
        {

            int[] q1a = { 5, 3, 4 };
            int[] q1b = { 1, 5, 8 };
            int[] q1c = { 6, 4, 2 };
            //int[][] q1 = { { 5, 3, 4 }, { 1, 5, 8 }, { 6, 4, 2 } };
            int[][] q1 = { q1a, q1b, q1c };

            int[] q2a = { 4, 9, 2 };
            int[] q2b = { 3, 5, 7 };
            int[] q2c = { 8, 1, 5 };
            int[][] q2 = { q2a, q2b, q2c };

            int[] q3a = { 4, 8, 2 };
            int[] q3b = { 4, 5, 7 };
            int[] q3c = { 6, 1, 6 };
            int[][] q3 = { q3a, q3b, q3c };

            
            Console.WriteLine(formingMagicSquare(q1));
            Console.WriteLine(formingMagicSquare(q2));
            Console.WriteLine(formingMagicSquare(q3));

            Console.ReadKey();
        }
    }
}
