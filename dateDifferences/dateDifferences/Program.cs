// calculate differences between two dates.

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
        // array to string function
        static string arStr(int[] input)
        {
            return $"[{string.Join(", ", input)}]";
        }

        static int febDays(int year)
        {
            Boolean leap = false;
            if (year % 4 == 0) { leap = true; };
            if (year % 100 == 0) { leap = false; };
            if (year % 400 == 0) { leap = true; };
            int result = leap ? 29 : 28;
            return result;
        }

        static int[] daysOfMonth(int year)
        {
            int[] result = { 31, febDays(year), 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            return result;
        }

        static int dateDiff(int d0, int m0, int y0, int d1, int m1, int y1)
        {

            int result = 0;

            if (y1 > y0)
            {
                result += dateDiff(m0, d0, y0, 31, 12, d0);
                for (int betwYear = y0 + 1; betwYear < y1; betwYear++)
                {
                    result += dateDiff(1, 1, betwYear, 31, 12, betwYear);
                }
                result += dateDiff(1, 1, y1, d1, m1, y1);
            }
            else
            {
                if (m0 == m1) { result = d1 - d0; }
                else
                {
                    int[] monthDays = daysOfMonth(y0);
                    result += (monthDays[m0] - d0);
                    for(int fullMonth = m0+1;fullMonth < m1; fullMonth++) { result += monthDays[fullMonth]; }
                    result += d1;
                }
            }

            return result;
        }
    


        static void Main(string[] args)
        {
            /*
             * 09-02-2019 - 10-02-2019
             * 09-02-2019 - 09-03-2019
             * 09-02-2019 - 09-02-2020
             * 09-02-2019 - 09-02-2021
             * 09-02-2019 - 24-12-2019
             */
            int y = 2019;
            int[] date1 = { 9, 2, y };
            int day1 = date1[0];
            int mon1 = date1[1];
            int year1 = date1[2];
            //int[,] testCases = { { 10, 2, y }, { 9, 3, y }, { 9, 2, 2020 }, { 9, 2, 2021 }, { 24, 12, 2019 } };
            int[] testCases = { 10, 2, y, 9, 3, y, 9, 2, 2020, 9, 2, 2021, 24, 12, 2019 };

            int day2;
            int mon2;
            int year2;
            for (int i = 0; i < testCases.Length; i += 3)
         
            {
                day2 = testCases[i];
                //i++;
                mon2 = testCases[i+1];
                //i++;
                year2 = testCases[i+2];

                Console.WriteLine(day1 + "-" + mon1 + "-" + year1 + " - " + day2 + "-" + mon2 + "-" + year2 + 
                    " -> " + dateDiff(day1,mon1,year1,day2,mon2,year2) + " days");
            }

            Console.ReadKey();
        }
    }
}
