using System;

namespace DSnA.Uploaded
{
    class CustomQue
    {
        static int front = 0;
        static int rear = 0;
        const int MAXSIZE = 10;
        static int[] queue = new int[MAXSIZE] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
        static int data = default;
        public static bool MainMenu()
        {
            Console.Write("A menu driven program for queue\n");
            Console.Write("------------------------------------------------");
            Console.Write("\nHere are the options :\n");
            Console.Write("1-Enqueue.\n2-Dequeue.\n3-Peek.\n4-List.\n5-MakeEmpty.\n6-Exit.\n");
            Console.Write("\nInput your choice :");

            if (int.TryParse(Console.ReadLine(), out int option))
            {
                switch (option)
                {
                    case 1:

                        if (!isFull())
                        {
                            Console.WriteLine("How many members you wants to enqueue? (put any number between 1 and 10)");
                            if (int.TryParse(Console.ReadLine(), out int count))
                            {

                                if (count > 0 && count <= 10)
                                {
                                    Console.WriteLine("Please enter the number now!!");
                                    for (int i = 0; i < count; i++)
                                    {
                                        if (int.TryParse(Console.ReadLine(), out int data))
                                            Enqueue(data);
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
                                                Enqueue(data);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("You have exceeded the number of wrong attempt. Good Bye!!");
                                        return false;
                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Could not insert data, Queue is full.\n");
                        }

                        return true;
                    case 2:
                        Dequeue();
                        return true;
                    case 3:
                        Console.WriteLine($"Top member of queue is: {Peek()}.\n");
                        return true;
                    case 4:
                        ListQueueMembers();
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
            for (int i = queue.Length - 1; i >= 0; i--)
                queue[i] = -1;
        }

        static void ListQueueMembers()
        {
            int tempCounter = 0;
            for (int i = front; i < rear; i++)
            {

                if (queue[i] > -1)
                {
                    Console.WriteLine(queue[i]);
                    ++tempCounter;
                }
                else
                {
                    continue;
                }
            }

            if (tempCounter == 0)
            {
                Console.WriteLine("Could not retrieve data, Queue is empty.\n");
            }

        }

        static void Enqueue(int data)
        {
            if (!isFull())
            {
                queue[rear] = data;
                ++rear;
                Console.WriteLine($"Member {data} is en-queued.");
            }
            else
            {
                Console.WriteLine("Could not insert data, Queue is full.\n");
            }
        }

        static void Dequeue()
        {

            if (!isEmpty())
            {
                Console.WriteLine($"Member {queue[front]} is de-queued.\n");
                for (int i = front; i < rear - 1; i++)
                {
                    queue[i] = queue[i + 1];
                }

                queue[rear - 1] = -1;
                --rear;

            }
            else
            {
                Console.WriteLine("Could not retrieve data, Queue is empty.\n");
            }
        }

        static int Peek()
        {
            return queue[front];
        }

        static bool isFull()
        {
            if (rear == MAXSIZE)
                return true;
            else
                return false;
        }

        static bool isEmpty()
        {
            if (front == rear)
                return true;
            else
                return false;
        }
    }
}
