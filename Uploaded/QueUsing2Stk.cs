using System;
using System.Collections.Generic;

namespace DSnA.Uploaded
{
    class QueUsing2Stk
    {
        public Stack<int> stack1;
        public Stack<int> stack2;

        /* Function to push an item to stack*/
        static void push(Stack<int> top, int new_data)
        {
            // Push the data onto the stack
            top.Push(new_data);
        }

        /* Function to pop an item from stack*/
        static int pop(Stack<int> top)
        {
            /*If stack is empty then error */
            if (top.Count == 0)
            {
                Console.WriteLine("Stack is empty");
                Environment.Exit(0);
            }

            // pop the data from the stack
            return top.Pop();
        }

        // Function to enqueue an item to the queue
        public static void enQueue(QueUsing2Stk q, int x)
        {
            push(q.stack1, x);
        }

        /* Function to deQueue an item from queue */
        public static int deQueue(QueUsing2Stk q)
        {
            int x;

            /* If both stacks are empty then error */
            if (q.stack1.Count == 0 && q.stack2.Count == 0)
            {
                Console.WriteLine("Queue is empty");
                Environment.Exit(0);
            }

            /* Move elements from stack1 to stack 2 only if
            stack2 is empty */
            if (q.stack2.Count == 0)
            {
                while (q.stack1.Count != 0)
                {
                    x = pop(q.stack1);
                    push(q.stack2, x);
                }
            }
            x = pop(q.stack2);
            return x;
        }
    }
}
