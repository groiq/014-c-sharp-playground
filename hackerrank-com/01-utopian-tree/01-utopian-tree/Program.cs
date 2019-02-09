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


        static int utopianTree(int n)
        {

            return n;
        }


        static void Main(string[] args)
        {

            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine(i + " -> " + utopianTree(i));
            }

            Console.ReadKey();
        }
    }
}
