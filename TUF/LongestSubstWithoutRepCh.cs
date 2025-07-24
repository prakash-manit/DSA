using System;
using System.Collections.Generic;

namespace DSA
{
    public class LongestSubstWithoutRepChars {
        public static void Driver()
        {
            string s = "abcaabcdba";//"abcabcbb";
            Console.Write(GetLengthOfLongestSubstring(s));
        }

        private static int GetLengthOfLongestSubstring(string s) //TC: O(n), SC: O(n)
        {
            Dictionary<char, int> dict = [];
            int left = 0;
            int right = 0;
            int n = s.Length;
            int len = 0;
            while (right < n) {
                if (dict.ContainsKey(s[right])) {
                    left = Math.Max(left, dict[s[right]] + 1);
                }
                dict[s[right]] = right;
                len = Math.Max(len, right - left + 1);
                right++;
            }
            return len;        
        }
    }    
}