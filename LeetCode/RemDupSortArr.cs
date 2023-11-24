using System;

namespace DSnA.LeetCode
{
    //https://leetcode.com/problems/remove-duplicates-from-sorted-array/description/
    internal class RemDupSortArr
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

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(nums[i]);
            }            
        }

        private static int RemoveDuplicates (int [] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                nums[count] = nums[i];                               
                count++;
                i = ReturnLastDupIndex(nums[i], nums, i);
            }
            return count;
        }      

        private static int ReturnLastDupIndex(int num, int []nums, int i)
        {
            int dupCounter = i;
            for (; dupCounter < nums.Length-1; dupCounter++)
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
