using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA
{
    public class DeleteNodeLL {
        public static void Driver()
        {
            ListNode lN = new ListNode();
            lN.Insert(ref lN, 4);
            lN.Insert(ref lN, 5);
            lN.Insert(ref lN, 1);
            lN.Insert(ref lN, 9);        

            lN.Print(lN);
            Console.WriteLine();
            int nodeToDel = 9;
            ListNode tN = lN;
            while (tN != null && tN.Val != nodeToDel) {
                tN = tN.Next;
            }
            DeleteNode(tN);
            lN.Print(lN);
        }

        private static void DeleteNode(ListNode node) //TC: O(1), SC: O(1)
        {
            if (node.Next != null) { //Not a last node
                node.Val = node.Next.Val;
                node.Next = node.Next.Next;
            } else { //Last node
                node.Val = null;
                node = null;           
            }
        }
    }
}