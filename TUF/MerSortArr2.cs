using System;

namespace DSA
{
    public class MerSortArr2
    {
        public static void Driver()
        {
            int [] num1 = {1, 3, 5, 7};
            int [] num2 = {0, 2, 6, 8, 9};
            //After merge: 0 1 2 3 5 6 7 8 9

            DoMerge3(num1, num1.Length, num2, num2.Length); 
        }        

        private static void DoMerge3 (int[] nums1, int m, int[] nums2, int n)// Time: log(m+n) * O(m+n), Space: O(1)
        {
            int len = m+n;
            int gap = (len/2) + (len%2);

            while (gap>0){
                int left = 0;
                int right = left+gap;
                while (right < len){                    
                    if (left < m && right >= m){ //nums1 and nums2
                        SwapIfGreater(nums1, nums2, left, right-m);
                    }
                    else if (right > m){ //nums2 and nums2
                        SwapIfGreater(nums2, nums2, left-m, right-m);
                    }
                    else{ //nums1 and nums1
                        SwapIfGreater(nums1, nums1, left, right);
                    }
                    left++;
                    right++;
                }
                if (gap==1){
                    break;
                }
                gap = (gap/2) + (gap%2);
            }

            //Print
            for (int i = 0; i<m; i++){               
                Console.Write(nums1[i] + " ");  
            }
            for (int i = 0; i<n; i++){               
                Console.Write(nums2[i] + " ");  
            }
        }

        private static void SwapIfGreater(int[] nums1, int[] nums2, int m, int n){
            if (nums1[m] > nums2[n]){
                (nums1[m], nums2[n]) = (nums2[n], nums1[m]); //swap the position
            }
        }
        private static void DoMerge2 (int[] nums1, int m, int[] nums2, int n)// Time: O[min(m,n)] + O(m log m) + O(n log n), Space: O(1)
        {
            int left = m-1;
            int right = 0;

            while (left >= 0 && right < n){
                if (nums1[left] > nums2[right]){
                    (nums1[left], nums2[right]) = (nums2[right], nums1[left]); //swap the position
                    left--;
                    right++;
                }
                else {
                    break;
                }
            }
            Array.Sort(nums1);
            Array.Sort(nums2);

            //Print
            for (int i = 0; i<m; i++){               
                Console.Write(nums1[i] + " ");  
            }
            for (int i = 0; i<n; i++){               
                Console.Write(nums2[i] + " ");  
            }

            // for (int i = 0; i<m+n; i++){
            //     if (i<m){
            //         Console.Write(nums1[i] + " ");
            //     }
            //     else
            //     {
            //         Console.Write(nums2[i-m] + " ");
            //     }
            // }            
        }
        private static void DoMerge (int[] nums1, int m, int[] nums2, int n)// Time: O(m+n) + O(m+n), Space: O(m+n)
        {
            int[] num3 = new int[m + n];
            int left = 0;
            int right = 0;
            int idx = 0;

            while(left < m && right < n){
                if (nums1[left] <= nums2[right]){
                    num3[idx++] = nums1[left++];
                }
                else {
                    num3[idx++] = nums2[right++];
                }
            }

            while (left < m){
                num3[idx++] = nums1[left++];               
            }
            while (right < n){
                num3[idx++] = nums2[right++];               
            }

            //Print
            for (int i = 0; i<m+n; i++){
                if (i<m){
                    nums1[i] = num3[i];
                    Console.Write(nums1[i] + " ");
                }
                else
                {
                    nums2[i-m] = num3[i];
                    Console.Write(nums2[i-m] + " ");
                }
            }
        }
    }
}