using System;
using System.Collections.Generic;
using System.Text;

namespace Algo.Leetcode
{
    /*
    297. https://leetcode.com/problems/serialize-and-deserialize-binary-tree/

    Serialization is the process of converting a data structure or object into a sequence of bits so that it can be stored in a file or memory buffer, or transmitted across a network connection link to be reconstructed later in the same or another computer environment.
    Design an algorithm to serialize and deserialize a binary tree. There is no restriction on how your serialization/deserialization algorithm should work. You just need to ensure that a binary tree can be serialized to a string and this string can be deserialized to the original tree structure.
    
    Clarification: The input/output format is the same as how LeetCode serializes a binary tree. You do not necessarily need to follow this format, so please be creative and come up with different approaches yourself.

    Example 1:
    Input: root = [1,2,3,null,null,4,5]
    Output: [1,2,3,null,null,4,5]

    Example 2:
    Input: root = []
    Output: []

    Example 3:
    Input: root = [1]
    Output: [1]

    Example 4:
    Input: root = [1,2]
    Output: [1,2]
    
    Constraints:

    The number of nodes in the tree is in the range [0, 104].
    -1000 <= Node.val <= 1000
    */
    public class BinaryTree_Serialize
    {
        public static TreeNode Initialize()
        {
            var root = new TreeNode(1, 
                            new TreeNode(2), 
                            new TreeNode(3, 
                                new TreeNode(4), 
                                new TreeNode(5)
                                )
                            );
            return root;
        }

        public static string serialize(TreeNode root)
        {
            if (root == null)
                return "#";

            return serial(root, new StringBuilder());
        }

        private static string serial(TreeNode currentNode, StringBuilder sb)
        {
            if (currentNode == null)
                sb.Append("#" + ",");
            else
            {
                sb.Append(currentNode.val + ",");
                serial(currentNode.left, sb);
                serial(currentNode.right, sb);
            }

            return sb.ToString();
        }

        public static TreeNode deserialize(string data)
        {
            var array = data.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            var queue = new Queue<string>(array);
            var result = deserial(queue);
            return result;
        }

        private static TreeNode deserial(Queue<string> queue)
        {
            if (queue.Count <= 0) return null;
            var item = queue.Dequeue();
            int? itemVal = (item == "#" ? null : int.Parse(item));
            if (itemVal == null)
                return null;
            var currentNode = new TreeNode(itemVal.Value);
            currentNode.left = deserial(queue);
            currentNode.right = deserial(queue);
            return currentNode;
        }
    }
}