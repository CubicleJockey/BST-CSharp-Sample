namespace BST_Sample.BinarySearchTree
{
    public class Tree<T> : ITree<T>
    {
        public Node<T> Head { get; set; }

        #region Implementation of ITree<T>

        public bool Add(T value)
        {
            throw new System.NotImplementedException();
        }

        public Node<T> Find(T value)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(T value)
        {
            throw new System.NotImplementedException();
        }

        public int GetTreeDepth()
        {
            throw new System.NotImplementedException();
        }

        public void TraversePreOrder(Node<T> parent)
        {
            throw new System.NotImplementedException();
        }

        public void TraverseInOrder(Node<T> parent)
        {
            throw new System.NotImplementedException();
        }

        public void TraversePostOrder(Node<T> parent)
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}
