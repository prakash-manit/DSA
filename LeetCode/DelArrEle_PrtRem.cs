using System;

namespace DSA
{
    //https://leetcode.com/problems/remove-element/description/
    internal class DelArrEle_PrtRem
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
            Console.WriteLine("Please enter the value to remove!");
            int val = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(RemoveElement(nums, val));
        }

        private static int RemoveElement(int[] nums, int val)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[count] = nums[i];
                    count++;
                }
            }
            return count;

        }

        //private static int RemoveElement(int[] nums, int val)
        //{
        //    List<int> result = new List<int>();

        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (nums[i] == val)
        //        {
        //            //Shift member left
        //            for (int j = i+1; j < nums.Length; j++)
        //            {
        //                nums[j-1] = nums[j];
        //            }
        //            nums[nums.Length - 1] = -1;
        //        }
        //        else
        //        {
        //            result.Add(nums[i]);
        //            continue;
        //        }
        //    }
        //    //foreach (int num in result)
        //    //{
        //    //    Console.Write(num + " ");
        //    //}

        //    return result.Count;
        //}
    }
}
