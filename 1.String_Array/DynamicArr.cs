using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA
{
    internal class DynamicArr
    {
        public static void Driver()
        {
            Console.WriteLine("Pease enter the number of arrays and queries!");
            string[] firstMultipleInput = Console.ReadLine().Trim().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);
            int q = Convert.ToInt32(firstMultipleInput[1]);

            List<List<int>> queries = new List<List<int>>();

            Console.WriteLine("Pease enter the queries (type, x and y)!");
            for (int i = 0; i < q; i++)
            {
                queries.Add(Console.ReadLine().Trim().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
            }

            List<int> result = dynamicArray(n, queries);
            Console.WriteLine(String.Join("\n", result));
        }

        private static List<int> dynamicArray(int n, List<List<int>> queries)
        {
            int lastAns = 0;
            List<int> result = new List<int>(n);

            List<int>[] lists = new List<int>[n];
            for (int i = 0; i < n; i++)
            {
                lists[i] = new List<int>();
            }

            for (int i = 0; i < queries.Count; i++)
            {
                int x = queries[i][1];
                int y = queries[i][2];
                int index = (x ^ lastAns) % n;
                int queryType = queries[i][0]; //Find the query type
                if (queryType == 1)
                {
                    lists[index].Add(y);

                }
                else if (queryType == 2)
                {
                    int size = lists[index].Count;
                    if (size > 0)
                    {
                        lastAns = lists[index][y % size];
                        result.Add(lastAns);
                    }
                }
            }

            return result;
        }
    }
}
