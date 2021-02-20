using System.Collections.Generic;

namespace Algo.Leetcode
{
    /*
    https://leetcode.com/problems/daily-temperatures/
    */
    public class DailyTemperaturesAlgo
    {
        public static int[] GetInput()
        {
            return new int[] { 89, 62, 70, 58, 47, 47, 46, 76, 100, 70 };
        }
        public static int[] DailyTemperatures(int[] T)
        {

            if (T == null || T.Length <= 0)
                return new int[0];

            int[] result = new int[T.Length];
            Stack<Item> stack = new Stack<Item>();

            for (int i = T.Length - 1; i >= 0; i--)
            {
                // Remove all items in stack which has a lower temp than current one in T
                while(stack.Count > 0 && stack.Peek().Temp <= T[i])
                    stack.Pop();
                
                // Record the days between current and next warmer day
                if(stack.Count > 0 && stack.Peek().Temp > T[i])
                    result[i] = stack.Peek().Index - i;
                
                stack.Push(new Item(i, T[i]));
            }

            return result;

                        /*
            stack.Push(new Item(T.Length - 1, T[T.Length - 1]));
            result[T.Length - 1] = 0;

            for (int i = T.Length - 2; i >= 0; i--)
            {
                

                if (stack.Count <= 0)
                {
                    result[i] = 0;
                    stack.Push(new Item(i, T[i]));
                }
                else if (stack.Peek().Temp > T[i])
                {
                    result[i] = stack.Peek().Index - i;
                    stack.Push(new Item(i, T[i]));
                }
                else if (stack.Peek().Temp <= T[i])
                {
                    while (stack.Count > 0 && stack.Peek().Temp < T[i])
                    {
                        stack.Pop();
                    }

                    if (stack.Count == 0)
                    {
                        stack.Push(new Item(i, T[i]));
                        result[i] = 0;
                    }
                    else
                    {
                        result[i] = stack.Peek().Index - i;
                        stack.Push(new Item(i, T[i]));
                    }
                }
            }
            */
        }

        public struct Item
        {
            public Item(int index, int temp)
            {
                this.Index = index;
                this.Temp = temp;
            }

            public int Index { get; set; }
            public int Temp { get; set; }
        }
    }
}