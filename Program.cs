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

            // var array1 = new int[] { 0, 3, 4, 31 };
            // var array2 = new int[] { };

            // var mergedArray = Algo.MergeSortedArrays(array1, array2);
            // Console.WriteLine(string.Join(",", mergedArray));

            // var myhashtable = new MyHashTable(2);
            // myhashtable.Set("apple", 300);
            // myhashtable.Set("pear", 13300);
            // myhashtable.Set("cherry", 300);
            // var num1 = myhashtable.Get("apple");
            // var num2 = myhashtable.Get("pear");
            // var num3 = myhashtable.Get("cherry");
            // var num4 = myhashtable.Get("pig");

            var myBST = new MyBinarySearchTree();
            myBST.Insert(75);
            myBST.Insert(34);
            myBST.Insert(77);
            myBST.Insert(26);
            myBST.Insert(52);
            myBST.Insert(38);
            myBST.Insert(62);
            myBST.Insert(55);
            myBST.Insert(64);
            myBST.Insert(57);

            var node = myBST.Lookup(52);
            var result = myBST.Remove(0);

        }
    }
}
