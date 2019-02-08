// workspace for exercises from https://www.hackerrank.com/

using System;

namespace hackerrank_com
{
    class Program
    {

        static int designerPdfViewer(int[] h, string word)
        {
            int width = word.Length;
            int height = 0;
            //pprint(h);
            foreach (char item in word)
            {
                int pos = (int)item - (int)'a';
                //Console.WriteLine(item + ": " + pos + ": " + h[pos]);
                if (h[pos] > height) { height = h[pos]; }
            }
            int result = width * height;
            return result;
        }

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

        static void Main(string[] args)
        {
            int[] i0 = { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            string w0 = "abc";
            string o0 = "9";
            Console.WriteLine(o0 + ": " + designerPdfViewer(i0, w0));
            int[] i1 = { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7 };
            string w1 = "zaba";
            string o1 = "28";
            Console.WriteLine(o1 + ": " + designerPdfViewer(i1, w1));

            Console.ReadKey();
        }
    }
}

//arrays in main method created with copy-paste and this bit of python:
//#!/usr/bin/env python3
//input = ["1 3 1 3 1 4 1 3 2 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5",
//         "1 3 1 3 1 4 1 3 2 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 7"]
//for iStr in input:
//    oStr = []
//    for num in iStr.split():
//        oStr.append(int(num))
//    print(oStr)
