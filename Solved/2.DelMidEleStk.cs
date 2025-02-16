using System;
using System.Collections.Generic;

namespace DSA
{
    internal class DelMidEleStk
    {
        public static void Driver()
        {
            Console.WriteLine("Please enter the size of stack!");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the elements of stack one by one!");
            Stack<int> stk = new Stack<int>();
            for (int i = 0; i < m; i++)
            {
                stk.Push(Convert.ToInt32(Console.ReadLine()));
            }

            deleteMidEle(stk);

            Console.WriteLine("Stack elements after deletion!");
            while (stk.Count > 0)
            {
                Console.WriteLine(stk.Pop());
            }
        }

        private static void deleteMidEle(Stack<int> stk)
        {
            int[] num = stk.ToArray();
            int size = stk.Count;
            int midIndex = size / 2;
            stk.Clear();
            for (int i = size - 1; i >= 0; i--)
            {
                if (i == midIndex)
                {
                    continue;
                }
                else
                {
                    stk.Push(num[i]);
                }
            }
        }
    }
}
