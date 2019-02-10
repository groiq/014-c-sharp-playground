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


        static int viralAdvertising(int n)
        {
            int curShared = 5;
            int cumulative = 0;
            for (int i = 0; i < n; i++)
            {
                curShared /= 2;
                cumulative += curShared;
                curShared *= 3;
            }

            return cumulative;
        }


        static void Main(string[] args)
        {

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(i + " -> " + viralAdvertising(i));
            }

            Console.ReadKey();
        }
    }
}
