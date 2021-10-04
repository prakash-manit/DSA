using DSnA;
using System;
using System.Collections.Generic;

namespace Singleton
{
    class Program
    {   
        static void Main(string[] args)
        {
            //bool showMenu = true;
            //while (showMenu)
            //{
            //    //showMenu = StackCustom.MainMenu();
            //    //showMenu = QueueCustom.MainMenu();
            //}

            /* Create a queue with items 1 2 3*/
            QueueUsingStack q = new QueueUsingStack();
            q.stack1 = new Stack<int>();
            q.stack2 = new Stack<int>();
            QueueUsingStack.enQueue(q, 1);
            QueueUsingStack.enQueue(q, 2);
            QueueUsingStack.enQueue(q, 3);

            /* Dequeue items */
            Console.Write(QueueUsingStack.deQueue(q) + " ");
            Console.Write(QueueUsingStack.deQueue(q) + " ");
            Console.WriteLine(QueueUsingStack.deQueue(q) + " ");

        }

        
    }
}