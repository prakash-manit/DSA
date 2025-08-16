using System;

namespace DSA {
    public class RemoveNFromEndLL {
        public static void Driver()
        {
            ListNode list = new ListNode();
            list.Insert(ref list, 2);
            list.Insert(ref list, 4);
            list.Insert(ref list, 1);
            list.Insert(ref list, 3);
            list.Insert(ref list, 5);
            list.Insert(ref list, 6);
            // list.Insert(ref list, 1);
            // list.Insert(ref list, 2);
            // list.Insert(ref list, 3);
            // list.Insert(ref list, 4);
            // list.Insert(ref list, 5);
            int eleSeqToRem = 4;

            list.Print(list);
            Console.WriteLine();

            list = RemoveNthEleFromEnd(list, eleSeqToRem);
            Console.WriteLine();
            list.Print(list);
        }

        private static ListNode RemoveNthEleFromEnd2(ListNode head, int n) //TC: O(n+n), SC O(1)
        {
            if (head.Next == null) return null;

            ListNode start = new ListNode();
            start.Next = head;
            ListNode fast = start;
            ListNode slow = start;

            //Get count to check if head needs to be removed
            ListNode temp = head;
            int nodeCnt = 0;
            while (temp != null) {
                temp = temp.Next;
                nodeCnt++;
            }

            //Traverse fast till count n
            for (int i = 1; i <= n; i++) {
                fast = fast.Next;
            }
            while (fast.Next != null) {
                fast = fast.Next;
                slow = slow.Next;
            }
            slow.Next = slow.Next.Next;

            if (nodeCnt != n) return head; 
            else return slow.Next; //if head needs to be removed
        }
        
        private static ListNode RemoveNthEleFromEnd(ListNode head, int n) //TC: O(n+n), SC O(1)
        {
            if (head.Next == null) return null;

            ListNode dN = head;
            int nodeCnt = 0;

            while (dN != null) {
                dN = dN.Next;
                nodeCnt++;
            }
            int disFromHead = nodeCnt - n;

            ListNode dN2 = head;
            int tCnt = 0;
            
            while (dN2 != null && (disFromHead-1) != tCnt) {
                dN2 = dN2.Next;
                tCnt++;
            }
           
            if (nodeCnt != n) {
                dN2.Next = dN2.Next.Next;              
            } else {
                head = head.Next; //if head needs to be removed
            }                              
            return head;
        }
    }
}
