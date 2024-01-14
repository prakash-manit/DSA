using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgQues
{
    public class PrefixAverage
    {
        //Complexity is O(n2)
        public static float[] PrefixAverages1(int[] tempA, int n)
        {
            float[] tempB = new float[tempA.Length];
            for (int i = 0; i < n; i++)
            {
                float sum = 0;
                for (int j = 0; j <= i; j++)
                {
                    sum = sum + tempA[j];
                }
                tempB[i] = sum / (i + 1);
            }
            return tempB;
        }

        //Complexity is O(n)
        public static float[] PrefixAverages2(int[] tempA, int n)
        {
            float[] tempB = new float[tempA.Length];
            float sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = sum + tempA[i];
                tempB[i] = sum / (i + 1);
            }
            return tempB;
        }
    }
}
