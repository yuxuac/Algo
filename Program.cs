using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using algo.Algorithm;

namespace Algo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[] { 3, 7, 8, 5, 2, 1, 9, 5, 4 };
			//int[] array = new int[] { 71, 61, 15, 90, 64, 25, 53, 63, 8, 51, 69, 16, 15, 68, 54, 80, 44, 19, 61, 53, 86, 90, 74, 79, 99, 16, 80, 74, 95, 1, 78, 37, 26, 66, 56, 80, 15, 14, 10, 59, 93, 34, 34, 92, 9, 61, 8, 42, 50, 99, 94, 56, 34, 13, 38, 14, 100, 76, 10, 24, 47, 49, 92, 94, 92, 63, 16, 68, 14, 86, 52, 95, 22, 9, 35, 57, 79, 11, 22, 63, 45, 26, 64, 64, 90, 83, 4, 90, 91, 37, 10, 64, 34, 27, 51, 48, 35, 40, 3, 76 };
            //int[] array = new int[] { 7, 8, 5, 9, 5, 4 };
            //int[] array = new int[] { 8, 9 };
            //int[] array = new int[] { 1, 4, 16, 14, 9 };
            // Sorting.QuickSort(array);
            // Sorting.Print(array);
            // ;
            // var val1 = Recursion.ReverseStringLoop("I am Bob");
            // var val2 = Recursion.ReverseStringRecursive("I am Bob");
            // Console.WriteLine(val1);
            /// ---
            // MyGraph graph = new MyGraph();
            // graph.AddVertex(0);
            // graph.AddVertex(1);
            // graph.AddVertex(2);
            // graph.AddVertex(3);
            // graph.AddVertex(4);
            // graph.AddVertex(5);
            // graph.AddVertex(6);

            // graph.AddEdge(3, 1);
            // graph.AddEdge(3, 4);
            // graph.AddEdge(4, 2);
            // graph.AddEdge(4, 5);
            // graph.AddEdge(1, 2);
            // graph.AddEdge(1, 0);
            // graph.AddEdge(0, 2);
            // graph.AddEdge(6, 5);

            // graph.ShowConnections();

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

            // var myBST = new MyBinarySearchTree();
            // myBST.Insert(75);
            // myBST.Insert(34);
            // myBST.Insert(77);
            // myBST.Insert(26);
            // myBST.Insert(52);
            // myBST.Insert(38);
            // myBST.Insert(62);
            // myBST.Insert(55);
            // myBST.Insert(64);
            // myBST.Insert(57);
            /*
                 75
               /   \
             34     77  
            /   \
          26     52
                /   \
               38    62
                    /  \
                  55   64
                   \
                    57
            */

            //var node = myBST.Lookup(52);
            //var result = myBST.Remove(0);

/*
            var myBST = new MyBinarySearchTree();
            myBST.Insert(9);
            myBST.Insert(4);
            myBST.Insert(6);
            myBST.Insert(20);
            myBST.Insert(170);
            myBST.Insert(15);
            myBST.Insert(1);
            myBST.Insert(3);
            myBST.Insert(0);
            myBST.Insert(5);
            myBST.Insert(7);
            myBST.Insert(14);
            myBST.Insert(16);
            myBST.Insert(31);
            myBST.Insert(180);
            
        //            9
        //        /       \
        //       4         20
        //     /  \       /   \
        //    1    6     15   170
        //   / \  / \   / \   / \
        //  0  3  5  7 14 16 31 180
            
            // BFS: Good: Shorest path, Closer nodes; Bad: Cost more memory
            var queue = new Queue<Node>();
            queue.Enqueue(myBST.GetRoot());
            Console.WriteLine("BFSResursive:");
            myBST.BFSResursive(queue, new List<Node>()); 

            // DFS: Good: Less momory, To answer: does path exists?; Bad: Can get slow.
            Console.WriteLine("DFS_InOrder:");
            myBST.DFS_InOrder(myBST.GetRoot()); // left-mid-right:  [0, 1, 3, 4, 5, 6, 7, 9, 14, 15, 16, 20, 31, 170, 180]
            Console.WriteLine("DFS_PreOrder:");
            myBST.DFS_PreOrder(myBST.GetRoot()); // mid-left-right: [9, 4, 1, 0, 3, 6, 5, 7, 20, 15, 14, 16, 170, 31, 180]
            Console.WriteLine("DFS_PostOrder:");
            myBST.DFS_PostOrder(myBST.GetRoot()); // left-right-mid:[0, 3, 1, 5, 7, 6, 4, 14, 16, 15, 31, 180, 170, 20, 9]
;
            // https://stackoverflow.com/questions/9844193/what-is-the-time-and-space-complexity-of-a-breadth-first-and-depth-first-tree-tr
            */

			/*
            DynamicProgram dp = new DynamicProgram();
            int index = 102;
            var val = dp.Fib_Cache2(index);
            // Fib(102): 5035488507601418376, CalculationTimes: 103
            // Fib(102): 5035488507601418376, CalculationTimes: 104
            // Fib(102): 5035488507601418376, CalculationTimes: 101

            Console.WriteLine($"Fib({index}): {val}, CalculationTimes: {dp.CalculationTimes}");
            */
			
            /*
			var myLinkedList = new MyLinkedList(10);
			myLinkedList.Append(5);
			myLinkedList.Append(16);
            myLinkedList.Print();
            // list now: 10->5->16
            
            myLinkedList.Remove(0, null);
            myLinkedList.Print();
            // list now: 5->16

            myLinkedList.Prepend(10);
            myLinkedList.Print();
            // list now: 10->5->16

            myLinkedList.Remove(2, null);
            myLinkedList.Print();
            // list now: 10->5

            myLinkedList.Append(16);
            myLinkedList.Print();
            // list now: 10->5->16

            myLinkedList.Append(10);
            myLinkedList.Append(1);
            myLinkedList.Append(10);
            myLinkedList.Append(1);
            myLinkedList.Append(10);
            myLinkedList.Print();
            // list now: 10->5->16->10->1->10->1->10

            myLinkedList.Remove(null, 10);
            myLinkedList.Print();
            // list now: 5->16->1->1
            */

            var myDoublyLinkedList = new MyDoublyLinkedList(10);
            myDoublyLinkedList.Append(10);
            myDoublyLinkedList.Append(5);
            myDoublyLinkedList.Append(10);
            myDoublyLinkedList.Append(10);
            myDoublyLinkedList.Append(6);
            myDoublyLinkedList.Append(10);
            myDoublyLinkedList.Append(7);

            myDoublyLinkedList.Remove(null, 10);
            myDoublyLinkedList.Remove(0, null);
            myDoublyLinkedList.Remove(1, null);
            myDoublyLinkedList.Remove(0, null);
            ;
        }
    }
}
