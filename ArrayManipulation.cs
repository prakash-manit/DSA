using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSnA
{
    internal class ArrayManipulation
    {
        public static void Driver()
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            List<List<int>> queries = new List<List<int>>();

            for (int i = 0; i < m; i++)
            {
                queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
            }

            long result = arrayManipulation(n, queries);

            Console.WriteLine(result);
        }

        //private static long arrayManipulation(int n, List<List<int>> queries) //9 out of 16 test cases passed.
        //{

        //    long[] result = new long[n];

        //    for (int i = 0; i < queries.Count; i++)
        //    {
        //        for (int j = queries[i][0]; j <= queries[i][1]; j++)
        //        {
        //            result[j - 1] = result[j - 1] + queries[i][2];
        //        }
        //    }

        //    return result.Max();
        //}

        private static long arrayManipulation(int n, List<List<int>> queries)
        {

            long[] result = new long[n];

            for (int i = 0; i < queries.Count; i++)
            {
                for (int j = queries[i][0]; j <= queries[i][1]; j++)
                {
                    result[j - 1] = result[j - 1] + queries[i][2];
                }
            }

            return result.Max();
        }
    }
}
