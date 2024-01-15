// -----------------------------------------------------------------------
// <copyright file="Bubble.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace DSA
{
    using System;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Bubble
    {
        public void BubbleSort(int[] arr)
        {
            Console.WriteLine("Before Sort");
            foreach (int a in arr)
                Console.WriteLine(a);
            
            int t = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        t = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = t;
                    }
                }
            }

            Console.WriteLine("After Sort");
            foreach (int a in arr)
                Console.WriteLine(a);
        }
    }
}
