using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA
{
    public class FourSum
    {
        public static void Driver()
        {
            int [] nums = [2,2,2,2,2]; //[1,0,-1,0,-2,2];
            int target = 8; //0;
            IList<IList<int>> res = GetFourSum3(nums, target);
            for (int i =0; i< res.Count; i++){
                for (int j = 0; j<res[0].Count; j++){
                    Console.Write(res[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static IList<IList<int>> GetFourSum3(int[] nums, int target) //TC: ~O(n^3), SC: O(no of quads)*2
        {
            int n = nums.Length;
            List<IList<int>> fList = [];
            Array.Sort(nums);
            
            for (int i = 0; i<n; i++) {
                if (i>0 && nums[i] == nums[i-1]) continue;
                for (int j = i+1; j<n; j++) {
                    if (j != (i+1)  && nums[j] == nums[j-1]) continue;
                    int k = j+1;
                    int l = n-1;
                    while (k < l) {
                        long sum = nums[i] + nums[j];
                        sum += nums[k];
                        sum += nums[l];
                        if (sum == target) {
                            IList<int> tList = [nums[i], nums[j], nums[k], nums[l]];
                            fList.Add(tList);
                            k++;
                            l--;
                            while (k<l && nums[k] == nums[k-1]) k++;
                            while (k<l && nums[l] == nums[l+1]) l--;
                        }
                        else if (sum < target) k++;
                        else l--;
                    }
                }
            }
            return fList;
        }

        private static IList<IList<int>> GetFourSum2(int[] nums, int target) //TC: O(n^3 * log n), SC: O(n) + O(no of quads)*2
        {
            int n = nums.Length;
            List<IList<int>> fList = [];
            List<string> uList = [];
            for (int i = 0; i<n; i++) {
                for (int j = i+1; j<n; j++) {
                    HashSet<long> hashSet = [];
                    for (int k = j+1; k<n; k++) {
                        long sum = nums[i] + nums[j];
                        sum += nums[k];
                        long fourth = Convert.ToInt64(target)-sum;                        
                        if (hashSet.Contains(fourth)) {
                            IList<int> tList = [nums[i], nums[j], nums[k], (int)fourth];                                
                            tList = (from c in tList orderby c select c).ToList();                              
                            string val = string.Empty;
                            foreach (int num in tList) {
                              val += num.ToString();
                            }                                
                            if (!uList.Contains(val)) {
                                uList.Add(val);
                                fList.Add(tList);
                            }
                        }
                        hashSet.Add(nums[k]);
                    }
                }
            }            
            return fList;
        }

        private static IList<IList<int>> GetFourSum(int[] nums, int target) //TC: O(n^4 * log n), SC: O(no of quads)*2
        {
            int n = nums.Length;
            List<IList<int>> fList = [];
            List<string> uList = [];
            for (int i = 0; i<n; i++) {
                for (int j = i+1; j<n; j++) {
                    for (int k = j+1; k<n; k++) {
                        for (int l = k+1; l<n; l++) {
                            if (nums[i] + nums[j] + nums[k] + nums[l] == target){
                                IList<int> tList = [nums[i], nums[j], nums[k], nums[l]];                                
                                tList = (from c in tList orderby c select c).ToList(); //IEnumerable<int> tList2 = tList.OrderBy(x=>x);                               
                                string val = string.Empty;
                                foreach (int num in tList) {
                                  val += num.ToString();
                                }                                
                                if (!uList.Contains(val)) {
                                    uList.Add(val);
                                    fList.Add(tList);
                                }
                            }
                        }
                    }
                }
            }
            return fList;       
        } 
    }    
}