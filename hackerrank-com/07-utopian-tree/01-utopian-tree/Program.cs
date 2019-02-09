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
            int height = 1;
            for (int i = 0; i < (n/2); i++)
            {
                height *= 2;
                height += 1;
            }
            if (n % 2 != 0) { height *= 2; }

            return height;
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
