using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA.LeetCode
{
    public class NextPermutation
    {
        public static void Driver()
        {
            int [] nums = [3, 2, 1];
            PrintNextPermutation(nums);            
        }

        private static void PrintNextPermutation(int[] nums) 
        {
            int idx = -1;
            int n = nums.Length;
            for (int i = n-2; i>=0; i--){
                if (nums[i] < nums [i+1]){
                    idx = i;
                    break;
                }
            }

            if (idx == -1){
                Array.Reverse(nums);
                //return nums;
            }
            else {          
                for (int i = n-1; i>idx; i--){
                    if (nums[i] > nums[idx]){
                        //swap
                        (nums[i], nums[idx]) = (nums[idx], nums[i]); //swap using tuple
                        // int temp = nums[idx];
                        // nums[idx] = nums[i];
                        // nums[i] = temp;
                        break;
                    }
                }

                //Reverse the element post index
                Array.Reverse(nums, idx+1, n-(idx+1));
                //return nums;
            }

            //Print
            foreach (int i in nums){
                Console.Write(i);
            }
        }
    }
}