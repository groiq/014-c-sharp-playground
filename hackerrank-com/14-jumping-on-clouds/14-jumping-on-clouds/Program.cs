// workspace for exercises from https://www.hackerrank.com/

using System;

namespace hackerrank_com
{
    class Program
    {

        // quick way to print an array
        static void pprint(int[] input)
        {
            Console.WriteLine("[{0}]", string.Join(", ", input));
        }
        // array toString function
        static string arStr(int[] input)
        {
            return $"[{string.Join(", ", input)}]";
        }


        // design function here
        static int jumpingOnClouds(int[] c, int k)
        {
            int energy = 100;

            return energy;
        }


        static void Main(string[] args)
        {

            /*
             * Sample Input

8 2
0 0 1 0 0 1 1 0

Sample Output

92
*/
            int[] i0 = { 0, 0, 1, 0, 0, 1, 1, 0 };
            Console.WriteLine("92: " + jumpingOnClouds(i0,2));

            Console.ReadKey();
        }
    }
}
