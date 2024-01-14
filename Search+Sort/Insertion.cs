using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgQues
{
    public class Insertion
    {
        //Return sorted array using Insertion Sort
        public static int[] InsertionSort(int[] arr)
        {           
            int temp = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = i - 1; j >= 0 && arr[j] > arr[j + 1]; j--)
                {
                    temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
            return arr;
        }
    }
}
