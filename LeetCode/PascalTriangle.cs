using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA
{
    public class PascalTriangle
    {
        public static void Driver()
        {
            //Que-1: Given row and col, find the element in that place.
            //Ex: If row = 5, col = 3, then output = 6
            //Console.WriteLine(GetPascalElement(5, 3));

            //Que-2: Print any nth row by passing col
            //Ex: if n= 5, then output should be: 1 4 6 4 1
            // IList<int> list = GetPascalRow(6);
            // for (int i = 0; i<list.Count; i++) {
            //     Console.Write(list[i] + " ");
            // }
            

            //Que-3: Give the number of now, print the entire pascal triangle
            //Ex: numRows = 5, output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]
            IList<IList<int>> list = GeneratePascalTriangle(6);
            for (int i = 0; i<list.Count; i++) {
                Console.WriteLine();
                for (int j = 0; j<list[i].Count; j++) {
                    Console.Write(list[i][j] + " ");
                }
            }
        }

        private static IList<IList<int>> GeneratePascalTriangle(int row) 
        {       
            IList<IList<int>> list = new List<IList<int>>();
            //Brute -Time: O(n*n*r) = ~O(n^3), Space: NA, since new collection types are created to return data, not compute
            // for (int i = 1; i<= row; i++) {
            // IList<int> tempList= new List<int>();
            //     for (int j = 1; j<= i; j++) {
            //         int ele = GetPascalElement(i, j);
            //         tempList.Add(ele);   
            //     }
            //     list.Add(tempList);
            // }

            //Better- Time: O(n*n) ~ O(n^2)
            for (int i = 1; i<= row; i++) {
                list.Add(GetPascalRow(i));
            }

            return list;        
        }

        private static IList<int> GetPascalRow(int row)
        {
            IList<int> list = new List<int>();
            //Brute - Calling the PrintPascalElement for entire row, In pascal triangle, At each given row, no of col is same, for ex: row 6 has 6 col
            //Time: O(n*r), Space: O(1)
            // for (int col = 1; col<= row; col++)
            // {
            //     list.Add(GetPascalElement(row, col));
            // } 

            //Better
            //Time: O(n), Space: O(1)
            int res = 1;
            list.Add(res);       
            for (int col = 1; col < row; col++)
            {
                res = res * (row - col);
                res = res/ col;
                list.Add(res);
            }
            return list;
        }

        private static int GetPascalElement(int row, int col) 
        {
            int res = 1;
            int n = row-1;
            int r = col-1;
            
            //Better: row C col -> n C r -> 10 C 3 = 10*9*8 / 3*2*1
            //Time: O(r), Space: O(1)
            for (int i = 0; i< r; i++) {
                res = res * (n-i);
                res = res/ (i+1);
            }

            //Brute - row-1 C col-1 -> n C r -> fact(n)/ (fact(r) * fact(n-r))
            //Time: O(n) + O(r) + O(n-r), Space: o()
            // res = Fact(n)/ (Fact(r) * Fact(n-r));
        return res;     
        }

        private static int Fact(int num) 
        {
            int result = 1;
            for (int i = num; i>0; i--) {
                result = result*i;
            }
            return result;

            // if (num == 0) {
            //     return 1;
            // } else
            // {
            //     return num* Fact(num-1);
            // }
        }
    }
}