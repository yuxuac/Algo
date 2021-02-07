using System;
using System.Collections.Generic;

namespace Algo
{
    // Important article:
    // https://thecodebarbarian.com/i-dont-want-to-hire-you-if-you-cant-reverse-a-binary-tree
    // https://www.educative.io/edpresso/how-to-invert-a-binary-tree

    public class MyBinaryTree
    {
        private TreeNode root;
        public MyBinaryTree()
        {
            this.root = null;
        }

        public TreeNode GetRoot()
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
        public TreeNode Insert(int val)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            if(this.root == null)
            {
                this.root = new TreeNode(val);
                return this.root;
            }

            queue.Enqueue(this.root);
            
            while(queue.Count > 0)
            {
                var currentNode = queue.Dequeue();

                if(currentNode.Left == null)
                {
                    currentNode.Left = new TreeNode(val);
                    return currentNode.Left;
                }
                else if(currentNode.Right == null)
                {
                    currentNode.Right = new TreeNode(val);
                    return currentNode.Right;
                }

                if(currentNode.Left != null)
                    queue.Enqueue(currentNode.Left);

                if(currentNode.Right != null)
                    queue.Enqueue(currentNode.Right);
            }
            return null;
        }
    }
}