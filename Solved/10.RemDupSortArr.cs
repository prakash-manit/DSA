using System;
using System.Linq;

namespace DSA
{
    //https://leetcode.com/problems/remove-duplicates-from-sorted-array/description/
    internal class RemDupSortArr
    {
        public static void Driver()
        {
            Console.WriteLine("Please enter the size of input array!");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the element of array by seperating space!");
            int[] nums = new int[m];
            nums = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            if (nums.Length == 0)
            {
                return;
            }

            int count = RemoveDuplicates2(nums);

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }

        private static int RemoveDuplicates2(int[] nums)
        {
            int count = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[count] != nums[i])
                {
                    nums[++count] = nums[i];
                }
            }
            return count + 1;
        }

        private static int RemoveDuplicates(int[] nums)
        {
            int count = 0;
            int index = default;
            for (int i = 0; i < nums.Length; i++)
            {
                nums[count] = nums[i];
                count++;

                //Return Next Unique Ele Index
                index = i;

                for (; index < nums.Length - 1; index++)
                {
                    if (nums[index].Equals(nums[index + 1]))
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                i = index;
            }
            return count;
        }
    }
}
