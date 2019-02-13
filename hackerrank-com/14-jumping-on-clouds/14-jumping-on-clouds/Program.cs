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
            int pos = 0;
            do
            {
                pos = (pos + k) % c.Length;
                energy -= 1;
                if (c[pos] == 1) { energy -= 2; }
                //Console.WriteLine("pos: " + pos + ", energy: " + energy);
            } while (pos != 0);

            return energy;
        }


        static void Main(string[] args)
        {

            int[] i0 = { 0, 0, 1, 0, 0, 1, 1, 0 };
            Console.WriteLine("92: " + jumpingOnClouds(i0,2));
            int[] i1 = { 1, 1, 1, 0, 1, 1, 0, 0, 0, 0 };
            Console.WriteLine("94: " + jumpingOnClouds(i1,3));
/*            Input(stdin)
Download

10 3
1 1 1 0 1 1 0 0 0 0

Your Output(stdout)

80

Expected Output
Download

94*/


            Console.ReadKey();
        }
    }
}
