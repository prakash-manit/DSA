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
            
            Console.Write("Before Insertion: ");
            for (int i = 0; i < arr.Length - 1; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();

            Console.Write("Plz enter the position followed by value, that to be inserted!");

            List<int> input = Console.ReadLine().Split(' ').ToList().Select(x => Convert.ToInt32(x)).ToList();
            
            int pos = input[0];
            if (pos < 0 || pos > arr.Length - 1)
            {
                Console.WriteLine("Invalid index position. Plz try again!!");
                return;
            }

            int x = input[1];

            // Inserting key at specific position
            //insertElement(arr, x, pos);
            insertElement(arr, x, pos);

            Console.Write("\n\nAfter Insertion: ");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }

        private static void insertElement(int[] arr, int x, int pos)
        {
            for (int i = 0; i <= arr.Length; i++)
            {
                if (i == pos)
                {
                    int counter = arr.Length- 1;
                    while (counter > i)
                    {
                        arr[counter] = arr[counter - 1];
                        counter--;
                    }
                    arr[i] = x;
                }
            }
        }

        private static void insertElement2(int[] arr, int x, int pos)
        {
            //Move the elements to the right until Pos index
            for (int i = arr.Length - 2; i >= pos; i--)
            {
                arr[i + 1] = arr[i];
            }
            arr[pos] = x;
        }
    }
}
