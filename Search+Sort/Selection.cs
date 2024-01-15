// -----------------------------------------------------------------------
// <copyright file="Selection.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace DSA
{
    using System;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Selection
    {
        public void SelectionSort(int[] arr)
        {
            Console.WriteLine("Before Sort");
            foreach (int a in arr)
                Console.WriteLine(a);

            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int index_of_min = i;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[index_of_min] > arr[j])
                    {
                        index_of_min = j;
                    }
                }

                temp = arr[i];
                arr[i] = arr[index_of_min];
                arr[index_of_min] = temp;
            }

            Console.WriteLine("After Sort");
            foreach (int a in arr)
                Console.WriteLine(a);
        }
    }
}
