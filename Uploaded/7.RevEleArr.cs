using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA
{
    class RevArrEle
    {
        public static void Driver()
        {
            Console.WriteLine("Please insert the number of elements you want to reverse");
            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine("Please enter the elements by keeping a space");
            List<object> list = Console.ReadLine().Trim().Split(' ').ToList().Select(a => (object)(a)).ToList();

            list = reverseArrElement2(list);
            Console.WriteLine(String.Join(" ", list));
        }

        private static List<object> reverseArrElement(List<object> list)
        {
            List<object> revList = new List<object>(list.Count);
            foreach (object lst in list)
            {
                revList.Add(default);
            }

            for (int i = 0; i < list.Count; i++)
            {
                revList[i] = list[list.Count - 1 - i];
            }
            return revList;
        }

        private static List<object> reverseArrElement2(List<object> list)
        {
            object temp;
            for (int i = 0; i < list.Count / 2; i++)
            {
                temp = list[i];
                list[i] = list[list.Count - 1 - i];
                list[list.Count - 1 - i] = temp;
            }
            return list;
        }
    }
}
