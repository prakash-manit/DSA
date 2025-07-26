using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA
{
    //https://leetcode.com/problems/remove-element/description/
    internal class RemoveElement
    {
        public static void Driver()
        {
            // Console.WriteLine("Please enter the size of input array!");
            // int m = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Please enter the element of array one by one!");

            // int[] nums = new int[m];
            // for (int i = 0; i < m; i++)
            // {
            //     nums[i] = Convert.ToInt32(Console.ReadLine());
            // }
            // Console.WriteLine("Please enter the value to remove!");
            // int val = Convert.ToInt32(Console.ReadLine());

            int[] nums = [0, 1, 2, 2, 3, 0, 4, 2]; //[3, 2, 2, 3];
            int val = 2;//3;
            Console.WriteLine(RemoveElementAndReturnCount2(nums, val));

        }

        private static int RemoveElementAndReturnCount2(int[] nums, int val) //In-place, TC: O(n), SC: O(1)
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
        
        private static int RemoveElementAndReturnCount(int[] nums, int val) //Extra container, not in-place
        {
            List<(int, bool)> result = new List<(int, bool)> { }; //(nums[0], true)
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] == val) {
                    result.Add((nums[i], false));
                } 
                else {
                    result.Add((nums[i], true));
                    continue;
                }
            }
            //foreach (int num in result)
            //{
            //    Console.Write(num + " ");
            //}

            return result.Where(x => x.Item2 == true).ToList().Count;
        }
    }
}
