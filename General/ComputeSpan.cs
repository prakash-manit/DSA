using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DSnA;
using ProgQues;

namespace ProgQues
{
    public class ComputeSpan
    {
        public static int [] ComputeSpan1(int [] stockArray)
        {
            int [] spanArray = new int[stockArray.Length];
            for (int i = 0; i < stockArray.Length; i++)
            {
                int k = 0;
                while ((k<=i))
                {
                    if (stockArray[i - k] <= stockArray[i])
                    {
                        k++;
                    }
                    else
                    {
                        break;
                    }
                } 
                spanArray[i] = k;
            }
            return spanArray;
        }

        public static int[] ComputeSpan2(int[] stockArray)
        {
            int[] spanArray = new int[stockArray.Length];
            Stack_Array tempStack = new Stack_Array(stockArray.Length);
            tempStack.Reset();
            bool done;
            int h;
            for (int i = 0; i < stockArray.Length; i++)
            {
                h= 0;
                done = false;
                while (!(tempStack.IsEmpty() || done))
                {
                    if (stockArray[i] >= stockArray[int.Parse(tempStack.Top().ToString())])
                    {
                        tempStack.Pop();
                    }
                    else
                    {
                        done = true;
                    }
                }
                if (tempStack.IsEmpty())
                {
                    h = -1;
                }
                else
                {
                    h = int.Parse(tempStack.Top().ToString());
                }
                spanArray[i] = i - h;
                tempStack.Push(i);
            }
            return spanArray;
        }
    }
}
