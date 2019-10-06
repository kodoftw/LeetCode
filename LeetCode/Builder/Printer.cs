namespace BinaryTree
{
    public class Printer
    {
        public static string InOrder(TreeNode node)
        {
            if (node == null)
            {
                return "null";
            }

            return $"{InOrder(node.left)},{node.val},{InOrder(node.right)}";
        }
    }
}
