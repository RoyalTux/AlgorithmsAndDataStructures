namespace DataStructures.BinarySearchTree
{
    public class Tree
    {
        public Node Insert(Node root, int value)
        {
            if (root == null)
            {
                root = new Node {Value = value};
            }
            else if (value < root.Value)
            {
                root.Left = Insert(root.Left, value);
            }
            else
            {
                root.Right = Insert(root.Right, value);
            }

            return root;
        }

        public void Traverse(Node root)
        {
            while (true)
            {
                if (root == null)
                {
                    return;
                }

                Traverse(root.Left);
                root = root.Right;
            }
        }
    }
}
