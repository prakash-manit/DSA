using System;

namespace DSA
{
    public class MaxSubArray
    {
        public static void Driver()
        {
            //int [] nums = [-2,1,-3,4,-1,2,1,-5,4]; //output: 6, The subarray [4,-1,2,1] has the largest sum 6
            //int [] nums = [-2,-3,4,-1,-2,1,5,-3]; //output: 7
            int [] nums = [5,4,-1,7,8];
            Console.Write("\n" + FindLargestSum4(nums));            
        }

        private static int FindLargestSum4(int [] nums) //Time: ~O(n), Space: O(1), uses a fixed amount of space regardless of the input size
        {
            int n = nums.Length;
            int sum = 0;
            int max = int.MinValue;
            int subArrStart = -1;
            int subArrEnd = -1;
            for (int i=0; i<n; i++) {
                if (sum ==0){
                    subArrStart  = i;
                }
                sum += nums[i];                
                if (sum > max) {
                    max = sum;
                    subArrEnd = i;
                }
                if (sum < 0){
                    sum = 0;
                }                            
            }

            //Print max Sub-array
            for (int i = subArrStart; i<=subArrEnd; i++){
                Console.Write (nums[i]+ " ");
            }           

            return max;
        }
        
        private static int FindLargestSum3(int [] nums) //Kadane's algo, Time: ~O(n), Space: O(1), uses a fixed amount of space regardless of the input size
        {
            int n = nums.Length;
            int sum = 0;
            int max = int.MinValue;
            for (int i=0; i<n; i++) {
                sum += nums[i];                
                if (sum > max){
                    max = sum;
                }
                if (sum < 0){
                    sum = 0;
                }                            
            }           
            return max;
        }

        private static int FindLargestSum2(int [] nums) //Time (worst case): ~O(n^2), Space: O(1), uses a fixed amount of space regardless of the input size
        {
            int n = nums.Length;
            int sum;
            int max = int.MinValue;
            for (int i=0; i<n; i++) {
                sum = 0;
                for (int j=i; j<n; j++) {
                    sum += nums[j];                    
                    max = Math.Max(max, sum);                
                }            
            }
            return max;
        }

        private static int FindLargestSum(int [] nums) //Time (worst case): ~O(n^3), Space: O(1), uses a fixed amount of space regardless of the input size
        {
            int n = nums.Length;
            int sum;
            int max = int.MinValue;
            for (int i=0; i<n; i++) {
                for (int j=i; j<n; j++) {
                    sum = 0;
                    for (int k=i; k<=j; k++) {
                        sum += nums[k];                        
                    }
                    max = Math.Max(max, sum);                    
                }
            }
            return max;
        }
    }
}