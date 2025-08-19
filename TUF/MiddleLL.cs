using System;

namespace DSA {
    public class MiddleLL {
        //private static ListNode head;
        public static void Driver()
        {
            ListNode head = new ListNode();
            head.Insert(ref head, 1);
            head.Insert(ref head, 2);
            head.Insert(ref head, 3);
            head.Insert(ref head, 4);
            head.Insert(ref head, 5); 
            //Insert(ref head, 6);            

            head.Print(head);
            ListNode mNode = MiddleNode2(head);
            Console.WriteLine();
            Console.WriteLine(mNode.Val);
        }

        

        private static ListNode MiddleNode2(ListNode head) //Tortoise method, TC: O(n/2), SC: O(1)
        {
            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.Next != null) {
                slow = slow.Next;
                fast = fast.Next.Next;
            }
            return slow;
        }

        private static ListNode MiddleNode(ListNode head) //TC: O(n) + O(n/2), SC: O(1)
        {
            ListNode current = head;
            int count = 0;
            int midIdx = 0;
            while (current != null) {
                current = current.Next;
                count++;
            }
            if (count % 2 == 0) {
                midIdx = (count / 2) + 1;
            } else {
                midIdx = (count / 2) + 1;
            }
            current = head;
            count = 0;
            while (current != null) {
                count++;
                if (count == midIdx) {
                    return current;
                }
                current = current.Next;
            }
            return current;
        }        
    }
}