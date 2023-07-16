using DSnA;
using System;
using System.Collections.Generic;

namespace Singleton
{
    class Program
    {   
        static void Main(string[] args)
        {

            int testcases;// Taking testcase as input
            testcases = Convert.ToInt32(Console.ReadLine());
            while (testcases-- > 0)// Looping through all testcases
            {
                int N = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[N];
                string elements = Console.ReadLine().Trim();
                elements = elements + " " + "0";
                arr = Array.ConvertAll(elements.Split(), int.Parse);
                Stack<int> s = new Stack<int>();
                for (int i = 0; i < N; i++)
                {
                    s.Push(arr[i]);
                }
                new StackDelMidEle().deleteMid(s, N);
                while (s.Count > 0)
                {
                    Console.Write(s.Peek() + " ");
                    s.Pop();
                }
                Console.Write("\n");
            }

            //LinkedListCustom<int> ll = new LinkedListCustom<int>();

            ////Add nodes to the list  
            //ll.Insert(1);
            //ll.Insert(5);
            //ll.Insert(7);
            //ll.Insert(10);

            ////Displays the nodes present in the list  
            //ll.Print();

            //Counts the nodes present in the given list  
            //Console.WriteLine("Count of nodes present in the list: " + ll.Size());

            /* Create a queue with items 1 2 3*/
            //QueueUsingStack q = new QueueUsingStack();
            //q.stack1 = new Stack<int>();
            //q.stack2 = new Stack<int>();
            //QueueUsingStack.enQueue(q, 1);
            //QueueUsingStack.enQueue(q, 2);
            //QueueUsingStack.enQueue(q, 3);

            ///* Dequeue items */
            //Console.Write(QueueUsingStack.deQueue(q) + " ");
            //Console.Write(QueueUsingStack.deQueue(q) + " ");
            //Console.WriteLine(QueueUsingStack.deQueue(q) + " ");

            //bool showMenu = true;
            //while (showMenu)
            //{
            //    //showMenu = StackCustom.MainMenu();
            //    //showMenu = QueueCustom.MainMenu();
            //}

        }
    }
}