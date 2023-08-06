using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSnA
{
    internal class ArrayHourglassSum
    {
        public static void Driver()
        {
            

            List<List<int>> list = new List<List<int>>();

            for (int i = 0; i < 6; i++)
            {
                list.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }           

            int result = GethourglassSum(list);

            Console.WriteLine(result);
        }

        private static int GethourglassSum(List<List<int>> arr)
        {
            //int[,] arr = list.Select(a => a.ToArray()).ToArray();

            int sum = 0;
            
            for (int i = 0; i < arr.Count-2; i++)
            {
                for (int j = 0; j < arr[i].Count-2; j++)
                {
                    int tempSum = arr[i][j] + arr[i][j+1] + arr[i][j+2] + arr[i+1][j+1] + arr[i+2][j] + arr[i+2][j+1]+ arr[i+2][j+2];
                    
                    if (i == 0 && j == 0)
                    {
                        sum = tempSum; //Initialize for the first time
                    }
                   
                    if (tempSum > sum)
                    {
                        sum = tempSum;
                    }
                }
            }
            
            return sum;
        }
    }
}
