using System;

namespace DSA
{
    internal class DelArrEle
    {
        // Driver Code
        public static void Driver()
        {
            int i;
            int[] nums = { 10, 50, 30, 40, 20, 30 };
            //int[] arr2 = { 10, 50, 10, 40, 20 };

            int delEle = 30;

            Console.Write("Array before deletion ");
            for (i = 0; i < nums.Length; i++)
                Console.Write(nums[i] + " ");
            Console.WriteLine();

            // Delete function call
            int remCount = deleteElement(nums, delEle);

            Console.Write("Array after deletion ");
            for (i = 0; i < remCount; i++)
                Console.Write(nums[i] + " ");
        }

        private static int GetIndex(int[] nums, int delEle)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == delEle)
                {
                    return i;
                }
            }
            return -1;
        }

        static int deleteElement(int[] nums, int delEle)
        {
            //check if element to delete is present in the array
            int idx = GetIndex(nums, delEle);
            if (idx == -1)
            {
                Console.WriteLine("Element not found!!");
            }
            else
            {
                for (int i = idx; i < nums.Length - 1; i++)
                {
                    nums[i] = nums[i + 1];
                }
            }
            return nums.Length - 1;
        }

        private static int deleteElement2(int[] nums, int delEle)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != delEle)
                {
                    nums[count] = nums[i];
                    count++;
                }
            }
            return count;
        }
    }
}
