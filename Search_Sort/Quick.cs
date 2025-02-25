namespace DSA
{
    class Quick
    {
        public static int[] QuickSort_Rec(int[] inputArray, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(inputArray, left, right);
                QuickSort_Rec(inputArray, left, pivot - 1);
                QuickSort_Rec(inputArray, pivot + 1, right);
            }
            return inputArray;
        }

        private static int Partition(int[] inputArray, int left, int right)
        {
            int pivot = inputArray[right];
            int temp = 0;
            while (true)
            {
                while (inputArray[right] > pivot)
                    right--;
                while (inputArray[left] < pivot)
                    left++;
                if (left < right)
                {
                    temp = inputArray[right];
                    inputArray[right] = inputArray[left];
                    inputArray[left] = temp;
                }
                else
                    return right;
            }
        }       
    }
}
