using System;
using System.Collections.Generic;

namespace DSA;

public class JumpGame2
{
    public static void Driver()
    {
        int[] nums = [1,2,1,1,1]; // {2,3,0,1,4};
        List<int> dp = new List<int>(nums.Length);
            for (int i = 0; i < nums.Length; i++)
            {
                dp.Add(-1);
            }
        //Console.Write(GetJumpSteps1(nums, 0, 0));
        //Console.Write(GetJumpSteps2(nums,dp, 0));
        Console.Write(GetJumpSteps3(nums));
    }

    private static int GetJumpSteps3(int[] nums) //Time: O(n), Space: O(1)
    {
        int jumpSteps = 0;
        int currEnd = 0;
        int farthest = 0;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            farthest = Math.Max(farthest, i + nums[i]);
            if (i == currEnd)
            {
                jumpSteps++;
                currEnd = farthest;
            }
        }

        return jumpSteps;
    }

    private static int GetJumpSteps2(int[] nums,List<int> dp, int idx) //Time: O(n^2), Space: O(n^2)
    {
        int n = nums.Length-1;
        
        if (idx >=n ) return 0; //No more jumps needed to reach the end
        if (dp[idx]!= -1) return dp[idx];
        
        int min = int.MaxValue-1;
        for (int i = 1; i<= nums[idx]; i++) {
            min = Math.Min(min, 1+ GetJumpSteps2(nums, dp, idx+i));
        }

        return dp[idx] = min;
    }

    private static int GetJumpSteps1(int[] nums, int idx, int jumps) //Time: O(c^n), Space: O(n)
    {
        if (idx >= nums.Length-1){
            return jumps;
        }
        
        int min = int.MaxValue;
        for (int i = 1; i<= nums[idx]; i++) {
            min = Math.Min(min, GetJumpSteps1(nums, idx+i, jumps+1));
        }

        return min;
    }
}