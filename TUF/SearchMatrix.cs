using System;

namespace DSA.TUF
{
    public class SearchMatrix
    {
        public static void Driver()
        {
            //Each row is sorted in non-decreasing order.
            //The first integer of each row is greater than the last integer of the previous row.
            int [][] matrix  = [[1,3,5,7],[10,11,16,20],[23,30,34,60]];
            int target = 33;
            
            Console.Write(DoSearchMatrix3(matrix,target));
        }

        private static bool DoSearchMatrix3(int[][] matrix, int target) //Time: O(log m*n), Space: O(1)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;

            int min = 0;
            int max = m * n - 1; //Virtual 2D array
            while (min <= max) {
                int mid = (min + max) / 2;
                //Virtually convert 1D to 2D array and find out row and col
                int row = mid/n; //How many row gone by
                int col = mid%n; //The reminder to find index
                if (target == matrix[row][col]) {
                    return true;
                }
                else if (target < matrix[row][col]) {
                    max = mid - 1;
                }
                else {
                    min = mid + 1;
                }
            }
            return false;
        }

        private static bool DoSearchMatrix2(int[][] matrix, int target) //Time: O(m*log n), Space: O(1)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            for (int i = 0; i<m; i++){
                if (matrix[i][0] <= target && target<= matrix[i][n-1]){
                    return BinarySearch(matrix[i], target);
                }
            }
            return false;
        }

        public static bool BinarySearch(int[] inputArray, int target)
        {
            int min = 0;
            int max = inputArray.Length-1;
            while (min <= max) {
                int mid = (min + max) / 2;
                if (target == inputArray[mid]) {
                    return true;
                }
                else if (target < inputArray[mid]) {
                    max = mid - 1;
                }
                else {
                    min = mid + 1;
                }
            }
            return false;
        }

        private static bool DoSearchMatrix(int[][] matrix, int target) //Time: O(m*n), Space: O(1)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            for (int i = 0; i< m; i++){
                for (int j = 0; j< n; j++){
                    if (matrix[i][j] == target){
                        return true;
                    }
                }
            }
            return false;
        }
    }
}