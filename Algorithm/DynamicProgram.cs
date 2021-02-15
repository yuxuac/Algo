using System.Collections.Generic;

namespace algo.Algorithm
{
    /// <summary>
    /// Dynamic programming is nothing but cache. 
    /// It uses cache to store calculation result in order to decrease time complexity.
    /// </summary>
    public class DynamicProgram
    {
        public DynamicProgram()
        {
            CalculationTimes = 0;
            Cache = new Dictionary<int, long>();
        }
        // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 154...
        public int CalculationTimes = 0;

        public Dictionary<int, long> Cache { get; set; }

        // Time complexity: O(2^n)
        public long Fib(int n)
        {
            CalculationTimes++;
            if (n < 2)
                return n;

            return Fib(n - 1) + Fib(n - 2);
        }

        // Time complexity: O(n)
        public long Fib_Cache(int n)
        {
            if (Cache.ContainsKey(n))
                return Cache[n];

            CalculationTimes++;

            if (n < 2)
                return n;

            if (!Cache.ContainsKey(n))
                Cache[n] = Fib_Cache(n - 1) + Fib_Cache(n - 2);

            return Cache[n];
        }

        public long Fib_Cache2(int n)
        {
            if (Cache.ContainsKey(n))
                return Cache[n];

            Cache[0] = 0;
            Cache[1] = 1;

            // Memorize results
            for (int i = 2; i <= n; i++)
            {
                CalculationTimes++;
                Cache[i] = Cache[i - 2] + Cache[i - 1];
            }
            return Cache[n];
        }

        // Exercises:
        // https://leetcode.com/problems/house-robber/
        // https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
        // https://leetcode.com/problems/climbing-stairs/
    }
}