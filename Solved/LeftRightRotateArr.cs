using System;
using System.Linq;

namespace DSA
{
    internal class LeftRightRotateArr
    {
        public static void Driver()
        {
            Console.WriteLine("Please enter the rotation type (l/r) and number of rotation steps to perform by seperating space!");
            string[] inputArr = Console.ReadLine().TrimEnd().Split(' ');

            string rotationType = inputArr[0];
            int steps = Convert.ToInt32(inputArr[1]);

            Console.WriteLine("Please enter the element of array by seperating space!");
            int[] arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToArray();
            //int[] arr = new int[1] { -1};

            if (rotationType == "l")
            {
                rotateLeft2(arr, steps);
            }
            else
            {
                rotateRight2(arr, steps);
            }
        }

        private static void rotateLeft(int[] nums, int k) //Brute force 0(n^2)
        {
            for (int i = 0; i < k; i++)
            {
                int temp = nums[0];
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    nums[j] = nums[j + 1];
                }
                nums[nums.Length - 1] = temp;
            }

            Console.WriteLine(string.Join(" ", nums));
        }

        private static void rotateRight(int[] nums, int k) //Brute force 0(n^2)
        {
            for (int i = 0; i < k; i++)
            {
                int temp = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j > 0; j--)
                {
                    nums[j] = nums[j - 1];
                }
                nums[0] = temp;
            }

            Console.WriteLine(string.Join(" ", nums));
        }

        private static void rotateLeft2(int[] nums, int k) //Optimised solution 0(n)
        {
            int[] result = new int[nums.Length];
            int count = 0;

            for (int i = k; i < nums.Length; i++)
            {
                result[count++] = nums[i];
            }

            for (int i = 0; i < k; i++)
            {
                result[count++] = nums[i];
            }

            result.CopyTo(nums, 0);

            Console.WriteLine(string.Join(" ", nums));
        }

        private static void rotateRight2(int[] nums, int k) //Optimised solution 0(n)
        {
            int[] result = new int[nums.Length];
            int count = 0;

            for (int i = nums.Length - k; i < nums.Length; i++)
            {
                result[count++] = nums[i];
            }

            for (int i = 0; i < nums.Length - k; i++)
            {
                result[count++] = nums[i];
            }

            result.CopyTo(nums, 0);

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
