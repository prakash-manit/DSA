using System;
using System.Collections.Generic;

namespace DSA
{
    public class TwoSum
    {
        public static void Driver()
        {
            int [] nums = [2, 6, 5, 8, 11]; //[2,7,11,15];
            int target = 14; //9;
            int [] res = GetTwoSum3(nums, target);
            foreach (int i in res){
                Console.WriteLine(i);
            }

            //Console.Write(IsTwoSumPresent(nums, target));
            
        }

        private static bool IsTwoSumPresent(int[] nums, int target) //Greedy Approach, Can be good to check if TwoSum Present, TC: ~O(n) + O(n log n), SC: O(1)
        {
            int n = nums.Length;
            int l = 0;
            int r = n-1;            
            Array.Sort(nums);          
            while (l < r) {              
                int sum = nums[l] + nums[r];
                if (sum == target) {
                    return true;                    
                } 
                else if (sum < target) l++;
                else r--;
                }                   
            return false;
        }

        private static int[] GetTwoSum3(int[] nums, int target) //TC: O(n log n), SC: O(n)
        {
            int n = nums.Length;
            int [] res = new int[2];
            Dictionary<int, int> dict = [];

            for (int i=0; i<n; i++) {
                int diff = target- nums[i];
                if (!dict.ContainsKey(diff)) { //TC: O(log n)
                    if (!dict.ContainsKey(nums[i])) dict.Add(nums[i], i);
                }
                else {
                    res[0] = dict[diff];
                    res[1] = i;
                    break;
                }
            }
            return res;
        }

        private static int[] GetTwoSum2(int[] nums, int target) //TC: ~O(n^2), SC: O(2)
        {
            int n = nums.Length;
            int [] res = new int[2];
            for (int i=0; i<n; i++) {
                for (int j=i+1; j<n; j++) {
                    //if (i == j) continue;
                    if (nums [i] + nums[j] == target) {
                        res[0] = i;
                        res[1] = j;
                        break;
                    }
                }
            }
            return res;
        }

        private static int[] GetTwoSum(int[] nums, int target) //TC: O(n^2), SC: O(2)
        {
            int n = nums.Length;
            int [] res = new int[2];
            for (int i=0; i<n; i++) {
                for (int j=0; j<n; j++) {
                    if (i == j) continue;
                    if (nums [i] + nums[j] == target) {
                        res[0] = i;
                        res[1] = j;
                        break;
                    }
                }
            }
            return res;
        }
    }
}