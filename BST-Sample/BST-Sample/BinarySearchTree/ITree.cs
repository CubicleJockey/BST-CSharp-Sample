namespace BST_Sample.BinarySearchTree
{
    public interface ITree<T>
    {
        bool Add(T value);
        Node<T> Find(T value);
        void Remove(T value);
        int GetTreeDepth();
        void TraversePreOrder(Node<T> parent);
        void TraverseInOrder(Node<T> parent);
        void TraversePostOrder(Node<T> parent);
    }
}