using System;
using System.Collections.Generic;

namespace DSA.TUF
{
    public class UniquePaths
    {
        public static void Driver()
        {
            int m =3; //3
            int n= 2; //7
            Console.WriteLine(GetUniquePaths3(m, n));
        }

        private static int GetUniquePaths3(int m, int n) //TC: O(m-1), SC: O(1)
        { 
            int N = m + n- 2;
            int r = m-1;
            double res = 1;
           
            for (int i = 1; i <=r; i++) {
                res =  res * (N - r + i)/ i;               
            }
            return (int) res;        
        }

        private static int GetUniquePaths2(int m, int n) //TC: O(m+n) due to memoization, SC: O(m+n)
        { 
            List<List<int>> dp = [];           
           
            for (int i = 0; i <m; i++) {
                List<int> row = [];
                dp.Add(row);
                for (int j = 0; j <n; j++) {
                    dp[i].Add(-1);
                }                    
            }

            return CountPathsRec2(0,0, m, n, dp);
        }

        private static int CountPathsRec2(int i, int j, int m, int n, List<List<int>> dp)
        {
            if (i==m-1 && j==n-1) return 1;
            if (i >=m || j>=n) return 0;
            if (dp[i][j] != -1) return dp[i][j];
            else return dp[i][j] = CountPathsRec2(i+1, j, m, n, dp) + CountPathsRec2(i, j+1, m, n, dp);
        }

        private static int GetUniquePaths(int m, int n) //TC: O(2^(m+n)), SC: O(m+n)
        {       
            return CountPathsRec(0,0, m, n);
        }

        private static int CountPathsRec(int i, int j, int m, int n)
        {
            if (i==m-1 && j==n-1) return 1;
            if (i >=m || j>=n) return 0;
            else return CountPathsRec(i+1, j, m, n) + CountPathsRec(i, j+1, m, n);
        }
    }
}