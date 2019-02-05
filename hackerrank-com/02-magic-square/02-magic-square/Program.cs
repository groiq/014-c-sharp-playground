// workspace for exercises from https://www.hackerrank.com/

using System;

namespace hackerrank_com
{
    class Program
    {
        static int[] Sums(int[][] s)
        {
            // return the sums in this order:
            // line 1 - line 2 - line 3 - col 1 - col 2 - col 3 - 
            // diag 1 - diag 2
            int[] result = new int[8];
            
            // row 1
            foreach (int i in s[0]) { result[0] += i;  }
            // row 2
            foreach (int i in s[1]) { result[1] += i; }
            // row 3
            foreach (int i in s[2]) { result[2] += i; }
            // col 1
            foreach (int[] i in s) { result[3] += i[0];  }
            // col 2
            foreach (int[] i in s) { result[4] += i[1]; }

            // col 3
            foreach (int[] i in s) { result[5] += i[2]; }

            // diag 1
            for (int i = 0; i < 3; i++) { result[6] += s[i][i]; }
            // diag 2
            for (int i = 0; i < 3; i++) { result[7] += s[i][2-i]; }

            //Console.WriteLine("sums: [{0}]", string.Join(", ", result));
            return result;
        }

        static void PrintSquare(int[][] s)
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
            int[] sums = Sums(s);

            Console.WriteLine("         | " + sums[7]);

            Console.WriteLine("---------|---");

            foreach (int item in s[0]) { Console.Write(" " + item + " "); }
            Console.Write("| " + sums[0]);
            Console.WriteLine();

            foreach (int item in s[1]) { Console.Write(" " + item + " "); }
            Console.Write("| " + sums[1]);
            Console.WriteLine();

            foreach (int item in s[2]) { Console.Write(" " + item + " "); }
            Console.Write("| " + sums[2]);
            Console.WriteLine();

            Console.WriteLine("---------|---");

            for (int i = 3; i < 6; i++) { Console.Write(sums[i] + " "); }
            Console.Write("| " + sums[6]);
            Console.WriteLine();

        }

        static int FormingMagicSquare(int[][] s)
        {
            // https://www.hackerrank.com/challenges/magic-square-forming/problem



            int result = 0;

            // check input
            //foreach (int[] i in s)
            //{
            //    foreach (int j in i)
            //    {
            //        Console.Write(j + ",");
            //    }
            //    Console.WriteLine();
            //}

            // todo: generate some test output with the squares and the sums - 
            // best as an extra function


            int[] sums = Sums(s);
            PrintSquare(s);

            // some thoughts:
            // find the single operation that brings us closest to our goal.

            // for that, find the horizontal / vertical sums that are least off.
            // also, if two sums are the same, take those.

            // new approach:
            // Each cell is off by a certain number.
            // This can be read by the sums the cell is involved in.

            // If the sum on one side is 15, I can assume that the cell is okay.
            // If a cell is in a row of 12 and a column of 14, I assume
            // that the cell makes the column off by 1
            // and that the row is off by this and another cell.
            // So, try increasing that cell by 1 and recalculating.


            // No, wait. I don't need to know everything about the cells!
            // If a row is 13, then it is off by two - then one cell is off by 2 -
            // or two cells are off by 1 each - 
            // and I don't need to know which ones!
            // All I need is to calculate all rows, check how much they are off, and add up the results!

            foreach (int[] row in s)
            {
                // data check
                //Console.WriteLine("sums: [{0}]", string.Join(", ", result));
                //Console.WriteLine("row: [{0}]", string.Join(", ", row));
                int rowSum = 0;
                foreach (int cell in row) { rowSum += cell; }
                int offset = Math.Abs(15 - rowSum);
                //Console.WriteLine(offset);
                result += offset;

            }


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

            //int[] testa = { 1, 2, 3 };
            //int[] testb = { 4, 5, 6 };
            //int[] testc = { 7, 8, 9 };
            //int[][] test = { testa, testb, testc };

            Console.WriteLine("7: " + FormingMagicSquare(q1));
            Console.WriteLine("1: " + FormingMagicSquare(q2));
            Console.WriteLine("4: " + FormingMagicSquare(q3));
            //Console.WriteLine(FormingMagicSquare(test));

            Console.ReadKey();
        }
    }
}
