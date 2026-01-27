using System;

namespace DSA;

public class JumpGame
{
    public static void Driver()
    {
        int[] nums = [3,2,1,0,4]; // {2,3,1,1,4};
        Console.Write(CanJump(nums));
    }

    private static bool CanJump(int[] nums) //Time: O(n), Space: O(1)
    {
        int jumpIndex = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (i > jumpIndex) return false;
            jumpIndex = Math.Max(jumpIndex, i + nums[i]);
        }

        return true;
    }
}