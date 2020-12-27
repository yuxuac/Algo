using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;

namespace pg1
{
    class Program
    {
        static void Main(string[] args)
        {
            // var array1 = new int[] { 2, 1, 7, -3, 9, 5, -2 };
            // var result = Algo1.IsSumExistsInArray(array1, 5);
            // Console.WriteLine("result:" + JsonSerializer.Serialize(result));

            // I am chris! => !sirhc ma I
            //var result = Algo2.ReverseString("!sirhc ma I");
            //Console.WriteLine(result);

            var array1 = new int[] { 0, 3, 4, 31 };
            var array2 = new int[] { };

            var mergedArray = Algo.MergeSortedArrays(array1, array2);
            Console.WriteLine(string.Join(",", mergedArray));
        }
    }
}
