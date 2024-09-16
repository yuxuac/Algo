using System;
using System.Collections.Generic;

namespace Algo.Exercise
{
    public class Recursion2
    {
        // 5! = 5 * 4 * 3 * 2 * 1
        /*
        n = 1                  1
        n = 2              2 * 1          n * Factorial(n-1)
        n = 3          3 * 2 * 1          3 * Factorial(2)
        n = 4      4 * 3 * 2 * 1          4 * Factorial(3)
        n = 5  5 * 4 * 3 * 2 * 1          5 * Factorial(4)
        */
        public static int Factorial(int n)
        {
            if(n <= 1)
                return n;
            else 
                return n * Factorial(n-1);
        }

        /*
        a, b, c, d, e
        e, [a, b, c, d]
        e, d, [a, b, c]
        e, d, c, [a, b]
        e, d, c, b, [a]
        =>
        e, d, c, b, a
        */
        public static string ReverseString(string input)
        {
            var inputArray = input.ToCharArray();
            var outputArray = ReverseStringRecursive(inputArray);
            return string.Join("", outputArray);
        }

        private static char[] ReverseStringRecursive(char[] inputArray)
        {
            if(inputArray.Length <= 1)
                return inputArray;
            else
            {
                var resultArray = new char[inputArray.Length];

                var tempArray = new char[inputArray.Length - 1];
                for(int i = 0 ; i < tempArray.Length; i++)
                {
                    tempArray[i] = inputArray[i];
                }
                var reversedArray = ReverseStringRecursive(tempArray);
                resultArray[0] = inputArray[inputArray.Length - 1];
                reversedArray.CopyTo(resultArray, 1);
                return resultArray;
            }
        }
        
        /*
        0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233 
		
		0, 1, 2, 3, 4, 5, 6, 7,   8,  9  10,  11, 12, 13
		
		0 => 0
		1 => 1
		2 => 0:f(0) + 1:f(1) => f(0) + f(1)
		3 => 1:f(1) + 1:f(2) => f(1) + f(2)
		4 => 1:f(2) + 2:f(3) => f(2) + f(3)
		5 => 2:f(3) + 3:f(4) => f(3) + f(4)
        */
		private static Dictionary<long, long> Fib_Cache = new Dictionary<long, long>();
		
        public static long Fib(long n)
        {
			if(n <= 2)
				return 1;
			else 
			{
				if(!Fib_Cache.ContainsKey(n))
				{
					Fib_Cache[n] = Fib(n - 2) + Fib(n - 1);
				}
				return Fib_Cache[n];
			}
        }
    }

}