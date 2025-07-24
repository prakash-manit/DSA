using System;

namespace DSA.TUF
{
    public class MergeTwoSortedLL {
        public static void Driver()
        {
            ListNode list1 = new ListNode();
            list1.Insert(ref list1, 5);
            list1.Insert(ref list1, 7);
            list1.Insert(ref list1, 9);
            ListNode list2 = new ListNode();
            list2.Insert(ref list2, 3);
            list2.Insert(ref list2, 4);
            list2.Insert(ref list2, 8);
            list2.Insert(ref list2, 10);                 

            list1.Print(list1);
            Console.WriteLine();
            list2.Print(list2);
            ListNode list = MergeTwoLists(list1, list2);
            Console.WriteLine();
            list.Print(list);
        }

        private static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null) return list2;
            if (list2 == null) return list1;

            //list1 should always have smaller node value, if it's not, swap
            
            if (list1.Val > list2.Val) {
                ListNode tmp = list2;
                list2 = list1;
                list1 = tmp;
            }
            ListNode head = list1;            
            while (list1 != null && list2 != null) {
                ListNode tmp = null;
                while (list1 != null && list1.Val <= list2.Val) {
                    tmp = list1;
                    list1 = list1.Next;
                }
                tmp.Next = list2;

                //Swap to make sure list1 always has smaller node value
                ListNode tmp2 = list2;
                list2 = list1;
                list1 = tmp2;
            }
            return head;
        }
    }
}