using System;
using System.Collections.Generic;
using System.Linq;

namespace DSnA
{
    internal class SparseArr
    {
        public static void Driver()
        {
            int stringListCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> stringList = new List<string>();

            for (int i = 0; i < stringListCount; i++)
            {
                string stringListItem = Console.ReadLine();
                stringList.Add(stringListItem);
            }

            int queriesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> queries = new List<string>();

            for (int i = 0; i < queriesCount; i++)
            {
                string queriesItem = Console.ReadLine();
                queries.Add(queriesItem);
            }

            List<int> res = matchingStrings(stringList, queries);

            Console.WriteLine(String.Join("\n", res));
        }

        private static List<int> matchingStrings(List<string> stringList, List<string> queries)
        {
            int[] res = new int[queries.Count];
            for (int i = 0; i < queries.Count; i++)
            {
                foreach (string str in stringList)
                {
                    if (queries[i].Equals(str))
                    {
                        res[i]++;
                    }
                }
            }

            return res.ToList();
        }
    }
}
