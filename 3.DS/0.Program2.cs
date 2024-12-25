namespace DSA
{
    using System;

    class Program2
    {
        static void Main0(string[] args)
        {
            Tree_AVL avl = new Tree_AVL();
            avl.InsertNode(44);
            avl.InsertNode(17);
            avl.InsertNode(32);
            avl.InsertNode(78);
            avl.InsertNode(50);
            avl.InsertNode(48);
            avl.InsertNode(88);
            avl.InsertNode(62);
            avl.InsertNode(54);

            //Console.Write("PreOrder Traversal:"); bst.PreOrder_Rec(bst.ReturnRoot()); Console.WriteLine();
            //Console.Write("InOrder Traversal:"); bst.InOrder_Rec(bst.ReturnRoot()); Console.WriteLine();
            //Console.Write("PostOrder Traversal:"); bst.PostOrder_Rec(bst.ReturnRoot()); Console.WriteLine();
            //Console.WriteLine(bst.SearchElement_Rec(31, bst.ReturnRoot()));
            //Console.WriteLine(bst.SearchElement_Ite(19));
            //Console.WriteLine(bst.TreeMin_Ite());
            //Console.WriteLine(bst.TreeMin_Rec(bst.ReturnRoot()));
            //Console.WriteLine(bst.TreeMax_Ite());
            //Console.WriteLine(bst.TreeMax_Rec(bst.ReturnRoot()));
            //Console.WriteLine(bst.TreeSuccessor_Ite(45));
            //Console.WriteLine(bst.TreePredecessor_Ite(13));

            //Console.WriteLine(bst.DeleteNode(14));
            //Console.WriteLine(bst.DeleteNode(20)); 
            //Console.WriteLine(bst.DeleteNode(13));
            //Console.WriteLine(bst.DeleteNode(45));
            //Console.WriteLine(bst.DeleteNode(20));
            //Console.Write("PreOrder Traversal:"); bst.PreOrder_Rec(bst.ReturnRoot()); Console.WriteLine();
            Console.WriteLine("Tree Sort"); avl.TreeSort(avl.ReturnRoot());

            //Tree_BS bst = new Tree_BS();
            //bst.InsertNode(20);
            //bst.InsertNode(25);
            //bst.InsertNode(45);
            //bst.InsertNode(15);
            //bst.InsertNode(13);
            //bst.InsertNode(18);
            //bst.InsertNode(22);
            //bst.InsertNode(14);
            //bst.InsertNode(40);
            //bst.InsertNode(17);
            //bst.InsertNode(20);

            //Console.Write("PreOrder Traversal:"); bst.PreOrder_Rec(bst.ReturnRoot()); Console.WriteLine();
            //Console.Write("InOrder Traversal:"); bst.InOrder_Rec(bst.ReturnRoot()); Console.WriteLine();
            //Console.Write("PostOrder Traversal:"); bst.PostOrder_Rec(bst.ReturnRoot()); Console.WriteLine();
            //Console.WriteLine(bst.SearchElement_Rec(31, bst.ReturnRoot()));
            //Console.WriteLine(bst.SearchElement_Ite(19));
            //Console.WriteLine(bst.TreeMin_Ite());
            //Console.WriteLine(bst.TreeMin_Rec(bst.ReturnRoot()));
            //Console.WriteLine(bst.TreeMax_Ite());
            //Console.WriteLine(bst.TreeMax_Rec(bst.ReturnRoot()));
            //Console.WriteLine(bst.TreeSuccessor_Ite(45));
            //Console.WriteLine(bst.TreePredecessor_Ite(13));

            //Console.WriteLine(bst.DeleteNode(14));
            //Console.WriteLine(bst.DeleteNode(20)); 
            //Console.WriteLine(bst.DeleteNode(13));
            //Console.WriteLine(bst.DeleteNode(45));
            //Console.WriteLine(bst.DeleteNode(20));
            //Console.Write("PreOrder Traversal:"); bst.PreOrder_Rec(bst.ReturnRoot()); Console.WriteLine();
            //Console.WriteLine("Tree Sort"); bst.TreeSort(bst.ReturnRoot());
            //Console.WriteLine("Replace elements in an array to the sum of all num >=element"); bst.ReplaceNodeValue(bst.ReturnRoot(),new int[1]{0});
            //Console.WriteLine("Tree Sort"); bst.TreeSort(bst.ReturnRoot());

            //Queue_2Stacks que = new Queue_2Stacks();
            //Console.WriteLine("Is queue empty? {0}", que.IsEmpty());
            //que.Enqueue(23); Console.WriteLine("Enqueued 23");
            //que.Enqueue(12); Console.WriteLine("Enqueued 12");
            //que.Enqueue(25); Console.WriteLine("Enqueued 25");
            //que.Enqueue(13); Console.WriteLine("Enqueued 13");
            //que.Enqueue(7); Console.WriteLine("Enqueued 7");
            //Console.WriteLine("Size of Queue: {0}", que.Size());
            //Console.WriteLine("Front Element: {0}", que.Front());
            //Console.WriteLine("Dequeued {0}", que.Dequeue());
            //Console.WriteLine("Dequeued {0}", que.Dequeue());
            //Console.WriteLine("Dequeued {0}", que.Dequeue());
            //Console.WriteLine("Front Element: {0}", que.Front());
            //Console.WriteLine("Is queue empty? {0}", que.IsEmpty());
            //Console.WriteLine("Size of Queue: {0}", que.Size());

            //Queue_CircularLL que = new Queue_CircularLL();
            //Console.WriteLine("Size of Queue: {0}", que.Size());
            //Console.WriteLine("Is queue empty? {0}", que.IsEmpty());
            //Console.WriteLine("Front Element: {0}", que.Front());
            //que.Enqueue(2);
            //que.Enqueue(3);
            //que.Enqueue(1);
            //Console.WriteLine("After EQ"); que.PrintList();
            //que.Dequeue();
            //Console.WriteLine("After DQ"); que.PrintList();
            //Console.WriteLine("Size of Queue: {0}", que.Size());
            //Console.WriteLine("Is queue empty? {0}", que.IsEmpty());
            //Console.WriteLine("Front Element: {0}", que.Front());

            //Dqueue_DoublyLL que = new Dqueue_DoublyLL();
            //Console.WriteLine("Size of Queue: {0}", que.Size());
            //Console.WriteLine("Is queue empty? {0}", que.IsEmpty());
            //Console.WriteLine("Front Element: {0}", que.First());
            //Console.WriteLine("Last Element: {0}", que.Last());
            //que.InsertLast(3);
            //que.InsertLast(2);
            //que.InsertLast(5);
            //que.InsertLast(4);
            //que.InsertLast(7);
            //que.InsertLast(9);
            //Console.WriteLine("After InsertLast"); que.PrintList();
            //que.RemoveFirst();
            //Console.WriteLine("After RemoveFirst"); que.PrintList();
            //Console.WriteLine("Last Element: {0}", que.Last());
            //que.RemoveLast();
            //Console.WriteLine("After RemoveLast"); que.PrintList();
            //que.InsertAfter(8, 5);
            //Console.WriteLine("After InsertAfter:"); que.PrintList();
            //que.RemoveAny(4);
            //Console.WriteLine("After RemoveAny 4:"); que.PrintList();
            //Console.WriteLine("Size of Queue: {0}", que.Size());
            //Console.WriteLine("Is queue empty? {0}", que.IsEmpty());
            //Console.WriteLine("Front Element: {0}", que.First());
            //Console.WriteLine("Last Element: {0}", que.Last());

            //Queue_LinkedList que = new Queue_LinkedList();
            //Console.WriteLine("Size of Queue: {0}", que.Size());
            //Console.WriteLine("Is queue empty? {0}", que.IsEmpty());
            //Console.WriteLine("Front Element: {0}", que.Front());
            //que.Enqueue(5);
            //que.Enqueue(7);
            //que.Enqueue(89);
            //Console.WriteLine("After EQ"); que.PrintList();
            //que.Dequeue();
            //Console.WriteLine("After DQ"); que.PrintList();
            //que.Enqueue(344);
            //Console.WriteLine("After EQ"); que.PrintList();
            //que.Dequeue();
            //que.Dequeue();
            ////que.Dequeue();
            ////que.Dequeue();
            //Console.WriteLine("After DQ"); que.PrintList();
            //que.Enqueue(7);
            //que.Enqueue(13);
            //que.Enqueue(38);
            //Console.WriteLine("After EQ"); que.PrintList();
            //que.InsertAfter(55, 13);
            //Console.WriteLine("After InsertAfter"); que.PrintList();
            //que.RemoveAny(13);
            //Console.WriteLine("After RemoveAny"); que.PrintList();
            //Console.WriteLine("Size of Queue: {0}", que.Size());
            //Console.WriteLine("Is queue empty? {0}", que.IsEmpty());
            //Console.WriteLine("Front Element: {0}", que.Front());
            //que.ReverseAndPrintList();

            //int c = 5%4;

            //Queue_Array que = new Queue_Array(6);
            //Console.WriteLine(que.Front());
            //que.Enqueue(5);
            //que.Enqueue(9);
            //que.Enqueue(3);
            //Console.WriteLine(que.Front());
            //que.Dequeue();
            //Console.WriteLine(que.Front());
            //que.Dequeue();
            //Console.WriteLine(que.Front());
            //que.Dequeue();
            //Console.WriteLine(que.Dequeue());
            //Console.WriteLine(que.Front());
            //que.Enqueue(2);
            //que.Enqueue(4);
            //que.Enqueue(1);
            //que.Enqueue(3);
            //que.Enqueue(6);
            //Console.WriteLine(que.Enqueue(5));
            //que.Reset();
            //Console.WriteLine(que.Front());

            //Stack_Array stackObj  = new Stack_Array(4);
            //Console.WriteLine(stackObj.Top());
            //stackObj.Push(5);
            //stackObj.Push(9);
            //stackObj.Push(3);
            //Console.WriteLine(stackObj.Top());
            //stackObj.Pop();
            //Console.WriteLine(stackObj.Top());
            //stackObj.Pop();
            //Console.WriteLine(stackObj.Top());
            //stackObj.Pop();
            //Console.WriteLine(stackObj.Top());
            //Console.WriteLine(stackObj.Pop());
            //stackObj.Push(2);
            //stackObj.Push(4);
            //stackObj.Push(1);
            //stackObj.Push(6);
            //stackObj.Push(7);
        }
    }
}
