using System;
using System.Collections.Generic;

namespace Algo.Leetcode
{
    public class HNode
    {
        public HNode(string name, List<HNode> children = null)
        {
            this.Name = name;

            if (children != null)
                this.Children = children;
            else
                this.Children = new List<HNode>();
        }
        public string Name { get; set; }
        public List<HNode> Children { get; set; }
        public bool IsLeaf()
        {
            return this.Children == null || this.Children.Count <= 0;
        }
    }

    public class SharedSupervisor
    {
        /*
             A
           /   \
          B     C
         / \   /  \
        D   E  F   G
       / \
      H   I
        */
        private static HNode InitializeData()
        {
            var root = new HNode("A",
                        new List<HNode>()
                        {
                            new HNode("B",
                                new List<HNode>()
                                {
                                    new HNode("D",
                                        new List<HNode>()
                                        {
                                            new HNode("H"),
                                            new HNode("I")
                                        }
                                    ),
                                    new HNode("E")
                                }
                            ),
                            new HNode("C",
                                new List<HNode>()
                                {
                                    new HNode("F"),
                                    new HNode("G")
                                }
                            )
                        }
                    );
            return root;
        }

        public static HNode GetSharedSupervisor(HNode root, HNode n1, HNode n2)
        {
            // 1. Find n1 and store the path
            var path1 = new Stack<HNode>();
            path1.Push(root);
            var node1 = Find(root, n1, path1);

            // 2. Find n2 and store the path
            var path2 = new Stack<HNode>();
            path2.Push(root);
            var node2 = Find(root, n2, path2);

            // 3. Find the shared supervisor
            var array1 = path1.ToArray();
            Array.Reverse(array1);
            var array2 = path2.ToArray();
            Array.Reverse(array2);

            var length = array1.Length > array2.Length ? array2.Length : array1.Length;

            for (int i = 0; i < length - 1; i++)
            {
                if (array1[i].Name == array2[i].Name && array1[i + 1].Name != array2[i + 1].Name)
                    return array1[i];
            }
            return null;

        }

        public static HNode Find(HNode root, HNode target, Stack<HNode> path)
        {
            if (root.Name == target.Name)
                return root;

            foreach (var child in root.Children)
            {
                path.Push(child);

                if (child.Name == target.Name)
                    return child;
                else
                {
                    var result = Find(child, target, path);
                    if (result != null)
                        return result;
                    else
                        path.Pop();
                }
            }
            return null;
        }

        public static void Test()
        {
            var root = InitializeData();
            var sharedManager = GetSharedSupervisor(root, new HNode("E"), new HNode("I"));
            // Expected: B
        }
    }
}