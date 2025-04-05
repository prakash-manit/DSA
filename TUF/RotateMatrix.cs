using System;

namespace DSA
{
    public class RotateMatrix
    {
        public static void Driver()
        {
            //Rotate 90% clockwise
            int [][] matrix = [[1,2,3],[4,5,6],[7,8,9]]; //Output: [[7,4,1],[8,5,2],[9,6,3]]

            Console.WriteLine("Before Rotation:");
            for (int i =0; i<matrix.Length; i++){
                for (int j = 0; j<matrix[0].Length; j++){
                    Console.Write (matrix[i][j] + " ");
                }
                Console.WriteLine();
            }

            DoRotate2(matrix);
        }

        private static void DoRotate2(int[][] matrix) //Time: O(n/2 * n/2) + O(n * n/2) = ~O(n^2), Space: O(1)
        {
            //Transpose the matrix
            for (int i =0; i<matrix.Length-1; i++){ //Time: O(n/2), traverse half of the array
                for (int j = i+1; j<matrix[0].Length; j++){ //Time: O(n/2)               
                    (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]); //element swap using tuple
                }
            }

            //Reverse the row
            for (int i =0; i<matrix.Length; i++){ //Time: O(n * n/2)
                //Array.Reverse(matrix[i]);
                ReverseArray(matrix[i]); //Time: O(n/2)
            }

            Console.WriteLine("After Rotation:");
            for (int i =0; i<matrix.Length; i++){
                for (int j = 0; j<matrix[0].Length; j++){
                    Console.Write (matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void ReverseArray(int [] nums){
            int n = nums.Length;
            for (int i = 0; i< n/2; i++){
                int temp = nums[i];
                nums[i] = nums[n-1-i];
                nums[n-1-i] = temp;
            }
        }

        private static void DoRotate(int[][] matrix) //Time: O(n^2), Space: O(n^2)
        {
            int [][] matNew = new int[matrix.Length][];

            //Initialise array
            for (int i =0; i<matrix.Length; i++){
                matNew[i] = new int[matrix[0].Length];
            }            

            //Copy the elements into a new array
            for (int i =0; i<matrix.Length; i++){
                for (int j = 0; j<matrix[0].Length; j++){                   
                    matNew[j] [matrix.Length-1-i] = matrix [i] [j];
                }
            }

           //Replace it back to the source array
           //matrix = matNew; //shallow or value copy
           //matrix = matNew.Select(x=>x.ToArray()).ToArray(); //shallow or value copy
           for (int i =0; i<matNew.Length; i++){  //Deep or ref copy
                for (int j = 0; j<matNew[0].Length; j++){
                    matrix[i][j] = matNew[i][j];
                }
           }

            Console.WriteLine("After Rotation:");
            for (int i =0; i<matrix.Length; i++){
                for (int j = 0; j<matrix[0].Length; j++){
                    Console.Write (matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}