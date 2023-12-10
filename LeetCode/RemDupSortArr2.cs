using System;

namespace DSnA.LeetCode
{
    //https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/
    internal class RemDupSortArr2
    {
        public static void Driver()
        {
            Console.WriteLine("Please enter the size of input array!");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the element of array one by one!");
            int[] nums = new int[m];
            for (int i = 0; i < m; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            int count = RemoveDuplicates(nums);

            Console.WriteLine();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }

        private static int RemoveDuplicates(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                nums[count] = nums[i];
                count++;

                if (i < nums.Length - 1 && nums[i] == nums[i + 1])
                {
                    nums[count] = nums[i + 1];
                    count++;
                    i = ReturnLastDupIndex(nums, i + 1);
                }
                else
                {
                    i = ReturnLastDupIndex(nums, i);
                }
            }
            return count;
        }

        private static int ReturnLastDupIndex(int[] nums, int i)
        {
            int dupCounter = i;
            for (; dupCounter < nums.Length - 1; dupCounter++)
            {
                if (nums[dupCounter].Equals(nums[dupCounter + 1]))
                {
                    continue;
                }
                else
                {
                    return dupCounter;
                }
            }
            return dupCounter;
        }
    }
}

