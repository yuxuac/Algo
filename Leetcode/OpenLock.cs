using System.Collections.Generic;

namespace Algo.Leetcode
{
    /*
    
    https://leetcode.com/problems/open-the-lock/

    */
    public class OpenLockSolution
    {
        public static void Test()
        {
            var deadends = new string[] { "0201", "0101", "0102", "1212", "2002" };
            var target = "0202";
            OpenLock(deadends, target);
        }
        public static int OpenLock(string[] deadends, string target)
        {
            List<int> squares = new List<int>();
            
            // BFS
            HashSet<string> deads = new HashSet<string>(deadends);
            HashSet<string> visited = new HashSet<string>();

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("0000");
            visited.Add("0000");
            int level = 0;

            while (queue.Count > 0)
            {
                var queueSize = queue.Count;
                for (int i = 0; i < queueSize; i++)
                {
                    var currentNode = queue.Dequeue();
                    if (deads.Contains(currentNode))
                        continue;
                    if (currentNode == target)
                        return level;

                    for (int j = 0; j < target.Length; j++)
                    {
                        var currentDigit = int.Parse(currentNode[j].ToString());
                        var currentDigitAdd = currentDigit + 1;
                        var currentDigitMinus = currentDigit - 1;

                        var str1 = currentNode.Substring(0, j) + (currentDigitAdd > 9 ? 0 : currentDigitAdd) + currentNode.Substring(j + 1);
                        var str2 = currentNode.Substring(0, j) + (currentDigitMinus < 0 ? 9 : currentDigitMinus) + currentNode.Substring(j + 1);
                        if (!visited.Contains(str1) && !deads.Contains(str1))
                        {
                            visited.Add(str1);
                            queue.Enqueue(str1);
                        }
                        if (!visited.Contains(str2) && !deads.Contains(str2))
                        {
                            visited.Add(str2);
                            queue.Enqueue(str2);
                        }
                    }
                }
                level++;
            }
            return -1;
        }
    }
}