using System;
using System.Collections.Generic;

namespace Algo
{
    // Important article:
    // https://thecodebarbarian.com/i-dont-want-to-hire-you-if-you-cant-reverse-a-binary-tree
    // https://www.educative.io/edpresso/how-to-invert-a-binary-tree

    public class TreeObjNode
    {
        public TreeObjNode(object input)
        {
            this.Value = input;
        }

        public object Value { get; set; }
        public TreeObjNode Left { get; set; }
        public TreeObjNode Right { get; set; }
    }

    public class MyBinaryTree
    {
        private TreeObjNode root;
        public MyBinaryTree()
        {
            this.root = null;
        }

        public TreeObjNode GetRoot()
        {
            return this.root;
        }

        // BFS Insert

        /*
           1
         /   \
        2     3
       / \   / \
      4   5 6   7
        */
        public TreeObjNode Insert(object val)
        {
            Queue<TreeObjNode> queue = new Queue<TreeObjNode>();
            if (this.root == null)
            {
                this.root = new TreeObjNode(val);
                return this.root;
            }

            queue.Enqueue(this.root);

            while (queue.Count > 0)
            {
                var currentNode = queue.Dequeue();

                if (currentNode.Left == null)
                {
                    currentNode.Left = new TreeObjNode(val);
                    return currentNode.Left;
                }
                else if (currentNode.Right == null)
                {
                    currentNode.Right = new TreeObjNode(val);
                    return currentNode.Right;
                }

                if (currentNode.Left != null)
                    queue.Enqueue(currentNode.Left);

                if (currentNode.Right != null)
                    queue.Enqueue(currentNode.Right);
            }
            return null;
        }

        // bottom up - Post_Order: left -> right -> parent
        public int Depth2(TreeObjNode node)
        {
            if(node == null)
                return 0;
            int leftDepth = Depth2(node.Left);
            int rightDepth = Depth2(node.Right);
            return (leftDepth > rightDepth ? leftDepth: rightDepth) + 1;
        }

        public int Depth()
        {
            int maxDepth = 0;
            MaximumDepth(this.root, 1, ref maxDepth);
            return maxDepth;
        }

        // top-down - Pre_order: parent -> left -> right
        private void MaximumDepth(TreeObjNode node, int depth, ref int maxDepth)
        {
            if (node == null)
                return;

            if(node.Left == null && node.Right == null)
                maxDepth = depth > maxDepth ? depth : maxDepth;

            if (node.Left != null)
                MaximumDepth(node.Left, depth + 1, ref maxDepth);
            if (node.Right != null)
                MaximumDepth(node.Right, depth + 1, ref maxDepth);
        }

        
    }
}