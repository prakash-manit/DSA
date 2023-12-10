using System;
using System.Linq;

namespace DSnA
{
    public class Stack_Array
    {
        private int MaxElement = 6;
        private int _top = -1;
        private object[] _customStack;

        public Stack_Array()
        { _customStack = new object[MaxElement]; }

        public Stack_Array(int n)
        {
            _customStack = new object[n];
            MaxElement = n;
        }

        public int Size()
        {
            return _top + 1;
        }

        public void Reset()
        {
            _customStack.ToList().Clear();
            _top = -1;
        }

        public bool IsEmpty()
        {
            return (_top < 0);
        }

        public void Push(object obj)
        {
            if (Size() == MaxElement)
            {
                Console.WriteLine("Stack is full");
                return;
            }
            _customStack[++_top] = obj;
        }

        public object Top()
        {
            return IsEmpty() ? "Stack is empty" : _customStack[_top];
        }

        public object Pop()
        {
            if (IsEmpty())
            {
                return "Stack is empty";
            }
            object element = _customStack[_top];
            _customStack[_top--] = null;
            return element;
        }
    }
}
