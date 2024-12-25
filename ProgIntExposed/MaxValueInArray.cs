// -----------------------------------------------------------------------
// <copyright file="MaxValueInArray.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace DSA
{
    using System;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class MaxValueInArray
    {
        internal static int CompareToMax(int[] nums)
        {
            if (nums.Length <= 0)
                return -1;

            int maxValue = nums[0];
            int count = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                ++count;

                if (maxValue < nums[i])
                {
                    maxValue = nums[i];
                }
            }
            Console.WriteLine("Count {0}", count);
            return maxValue;
        }

        internal static int CompareToAll(int[] nums)
        {
            if (nums.Length <= 0)
                return -1;

            int maxValue = nums[0];
            bool isMax = false;
            int i = 0;
            int count = 0;
            for (i = nums.Length - 1; i > 0; i--)
            {
                isMax = true;
                for (int j = 0; j < i; j++)
                {
                    ++count;

                    if (nums[i] < nums[j])
                    {
                        isMax = false; // nums [i] is not the max value
                        break;
                    }
                }
                if (isMax)
                {
                    break; //nums [i] is largest to all other numbers.
                }
            }
            Console.WriteLine("Count {0}", count);
            return nums[i];
        }

        internal static int CompareToAll2(int[] nums)
        {
            if (nums.Length <= 0)
                return -1;

            int maxValue = nums[0];
            bool isMax = false;
            int i = 0;
            int count = 0;
            for (i = nums.Length - 1; i > 0; i--)
            {
                isMax = true;
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    ++count;

                    if (nums[i] < nums[j])
                    {
                        isMax = false; // nums [i] is not the max value
                        break;
                    }

                }
                if (isMax)
                {
                    break; //nums [i] is largest to all other numbers.
                }
            }
            Console.WriteLine("Count {0}", count);
            return nums[i];
        }
    }
}
