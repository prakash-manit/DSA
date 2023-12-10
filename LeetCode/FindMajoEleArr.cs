using System;

namespace DSnA.LeetCode
{
    internal class FindMajoEleArr
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

            Console.WriteLine(GetMejorityElement(nums));
        }
        private static int GetMejorityElement(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {

            }
            return 0;
        }
    }
}
