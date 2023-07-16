using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSnA
{
    internal class LinkedListCustom <T>
    {
        Node<T> head, tail = null;        

        public T Insert(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (head == null)
            {
                //If head is null or if list is empty, newnode becomes the head  
                head = newNode;
            }
            else 
            {
                //If list is not empty, newNode is added after tail such that tail's next will point to newNode  
                tail.Next = newNode;
            }

            //newNode will become new tail of the list 
            tail = newNode;
            return tail.Data;
        }

        public int Size()
        {
            int count = 0;
            Node<T> current = head;

            while (current != null)
            {
                //Increment the count by 1 for each node  
                count++;
                current = current.Next;
            }
            return count;
        }

        public void Print()
        {
            Node<T> current = head;

            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            Console.WriteLine("Nodes of singly linked list: ");
            while (current != null)
            {
                //Prints each node by incrementing pointer  
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }

    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next;

        public Node(T data)
        {
            this.Data = data;
            this.Next = null;
        }
    }


}
