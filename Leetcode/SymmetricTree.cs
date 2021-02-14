using System.Collections.Generic;

namespace Algo.Leetcode
{
    // https://leetcode.com/problems/symmetric-tree
    public class SymmetricTree
    {

        public static bool IsSymmetric2(TreeNode node)
        {
            if(node == null) return true;
            return SymmetricSubTree(node.left, node.right);
        }

        private static bool SymmetricSubTree(TreeNode left, TreeNode right)
        {
            if(left == null && right == null)
                return true;
            if(left == null || right == null)
                return false;
            return left.val == right.val && 
                    SymmetricSubTree(left.left, right.right) && 
                    SymmetricSubTree(left.right, right.left);
        }


        public static bool IsSymmetric(TreeNode root)
        {
            if (root == null)
                return true;
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var items = new List<TreeNode>();
                int queueCnt = queue.Count;
                for (int i = 0; i < queueCnt; i++)
                {
                    var currentNode = queue.Dequeue();
                    items.Add(currentNode);
                    if (currentNode != null)
                    {
                        queue.Enqueue(currentNode.left);
                        queue.Enqueue(currentNode.right);
                    }
                }
                for (int i = 0, j = queueCnt - 1; i < j; i++, j--)
                {
                    if (items[i] == null && items[j] == null)
                        continue;
                    if (items[i] == null || items[j] == null)
                        return false;
                    if (items[i].val != items[j].val)
                        return false;
                }
            }
            return true;
        }
    }
}