using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA.Uploaded
{
    internal class FindMajoEleArr
    {
        public static void Driver()
        {
            Console.WriteLine("Please enter the size of input array!");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the element of array by seperating space!");
            int[] nums = new int[m];
            nums = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Console.WriteLine(GetMejorityElement(nums));
        }
        private static int GetMejorityElement(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], 1);
                }
                else
                {
                    dict[nums[i]]++;
                }
            }

            return dict.MaxBy(x => x.Value).Key;
        }
    }
}
