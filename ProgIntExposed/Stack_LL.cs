// -----------------------------------------------------------------------
// <copyright file="Stack_LL.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace ProgQues.ProgIntExposed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Stack_LL : Node
    {
        Node head, current, newNode = null;
        public Stack_LL()
        {
            head = new Node();
        }

        public object Push(object item)
        {
            newNode = new Node(item);

            if (head != null)
            {
                newNode.Next = head.Next;
                head.Next = newNode;
            }
            else //It's a first node.
            {
                head.Next = newNode;
            }

            return newNode.Data;
        }

        public object Pop()
        {
            object deletedItem = null;

            if (head.Next != null)
            {
                deletedItem = head.Next.Data;
                head.Next = head.Next.Next;
            }
            else //It's a first node.
            {
                return "Stack is empty"; 
            }

            return deletedItem;                                  
        }

        public object Peek()
        {
            if (head.Next != null)
            {
                return head.Next.Data;
            }

            //It's a first node.
            return "Stack is empty";             
        }
    }
}
