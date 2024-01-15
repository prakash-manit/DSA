namespace DSA
{
    class BinarySearch
    {
        /// <summary>
        /// Binary Search using Recursive method
        /// </summary>
        /// <param name="inputArray">The input array.</param>
        /// <param name="key">Value to search</param>
        /// <param name="min">Position of min number</param>
        /// <param name="max">Position of max number</param>
        /// <returns></returns>
        public static object BinarySearchRecursive(int [] inputArray, int key, int min, int max)
        {
            if (min > max)
            {
                return "Nil";
            }
            else
            {
                int mid = (min+max)/2;
                if (key == inputArray [mid])
                {
                    return ++mid;
                }
                else if (key < inputArray [mid])
                {
                    return BinarySearchRecursive(inputArray, key, min, mid - 1);
                }
                else
                {
                    return BinarySearchRecursive(inputArray, key, mid + 1, max);
                }
            }
        }

        public static object BinarySearchIterative(int[] inputArray, int key, int min, int max)
        {
            while (min <=max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return ++mid;
                }
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return "Nil";
        }
    }
}
