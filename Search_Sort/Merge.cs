// -----------------------------------------------------------------------
// <copyright file="Sort.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace DSA
{
    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Merge
    {
        public static void Driver()
        {
            int n = 7;
            int[] arr = { 9, 4, 7, 6, 3, 1, 5 };

            Console.WriteLine("Before sorting array: ");
            for (int i = 0; i < n; i++) {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            DoMergeSort(arr, 0, n - 1);
            
            Console.WriteLine("After sorting array: ");
            for (int i = 0; i < n; i++) {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        private static void DoMergeSort(int[] arr, int low, int high) 
        {
            if (low >= high) return;
            int mid = (low + high) / 2;
            DoMergeSort(arr, low, mid);  // left half
            DoMergeSort(arr, mid + 1, high); // right half
            MergeSort(arr, low, mid, high);  // merging sorted halves
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
                } else {
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
    }
}
