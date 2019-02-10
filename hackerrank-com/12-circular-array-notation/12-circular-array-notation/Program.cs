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
        static int[] circularArrayRotation(int[] a, int k, int[] queries)
        {
            int[] result = new int[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                int pos = 0;
                pos = queries[i] - (k % a.Length);
                if (pos < 0) { pos += a.Length; }
                //Console.WriteLine(arStr(a) + ", query: " + queries[i] + ", " + "k: " + k + ", pos: " + pos);
                result[i] = a[pos];
            }

            return result;
        }


        static void Main(string[] args)
        {

            int[] a = { 3, 4, 5 };
            int[] queries = new int[a.Length];
            for (int i = 0; i < queries.Length; i++) { queries[i] = i; }
            //int[] queries = { 2, 1 };
            for (int k = 0; k < a.Length*2; k++)
            {
                Console.WriteLine(arStr(a) + ", " + k + " -> " + arStr(circularArrayRotation(a, k, queries)));
            }
  
            Console.ReadKey();
        }
    }
}
