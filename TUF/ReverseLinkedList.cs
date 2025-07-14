using System;

namespace DSA
{
    public class ReverseLinkedList
    {
        //private static ListNode head;
        public static void Driver()
        {
            ListNode head = new ListNode();
            Insert(ref head, 1);
            Insert(ref head, 2);
            Insert(ref head, 3);
            Insert(ref head, 4);
            Insert(ref head, 5);            

            Print(head);
            head = Reverse(head);
            Console.WriteLine();
            Print(head);
        }

        private static void Insert(ref ListNode head, int val)
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

        private static void Print(ListNode head)
        {
            if (head.Val == null) return;
            ListNode current = head;

            while (current != null) {
                Console.Write(current.Val);
                current = current.Next;
            }
        }

        private static ListNode Reverse(ListNode head) //TC: O(n), SC: O(1)
        {
            ListNode newHead = null;
            while (head != null) {
                ListNode next = head.Next;
                head.Next = newHead;
                newHead = head;
                head = next;
            }
            return newHead;
        }        
    }
}