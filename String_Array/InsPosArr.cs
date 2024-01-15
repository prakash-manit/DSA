using System;

namespace DSnA
{
    internal class InsPosArr
    {
        public static void Driver()
        {
            int[] arr = new int[6];
            arr[0] = 2;
            arr[1] = 4;
            arr[2] = 1;
            arr[3] = 8;
            arr[4] = 5;
            int x = 10;
            int n = 5;
            int pos = 2;

            Console.Write("Before Insertion: ");
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();

            // Inserting key at specific position
            insertElement(arr, n, x, pos);
            n += 1;

            Console.Write("\n\nAfter Insertion: ");
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
        }

        private static void insertElement(int[] arr, int n, int x, int pos)
        {
            //Move the elements to the right until Pos index
            for (int i = n - 1; i >= pos; i--)
            {
                arr[i + 1] = arr[i];
            }
            arr[pos] = x;

            //for (int i = 0; i < n; i++)
            //{
            //    if (i == pos)
            //    {
            //        int counter = n;
            //        while (counter > i)
            //        {
            //            arr[counter] = arr[counter - 1];
            //            counter--;
            //        }
            //        arr[i] = x;
            //    }
            //}
        }
    }
}
