using System;

namespace DSA
{
    internal class DelArrEle
    {
        // Driver Code
        public static void Driver()
        {
            int[] nums = { 10, 50, 30, 40, 20, 30 };

            int delEle = 30;

            Console.Write("Array before deletion\n");
            for (int i = 0; i < nums.Length; i++)
                Console.Write(nums[i] + " ");

            // Delete function call
            int remCount = deleteElement2(nums, delEle);

            if (remCount < nums.Length)
            {
                Console.Write("\nArray after deletion\n");
                for (int i = 0; i < remCount; i++)
                    Console.Write(nums[i] + " ");
            }
            else
            {
                Console.WriteLine("\nElement not found!!");
            }
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
                return nums.Length;
            }
            else
            {
                for (int i = idx; i < nums.Length - 1; i++)
                {
                    nums[i] = nums[i + 1];
                }
                return nums.Length - 1;
            }            
        }

        //Efficient approach with just 1 loop
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
