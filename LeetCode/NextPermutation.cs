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

        //Time (Worst case): O(n) + O(n) + O(n) = ~O(3n), Space: No additional space, O(1)
        private static void PrintNextPermutation(int[] nums) 
        {
            int idx = -1;
            int n = nums.Length;
            for (int i = n-2; i>=0; i--){ //Time: worst case: o(n)
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
                for (int i = n-1; i>idx; i--){  //Time: worst case: o(n)
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
                Array.Reverse(nums, idx+1, n-(idx+1)); //Time: worst case: o(n)
                //return nums;
            }

            //Print
            foreach (int i in nums){
                Console.Write(i);
            }
        }
    }
}