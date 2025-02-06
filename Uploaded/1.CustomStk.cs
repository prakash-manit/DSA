using System;

namespace DSA
{
    class CustomStk
    {
        static int top = -1;
        static int[] stack = new int[10] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
        static int MAXSIZE = 10;
        static int data = default;
        public static bool MainMenu()
        {
            Console.Write("A menu driven program for stack\n");
            Console.Write("------------------------------------------------");
            Console.Write("\nHere are the options :\n");
            Console.Write("1-Push.\n2-Pop.\n3-Peek.\n4-List.\n5-MakeEmpty.\n6-Exit.\n");
            Console.Write("\nInput your choice :");

            if (int.TryParse(Console.ReadLine(), out int option))
            {
                switch (option)
                {
                    case 1:
                        Console.WriteLine("How many members you wants to push? (put any number between 1 and 10)");
                        if (int.TryParse(Console.ReadLine(), out int count))
                        {

                            if (count > 0 && count <= 10)
                            {
                                Console.WriteLine("Please enter the number now!!");
                                for (int i = 0; i < count; i++)
                                {
                                    if (int.TryParse(Console.ReadLine(), out int data))
                                        Push(data);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please enter the number between 1 and 10!!");
                                count = Convert.ToInt32(Console.ReadLine());
                                if (count > 0 && count <= 10)
                                {
                                    Console.WriteLine("Please enter the number now!!");
                                    for (int i = 0; i < count; i++)
                                    {
                                        if (int.TryParse(Console.ReadLine(), out int data))
                                            Push(data);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("You have exceeded the number of wrong attempt. Good Bye!!");
                                    return false;
                                }

                            }

                        }
                        return true;

                    case 2:
                        Pop();
                        return true;
                    case 3:
                        Console.WriteLine($"Top member of stack is: {Peek()}.\n");
                        return true;
                    case 4:
                        ListStackMembers();
                        return true;
                    case 5:
                        MakeEmpty();
                        return true;
                    case 6:
                        return false;
                    default:
                        return true;
                }
            }
            else
            {
                return false;
            }
        }

        static void MakeEmpty()
        {
            for (int i = stack.Length - 1; i >= 0; i--)
                stack[i] = -1;
        }

        static void ListStackMembers()
        {
            int tempCounter = 0;
            for (int i = stack.Length - 1; i >= 0; i--)
            {

                if (stack[i] > -1)
                {
                    Console.WriteLine(stack[i]);
                    ++tempCounter;
                }
                else
                {
                    continue;
                }
            }

            if (tempCounter == 0)
            {
                Console.WriteLine("Could not retrieve data, Stack is empty.\n");
            }

        }

        static void Push(int data)
        {
            if (!isFull())
            {
                top++;
                stack[top] = data;
                Console.WriteLine($"Member {data} is pushed.");
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
                stack[top] = -1;
                top--;
                Console.WriteLine($"Member {data} is popped.\n");

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
