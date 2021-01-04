using System;

namespace Algo
{
    public class Node
    {
        public Node(int input)
        {
            this.Value = input;
        }

        public int? Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }

    public class MyBinarySearchTree
    {
        private Node root;
        public MyBinarySearchTree()
        {
            this.root = null;
        }

        public Node Insert(int val)
        {
            var currentNode = this.root;

            if (this.root == null)
            {
                this.root = new Node(val);
            }
            else
            {
                while (true)
                {
                    if (currentNode.Value > val)
                    {
                        if (currentNode.Left == null)
                        {
                            currentNode.Left = new Node(val);
                            break;
                        }
                        else
                            currentNode = currentNode.Left;
                    }
                    else if (currentNode.Value < val)
                    {
                        if (currentNode.Right == null)
                        {
                            currentNode.Right = new Node(val);
                            break;
                        }
                        else
                            currentNode = currentNode.Right;
                    }
                    else
                    {
                        currentNode = null;
                        break;
                    }
                }
            }

            return currentNode;
        }

        public Tuple<Node, Node> Lookup(int val)
        {
            if (this.root == null)
            {
                return null;
            }
            else
            {
                var currentNode = this.root;
                Node currentParentNode = null;

                while (true)
                {
                    if (currentNode.Value > val)
                    {
                        currentParentNode = currentNode;
                        currentNode = currentNode.Left;
                    }
                    else
                    {
                        currentParentNode = currentNode;
                        currentNode = currentNode.Right;
                    }

                    // Can't find any.
                    if (currentNode == null)
                        break;
                    
                    // Find one.
                    if (currentNode.Value == val)
                        return Tuple.Create<Node, Node>(currentNode, currentParentNode);
                }
            }
            return null;
        }

        public bool Remove(int val)
        {
            // 1. No children, delete it directly
            // 2. Has one child, delete it and link parent to its child
            // 3. the node Has 2 children, right child's left child (keep looping until it has no left child)
            //    the node's parent's right child -> the target node (delink the parent)
            //    the target node's parent's left child = null (delete the target node in original position)
            //    the target node's children = the node's children (left and right, delink the children)
            var targetNode = Lookup(val);
            var currentNode = targetNode.Item1;
            var currentParentNode = targetNode.Item2;

            if (targetNode != null)
            {
                // 1. No children, delete it directly
                if (currentNode.Left == null && currentNode.Right == null)
                {
                    if (currentParentNode.Left.Value == currentNode.Value)
                        currentParentNode.Left = null;
                    else if (currentParentNode.Right.Value == currentNode.Value)
                        currentParentNode.Right = null;
                }
                // 3. the node Has 2 children
                else if (currentNode.Left != null && currentNode.Right != null)
                {
                    var firstRight = currentNode.Right;
                    var currentTarget = firstRight;
                    Node currentTargetParent = currentNode;
                    while (true)
                    {
                        if (currentTarget.Left == null)
                            break;
                        currentTargetParent = currentTarget;
                        currentTarget = currentTarget.Left;
                    }

                    // the node's parent's right child -> the target node (delink the parent)
                    currentParentNode.Right = currentTarget;
                    currentTargetParent.Left = currentTarget.Right;
                    currentTarget.Right = firstRight;
                    currentTarget.Left = currentNode.Left;
                }
                // 2. Has one child, delete it and link parent to its child
                else if (currentNode.Left != null)
                {
                    if (currentParentNode.Left.Value == currentNode.Value)
                        currentParentNode.Left = currentNode.Left;
                    else if (currentParentNode.Right.Value == currentNode.Value)
                        currentParentNode.Right = currentNode.Left;
                }
                else if (currentNode.Right != null)
                {
                    if (currentParentNode.Left.Value == currentNode.Value)
                        currentParentNode.Left = currentNode.Right;
                    else if (currentParentNode.Right.Value == currentNode.Value)
                        currentParentNode.Right = currentNode.Right;
                }
                return true;
            }
            return false;
        }
    }
}