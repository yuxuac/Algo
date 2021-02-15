using System.Collections.Generic;

namespace Algo.Leetcode
{
    /*
    https://leetcode.com/problems/populating-next-right-pointers-in-each-node/

    You are given a perfect binary tree where all leaves are on the same level, and every parent has two children. The binary tree has the following definition:

    struct TreeNode2 {
    int val;
    TreeNode2 *left;
    TreeNode2 *right;
    TreeNode2 *next;
    }
    Populate each next pointer to point to its next right node. If there is no next right node, the next pointer should be set to NULL.

    Initially, all next pointers are set to NULL.

    

    Follow up:

    You may only use constant extra space.
    Recursive approach is fine, you may assume implicit stack space does not count as extra space for this problem.
 
    */
    public class BinaryTree_RightPointers
    {
        public static TreeNode2 Initialize()
        {
            var root = new TreeNode2(1, 
                            new TreeNode2(2, 
                                new TreeNode2(4), 
                                new TreeNode2(5), 
                                null), 
                            new TreeNode2(3, 
                                new TreeNode2(6), 
                                new TreeNode2(7), 
                                null), 
                            null);
            return root;
        }

        public static TreeNode2 Connect(TreeNode2 root)
        {
            if (root == null)
                return null;
            Queue<TreeNode2> queue = new Queue<TreeNode2>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var queueSize = queue.Count;
                for (int i = 0; i < queueSize; i++)
                {
                    var currentTreeNode2 = queue.Dequeue();
                    var nextTreeNode2 = (i < queueSize - 1 ? queue.Peek() : null);
                    currentTreeNode2.next = nextTreeNode2;

                    if (currentTreeNode2.left != null)
                        queue.Enqueue(currentTreeNode2.left);
                    if (currentTreeNode2.right != null)
                        queue.Enqueue(currentTreeNode2.right);
                }
            }
            return root;
        }


    }

}