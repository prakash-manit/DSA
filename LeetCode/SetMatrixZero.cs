using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA.LeetCode
{
    public class SetMatrixZero
    {
        public static void Driver ()
        {
            int[][] matrix = [[1, 1, 1], [1, 0, 1], [1, 1, 1]]; 
            //output: [1,0,1],[0,0,0],[1,0,1]

            //int[][] matrix = [[0,1,2,0], [3,4,5,2], [1,3,1,5]];
            //output: [0,0,0,0],[0,4,5,0],[0,3,1,0]

            //int[][] matrix = [[-1],[2],[3]];
            //output: [[-1],[2],[3]]
            SetZeroes3(matrix); 
        }    

        private static void SetZeroes3(int[][] matrix) //Time: O(m*n) + O(m*n) + O(m) + O(n) = ~O(n^2), Space: O(1)
        {
            //int [] markedRow = new int[matrix.Length]; //matrix [][0]
            //int [] markedCol = new int[matrix[0].Length]; //matrix [0][]
            int col0 = 1;
            for (int i = 0; i < matrix.Length; i++) {
                for (int j = 0; j < matrix[i].Length; j++) {
                    if (matrix[i][j] == 0){
                        //mark the i'th row and j'th col
                        matrix [i][0] = 0;
                        if (j!= 0){
                            matrix [0][j] = 0;
                        }else{
                            col0= 0;
                        }
                    }
                }
            }

            for (int i = 1; i < matrix.Length; i++) {
                for (int j = 1; j < matrix[i].Length; j++) {
                    if (matrix [i][j] != 0){
                        //check for row and col
                        if (matrix[i][0] == 0 || matrix [0][j] == 0){
                            matrix [i][j] = 0;
                        }
                    }
                }
            }

            if (matrix[0][0] == 0)
            {
                for (int j = 1; j< matrix[0].Length; j++) {
                    matrix[0][j] = 0;
                }
            }

            if (col0 == 0)
            {
                for (int i = 0; i< matrix.Length; i++) {
                    matrix[i][0] = 0;
                }
            }         
            
            PrintMatrix(matrix);
    }

        private static void SetZeroes2(int[][] matrix) //Time: O(m*n) + O(m*n) = ~O(n^2), Space: O(m + n) ~O(n)
        {
            int [] markedRow = new int[matrix.Length];
            int [] markedCol = new int[matrix[0].Length];

            for (int i = 0; i < matrix.Length; i++) {
                for (int j = 0; j < matrix[i].Length; j++) {
                    if (matrix[i][j] == 0){
                        markedRow[i] = 1;
                        markedCol[j] = 1;
                    }
                }
            }

            for (int i = 0; i < matrix.Length; i++) {
                for (int j = 0; j < matrix[i].Length; j++) {
                    if (markedRow[i] == 1 || markedCol[j] == 1 ) {
                        matrix[i][j] = 0;
                    }
                }
            }
            PrintMatrix(matrix);
        }    

        private static void SetZeroes1(int[][] matrix) //Time: O((m*n) * (m+n)) + O(m*n) = ~O(n^3), Space: O(1)
        {
            //O(m*n)
            for (int i = 0; i < matrix.Length; i++) {
                for (int j = 0; j < matrix[i].Length; j++) {
                    if (matrix[i][j] == 0)
                    {
                        MarkRowColTemp(matrix, i, j);                    
                    }
                }            
            }

            //MarkRowColZero
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j< matrix[i].Length; j++)
                {
                    if (matrix [i][j] == -999) {
                        matrix [i] [j] = 0;
                    }
                    if (matrix [i][j] == -999) {
                        matrix [i] [j] = 0;
                    }
                }
            }        
            PrintMatrix(matrix);        
        }

        private static void MarkRowColTemp(int[][] matrix, int row, int col) //O(m+n)
        {
            //Mark row
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (matrix [row][j] != 0) {
                    matrix [row] [j] = -999;
                }    
            }

            //Mark col
            for (int i = 0; i< matrix.Length; i++)
            {
                if (matrix [i][col] != 0) {
                    matrix [i] [col] = -999;
                }
            }
        }

        private static void PrintMatrix(int[][] matrix)
        {
            for (int i = 0; i< matrix.Length; i++) 
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();  
            }
        }
    }
}