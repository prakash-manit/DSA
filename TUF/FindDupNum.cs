using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA
{
    public class FindDupNum
    {
        public static void Driver()
        {
            //int [] nums = [1,3,4,2,2]; //output: 2
            int [] nums = [3,3,3,3,3]; //output: 3
            Console.Write(FindDuplicate3(nums));
        }

        private static int FindDuplicate3(int[] nums) //Time: O(n), Space: O(1)
        {
            int slow = nums[0];
            int fast = nums[0];

            do {
                slow = nums[slow];
                fast = nums[nums[fast]];
            } while (slow!=fast);

            fast = nums[0];
            while (slow != fast){
                slow = nums[slow];
                fast = nums[fast];
            }
            return slow;

        }
        private static int FindDuplicate2(int[] nums) //Time: O(n), Space: O(n)
        {
            Dictionary<int,int> Dict  = [];
            for (int i =0; i<nums.Length; i++){ //Time: O(n)
                if (!Dict.ContainsKey(nums[i])){
                    Dict.Add(nums[i],1);
                }
                else {
                    Dict[nums[i]]++;
                }
            }

            return Dict.First(x=>x.Value>1).Key;
        }

        private static int FindDuplicate(int[] nums) //Time: O(n log n) + O(n), Space: O(1)
        {
            Array.Sort(nums); //Time: O(n log n)
            int dup = -1;
            for (int i =0; i<nums.Length-1; i++){ //Time: O(n)
                if (nums[i] == nums[i+1]){
                    dup = nums[i];
                }
            }
            return dup;
        }
    }
}