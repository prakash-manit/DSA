using System;
using System.Collections.Generic;

namespace DSA
{
    internal class MajorityEleArr
    {
        public static void Driver()
        {
            // Console.WriteLine("Please enter the size of input array!");
            // int m = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Please enter the element of array by seperating space!");
            // int[] nums = new int[m];
            // nums = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            int[] nums = { 2, 2, 1, 1, 1, 2, 2 };
            Console.WriteLine(GetMejorityElement3(nums));
        }

        private static int GetMejorityElement3(int[] nums) //Moore Majority vote algo TC: O(n) + O(n), Space O(1)
        {
            int n = nums.Length;
            int cnt  = 0;
            int ele= default;

            for (int i = 0; i<n; i++) {
                if (cnt == 0) {
                    cnt = 1;
                    ele = nums[i];
                } else if (nums[i] == ele) {
                    cnt++;
                } else {
                    cnt--;
                }
            }

            //Below step is not required, if majority element is always present in array
            cnt = 0;
            for (int i = 0; i<n; i++) {
                if (nums[i]== ele) {
                    cnt++;
                }
            }
            if (cnt > (n/2)){
                return ele;
            }
            return -1;
        }

        private static int GetMejorityElement2(int[] nums) //TC: O(n) + O(n log n) , Space O(n)
        {
            Dictionary<int, int> dict = [];
            int n = nums.Length;

            foreach (int i in nums) {
                if (!dict.ContainsKey(i)) {
                    dict[i] = 1;
                }
                else {
                    dict[i]++;
                }
            }
            // for (int i = 0; i < n; i++) {
            // if (!dict.ContainsKey(nums[i]))
            // {
            //     dict.Add(nums[i], 1);
            // }
            // else
            // {
            //     dict[nums[i]]++;
            // }        

            foreach (var d in dict) { //TC: O(n log n)
                if (d.Value > (n / 2)) {
                    return d.Key;
                }
            }
            return -1;
            // int ele = dict.MaxBy(x => x.Value).Key;
            // int cnt = dict.MaxBy(x => x.Value).Value;
            // return cnt > n/2? ele: 0;    
        }

        private static int GetMejorityElement(int[] nums) //TC: O(n^2), Space O(1)
        {
            int n = nums.Length;
            int cnt;
            for (int i = 0; i < n; i++) {
                cnt  = 0;
                for (int j = 0; j < n; j++) {
                    if (nums[i] == nums[j]){
                        cnt++;
                    }
                    if (cnt > n/2) {
                        return nums[i];
                    }                   
                }                
            }
            return -1;       
        }        
    }
}
