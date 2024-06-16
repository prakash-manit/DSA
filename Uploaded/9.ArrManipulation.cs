using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA
{
    internal class ArrManipulation
    {
        public static void Driver()
        {
            //Approach1And2();
            Approach3();
        }

        private static void Approach1And2()
        {
            Console.WriteLine("Please enter the number of array element and 2D queries count respectively by keeping a space!");
            string[] firstInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = int.Parse(firstInput[0]);
            int m = int.Parse(firstInput[1]);
            
            List<List<int>> queries = new List<List<int>>();
            Console.WriteLine("Please enter the 2D query elements (start index, end index and value to add) one by one, keeping a space!");
            for (int i = 0; i < m; i++)
            {
                queries.Add(Console.ReadLine().Split(' ').ToList().Select(x => int.Parse(x)).ToList());
            }

            long result = arrayManipulation2(n, queries);
            Console.WriteLine(result);
        }

        // It leverages sorting and cumulative sum calculations to determine the maximum prefix sum after all modifications are applied,
        // Suitable for scenarios requiring fast processing of cumulative sum operations over ranges.
        private static void Approach3() //O(m log m) Most efficient
        {
            //Below example is even more efficient solution
            
            Console.WriteLine("Please enter the number of array element and 2D queries count respectively by keeping a space!");
            string[] input = Console.ReadLine().Split();
            int n, m;
            n = int.Parse(input[0]);
            m = int.Parse(input[1]);

            List<(int, int)> tupleList = new List<(int, int)>();
            Console.WriteLine("Please enter the 2D query elements (start index, end index and value to add) one by one, keeping a space!");            
            for (int i = 0; i < m; i++)
            {
                input = Console.ReadLine().Split();
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                int k = int.Parse(input[2]);

                // Storing the query
                // This will add k in the prefix sum for index >= a
                tupleList.Add((a, k));

                // Adding -1*k will remove k from the prefix sum for index > b
                tupleList.Add((b + 1, -1 * k));
            }

            long mmaxValuex = 0, prefix_sum = 0;

            tupleList.Sort((x, y) => x.Item1.CompareTo(y.Item1));

            for (int i = 0; i < 2 * m; i++)
            {
                prefix_sum += tupleList[i].Item2;
                mmaxValuex = Math.Max(mmaxValuex, prefix_sum);
            }

            Console.WriteLine(mmaxValuex);
        }

        private static long arrayManipulation(int n, List<List<int>> queries) // up to O(n^2), 9 out of 16 test cases passed.
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

        //The solution achieves optimal performance for scenarios involving multiple range update queries on a large array.
        //This technique is widely used in real-world applications where efficient handling of cumulative sum queries and updates is crucial.
        private static long arrayManipulation2(int n, List<List<int>> queries) // O(m + n) All 16 test cases passed
        {
            long[] result = new long[n];

            for (int i = 0; i < queries.Count; i++)
            {
                int start = queries[i][0] - 1;
                int end = queries[i][1] - 1;
                int value = queries[i][2];

                result[start] = result[start] + value; //Add value to result[start] to indicate an increment starting from index start
                if (end + 1 < n)
                {
                    result[end + 1] = result[end + 1] - value; //Subtract value from result[end + 1] to cancel the increment effect after index end.
                }
            }

            long maxValue = 0;
            long prefix_sum = 0;

            foreach (var a in result)
            {
                prefix_sum += a;
                if (prefix_sum > maxValue)
                {
                    maxValue = prefix_sum;
                }
            }
            return maxValue;


            //for (int i = 1; i < n; i++)
            //{
            //    result[i] = result[i] + result[i - 1]; //prefix sum approach
            //}

            //return result.Max();
        }

    }
}
