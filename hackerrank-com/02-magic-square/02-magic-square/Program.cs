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
            foreach (int i in s[0]) { result[0] += i; }
            // row 2
            foreach (int i in s[1]) { result[1] += i; }
            // row 3
            foreach (int i in s[2]) { result[2] += i; }
            // col 1
            foreach (int[] i in s) { result[3] += i[0]; }
            // col 2
            foreach (int[] i in s) { result[4] += i[1]; }

            // col 3
            foreach (int[] i in s) { result[5] += i[2]; }

            // diag 1
            for (int i = 0; i < 3; i++) { result[6] += s[i][i]; }
            // diag 2
            for (int i = 0; i < 3; i++) { result[7] += s[i][2 - i]; }

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

            int result = 128;    // max possible cost should be 45, let's leave a generous error of margin

            // test output
            int[] sums = Sums(s);
            PrintSquare(s);

            // brute force restart: hard-code all possible magic squares

            // for ease of handling, copy the input to a single-dimension array
            int[] input = new int[9];
            for (int i = 0; i < 9; i++)
            {
                int row = i / 3;
                int col = i % 3;
                //Console.WriteLine("row " + row + ", col " + col);
                input[i] = s[row][col];
            }
            //Console.WriteLine("sums: [{0}]", string.Join(", ", result));
            //Console.WriteLine("square as single array: [{0}]", string.Join(", ", input));

            // define all possible magic squares as single arrays

            // the raw data is copy-pasted from the output of the included python script.
            // original data from wikipedia.
            int[] magSquaresRawData = { 8, 1, 6, 3, 5, 7, 4, 9, 2, 6, 1, 8, 7, 5, 3, 2, 9, 4, 2, 7, 6, 9, 5, 1, 4, 3, 8, 4, 3, 8, 9, 5, 1, 2, 7, 6, 2, 9, 4, 7, 5, 3, 6, 1, 8, 4, 9, 2, 3, 5, 7, 8, 1, 6, 6, 7, 2, 1, 5, 9, 8, 3, 4, 8, 3, 4, 1, 5, 9, 6, 7, 2};
            //Console.WriteLine("[{0}]", string.Join(", ", magSquaresRawData));
            int[][] magSquares = new int[8][];
            for (int i = 0; i < 8; i++)
            {
                magSquares[i] = new int[9];
            }

            for (int i = 0; i < magSquaresRawData.Length; i++)
            {
                //Console.WriteLine(i);
                int square = i / 9;
                int field = i % 9;
                magSquares[square][field] = magSquaresRawData[i];
            }

            

            // compare the arrays
            foreach (int[] item in magSquares)
            {
                Console.WriteLine("[{0}]", string.Join(", ", item));
                Console.WriteLine("[{0}]", string.Join(", ", input));
                int currCost = 0;
                Console.Write(">");
                for (int i = 0; i < item.Length; i++)
                {
                    Console.Write(Math.Abs(item[i] - input[i]) + ", ");
                    currCost += Math.Abs(item[i] - input[i]);
                }
                Console.WriteLine(">" + currCost);
                if (currCost < result) { result = currCost; }
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

            int[] q4a = { 4, 5, 8 };
            int[] q4b = { 2, 4, 1 };
            int[] q4c = { 1, 9, 7 };
            int[][] q4 = { q4a, q4b, q4c, };

            //Console.WriteLine("7: " + FormingMagicSquare(q1));
            //Console.WriteLine("1: " + FormingMagicSquare(q2));
            //Console.WriteLine("4: " + FormingMagicSquare(q3));
            Console.WriteLine("14: " + FormingMagicSquare(q4));
            //Console.WriteLine(FormingMagicSquare(test));

            Console.ReadKey();
        }
    }
}
