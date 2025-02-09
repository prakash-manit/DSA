using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DSA
{
    public class SortColors
    {
        public static void Driver()
        {
          //Assume integers 0, 1, and 2 to represent the color red, white, and blue, respectively.
          int [] nums = [2,0,2,1,1,0]; //Input: nums = [2,0,2,1,1,0], Output: [0,0,1,1,2,2]
          DoSortColors3(nums);

          
        }
        public static void DoSortColors3(int[] nums) //Dutch national flag algo, Time: O(n), Space: O(1)
        {
            int low = 0;
            int mid = 0;
            int high = nums.Length-1;

            while (mid <=high) {
              if (nums[mid]==0) {
                (nums[low], nums[mid]) = (nums[mid], nums[low]); //swap mid wth low
                low++;
                mid++;
              } 
              else if (nums[mid]==1){
                mid++;
              }
              else{
                 (nums[high], nums[mid]) = (nums[mid], nums[high]); //swap mid wth high
                 high--;
              }
            }

            foreach (int item in nums) {
              Console.Write (item + " ");
            }
        }
        public static void DoSortColors2(int[] nums) //Time: O(2n) ~O(n), Space: O(1)
        {
            int zero = 0;
            int one = 0;
            int two = 0;

            for (int i = 0; i< nums.Length; i++) {
              if (nums[i] == 0){
                zero++;
              } else if (nums[i] == 1){
                one++;
              } else {
                two++;
              }
            }

            for (int i = 0; i< zero; i++) {
              nums[i] = 0;
            }
            for (int i = zero; i< zero+one; i++) {
              nums[i] = 1;
            }
            for (int i = zero+one; i< zero+one+two; i++) {
              nums[i] = 2;
            }

            foreach (int item in nums) {
              Console.Write (item + " ");
            }
        }
        public static void DoSortColors(int[] nums) 
        {
            Array.Sort(nums); //Uses heap [>16 elements, time: O(n log n)] and insertion sort O(n) to O(n^2), space: O(1)
            //nums = Quick.QuickSort_Rec(nums, 0, nums.Length - 1);
            foreach (int item in nums) {
              Console.Write (item + " ");
            }
        }        
    }
}