using System.Transactions;

namespace BST_Sample.BinarySearchTree
{
    public class Tree : ITree
    {
        public Node Head { get; set; }
        public int NodeCount { get; private set; }

        #region Implementation of ITree

        public bool Add(int value)
        {
            if (Head != null) { return Add(value, Head); }

            Head = new Node { Data = value };
            NodeCount++;

            return true;
        }

        public Node Find(int value)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(int value)
        {
            throw new System.NotImplementedException();
        }

        public int GetTreeDepth()
        {
            throw new System.NotImplementedException();
        }

        public void TraversePreOrder(Node parent)
        {
            throw new System.NotImplementedException();
        }

        public void TraverseInOrder(Node parent)
        {
            throw new System.NotImplementedException();
        }

        public void TraversePostOrder(Node parent)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        #region Helper Methods

        private bool Add(int value, Node current)
        {
            if (value < current.Data)//check if on LEFT
            {
                if (current.Left != null) return Add(value, current.Left);
                current.Left = new Node { Data = value };
                NodeCount++;
                return true;
            }
            
            if (value > current.Data)
            {
                if (current.Right != null) return Add(value, current.Right);
                current.Right = new Node { Data = value };
                NodeCount++;
                return true;
            }

            //value already exists do not insert.
            return false;
        }

        #endregion Helper Methods
    }
}
