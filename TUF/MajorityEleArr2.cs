using System;
using System.Collections.Generic;

namespace DSA
{
    public class MajorityEleArr2
    {        
        public static void Driver()
        {
            int[] nums = { 1, 1, 1, 3, 3, 2, 2, 2 };
            int [] ls = GetMejorityElement4(nums);
            foreach (int i in ls){
                Console.Write(i + " ");
            }            
        }

        private static int[] GetMejorityElement4(int[] nums) //TC: O(n), SC: O(2)
        {
            int n = nums.Length;
            int cnt1  = 0;
            int cnt2  = 0;
            int ele1= default;
            int ele2= default;
            List<int> ls = [];

            for (int i = 0; i<n; i++) {
                if (cnt1 == 0 && nums[i]!= ele2) {
                    cnt1 = 1;
                    ele1 = nums[i];
                } else if (cnt2 == 0 && nums[i]!= ele1) {
                    cnt2 = 1;
                    ele2 = nums[i];
                }
                else if (nums[i] == ele1) {
                    cnt1++;
                } else if (nums[i] == ele2) {
                    cnt2++;
                }
                 else {
                    cnt1--;
                    cnt2--;
                }
            }

            //Below step is not required, if majority element is always present in array
            cnt1 = 0;
            cnt2 = 0;
            for (int i = 0; i<n; i++) {
                if (nums[i]== ele1) {
                    cnt1++;
                } else if (nums[i]== ele2) {
                    cnt2++;
                }
            }
            if (cnt1 > (n/3)){
                ls.Add(ele1);
            }
            if (cnt2 > (n/3)){
                ls.Add(ele2);
            }
            return ls.ToArray();
        }

        private static int[] GetMejorityElement3(int[] nums) //TC: O(n), SC: O(n) +  O(2)
        {
            Dictionary<int, int> dict = [];
            List<int> ls = [];
            int n = nums.Length;
            int mv = (int) Math.Floor((decimal)(n / 3)) +1;

            foreach (int i in nums) {
                if (!dict.ContainsKey(i)) {
                    dict[i] = 1;
                }
                else {
                    dict[i]++;
                }

                if (dict[i] == mv) {
                    ls.Add(i);
                }
                if (ls.Count == 2){
                    break;
                }
            }        
            return ls.ToArray();
        }
        private static int[] GetMejorityElement2(int[] nums) //TC: O(n) + O(n log n), SC: O(n) +  O(2)
        {
            Dictionary<int, int> dict = [];
            List<int> ls = [];
            int n = nums.Length;            

            foreach (int i in nums) {
                if (!dict.ContainsKey(i)) {
                    dict[i] = 1;
                }
                else {
                    dict[i]++;
                }           
            }

            foreach (var d in dict) { //TC: O(n log n)
                if (d.Value > (n / 3)) {
                    ls.Add(d.Key);
                }
            }
            return ls.ToArray();
        }

        private static int[] GetMejorityElement(int[] nums) //TC: O(n^2), SC: O(2)
        {
            List<int> ls = [];
            int n = nums.Length;
            int cnt;
            for (int i=0; i<n; i++) {
                if (ls.Count == 0 || ls[0] != nums[i]) {
                    cnt = 0;
                    for (int j = 0; j<n; j++) {
                        if (nums[i] == nums[j]){
                            cnt++;
                        }
                    }
                    if (cnt > (n/3)) {
                        ls.Add(nums[i]);
                    }
                    if (ls.Count == 2){
                        break;
                    }
                }
            }
            return ls.ToArray();
        }
    }
}