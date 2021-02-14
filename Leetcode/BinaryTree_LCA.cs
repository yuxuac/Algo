using System;
using System.Collections.Generic;

namespace Algo.Leetcode
{
    /*
    https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree/

    Given a binary tree, find the lowest common ancestor (LCA) of two given nodes in the tree.

    According to the definition of LCA on Wikipedia: “The lowest common ancestor is defined between two nodes p and q as the lowest node in T that has both p and q as descendants (where we allow a node to be a descendant of itself).”

    Example 1:
    Input: root = [3,5,1,6,2,0,8,null,null,7,4], p = 5, q = 1
    Output: 3
    Explanation: The LCA of nodes 5 and 1 is 3.

    Example 2:
    Input: root = [3,5,1,6,2,0,8,null,null,7,4], p = 5, q = 4
    Output: 5
    Explanation: The LCA of nodes 5 and 4 is 5, since a node can be a descendant of itself according to the LCA definition.
    
    Example 3:
    Input: root = [1,2], p = 1, q = 2
    Output: 1

    Constraints:
        The number of nodes in the tree is in the range [2, 105].
        -109 <= TreeNode2.val <= 109
        All TreeNode2.val are unique.
        p != q
        p and q will exist in the tree.
    */
    public class BinaryTree_LCA
    {
        public static TreeNode2 Initialize()
        {
            var root = new TreeNode2(3,
                new TreeNode2(5,
                    new TreeNode2(6),
                    new TreeNode2(2,
                        new TreeNode2(7),
                        new TreeNode2(4),
                        null
                    ),
                    null
                ),
                new TreeNode2(1,
                    new TreeNode2(0),
                    new TreeNode2(8),
                    null
                ),
                null
            );
            return root;
        }
        public static TreeNode2 LowestCommonAncestor(TreeNode2 root, TreeNode2 p, TreeNode2 q)
        {
            if (root == null)
                return null;

            Stack<TreeNode2> stack_p = new Stack<TreeNode2>();
            Stack<TreeNode2> stack_q = new Stack<TreeNode2>();

            var node_p = Find(root, p.val, stack_p);
            var node_q = Find(root, q.val, stack_q);

            var array_p = stack_p.ToArray();
            Array.Reverse(array_p);
            var array_q = stack_q.ToArray();
            Array.Reverse(array_q);

            TreeNode2 result = null;
            var maxLength = array_p.Length > array_q.Length ? array_p.Length : array_q.Length;
            var minLength = array_p.Length < array_q.Length ? array_p.Length : array_q.Length;
            for (int i = 0; i < maxLength; i++)
            {
                if (i == array_p.Length - 1 || i == array_q.Length - 1)
                {
                    return array_p[i];
                }
                else if (array_p[i] == array_q[i] && array_p[i + 1] != array_q[i + 1])
                {
                    return array_p[i];
                }
            }
            return result;
        }

        private static TreeNode2 Find(TreeNode2 currentNode, int val, Stack<TreeNode2> stack)
        {
            if (currentNode == null)
                return null;

            else if (currentNode.val == val)
            {
                stack.Push(currentNode);
                return currentNode;
            }

            TreeNode2 result = null;
            stack.Push(currentNode);

            if (currentNode.left != null)
                result = Find(currentNode.left, val, stack);

            if (result == null && currentNode.right != null)
                result = Find(currentNode.right, val, stack);

            if (result == null)
                stack.Pop();

            return result;
        }
    }
}