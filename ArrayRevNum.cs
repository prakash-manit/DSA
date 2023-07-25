using System;
using System.Collections.Generic;
using System.Linq;

namespace DSnA
{
    internal class ArrayRevNum
    {
        public static void Driver()
        {
            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> res = ArrayRevNum.reverseArray(arr);

            Console.WriteLine(String.Join(" ", res));
        }

        private static List<int> reverseArray(List<int> a)
        {
            int len = a.Count;
            for (int i = 0; i < len / 2; i++)
            {
                int temp = a[i];
                a[i] = a[len-1 - i];
                a[len-1 - i] = temp;
            }
            return a;
        }
    }
}
