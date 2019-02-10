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
        static int saveThePrisoner(int n, int m, int s)
        {

            return s;
        }

        static void Main(string[] args)
        {
            for (int n = 1; n < 4; n++)
            {
                for (int m = 1; m < 4; m++)
                {
                    for (int s = 1; s < 4; s++)
                    {
                        Console.WriteLine(n + " prisoners, " + m + " sweets, " + s + "starter -> " + saveThePrisoner(n, m, s));
                    }
                }
            }



            Console.ReadKey();
        }
    }
}
