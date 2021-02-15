namespace algo.Algorithm
{
    public static class Recursion
    {
        /*
            1. Identify the base case.
            2. Identify the recursive case.
            Get closer and closer and return when needed. Usually you have 2 returns.
        */

        private static int Counter = 0;

        public static string RecursiveHello()
        {
            // 1. Base base
            if (Counter < 3)
            {
                Counter++;
                return "Done";
            }
            // 2. Recursive case
            else
                return RecursiveHello();
        }

        // sum = 10000
        // Fibonacci
        // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 
        // O(2^N)
        public static int FibRecursive(int n)
        {
            // Base case
            if (n <= 1) 
                return n;
            // Recursive case
            else 
                return FibRecursive(n - 2) + FibRecursive(n - 1);
        }

        public static int FibLoop(int n)
        {
            if (n <= 1) return n;

            var fib_2 = 0;
            var fib_1 = 1;
            var sum = 0;

            for (int i = 2; i <= n; i++)
            {
                sum = fib_1 + fib_2;
                fib_2 = fib_1;
                fib_1 = sum;
            }
            return sum;
        }

        // 5! = 5 * 4 * 3 * 2 * 1
        // O(n)
        public static int FactorialRecursive(int n)
        {
            if (n <= 1) return 1;
            else return n * FactorialRecursive(n - 1);
        }

        // 5! = 5 * 4 * 3 * 2 * 1
        // O(n)
        public static int FactorialLoop(int n)
        {
            if (n <= 1) return 1;

            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

		// I am Bob
		// boB ma I
        public static string ReverseStringRecursive(string str)
        {
			if(string.IsNullOrEmpty(str) || str.Length == 1) 
                return str;
			else
                return str[str.Length - 1] + ReverseStringRecursive(str.Substring(0, str.Length - 1));
        }
		
		public static string ReverseStringLoop(string str)
        {
            char[] resultArray = new char[str.Length];
            char[] source = str.ToCharArray();
			
            for(int i = str.Length - 1; i >= 0; i--)
			{
				resultArray[str.Length - 1 - i] = source[i];
			}
			return string.Join("", resultArray);
        }

        // Things can use recursion:
        // 1. Merge Sort
        // 2. Quick Sort
        // 3. Tree Traversal
        // 4. Graph Traversal
        // Anything you do with a recuision CAN be done iteratively(loop).
        
    }
}