using System;
using System.Collections.Generic;
using System.Linq;

namespace DSnA
{
    internal class HourglassSumArr
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
            int sum = 0;

            //Using array of arrays
            for (int i = 0; i < arr.Count - 2; i++)
            {
                for (int j = 0; j < arr[i].Count - 2; j++)
                {
                    int tempSum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];

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

            ////Using 2D Array
            //int[,] arr2 = new int[arr.Count, arr[0].Count];
            //for (int i = 0; i < arr.Count; i++)
            //{
            //    for (int j = 0; j < arr[i].Count; j++)
            //    {
            //        arr2[i, j] = arr[i][j];
            //    }
            //}

            //for (int i = 0; i < arr2.GetLength(0) - 2; i++)
            //{
            //    for (int j = 0; j < arr2.GetLength(1) - 2; j++)
            //    {
            //        int tempSum = arr2[i, j] + arr2[i, j + 1] + arr2[i, j + 2] + arr2[i + 1, j + 1] + arr2[i + 2, j] + arr2[i + 2, j + 1] + arr2[i + 2, j + 2];

            //        if (i == 0 && j == 0)
            //        {
            //            sum = tempSum; //Initialize for the first time
            //        }

            //        if (tempSum > sum)
            //        {
            //            sum = tempSum;
            //        }
            //    }
            //}

            return sum;
        }
    }
}
