namespace DSA
{
    /// <summary>
    /// Class to keep Data and Pointer node
    /// </summary>
    public class Node
    {
        public object Data { get; set; }
        public Node Next;

        public Node()
        {
            this.Data = null;
            this.Next = null;
        }
        public Node(object data)
        {
            this.Data = data;
            this.Next = null;
        }
    }

    public class DQNode
    {
        public object Data { get; set; }
        public DQNode Next;
        public DQNode Previous;

        public DQNode()
        {
            this.Data = null;
            this.Next = null;
            this.Previous = null;

        }
        public DQNode(object data)
        {
            this.Data = data;
            this.Next = null;
            this.Previous = null;
        }
    }

    public class TNode
    {
        public object Data { get; set; }
        public TNode Left;
        public TNode Right;
        public TNode Parent;

        public TNode()
        {
            this.Data = null;
            this.Left = null;
            this.Right = null;
        }

        public TNode(object data)
        {
            this.Data = data;
            this.Left = null;
            this.Right = null;
        }
    }

    public class AVLTNode
    {
        public object Data { get; set; }
        public AVLTNode Left;
        public AVLTNode Right;
        public AVLTNode Parent;
        public int Height { get; set; }

        public AVLTNode()
        {
            this.Data = null;
            this.Left = null;
            this.Right = null;
            this.Height = 1;
        }

        public AVLTNode(object data)
        {
            this.Data = data;
            this.Left = null;
            this.Right = null;
            this.Height = 1;
        }
    }
}
