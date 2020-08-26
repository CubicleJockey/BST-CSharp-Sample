namespace BST_Sample.BinarySearchTree
{
    public interface ITree
    {
        int NodeCount { get; }
        bool Add(int value);
        Node Find(int value);
        void Remove(int value);
        int GetTreeDepth();
        void TraversePreOrder(Node parent);
        void TraverseInOrder(Node parent);
        void TraversePostOrder(Node parent);
    }
}