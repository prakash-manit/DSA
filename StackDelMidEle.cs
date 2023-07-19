using System;
using System.Collections.Generic;

namespace DSnA
{
    internal class StackDelMidEle
    {
        public static void Driver()
        {
            int testcases;// Taking testcase as input
            testcases = Convert.ToInt32(Console.ReadLine());
            while (testcases-- > 0)// Looping through all testcases
            {
                int N = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[N];
                string elements = Console.ReadLine().Trim();
                elements = elements + " " + "0";
                arr = Array.ConvertAll(elements.Split(), int.Parse);
                Stack<int> s = new Stack<int>();
                for (int i = 0; i < N; i++)
                {
                    s.Push(arr[i]);
                }
                new StackDelMidEle().deleteMid(s, N);
                while (s.Count > 0)
                {
                    Console.Write(s.Peek() + " ");
                    s.Pop();
                }
                Console.Write("\n");
            }
        }

        private void deleteMid(Stack<int> s, int sizeOfStack)
        {
            // code here

            int[] num = s.ToArray();
            s.Clear();
            int midIndex = sizeOfStack / 2;
            for (int n = sizeOfStack - 1; n >= 0; n--)
            {
                if (n == midIndex)
                {
                    continue;
                }
                else
                {
                    s.Push(num[n]);
                }
            }
        }
    }
}
