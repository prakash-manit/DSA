using System;
using System.Collections.Generic;

namespace DSA
{
    public class ReversePairs
    {
        public static void Driver()
        {
            int [] nums  = [2147483647,2147483647,2147483647,2147483647,2147483647,2147483647]; //[40, 25, 19, 12, 9, 6, 2];  // i<j and nums[i]>2*nums[j]
            Console.Write(getInversions3(nums));
        }       

        //private static int cnt = 0;

        private static int getInversions3(int [] nums) //Time: O(2n logn), Space: O(n)
        {
            return DoMergeSort(nums, 0, nums.Length-1);
            //return cnt;
        }

        private static int DoMergeSort(int[] arr, int low, int high) 
        {
            int cnt = 0;
            if (low >= high) return cnt;
            int mid = (low + high) / 2;
            cnt += DoMergeSort(arr, low, mid);  // left half
            cnt += DoMergeSort(arr, mid + 1, high); // right half
            cnt += CountPairs (arr, low, mid, high);
            MergeSort(arr, low, mid, high);  // merging sorted halves
            return cnt;
        }

        private static int CountPairs(int[] arr, int low, int mid, int high) //TC (n lon n) due to optimization
        {
            int right = mid+1;
            int cnt = 0;
            for (int i = low; i<=mid; i++) {
                 while (right <= high && arr[i] > 2* arr[right]) right++;
                  cnt += right - (mid+1);
            }
            return cnt;
        }

       private static void MergeSort(int[] arr, int low, int mid, int high) 
        {
            List<int> temp = new List<int>(); // temporary array
            int left = low;      // starting index of left half of arr
            int right = mid + 1; // starting index of right half of arr

            // storing elements in the temporary array in a sorted manner
            while (left <= mid && right <= high) {
                if (arr[left] <= arr[right]) {
                    temp.Add(arr[left]);
                    left++;
                } 
                else {
                    temp.Add(arr[right]);
                    right++;
                }
            }

            // if elements on the left half are still left
            while (left <= mid) {
                temp.Add(arr[left]);
                left++;
            }

            // if elements on the right half are still left
            while (right <= high) {
                temp.Add(arr[right]);
                right++;
            }

            // transferring all elements from temporary to arr
            for (int i = low; i <= high; i++) {
                arr[i] = temp[i - low];
            }
        }

        private static int getInversions2(int [] nums) //Time: O(n^2), Space: O(1)
        {
            int cnt = 0;
            int n = nums.Length;
            for (int i = 0; i<n; i++){
                for (int j = i+1; j<n; j++){
                    long n1 = nums[i];
                    long n2= 2*nums[j]; 
                    if (n1 != int.MaxValue && n1 != int.MinValue && n1 > n2){
                        cnt++;
                    }
                }
            }
            return cnt;
        }

        private static int getInversions(int [] nums) //Time: O(n^2), Space: O(1)
        {
            int cnt = 0;
            int n = nums.Length;
            for (int i = 0; i<n; i++){
                for (int j = i+1; j<n; j++){
                    if (nums[i] > 2*nums[j]){
                        cnt++;
                    }
                }
            }
            return cnt;
        }            
    }
}