namespace DSA
{
    using System;
    class Tree_BS : TNode
    {
        private TNode root, tempParent, tempChild, current = null;

        public Tree_BS()
        {
            root = new TNode();
        }

        public TNode ReturnRoot()
        {
            return root;
        }

        public void InsertNode(object data)
        {
            TNode newNode = new TNode(data);

            if (root.Data == null) //First node insertion   
                root = newNode;
            else
            {
                current = root;
                while (true)
                {
                    tempParent = current;
                    if (Convert.ToInt32(newNode.Data) < Convert.ToInt32(current.Data))
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            tempParent.Left = newNode;
                            newNode.Parent = tempParent;
                            return;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            tempParent.Right = newNode;
                            newNode.Parent = tempParent;
                            return;
                        }
                    }
                }
            }
        }

        public void TreeSort(TNode root)
        {
            this.InOrder_Rec(root);
        }

        public object DeleteNode(object data)
        {
            TNode tempDelete = this.GetNode(data);
            if (tempDelete != null)
            {
                if ((tempDelete.Left == null) && (tempDelete.Right == null)) //Its a Leaf node
                {
                    tempParent = tempDelete.Parent;
                    if (tempDelete == tempParent.Left) //Just remove by making it null
                        tempParent.Left = null;
                    else
                        tempParent.Right = null;
                }
                else if ((tempDelete.Left == null) || (tempDelete.Right == null)) //It has either Left or Right child
                {
                    tempChild = tempDelete.Left == null ? tempDelete.Right : tempDelete.Left; //Get the child
                    tempParent = tempDelete.Parent; //Get the parent
                    if (tempDelete == tempParent.Left) //Make parent points to it's child so it will automatically deleted like Linked list
                        tempParent.Left = tempChild;
                    else
                        tempParent.Right = tempChild;

                }
                else if ((tempDelete.Left != null) || (tempDelete.Right != null)) //It has both Left and Right child
                {
                    TNode predNode = this.GetNode(this.TreePredecessor_Ite(data));  //Find it's predecessor
                    if (predNode.Left != null) // Predecessor node can have no or left child. Do below two steps only if it has left child
                    {
                        tempChild = predNode.Left;
                        predNode.Parent.Right = tempChild; //Assign left child of predecessor to it's Parent's right.
                    }
                    tempDelete.Data = predNode.Data;  //Replace the value of predecessor node to the value of to be deleted node
                    //predNode = null; //Remove predecessor node as it's no longer required.
                }

                return data + " Deleted";
            }
            else
                return "Please enter the valid tree element!";
        }

        public void PreOrder_Rec(TNode root)
        {
            if (root != null)
            {
                Console.Write(root.Data + " ");
                PreOrder_Rec(root.Left);
                PreOrder_Rec(root.Right);
            }
        }

        public void InOrder_Rec(TNode root)
        {
            if (root != null)
            {
                InOrder_Rec(root.Left);
                Console.Write(root.Data + " ");
                InOrder_Rec(root.Right);
            }
        }

        public void PostOrder_Rec(TNode root)
        {
            if (root != null)
            {
                PostOrder_Rec(root.Left);
                PostOrder_Rec(root.Right);
                Console.Write(root.Data + " ");
            }
        }

        public object SearchElement_Rec(object element, TNode root)
        {
            current = root;
            if (current == null)
                return "Not found";
            if (Convert.ToInt32(element) == Convert.ToInt32(current.Data))
                return element;
            if (Convert.ToInt32(element) < Convert.ToInt32(current.Data))
                return this.SearchElement_Rec(element, current.Left);
            else
                return this.SearchElement_Rec(element, current.Right);
        }

        public object SearchElement_Ite(object element)
        {
            current = this.ReturnRoot();
            while (current != null)
            {
                tempParent = current;
                if (Convert.ToInt32(element) == Convert.ToInt32(current.Data))
                    return current.Data;
                if (Convert.ToInt32(element) < Convert.ToInt32(current.Data))
                    current = current.Left;
                else
                    current = current.Right;
            }
            return "Not found";
        }

        public object TreeMin_Ite()
        {
            current = this.ReturnRoot(); ;
            while (current.Left != null)
            {
                current = current.Left;
            }
            return current.Data;
        }

        public object TreeMin_Rec(TNode root)
        {
            current = root;
            if (current.Left == null)
            {
                return current.Data;
            }
            return TreeMin_Rec(current.Left);
        }

        public object TreeMax_Ite()
        {
            current = this.ReturnRoot();
            while (current.Right != null)
            {
                current = current.Right;
            }
            return current.Data;
        }

        public object TreeMax_Rec(TNode root)
        {
            current = root;
            if (current.Right == null)
            {
                return current.Data;
            }
            return TreeMax_Rec(current.Right);
        }

        private TNode GetNode(object element)
        {
            current = this.ReturnRoot();
            while (current != null)
            {
                if (Convert.ToInt32(element) == Convert.ToInt32(current.Data))
                    return current;
                if (Convert.ToInt32(element) < Convert.ToInt32(current.Data))
                    current = current.Left;
                else
                    current = current.Right;
            }
            return null;
        }

        public object TreeSuccessor_Ite(object element)
        {
            ////Get the Node object for an element
            current = this.GetNode(element);
            if (current != null)
            {
                if (current.Right != null)
                    return this.TreeMin_Rec(current.Right);
                else
                {
                    tempParent = current.Parent;
                    while ((tempParent != null) && (current == tempParent.Right))
                    {
                        current = tempParent;
                        tempParent = tempParent.Parent;
                    }
                    if (tempParent != null)
                        return tempParent.Data;
                    else
                        return "Successor is not found!";
                }
            }
            else
            {
                return "Please enter the valid tree element!";
            }
        }

        public object TreePredecessor_Ite(object element)
        {
            ////Get the Node object for an element
            current = this.GetNode(element);
            if (current != null)
            {
                if (current.Left != null)
                    return this.TreeMax_Rec(current.Left);
                else
                {
                    tempParent = current.Parent;
                    while ((tempParent != null) && (current == tempParent.Left))
                    {
                        current = tempParent;
                        tempParent = tempParent.Parent;
                    }
                    if (tempParent != null)
                        return tempParent.Data;
                    else
                        return "Predecessor is not found!";
                }
            }
            else
            {
                return "Please enter the valid tree element!";
            }
        }

        //////////////////////////Adv//////////////////////////////////
        //Replace BST nodes with the sum of nodes greater than or equal to the node
        // sum is a single element array. initially sum[0] = 0
        public void ReplaceNodeValue(TNode root, int[] Sum)
        {
            if (root != null)
            {
                ReplaceNodeValue(root.Right, Sum);
                root.Data = (Sum[0] = Sum[0] + Convert.ToInt32(root.Data));
                ReplaceNodeValue(root.Left, Sum);
            }
        }

        //2nd Approach
        //Travers as Inodred traversal and put it into an array
        //Replace elements in a sorted array to the sum of all elements which are greater or equal to that element.
        //Finally, traversal the BST again and do the replacement with the help of the array.



    }
}
