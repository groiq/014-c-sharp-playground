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


        static string angryProfessor(int k, int[] a)
        {
            Boolean result = false;
            int counter = 0;

            foreach (var item in a) 
            {
                if (item < 1)
                {
                    counter++;
                }
                
            }
            if (counter >= k) { result = true; }
            return result ? "NO" : "YES";
        }

        static void Main(string[] args)
        {

            int[] classList = { -1, -1, 0, 0, 1, 1 };
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(i + " -> " + angryProfessor(i, classList));
            }

            Console.ReadKey();
        }
    }
}
