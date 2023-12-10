using System;

namespace DSnA
{
    internal class RemEleArr
    {
        // Driver Code
        public static void Driver()
        {
            int i;
            int[] arr = { 10, 50, 30, 40, 20 };

            int n = arr.Length;
            int delEle = 30;

            Console.Write("Array before deletion ");
            for (i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();

            // Delete function call
            n = deleteElement(arr, n, delEle);

            Console.Write("Array after deletion ");
            for (i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
        }

        private static int FindElement(int[] arr, int n, int delEle)
        {
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == delEle)
                {
                    return i;
                }
            }
            return -1;
        }

        static int deleteElement(int[] arr, int n, int delEle)
        {
            //check if element to delete is present in the array
            int pos = FindElement(arr, n, delEle);
            if (pos == -1)
            {
                Console.WriteLine("Element not found!!");
            }
            else
            {
                for (int i = pos; i < n - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
            }

            return n - 1;
        }
    }
}
