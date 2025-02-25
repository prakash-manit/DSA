using System;

namespace DSA
{
    class SquareRoot
    {
        public static float FindSquareRoot1(int number)
        {
            float result = 0;
            float diff = 0;
            float minDiff = Math.Abs(result * result - number);
            int count = 0;
            float tempResult = 0;
            while (true)
            {
                tempResult = Convert.ToSingle(count) / 1000;
                diff = Math.Abs(tempResult * tempResult - number);

                if (diff <= minDiff)
                {
                    minDiff = diff;
                    result = tempResult;
                }
                else
                    return result;
                count++;
            }
        }

        public static float FindSquareRoot_BS(int number)
        {
            float precision = 0.0001f;
            float min = 0;
            float max = number;
            float result = 0;
            int count = 0;

            while (max - min > precision)
            {
                result = (min + max) / 2;
                if ((result * result) >= number)
                {
                    max = result;
                }
                else
                {
                    min = result;
                }
                count++;
            }
            return count;
        }
    }
}
