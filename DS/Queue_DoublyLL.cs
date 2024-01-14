using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProgQues;

namespace DSnA
{
    /// <summary>
    /// This class illustrates queue implementation using Linked list (Doubly)
    /// It allows element addition/deletion at any place.
    /// </summary> 
    public class Queue_DoublyLL : DQNode
    {
        private DQNode head, tail = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedListQueue"/> class.
        /// </summary>
        public Queue_DoublyLL()
        {
            head = new DQNode("Head");
        }

        /// <summary>
        /// Enqueues the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Enqueue(object data)
        {
            DQNode newNode = new DQNode(data);
            newNode.Next = null;
            if (tail != null)
            {
                tail.Next = newNode;
            }
            else ////First element Insertion
            {
                head.Next = newNode;
            }
            
            tail = newNode;
        }

        /// <summary>
        /// Dequeues this instance.
        /// </summary>
        public void Dequeue()
        {
            if (head.Next != null)
                head.Next = head.Next.Next;
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
    }    
}
