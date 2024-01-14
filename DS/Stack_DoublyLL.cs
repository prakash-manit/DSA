namespace ProgQues
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// This class illustrates Stack implementation using Linked list (Doubly)
    /// Stack can be implemented by using the methods of doubly linked list as below
    /// Top() can be implemented using Last() 
    /// Push(o) can be implemented using InsertLast(o)
    /// Pop() can be implemented using RemoveLast()
    /// </summary>
    class Stack_DoublyLL
    {
        DoublyLL queDLL;
        public Stack_DoublyLL()
        {
            queDLL = new DoublyLL();
        }

        public int Size()
        {
            return queDLL.Size();
        }

        public bool IsEmpty()
        {
            return queDLL.IsEmpty();
        }

        public object Top()
        {
            return queDLL.Last();
        }

        public void Push(object data)
        {
            queDLL.InsertLast(data);
        }

        public object Pop()
        {
            return queDLL.RemoveLast();
        }
    }
}
