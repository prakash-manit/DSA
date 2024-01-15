using System;

namespace DSA
{
    /// <summary>
    /// This class illustrates queue implementation using Linked list (Doubly)
    /// It allows element addition/deletion at any place.
    /// </summary> 
    class DoublyLL : DQNode
    {
        private DQNode head, tail, current = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedList"/> class.
        /// </summary>
        public DoublyLL()
        {
            head = new DQNode("Head");
        }

        /// <summary>
        /// Inserts the last.
        /// </summary>
        /// <param name="data">The data.</param>
        public void InsertLast(object data)
        {
            DQNode newNode = new DQNode(data);
            if (tail != null)
            {
                tail.Next = newNode;
                newNode.Previous = tail;
            }
            else ////First element Insertion
            {
                head.Next = newNode;
                newNode.Previous = head;
            }
            
            tail = newNode;
        }

        /// <summary>
        /// Removes the first.
        /// </summary>
        public void RemoveFirst()
        {
            if (head.Next != null)
            {
                head.Next = head.Next.Next;
                head.Next.Previous = head;
            }

        }

        /// <summary>
        /// Removes the last.
        /// </summary>
        public object RemoveLast()
        {
            current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            object data = current.Data;
            current.Previous.Next = current.Next;
            current.Next.Previous = current.Previous;
            //Update the tail
            tail = current.Previous;
            //clean up object
            current = null;
            return data;
        }

        /// <summary>
        /// Prints the list.
        /// </summary>
        public void PrintList()
        {
            DQNode current = head;
            while (current.Next != null)
            {
                Console.WriteLine(current.Next.Data);
                current = current.Next;
            }
        }

        public int Size()
        {
            int count = 0;
            current = head;
            while (current.Next != null)
            {
                current = current.Next;
                count++;
            }
            return count;
        }

        public bool IsEmpty()
        {
            if (head.Next == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public object First()
        {
            return IsEmpty() ? "Queue is empty" : head.Next.Data;
        }

        public object Last()
        {
            return IsEmpty() ? "Queue is empty" : tail.Data;
        }

        ///////////////////////////////////DQue Adv/////////////////////////////////
        private DQNode Find(object item)
        {
            current = head.Next;
            while (current.Data.ToString() != item.ToString())
            {
                current = current.Next;
            }
            return current;
        }

        public void InsertAfter(object newItem, object after)
        {
            current = this.Find(after);
            DQNode newNode = new DQNode(newItem);

            newNode.Next = current.Next;
            newNode.Previous = current;

            current.Next = newNode;
            newNode.Next.Previous = newNode;
        }

        public void RemoveAny(object item)
        {
            current = this.Find(item);

            current.Previous.Next = current.Next;
            current.Next.Previous = current.Previous;
            current.Next = null;
            current.Previous = null;
        }
    }
}
