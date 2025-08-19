using System;

namespace DSA
{
    public class ReverseLL
    {
        //private static ListNode head;
        public static void Driver()
        {
            ListNode head = new ListNode();
            head.Insert(ref head, 1);
            head.Insert(ref head, 2);
            head.Insert(ref head, 3);
            head.Insert(ref head, 4);
            head.Insert(ref head, 5);            

            head.Print(head);
            head = Reverse(head);
            Console.WriteLine();
            head.Print(head);
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