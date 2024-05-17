using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA
{
    internal class SparseArr
    {
        public static void Driver()
        {
            SparseArrMethod1();
            //SparseArrMethod2();
        }

        private static void SparseArrMethod1()
        {
            Console.WriteLine("Please enter the string array count!");
            int stringListCount = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine("Please enter the string list one by one!");
            List<string> stringList = new List<string>();
            for (int i = 0; i < stringListCount; i++)
            {
                stringList.Add(Console.ReadLine().Trim());
            }

            Console.WriteLine("Please enter the query array count!");
            int queryListCount = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine("Please enter the query list one by one!");
            List<string> queryList = new List<string>();
            for (int i = 0; i < queryListCount; i++)
            {
                queryList.Add(Console.ReadLine().Trim());
            }

            List<int> result = matchingString(stringList, queryList);
            Console.WriteLine(String.Join("\n", result));
        }

        private static List<int> matchingString(List<string> stringList, List<string> queryList)
        {
            int[] result = new int[queryList.Count];

            for (int i = 0; i < queryList.Count; i++)
            {
                foreach (string str in stringList)
                {
                    if (str.Equals(queryList[i]))
                    {
                        result[i]++;
                    }
                }
            }

            return result.ToList();
        }

        private static void SparseArrMethod2()
        {
            Console.WriteLine("Please enter the string array count!");
            int stringListCount = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine("Please enter the string list one by one!");
            Dictionary<string, int> stringDict = new Dictionary<string, int>();
            while (stringListCount > 0)
            {
                string str = Console.ReadLine();
                int count = 0;

                if (!stringDict.ContainsKey(str))
                {
                    stringDict.Add(str, 1);
                }
                else
                {
                    count = stringDict[str];
                    stringDict[str] = count + 1;
                }
                stringListCount--;
            }

            Console.WriteLine("Please enter the query array count!");
            int queryListCount = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine("Please enter the query list one by one!");
            while (queryListCount > 0)
            {
                string query = Console.ReadLine();
                if (stringDict.ContainsKey(query))
                {
                    Console.WriteLine(stringDict[query]);
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}