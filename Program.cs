using System;

namespace Singleton
{
    class Program
    {
        static int top = -1;
        static int[] stack = new int[10];
        static int MAXSIZE = 10;
        static int data = default;
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the data to push:");
            data = Console.Read();
            Push(data);

            Console.WriteLine($"Top member of stack is: {Peek()}");

            Pop();
            Console.WriteLine($"Top member of stack is: {Peek()}");

        }

        static void Push(int data)
        {
            if (!isFull())
            {
                top = top + 1;
                stack[top] = data;
                Console.WriteLine($"Member {data} is pushed");
            }
            else
            {
                Console.WriteLine("Could not insert data, Stack is full.\n");
            }
        }

        static void Pop()
        {

            if (!isEmpty())
            {
                data = stack[top];
                top = top - 1;
                Console.WriteLine($"Member {data} is popped");

            }
            else
            {
                Console.WriteLine("Could not retrieve data, Stack is empty.\n");
            }
        }

        static int Peek()
        {
            if (top != -1)
                return stack[top];
            else
                return -1;

        }

        static bool isFull()
        {
            if (top == MAXSIZE)
                return true;
            else
                return false;
        }

        static bool isEmpty()
        {
            if (top == -1)
                return true;
            else
                return false;
        }
    }
}