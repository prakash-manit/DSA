using System;
using System.Collections.Generic;

namespace DSA;

public class Inversion_Arr
{
    public static void Driver()
    {
        int [] nums  = [5, 3, 2, 4, 1];  // i<j and nums[i]>nums[j]
        Console.Write(getInversions2(nums));
    }

    //private static int cnt = 0;

    private static int getInversions2(int [] nums) //Time: O(n logn), Space: O(n)
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
        cnt += MergeSort(arr, low, mid, high);  // merging sorted halves
        return cnt;
    }

    private static int MergeSort(int[] arr, int low, int mid, int high) 
    {
        List<int> temp = new List<int>(); // temporary array
        int left = low;      // starting index of left half of arr
        int right = mid + 1; // starting index of right half of arr

        int cnt = 0;
        // storing elements in the temporary array in a sorted manner
        while (left <= mid && right <= high) {
            if (arr[left] <= arr[right]) {
                temp.Add(arr[left]);
                left++;

            } 
            else { //right is smaller
                temp.Add(arr[right]);
                cnt += mid-left+1; //Add the count of right most elements in the array
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
        return cnt;
    }

    private static int getInversions(int [] nums) //Time: O(n^2), Space: O(1)
    {
        int cnt = 0;
        int n = nums.Length;
        for (int i = 0; i<n; i++){
            for (int j = i+1; j<n; j++){
                if (nums[i] > nums[j]){
                    cnt++;
                }
            }
        }
        return cnt;
    }
}
