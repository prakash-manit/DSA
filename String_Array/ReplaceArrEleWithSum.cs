using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewQues
{
    class ReplaceArrEleWithSum
    {
        public static int [] ReplaceArrayElementWithSum1(int[] A1)
        {
            int sum = 0;
            int[] A2 = new int[A1.Length];
            for (int i = 0; i<A1.Length; i++)
            {
                sum = sum + A1[i];
            }

            A2[0] = sum;
            for (int i = 0; i < A1.Length; i++)
            {
                if (i == 0)
                {
                    A2[i] = sum;
                }
                else
                {
                    A2[i] = A2[i - 1] - A1[i - 1];
                }         
            }
            return A2;
        }

        public static int[] ReplaceArrayElementWithSum2(int[] A1)
        {
            for (int i = A1.Length-2; i>=0; i--)
            {         
                    A1[i] = A1[i] + A1[i + 1];                                             
            }
            return A1;
        }
    }
}
