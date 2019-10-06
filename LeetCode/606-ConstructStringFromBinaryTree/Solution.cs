using BinaryTree;

namespace _606_ConstructStringFromBinaryTree
{
    internal class Solution
    {
        public string Tree2str(TreeNode t)
        {
            if (t == null)
            {
                return string.Empty;
            }

            var left = Tree2str(t.left);
            var right = Tree2str(t.right);

            var isLeftEmpty = string.IsNullOrEmpty(left);
            var isRightEmpty = string.IsNullOrEmpty(right);
            var rootVal = t.val.ToString();

            if (isLeftEmpty && isRightEmpty)
            {
                return t.val.ToString();
            }
            else if (isRightEmpty)
            {
                return $"{rootVal}({left})";
            }
            else if (isLeftEmpty)
            {
                return $"{rootVal}()({right})";
            }
            else
            {
                return $"{rootVal}({left})({right})";
            }
        }
    }
}
