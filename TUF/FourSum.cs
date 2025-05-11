using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA.TUF
{
    public class FourSum
    {
        public static void Driver()
        {
            int [] nums = [1,0,-1,0,-2,2]; // [2,2,2,2,2];
            int target = 0; //8;
            IList<IList<int>> res = GetFourSum(nums, target);
            for (int i =0; i< res.Count; i++){
                for (int j = 0; j<res[0].Count; j++){
                    Console.Write(res[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static IList<IList<int>> GetFourSum(int[] nums, int target) 
        {
            int n = nums.Length;
            List<IList<int>> fList = [];
            for (int i = 0; i<n; i++) {
                for (int j = i+1; j<n; j++) {
                    for (int k = j+1; k<n; k++) {
                        for (int l = k+1; l<n; l++) {
                            if (nums[i] + nums[j] + nums[k] + nums[l] == target){
                                IList<int> tList = [nums[i], nums[j], nums[k], nums[l]];
                                IEnumerable<int> sortedEnum = tList.OrderBy(x=>x);
                                fList.Add(sortedEnum.ToList());
                            }
                        }
                    }
                }
            }
            return fList;       
        } 
    }    
}