// -----------------------------------------------------------------------
// <copyright file="LinkedList.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

using System;

namespace DSA
{
    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class LinkedList : Node
    {
        Node head, tail, current, previous, newNode = null;

        public LinkedList()
        {
            head = new Node("Head");
        }

        public object Insert(object item)
        {
            newNode = new Node(item);

            if (tail != null)
            {
                tail.Next = newNode;
            }
            else //It's a first node.
            {
                head.Next = newNode;
            }

            tail = newNode;
            return tail.Data;
        }

        public void InsertAfter(object item, object newItem)
        {
            Node currentNode = GetNodeObject(item);
            Node newNode = new Node(newItem);

            newNode.Next = current.Next;
            current.Next = newNode;
        }

        public void Print()
        {
            current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }

        public void PrintByNodeNumber(int [] nodesNumber)
        {
            current = head.Next;
            int tempCount = 0;
            int tempIndex = 0;

            while (current != null)
            {                
                if (tempCount == nodesNumber[tempIndex] && tempIndex < nodesNumber.Length)
                 {
                    Console.WriteLine(current.Data);
                    ++tempIndex;
                 }
                ++tempCount;
                current = current.Next;
            }
        }

        public void FindNodeByItem(object item)
        {
            current = head.Next;
            bool isFound = false;
            while (current != null)
            {
                if (item.ToString() == current.Data.ToString())
                {
                    Console.WriteLine("Item found {0}", item);
                    isFound = true;
                    break;
                }
                current = current.Next;
            }

            if (isFound == false)
            {
                Console.WriteLine("Item {0} not found in the list", item);
            }
        }

        private Node FindPreviousNodeByItem(object item)
        {
            current = head.Next;
            while ((current.Next != null) && (current.Next.Data.ToString() != item.ToString()))
            {
                current = current.Next;
            }
            return current;
        }

        public object Delete()
        {
            object toDelete = null;
            if (IsEmpty())
            {
                toDelete = head.Next.Data;
                head.Next = head.Next.Next;
            }
            else //It's a first node.
            {
                return "No Data to delete";
            }

            return toDelete;
        }

        public void DeleteItem(object item)
        {
            previous = this.FindPreviousNodeByItem(item);
            if (previous != null)
            {
                previous.Next = previous.Next.Next;
            }
        }

        public Node GetNodeObject(object item)
        {
            current = head.Next;            
            while (current != null)
            {
                if (item.ToString() == current.Data.ToString())
                {
                    return current;                    
                }
                current = current.Next;
            }

            return null;
        }

        private int Size()
        {
            current = head.Next;
            int temp = 0;
            while (current != null)
            {
                ++temp;
                current = current.Next;
            }
            return temp;
        }

        public bool IsEmpty()
        {
            if (head.Next == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ReversePrint()
        {
            current = head.Next;
            Node prev = null;
            Node next = null;
            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;                
            }

            Console.WriteLine("After Reserve");
            current = prev;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }

        public void SplitAndPrint()
        {
            current = head.Next;
            int nodeCount = Size();
            int[] nodeNumber = new int[nodeCount];
            for (int i = 0; i < nodeCount / 2; i++)
            {
                nodeNumber[i] = i;
            }
            Console.WriteLine("Part1");
            PrintByNodeNumber(nodeNumber);

            Array.Clear(nodeNumber, 0, nodeNumber.Length);

            for (int i = 0, j = nodeCount / 2; j < nodeCount; i++, j++)
            {
                nodeNumber[i] = j;
            }

            Console.WriteLine("Part2");
            PrintByNodeNumber(nodeNumber);
        }
    }
}
