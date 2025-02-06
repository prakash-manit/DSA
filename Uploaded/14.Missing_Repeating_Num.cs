using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA
{
    internal class Missing_Repeating_Num
    {
        public static void Driver()
        {
            Console.WriteLine("Please enter the size of input array!");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the element of array by seperating space!");
            int[] nums = new int[m];
            nums = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            //Console.WriteLine(GetRepeatingMissingNum(nums));
            GetRepeatingMissingNum4(nums);
        }

        private static void GetRepeatingMissingNum(int[] nums) //O(n^2)
        {
            int rep = -1;
            int miss = -1;
            int cnt = -1;

            for (int i = 1; i <= nums.Length; i++)
            {
                cnt = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == nums[j])
                    {
                        cnt++;
                    }
                }
                if (cnt == 0)
                {
                    miss = i;
                }
                if (cnt == 2)
                {
                    rep = i;
                }
            }

            Console.WriteLine("Repeating No: {0}, Missing No: {1} ", rep, miss);
        }

        private static void GetRepeatingMissingNum2(int[] nums) //O(2n)
        {
            //Find Duplicate no
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

            int rep = -1;
            int miss = -1;
            for (int i = 1; i <= nums.Length; i++)
            {
                if (dict.ContainsKey(i) && dict[i] == 2)
                {
                    rep = i;
                }
                else if (!dict.ContainsKey(i))
                {
                    miss = i;
                }

                if (rep != -1 && miss != -1) { break; }
            }

            Console.WriteLine("Repeating No: {0}, Missing No: {1} ", rep, miss);
        }

        private static void GetRepeatingMissingNum3(int[] nums) //O(n)
        {
            //Find Duplicate no
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int rep = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], 1);
                }
                else
                {
                    rep = nums[i];
                    break;
                }
            }

            //Find Missing no
            int maxValue = nums.Max();
            int ArraySum = nums.Sum();
            int NumSum = maxValue * (maxValue + 1) / 2;
            int miss = NumSum - (ArraySum - rep);

            Console.WriteLine("Repeating No: {0}, Missing No: {1} ", rep, miss);
        }

        private static void GetRepeatingMissingNum4(int[] nums)
        {
            int n = nums.Length;

            long NumSum = n * (n + 1) / 2;
            long NumSum2 = n * (n + 1) * (2 * n + 1) / 6;

            long ArrSum = default;// = nums.Sum();
            long ArrSum2 = default;// = nums.Sum(n => n * n);
            for (int i = 0; i < n; i++)
            {
                ArrSum += nums[i];
                ArrSum2 += nums[i] * nums[i];
            }

            long val1 = ArrSum - NumSum; //x-y, x->rep, y-miss
            long valT = ArrSum2 - NumSum2; //x2- y2 -> (x+y) (x-y) -> val2 * val1
            long val2 = valT / val1; //x+y

            long rep = (val1 + val2) / 2;
            long miss = rep - val1; //val1 = x-y

            Console.WriteLine("Repeating No: {0}, Missing No: {1} ", rep, miss);
        }
    }
}
