using System;
using System.Collections.Generic;

namespace DSA
{
    public class LongestConsecutiveSeq
    {
        public static void Driver()
        {
            int[] nums = [100, 4, 200, 1, 3, 2];
            Console.Write(GetLongestConsecutive3(nums));
        }

        public static int GetLongestConsecutive3(int[] nums) //TC: O(3n) = ~O(n), SC: O(n)
        {
            if (nums.Length == 0) return 0;
            int n = nums.Length;
            int longest = 1;
            HashSet<int> hSet = new HashSet<int>();
            foreach (int num in nums) { //TC: O(n)
                hSet.Add(num);
            }

            foreach (int num in hSet ) { //TC: O(2n)
                if (!hSet.Contains(num - 1)) {
                    int cnt = 1;
                    int x = num;
                    while (hSet.Contains(x + 1)) {
                        x++;
                        cnt++;
                    }
                    longest = Math.Max(longest, cnt);
                }
            }
            return longest;
        }

        public static int GetLongestConsecutive2(int[] nums) //TC: O(n log n) + O(n)= ~O(n log n), SC: O(1)
        {
            if (nums.Length == 0) return 0;
            int n = nums.Length;
            int longest = 1;
            int cnt = 0;
            int lastSmall = int.MinValue;
            Array.Sort(nums);
            for (int i = 0; i < n; i++) {
                if (nums[i] - 1 == lastSmall) {
                    cnt++;
                    lastSmall = nums[i];
                } else if (nums[i] != lastSmall) {
                    cnt = 1;
                    lastSmall = nums[i];
                }
                longest = Math.Max(longest, cnt);
            }
            return longest;
        }

        public static int GetLongestConsecutive(int[] nums) //TC: O(n^2), SC: O(1)
        {
            if (nums.Length == 0) return 0;
            int n = nums.Length;
            int longest = 1;
            for (int i = 0; i < n; i++) {
                int cnt = 1;
                int x = nums[i];
                while (linearSearch(nums, x + 1)) {
                    x++;
                    cnt++;
                }
                //longest = Math.Max(longest, cnt);
                if (cnt > longest) {
                    longest = cnt;
                }
            }
            return longest;
        }

        private static bool linearSearch(int[] nums, int x)
        {
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] == x) return true;
            }
            return false;            
        }
    }
}