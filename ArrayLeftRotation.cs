using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSnA
{
    internal class ArrayLeftRotation
    {
        public static void Driver()
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int d = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> result = rotateLeft(d, arr);

            Console.WriteLine(String.Join(" ", result));
        }

        //private static List<int> rotateLeft (int d, List<int> arr) //Brute force 0(n^2)
        //{
        //    for (int i = 0; i < d; i++)
        //    {
        //        int temp = arr[0];
        //        for (int j = 0; j < arr.Count - 1; j++)
        //        {
        //            arr[j] = arr[j + 1];
        //        }
        //        arr[arr.Count - 1] = temp;
        //    }      

        //    return arr;
        //}

        private static List<int> rotateLeft(int d, List<int> arr) //Optimised solution 0(n)
        {
            List<int> result = new List<int>();
            int count = 0;

            for (int i = d; i < arr.Count; i++)
            {
                result.Insert(count++,arr[i]);
            }

            for (int i = 0; i < d; i++)
            {
                result.Insert(count++, arr[i]);
            }
            return result;
        }
    }
}
