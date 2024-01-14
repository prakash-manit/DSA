using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgQues
{
    class Tree_AVL : AVLTNode
    {
        private AVLTNode root, tempParent, tempChild, current = null;

        public Tree_AVL()
        {
            root = new AVLTNode();
        }

        public AVLTNode ReturnRoot()
        {
            return root;
        }

        int Max(int a, int b)
        {
            return (a > b) ? a : b;
        }

        public void InsertNode(object data)
        {
            AVLTNode newNode = new AVLTNode(data);

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

        public void TreeSort(AVLTNode root)
        {
            this.InOrder_Rec(root);
        }

        public void InOrder_Rec(AVLTNode root)
        {
            if (root != null)
            {
                InOrder_Rec(root.Left);
                Console.Write(root.Data + " ");
                InOrder_Rec(root.Right);
            }
        }

        public object DeleteNode(object data)
        {
            AVLTNode tempDelete = this.GetNode(data);
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
                    AVLTNode predNode = this.GetNode(this.TreePredecessor_Ite(data));  //Find it's predecessor
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

        public object SearchElement_Rec(object element, AVLTNode root)
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

        public object TreeMin_Rec(AVLTNode root)
        {
            current = root;
            if (current.Left == null)
            {
                return current.Data;
            }
            return TreeMin_Rec(current.Left);
        }

        public object TreeMax_Rec(AVLTNode root)
        {
            current = root;
            if (current.Right == null)
            {
                return current.Data;
            }
            return TreeMax_Rec(current.Right);
        }

        private AVLTNode GetNode(object element)
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
    }
}
