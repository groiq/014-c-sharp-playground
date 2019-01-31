// workspace for exercises from https://www.hackerrank.com/

using System;

namespace hackerrank_com
{
    class Program
    {

        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            int result = -1;

            foreach (int k in keyboards)
            {
                foreach (int d in drives)
                {
                    if ((k+d > result) && (k+d <= b)) { result = k + d; }
                }
            }

            return result;
         
        }



        static void Main(string[] args)
        {

            /*
             * 10,(3,1),(5,2,8) -> 9
             * 5,(4),(5) -> -1
             */

            
            int[] keyboards = { 3, 1 };
            int[] drives = { 5, 2, 8 };
            Console.WriteLine("9: " + getMoneySpent(keyboards, drives, 10));
            int[] k1 = { 4};
            int[] d1 = { 5};
            Console.WriteLine("-1: " + getMoneySpent(k1, d1, 5));

            //Console.WriteLine(keyboards);
            //foreach (int i in keyboards) { Console.Write(i); }


            Console.ReadKey();
        }
    }
}
