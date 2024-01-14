// -----------------------------------------------------------------------
// <copyright file="Sort.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

using System;

namespace ProgQues
{
    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Sort
    {
        //O(n2)
        public void BubbleSort(int[] arr)
        {
            Console.WriteLine("Before Sort");
            foreach (int a in arr)
                Console.WriteLine(a);
            int  t = 0;

            for (int i = arr.Length - 1; i >=0; i--)
            {
                for (int j = 0; j < i ; j++)
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

        public void InsertionSort(int [] arr)
        {
            Console.WriteLine("Before Sort");
            foreach (int a in arr)
                Console.WriteLine(a);

            int temp = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = i - 1; j >= 0 && arr[j] > arr[j+1]; j--)
                {
                    temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }

            }
           
            Console.WriteLine("After Sort");
            foreach (int a in arr)
                Console.WriteLine(a);
        }
    }
}
