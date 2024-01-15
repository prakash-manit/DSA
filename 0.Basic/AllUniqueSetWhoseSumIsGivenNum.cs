using System;
using System.Collections.Generic;

namespace DSA
{
    class AllUniqueSetWhoseSumIsGivenNum
    {
        public static void GetAllUniqueSetWhoseSumIsGivenNumber(int num)
        {
            Dictionary <int,int> dict = new Dictionary <int,int>();
            for (int i = 1; i<=num; i++)
            {
                for (int j = 1; j<=num; j++)
                {
                    if (i + j == num)
                    {
                        Console.WriteLine("{0} + {1} = {2}", i, j, num);
                    }
                }
            }
        }
    }
}
