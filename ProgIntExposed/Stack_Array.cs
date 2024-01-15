// -----------------------------------------------------------------------
// <copyright file="Stack_Array.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace DSA
{
    public class Stack_Array
    {
        private const int MAX_ELEMENT = 5;
        object[] Stack = new object[MAX_ELEMENT];
        int currentIndex = -1;

        public object Push(object item)
        {
            if (currentIndex == MAX_ELEMENT - 1)
            {
                return "Stack is full";
            }

            ++currentIndex;
            Stack[currentIndex] = item;
            return item;
        }

        public object Pop()
        {
            if (currentIndex == -1)
            {
                return "Stack is empty";
            }

            var deletedItem = Stack[currentIndex];
            Stack[currentIndex] = null;
            --currentIndex;
            return deletedItem;
        }

        public object Peek()
        {
            if (currentIndex == -1)
            {
                return "Stack is empty";
            }
            return Stack[currentIndex];
        }
    }
}
