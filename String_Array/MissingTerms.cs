using System;
using System.Linq;

namespace DSA
{
    class MissingTerms
    {
        internal static void PrintMissingTerms(int[] inputArray)
        {
            int difference = 0;
            int first = 0;
            int second = 0;
            for (int i = 0; i < (inputArray.Length - 1); i++)
            {
                first = inputArray[i];
                second = inputArray[i + 1];
                //find minimum difference of all terms
                if (difference == 0)
                {
                    difference = Math.Abs(second - first);
                }
                else
                {
                    difference = Math.Min(difference, Math.Abs(second - first));
                }
            }

            bool isAsc = inputArray[0] < inputArray[1] ? true : false;
            int last = inputArray.Last();
            int nextNumber = isAsc ? inputArray.First() + difference : inputArray.First() - difference;

            while (nextNumber != last)
            {
                if (!inputArray.Contains(nextNumber))
                {
                    Console.WriteLine(nextNumber);
                }
                nextNumber = isAsc ? nextNumber + difference : nextNumber - difference;
            }
        }

        internal static void PrintMissingTerm(int[] inputArray)
        {
            int difference = (inputArray.Last() - inputArray.First())/inputArray.Length;
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                if (inputArray[i + 1] != inputArray[i] + difference)
                {
                    Console.WriteLine(inputArray[i] + difference);
                }
            }
            
        }
    }
}
