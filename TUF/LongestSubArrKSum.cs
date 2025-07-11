using System;
using System.Collections.Generic;

namespace DSA
{
    public class LongestSubArrKSum {
        public static void Driver()
        {
            int[] nums = [1, 2, 3, 1, 1, 1, 1, 4, 2, 3];
            int x = 4;
            Console.Write(GetLongestSubarrKSum4(nums, x));
        }

        private static int GetLongestSubarrKSum4(int[] nums, int k) //Best when array elements has +ive/0, TC: ~O(2n), SC: ~O(1)
        {
            int left = 0;
            int right = 0;
            long sum = nums[0];
            int maxLen = 0;
            int n = nums.Length;

            while (right < n) {
                while (left <= right && sum > k) { //Not a cascade loop but an extension of 1st loop
                    sum -= nums[left];
                    left++;
                }
                if (sum == k) {
                    maxLen = Math.Max(maxLen, right - left + 1);
                }
                right++;
                if (right < n) {
                    sum += nums[right];
                }
            }
            return maxLen;
        }
        private static int GetLongestSubarrKSum3(int[] nums, int k) //Best when array elements has +ive/-ive, TC: ~O(n), SC: ~O(n)
        {
            Dictionary<long, int> preSum = [];
            long sum = 0;
            int maxLen = 0;
            int n = nums.Length;
            for (int i = 0; i < n; i++) {
                sum += nums[i];
                if (sum == k) {
                    maxLen = Math.Max(maxLen, i + 1);
                }
                int rem = (int)(sum - k);
                if (preSum.ContainsKey(rem)) {
                    maxLen = Math.Max(maxLen, i - preSum[rem]);
                }
                if (!preSum.ContainsKey(sum)) {
                    preSum[sum] = i;
                }
            }
            return maxLen;
        }

        private static int GetLongestSubarrKSum2(int[] nums, int x) //TC: ~O(n^2), SC: O(1)
        {
            int n = nums.Length;
            int maxLen = 0;
            for (int i = 0; i < n; i++) {
                int sum = 0;
                for (int j = i; j < n; j++) {
                    sum += nums[j];
                    if (sum == x) {
                        maxLen = Math.Max(maxLen, j - i + 1);
                    }
                }
            }
            return maxLen;
        }

        private static int GetLongestSubarrKSum(int[] nums, int x) //TC: ~O(n^3), SC: O(1)
        {
            int n = nums.Length;
            int maxLen = 0;
            for (int i = 0; i < n; i++) {
                for (int j = i; j < n; j++) {
                    int sum = 0;
                    for (int k = i; k <= j; k++) {
                        sum += nums[k];
                    }
                    if (sum == x) {
                        maxLen = Math.Max(maxLen, j - i + 1);
                    }
                }
            }
            return maxLen;
        }
    }
}