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


        static int beautifulDays(int i, int j, int k)
        {
            int result = 0;

            return result;
        }


        static void Main(string[] args)
        {

            Console.WriteLine(beautifulDays(5, 15, 2));
            Console.WriteLine(beautifulDays(95, 105, 2));


            Console.ReadKey();
        }
    }
}
