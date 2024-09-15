using System;
using System.Linq;

namespace DSA
{
    //https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/
    internal class RemDupSortArr2
    {
        public static void Driver()
        {
            Console.WriteLine("Please enter the size of input array!");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the element of array by seperating space!");
            int[] nums = new int[m];
            nums = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            int count = RemoveDuplicates2(nums);

            Console.WriteLine();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }

        private static int RemoveDuplicates2(int[] nums)
        {
            int count = 0;           

            for (int i = 0; i < nums.Length; i++)
            {
                nums[count++] = nums[i];

                // If the current element is same as next element (occured twice), copy it in-place.
                if (i < nums.Length - 1 && nums[i] == nums[i + 1])
                {
                    nums[count++] = nums[i + 1];

                    // Skip over all duplicates until next unique element is found.
                    while (i < nums.Length - 1 && nums[i] == nums[i + 1])
                    {
                        i++;
                    }
                }               
            }

            return count;
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
                    i = ReturnNextUniqueIndex(nums, i + 1);
                }
                else
                {
                    i = ReturnNextUniqueIndex(nums, i);
                }
            }
            return count;
        }

        private static int ReturnNextUniqueIndex(int[] nums, int i)
        {
            int index = i;
            for (; index < nums.Length - 1; index++)
            {
                if (nums[index].Equals(nums[index + 1]))
                {
                    continue;
                }
                else
                {
                    return index;
                }
            }
            return index;
        }
    }
}

