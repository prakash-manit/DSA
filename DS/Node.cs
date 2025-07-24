using System;

namespace DSA
{
    /// <summary>
    /// Class to keep Data and Pointer node
    /// </summary>
    public class Node {
        public object Data { get; set; }
        public Node Next;

        public Node()
        {
            this.Data = null;
            this.Next = null;
        }
        public Node(object data)
        {
            this.Data = data;
            this.Next = null;
        }
        
    }

    public class ListNode {
        public int? Val;
        public ListNode Next;
        public ListNode()
        {
            this.Val = null;
            this.Next = null;
        }
        public ListNode(int val)
        {
            this.Val = val;
            this.Next = null;
        }
        public ListNode(int val, ListNode next)
        {
            this.Val = val;
            this.Next = next;
        }
        
        public void Insert(ref ListNode head, int val)
        {
            ListNode newNode = new ListNode(val);
            if (head.Val == null) {
                head = newNode;
            } 
            else {
                ListNode curr = head;
                while (curr.Next != null) {
                    curr = curr.Next;
                }
                curr.Next = newNode;
            }
        }

        public void Print(ListNode head)
        {
            if (head.Val == null) return;
            ListNode current = head;

            while (current != null) {
                Console.Write(current.Val + " ");
                current = current.Next;
            }
        }
    }

    

    public class DQNode {
        public object Data { get; set; }
        public DQNode Next;
        public DQNode Previous;

        public DQNode()
        {
            this.Data = null;
            this.Next = null;
            this.Previous = null;

        }
        public DQNode(object data)
        {
            this.Data = data;
            this.Next = null;
            this.Previous = null;
        }
    }

    public class TNode
    {
        public object Data { get; set; }
        public TNode Left;
        public TNode Right;
        public TNode Parent;

        public TNode()
        {
            this.Data = null;
            this.Left = null;
            this.Right = null;
        }

        public TNode(object data)
        {
            this.Data = data;
            this.Left = null;
            this.Right = null;
        }
    }

    public class AVLTNode
    {
        public object Data { get; set; }
        public AVLTNode Left;
        public AVLTNode Right;
        public AVLTNode Parent;
        public int Height { get; set; }

        public AVLTNode()
        {
            this.Data = null;
            this.Left = null;
            this.Right = null;
            this.Height = 1;
        }

        public AVLTNode(object data)
        {
            this.Data = data;
            this.Left = null;
            this.Right = null;
            this.Height = 1;
        }
    }
}
