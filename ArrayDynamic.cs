using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSnA
{
    internal class ArrayDynamic
    {
        public static void Driver()
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);
            int q = Convert.ToInt32(firstMultipleInput[1]);

            List<List<int>> queries = new List<List<int>>();

            for (int i = 0; i < q; i++)
            {
                queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
            }

            List<int> result = dynamicArray(n, queries);
            Console.WriteLine(String.Join("\n", result));
        }

        private static List<int> dynamicArray(int n, List<List<int>> queries)
        {
            int lastans = 0;
            List<int> result = new List<int> (n);           

            List<int>[] lists = new List<int>[n];
            for (int i = 0; i < n; i++)
            {
                lists[i] = new List<int>();
            }

            for (int i = 0; i < queries.Count; i++)
            {
                int x = queries[i][1];
                int y = queries[i][2];
                int index = (x ^ lastans) % n;
                if (queries[i][0] == 1)
                {
                    lists[index].Add(y);                
                    
                }
                else if (queries[i][0] == 2)
                {
                    int size = lists[index].Count;
                    lastans = lists[index][y % size];
                    result.Add(lastans);
                }               
            }
            
            return result;

        }
    }
}
