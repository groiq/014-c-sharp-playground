// workspace for exercises from https://www.hackerrank.com/

using System;
using System.Collections.Generic;

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

        static int reverseNum(int input)
        {
            Console.Write(input);
            int result = 0;
            int rest;
            while(input > 0)
            {
                rest = input % 10;
                result = result * 10 + rest;
                input /= 10;
            }
            
            Console.WriteLine(" - " + result);
            return result;
        }


        static int beautifulDays(int i, int j, int k)
        {
            Console.WriteLine(i + " - " + j + " - " + k);
            int result = 0;

            for (int currNum = i; currNum <= j; currNum++)
            {
                int currNumInv = reverseNum(currNum);
                int diff = Math.Abs(currNum - currNumInv);
                if (diff % k == 0) { result += 1; }
                Console.WriteLine(currNum + " - " + currNumInv + " - " + diff + " - " + (diff % k));
            }

            return result;
        }


        static void Main(string[] args)
        {

            //Console.WriteLine(beautifulDays(5, 15, 2));
            //Console.WriteLine(beautifulDays(95, 105, 2));
            Console.WriteLine(beautifulDays(13, 45, 3));


            Console.ReadKey();
        }
    }
}
