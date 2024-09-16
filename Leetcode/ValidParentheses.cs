using System.Collections.Generic;

namespace Algo.Leetcode
{
    /*
    https://leetcode.com/problems/valid-parentheses/

    */
    public class ValidParentheses
    {
        public static bool IsValid(string s)
        {
            var array = s.ToCharArray();
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '(' || array[i] == '[' || array[i] == '{')
                    stack.Push(array[i]);
                else if (stack.Count <= 0)
                    return false;
                else if (array[i] == ')' && stack.Peek() == '(')
                    stack.Pop();
                else if (array[i] == ']' && stack.Peek() == '[')
                    stack.Pop();
                else if (array[i] == '}' && stack.Peek() == '{')
                    stack.Pop();
                else
                    stack.Push(array[i]);
            }
            return stack.Count == 0;
        }
    }
}