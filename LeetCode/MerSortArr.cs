using System;

namespace DSnA.LeetCode
{
    //https://leetcode.com/problems/merge-sorted-array/description/
    internal class MerSortArr
    {
        public static void Driver()
        {
            Console.WriteLine("Please enter the size of first array!");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the size of second array!");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the element of first array one by one!");
            int[] num1 = new int[m + n];
            for (int i = 0; i < m; i++)
            {
                num1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Please enter the element of second array one by one!");
            int[] num2 = new int[n];
            for (int i = 0; i < n; i++)
            {
                num2[i] = Convert.ToInt32(Console.ReadLine());
            }

            Merge(num1, m, num2, n);
        }
        private static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = m, j= 0; i< (m+n); i++, j++)
            {
                nums1[i] = nums2[j];
            }

            Array.Sort(nums1);
            foreach (int num in nums1)
            {
                Console.Write(num + " ");              
            }           
            //Console.Write(String.Join(" ", nums1)); //Another way to print array elements                  
        }
    }
}
