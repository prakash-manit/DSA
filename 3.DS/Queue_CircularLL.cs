using System;

namespace DSA
{
    class Queue_CircularLL
    {
        private Node newNode, current, head, tail = null;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedList"/> class.
        /// </summary>
        public Queue_CircularLL()
        {
            head = new Node("Head");
            head.Next = head;
        }

        public int Size()
        {
            int count = 0;
            current = head;
            while (current.Next != head)
            {
                current = current.Next;
                count++;
            }
            return count;
        }

        public bool IsEmpty()
        {
            if (head.Next == head)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public object Front()
        {
            return IsEmpty() ? "Queue is empty" : head.Next.Data;
        }

        /// <summary>
        /// Enqueues the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public bool Enqueue(object data)
        {
            newNode = new Node(data);
            newNode.Next = head;
            if (tail != null)
            {
                tail.Next = newNode;
            }
            else ////First element Insertion
            {
                head.Next = newNode;
            }

            tail = newNode;
            return true;
        }

        /// <summary>
        /// Dequeues this instance.
        /// </summary>
        public void Dequeue()
        {
            if (head.Next != head)
                head.Next = head.Next.Next;
        }

        /// <summary>
        /// Prints the list.
        /// </summary>
        public void PrintList()
        {
            current = head;
            while (current.Next != head)
            {
                Console.WriteLine(current.Next.Data);
                current = current.Next;
            }
        }
    }
}
