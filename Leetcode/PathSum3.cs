using System.Collections.Generic;

namespace Algo.Leetcode
{
    // https://leetcode.com/problems/path-sum-iii/

    /*
    
    You are given a binary tree in which each node contains an integer value.
    Find the number of paths that sum to a given value.
    The path does not need to start or end at the root or a leaf, but it must go downwards (traveling only from parent nodes to child nodes).
    The tree has no more than 1,000 nodes and the values are in the range -1,000,000 to 1,000,000.

    root = [10,5,-3,3,2,null,11,3,-2,null,1], sum = 8

          10
         /  \
        5   -3
       / \    \
      3   2   11
     / \   \
    3  -2   1

    Return 3. The paths that sum to 8 are:

    1.  5 -> 3
    2.  5 -> 2 -> 1
    3. -3 -> 11
    */
    public class PathSum3
    {
        public static TreeNode InitializeTree()
        {
            TreeNode root = new TreeNode(10, 
                                new TreeNode(5, 
                                    new TreeNode(3
                                        //, 
                                        // new TreeNode(3), 
                                        // new TreeNode(-2)
                                    ), 
                                    new TreeNode(2
                                        // , 
                                        // null, 
                                        // new TreeNode(1)
                                    )
                                ), 
                                new TreeNode(-3, 
                                    null, 
                                    new TreeNode(11)
                                )
                            );
            return root;
        }

        public static int PathSum(TreeNode root, int sum)
        {
            if (root == null) return 0;

            Dictionary<int, int> dic = new Dictionary<int, int>();
            dic.Add(0, 1);
            return findPathSum(root, 0, sum, dic);

        }

        private static int findPathSum(TreeNode currentNode, int currentSum, int target, Dictionary<int, int> dic)
        {
            if (currentNode == null) return 0;

            currentSum += currentNode.val;

            // if (current - target) exists in dic, it means the path exists.
            int numPathToCurr = dic.ContainsKey(currentSum - target) ? dic[currentSum - target] : 0;

            if (dic.ContainsKey(currentSum))
                dic[currentSum]++;
            else
                dic.Add(currentSum, 1);

            int result = numPathToCurr + findPathSum(currentNode.left, currentSum, target, dic) + findPathSum(currentNode.right, currentSum, target, dic);

            dic[currentSum]--;
            return result;
        }
    }
}