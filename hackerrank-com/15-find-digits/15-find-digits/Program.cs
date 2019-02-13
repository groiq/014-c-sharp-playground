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
        static int findDigits(int n)
        {
            //Console.WriteLine("examining: " + n);
            int found = 0;
            int unsearched = n;
            int currDigit = 0;
            while (unsearched > 0)
            {
                currDigit = unsearched % 10;
                unsearched = unsearched / 10;
                //Console.WriteLine("current: " + currDigit + ", rest: " + unsearched);
                if (currDigit > 0 && n % currDigit == 0)
                {
                    found++;
                    //Console.WriteLine(n + " / " + currDigit + " counts, found: " + found);
                }
            }

            return found;
        }

        static void Main(string[] args)
        {

            Console.WriteLine(findDigits(12));
            Console.WriteLine(findDigits(1012));

            Console.ReadKey();
        }
    }
}
