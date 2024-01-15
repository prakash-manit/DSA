using System.Collections.Generic;

namespace DSA
{
    class QueUsing2Stk_v2
    {
        Stack<object> oldStack;
        Stack<object> newStack;

        public QueUsing2Stk_v2()
        {
            oldStack = new Stack<object>();
            newStack = new Stack<object>();
        }

        public bool Enqueue(object data)
        {
            newStack.Push(data);
            return true;
        }

        public object Dequeue()
        {
            object topValue = -1;
            if (oldStack.Count == 0)
            {
                while (newStack.Count != 0)
                {
                    oldStack.Push(newStack.Peek());
                    newStack.Pop();
                }
            }

            if (oldStack.Count != 0)
            {
                topValue = oldStack.Peek();
                oldStack.Pop();
            }
            return topValue;
        }

        public bool IsEmpty()
        {
            if (oldStack.Count == 0 && newStack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Size()
        {
            return (oldStack.Count + newStack.Count);
        }

        public object Front()
        {
            object topValue = -1;
            if (oldStack.Count == 0)
            {
                while (newStack.Count != 0)
                {
                    oldStack.Push(newStack.Peek());
                    newStack.Pop();
                }
            }

            if (oldStack.Count != 0)
            {
                topValue = oldStack.Peek();

            }
            return topValue;
        }
    }
}
