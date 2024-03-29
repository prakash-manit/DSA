﻿using System;
using System.Collections.Generic;

namespace DSA
{
    internal class CustomLL<T>
    {
        //tail pointer helps to avoid extra loop in finding last node
        Node<T> head, tail = null;

        public static void Driver()
        {
            CustomLL<int> ll = new CustomLL<int>();
            //Add nodes to the list  
            ll.Insert(1);
            ll.Insert(5);
            ll.Insert(7);
            ll.Insert(10);

            //Displays the nodes present in the list  
            ll.Print();

            //Counts the nodes present in the given list
            Console.WriteLine("Count of nodes present in the list: " + ll.Size());

            /* Create a queue with items 1 2 3*/
            QueUsing2Stk q = new QueUsing2Stk();
            q.stack1 = new Stack<int>();
            q.stack2 = new Stack<int>();
            QueUsing2Stk.enQueue(q, 1);
            QueUsing2Stk.enQueue(q, 2);
            QueUsing2Stk.enQueue(q, 3);

            /* Dequeue items */
            Console.Write(QueUsing2Stk.deQueue(q) + " ");
            Console.Write(QueUsing2Stk.deQueue(q) + " ");
            Console.WriteLine(QueUsing2Stk.deQueue(q) + " ");

            bool showMenu = true;
            while (showMenu)
            {
                //showMenu = StackCustom.MainMenu();
                //showMenu = QueueCustom.MainMenu();
            }
        }

        private T Insert(T data)
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

        private int Size()
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

        private void Print()
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

    internal class Node<T>
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
