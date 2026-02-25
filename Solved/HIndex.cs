using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA;

public class HIndex
{
    public static void Driver()
    {
        int[] citations  = [1, 3, 1];//[3,0,6,1,5];   
        Console.Write(GetHIndex(citations));
    }

    private static int GetHIndex2(int[] citations) //TC: O(n), SC O(n)
    {
        int n = citations.Length;
        int [] freq = new int[n+1];

        for(int i = 0; i<n ; i++) {
            if (citations[i]>=n) {
                freq[n]++;
            } else {
                freq[citations[i]]++;
            }
        }
        
        int idx = n;
        int cnt = freq[n]; //To keep count of papers that have atleast idx citation
        while (cnt < idx) {
            idx--;
            cnt = cnt + freq[idx];
        }
        return idx;
    }

    private static int GetHIndex(int[] citations) //TC: O(n log n) + O(n)= O(n logn), SC O(1)
    {
        citations = citations.OrderByDescending(x=>x).ToArray();
        int n = citations.Length;
        int idx = 0;
        while (idx < n && citations[idx] > idx) {          
            idx++;
        }
        return idx;
    }
}