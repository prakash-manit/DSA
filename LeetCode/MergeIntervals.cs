using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA.LeetCode
{
    public class MergeIntervals
    {
        public static void Driver(){
            //int [][] intervals = [[1,3],[2,6],[8,10],[15,18]]; //Output: [[1,6],[8,10],[15,18]]
            int [][] intervals = [[1,3],[2,6],[8,9],[9,11],[8,10],[2,4],[15,18],[16,17]]; //Output: [[1,6],[8,10],[15,18]]
            Console.Write("Before Merge:");
            for (int i = 0; i<intervals.Length; i++){
                Console.WriteLine();
                for (int j = 0; j<intervals[0].Length; j++){
                    Console.Write(intervals[i][j] + " ");
                }
            }
            int [][] interNew = DoMerge3(intervals);
            Console.Write("\n\nAfter Merge:");
            for (int i = 0; i<interNew.Length; i++){
                Console.WriteLine();
                for (int j = 0; j<interNew[0].Length; j++){
                    Console.Write(interNew[i][j] + " ");
                }
            }
        }

        private static int[][] DoMerge3(int[][] inter) //Time: O(n log n) + O(n), Space O(n)
        {            
            int n = inter.Length;
            inter = inter.OrderBy(x=>x[0]).ThenBy(x=>x[1]).ToArray();
            List <int[]> ansInter = [];

            for (int i = 0; i<n; i++){ //Time O(n)
                if (ansInter.Count == 0 || inter[i][0] > ansInter.Last()[1]){
                    ansInter.Add(inter[i]);
                }
                else {
                    ansInter.Last()[1] = Math.Max(ansInter.Last()[1], inter[i][1]);
                }
            }
            return ansInter.Select(x=>x).ToArray();
        }

        private static int[][] DoMerge2(int[][] inter) 
        {
            int n = inter.Length;
            inter = inter.OrderBy(x=>x[0]).ThenBy(x=>x[1]).ToArray();
            List <int[]> ansInter = [];

            for (int i = 0; i<n; i++){
                int start = inter[i][0];
                int end = inter[i][1];

                if (ansInter.Count!=0 && end <= ansInter.Last()[1]){
                    continue;
                }

                for (int j = i+1; j<n;j++){
                    if (inter[j][0] <= end) {
                        end = Math.Max(end, inter[j][1]);
                    }
                    else{
                        break;
                    }
                }
                ansInter.Add([start, end]);                
            }
            return ansInter.Select(x=>x).ToArray();   
        }

        private static int[][] DoMerge(int[][] inter) //Time: O(n*log n) + O(2n to n^2), Space: O(n)
        {
            int n = inter.Length;
            inter = inter.OrderBy(x=>x[0]).ThenBy(x=>x[1]).ToArray(); //Time: O(n*log n)
            IList<List<int>> ansInter = [];

            for (int i = 0; i<n; i++){
                int start = inter[i][0];
                int end = inter[i][1];

                if (ansInter.Count!=0 && end <= ansInter.Last()[1]){
                    continue;
                }

                for (int j = i+1; j<n;j++){
                    if (inter[j][0] <= end) {
                        end = Math.Max(end, inter[j][1]);
                    }
                    else{
                        break;
                    }
                }
                ansInter.Add([start, end]);                
            }
            return ansInter.Select(x=>x.ToArray()).ToArray();        
        }
    }
}