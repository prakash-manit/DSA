using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA
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
            
            int n = arr.Length;

            Console.Write("Before Insertion: ");
            for (int i = 0; i < n-1; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();

            Console.Write("Plz enter the position followed by value, that to be inserted!");

            List<int> input = Console.ReadLine().Split(' ').ToList().Select(x => Convert.ToInt32(x)).ToList();
            int pos = input[0];
            int x = input[1];

            // Inserting key at specific position
            //insertElement(arr, n, x, pos);
            insertElement2(arr, n, x, pos);

            Console.Write("\n\nAfter Insertion: ");
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
        }

        private static void insertElement(int[] arr, int n, int x, int pos)
        {
            for (int i = 0; i <= n; i++)
            {
                if (i == pos)
                {
                    int counter = n-1;
                    while (counter > i)
                    {
                        arr[counter] = arr[counter - 1];
                        counter--;
                    }
                    arr[i] = x;
                }
            }
        }

        private static void insertElement2(int[] arr, int n, int x, int pos)
        {
            //Move the elements to the right until Pos index
            for (int i = n - 2; i >= pos; i--)
            {
                arr[i + 1] = arr[i];
            }
            arr[pos] = x;
        }
    }
}
