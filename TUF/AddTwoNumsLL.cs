using System;

namespace DSA
{
    public class AddTwoNumsLL {
        public static void Driver()
        {
            ListNode l1 = new ListNode();
            l1.Insert(ref l1, 2);
            l1.Insert(ref l1, 4);
            l1.Insert(ref l1, 3);
            ListNode l2 = new ListNode();
            l2.Insert(ref l2, 5);
            l2.Insert(ref l2, 6);
            l2.Insert(ref l2, 4);           

            l1.Print(l1);
            Console.WriteLine();
            l2.Print(l2);
            Console.WriteLine();
            ListNode l3 = AddTwoNumbers(l1, l2);
            l3.Print(l3);
        }

        private static ListNode AddTwoNumbers(ListNode l1, ListNode l2) //TC: O(max(n1, n2)), SC: O(n)
        {
            ListNode dN = new ListNode();
            ListNode tN = dN;
            int? carry = 0;
            while (l1 != null || l2 != null || carry == 1) {
                int? sum = 0;
                if (l1 != null) {
                    sum += l1.Val;
                    l1 = l1.Next;
                }
                if (l2 != null) {
                    sum += l2.Val;
                    l2 = l2.Next;
                }
                sum += carry;
                carry = sum / 10;
                ListNode sumN = new ListNode((int) sum % 10);
                tN.Next = sumN;
                tN = tN.Next;
            }
            return dN.Next;
        }
    }
}