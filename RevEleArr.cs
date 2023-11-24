using System;
using System.Collections.Generic;
using System.Linq;

namespace DSnA
{
    internal class RevEleArr
    {
        public static void Driver()
        {
            Console.WriteLine("Please insert the count of numbers or characters you want to reverse!");
            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine("Please insert the numbers or characters by keeping one space!");
            List<object> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => (object)(arrTemp)).ToList();

            List<object> res = RevEleArr.reverseArray(arr);

            Console.WriteLine(String.Join(" ", res));
        }

        private static List<object> reverseArray(List<object> a)
        {
            int len = a.Count;
            for (int i = 0; i < len / 2; i++)
            {
                object temp = a[i];
                a[i] = a[len-1 - i];
                a[len-1 - i] = temp;
            }
            return a;
        }
    }
}
