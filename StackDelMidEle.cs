using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSnA
{
    internal class StackDelMidEle
    {
        public void deleteMid(Stack<int> s, int sizeOfStack)
        {
            // code here

            int[] num = s.ToArray();
            s.Clear();
            int midIndex = sizeOfStack / 2;
            for (int n = sizeOfStack - 1; n >= 0; n--)
            {
                if (n == midIndex)
                {
                    continue;
                }
                else
                {
                    s.Push(num[n]);
                }
            }

        }
    }
}
