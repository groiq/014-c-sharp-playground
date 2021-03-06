﻿// workspace for exercises from https://www.hackerrank.com/

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
        static int[] permutationEquation(int[] p)
        {
            int[] result = new int[p.Length];
            int x = 0;
            for (int i = 0; i < p.Length; i++)
            {
                //Console.WriteLine("i: " + i);
                x = p[i];
                //Console.WriteLine("x: " + x);
                x = p[x-1];
                //Console.WriteLine("x: " + x);
                //result[i] = x;
                result[x - 1] = i+1;
                //Console.WriteLine("result[" + i + "] = " + x);
            }

            return result;
        }


        static void Main(string[] args)
        {
            int[] i = { 5, 2, 1, 3, 4 };
            Console.WriteLine(arStr(i) + " -> {4,2,5,1,3} -> " + arStr(permutationEquation(i)));
            int[] i0 = { 2, 3, 1 };
            Console.WriteLine(arStr(i0) + " -> {2,3,1} -> " + arStr(permutationEquation(i0)));
            int[] i1 = { 4, 3, 5, 1, 2 };
            Console.WriteLine(arStr(i1) + " -> {1,3,5,4,2} -> " + arStr(permutationEquation(i1)));
            

            Console.ReadKey();
        }
    }
}
