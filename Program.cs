using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using algo.Algorithm;
using Algo.Exercise;
using Algo.Algorithm.Exercise;

namespace Algo
{
    class Program
    {
        // private static int Count = 0;
        // private static string Call()
        // {
        //     // Exit condition: to stop it running infinitly
        //     if(Count > 3)
        //         return "Done!";
        //     else
        //     {
        //         Count++;
        //         return Call();
        //     }
        // }
        static void Main(string[] args)
        {
            List<Dictionary<string, bool>> data = new List<Dictionary<string, bool>>()
            {
                new Dictionary<string, bool>()
                {
                    { "gym", false },
                    { "school", true },
                    { "store", false }
                },
                new Dictionary<string, bool>()
                {
                    { "gym", true },
                    { "school", false },
                    { "store", false }
                },
                new Dictionary<string, bool>()
                {
                    { "gym", true },
                    { "school", true },
                    { "store", false }
                },
                new Dictionary<string, bool>()
                {
                    { "gym", false },
                    { "school", true },
                    { "store", false }
                },
                new Dictionary<string, bool>()
                {
                    { "gym", false },
                    { "school", true },
                    { "store", true }
                }
            };

            var result = BestApartmentToLive.Find(data, new string[] { "gym", "school", "store" });
            ;

            // MyBinaryTree tree = new MyBinaryTree();
            // tree.Insert(1);
            // tree.Insert(2);
            // tree.Insert(3);
            // tree.Insert(4);
            // tree.Insert(5);
            // tree.Insert(6);
            // tree.Insert(7);
            // tree.Insert(8);

            // var result = Recursion2.Fib(50);

            // var input = "I AM CHRIS!";
            // var output = Recursion2.ReverseString(input);
            //var result = Recursion2.Factorial(5);
            //;
            //Console.WriteLine(Call());
            // var array1 = new int[] { -1, 3, 8, 2, 9, 5 };
            // var array2 = new int[] { 4, 1, 2, 10, 5, 20 };
            // var sum = 24;
            // var result = Puzzles.GetClosestPairOfSum(array1, array2, sum);
            //;
            // LinkedList lst = new LinkedList(1);
            // lst.Append(3);
            // lst.Append(4);
            // lst.Append(5);
            // lst.Insert(1, 2);
            // lst.Remove(0);
            // lst.Remove(lst.Length - 1);
            // lst.Remove(1);
            // ;
            // int[] a1 = new int[] { 2, 5, 1, 2, 3, 5, 1, 2, 4 };
            // int[] a2 = new int[] { 2, 1, 1, 2, 3, 5, 1, 2, 4 };
            // int[] a3 = new int[] { 2, 3, 4, 5 };

            // var val1 = Algo.FindFirstRecurringCharacter(a1);
            // var val2 = Algo.FindFirstRecurringCharacter(a2);
            // var val3 = Algo.FindFirstRecurringCharacter(a3);
            // var hsTbl = new MyHashTable(5);
            // hsTbl.Set("apple", 100.0);
            // hsTbl.Set("pear", 200.0);
            // hsTbl.Set("zip", 300.0);
            // hsTbl.Set("gap", 400.0);
            // hsTbl.Set("grape", 500.0);
            // hsTbl.Set("rock", 600.0);
            // hsTbl.Set("gold", 700.0);
            // hsTbl.Set("pic", 800.0);

            // var keys = hsTbl.Keys();
            //;
            // var obj = hsTbl.Get("apple");
            // obj = hsTbl.Get("pear");
            // obj = hsTbl.Get("zip");
            // obj = hsTbl.Get("gap");
            // obj = hsTbl.Get("grape");

            // var myArray = new MyArray();
            // for(int i = 0; i < 101; i++)
            // {
            //     myArray.Push(i);
            // }
            // myArray.Print();
            // myArray.Delete(100);
            // myArray.Print();
            // var item = myArray.Pop();
            // myArray.Print();
            // for(int i = 0; i < 100; i++)
            // {
            //     item = myArray.Pop();
            //     myArray.Print();
            // }
            // item = myArray.Pop();
            // myArray.Print();

            // Console.ReadLine();

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

            // var myLinkedList = new MyLinkedList(1);
            // myLinkedList.Append(2);
            // myLinkedList.Append(3);
            // myLinkedList.Append(4);
            // myLinkedList.Reverse();

            // myLinkedList.Append(10);
            // myLinkedList.Append(6);
            // myLinkedList.Append(10);
            // myLinkedList.Append(7);

            // myLinkedList.Print();
            // myLinkedList.Reverse();
            // myLinkedList.Print();

            // myLinkedList.Remove(null, 10);
            // myLinkedList.Remove(0, null);
            // myLinkedList.Remove(1, null);
            // myLinkedList.Remove(0, null);
            ;

            // MyStack stack = new MyStack();
            // stack.Push(1);
            // stack.Push(2);
            // stack.Push(3);

            // var peak = stack.Peek();
            // var n1 = stack.Pop();
            // var n2 = stack.Pop();
            // var n3 = stack.Pop();
            // var n4 = stack.Pop();

            // MyStack2 stack = new MyStack2();
            // stack.Push(1);
            // stack.Push(2);
            // stack.Push(3);
            // stack.Push(4);
            // stack.Push(5);
            // stack.Push(6);
            // stack.Push(7);
            // stack.Push(8);
            // stack.Push(9);
            // stack.Push(10);
            // stack.Push(11);

            // stack.Print();

            // var obj = stack.Peek();
            // obj = stack.Pop();
            // obj = stack.Pop();
            // obj = stack.Pop();
            // obj = stack.Pop();
            // stack.Print();
            // obj = stack.Pop();
            // stack.Print();
            // obj = stack.Pop();
            // obj = stack.Pop();
            // obj = stack.Pop();
            // obj = stack.Pop();
            // obj = stack.Pop();
            // stack.Print();
            // obj = stack.Pop();
            // stack.Print();

            // MyQueue queue = new MyQueue();
            // queue.Enqueue(1);
            // queue.Print();
            // queue.Enqueue(2);
            // queue.Print();
            // queue.Enqueue(3);
            // queue.Print();
            // queue.Enqueue(4);
            // queue.Print();
            // queue.Enqueue(5);
            // queue.Print();
            // var obj = queue.Peek();
            // obj = queue.Dequeue();
            // queue.Print();
            // obj = queue.Dequeue();
            // queue.Print();
            // obj = queue.Dequeue();
            // queue.Print();
            // obj = queue.Dequeue();
            // queue.Print();
            // queue.Enqueue(6);
            // queue.Print();
            // queue.Enqueue(7);
            // queue.Print();
            // queue.Enqueue(8);
            // queue.Print();
            // Console.WriteLine();



            // var lst = new LinkedList(1);
            // lst.Append(2);
            // lst.Append(3);
            // lst.Append(4);
            // lst.Reverse();

            // lst.Append(10);
            // lst.Append(6);
            // lst.Append(10);
            // lst.Append(7);

            // lst.Reverse();

            // var dlst = new DoublyLinkedList(1);
            // dlst.Append(2);
            // dlst.Append(3);
            // dlst.Append(4);
            // dlst.Append(5);

            // dlst.Print();
            // dlst.Prepend(0);
            // dlst.Print();

            // dlst.Remove(0);
            // dlst.Print();
            // dlst.Remove(4);
            // dlst.Print();
            // dlst.Remove(1);
            // dlst.Print();

            // Exercise.Queue q = new Exercise.Queue();
            // q.Enqueue(1);
            // q.Enqueue(2);
            // q.Enqueue(3);
            // q.Enqueue(4);
            // q.Enqueue(5);
            // q.Print();
            // var dt = q.Dequeue();
            // q.Print();
            // dt = q.Dequeue();
            // q.Print();
            // dt = q.Dequeue();
            // q.Print();
            // dt = q.Dequeue();
            // q.Print();
            // dt = q.Dequeue();
            // q.Print();
            // dt = q.Dequeue();
            // q.Print();


            // Exercise.Stack stack = new Exercise.Stack();
            // stack.Push(1);
            // stack.Push(2);
            // stack.Push(3);
            // stack.Push(4);
            // stack.Push(5);
            // stack.Print();
            // stack.Pop();
            // stack.Print();
            // stack.Pop();
            // stack.Print();
            // stack.Pop();
            // stack.Print();
            // stack.Pop();
            // stack.Print();
            // stack.Pop();
            // stack.Print();

            // Exercise.StackImplementedQueue queue = new StackImplementedQueue();
            // queue.Push(1);
            // queue.Push(2);
            // queue.Push(3);
            // queue.Push(4);
            // queue.Push(5);
            // var r = queue.Pop();
            // r = queue.Pop();
            // r = queue.Pop();
            // r = queue.Pop();
            // r = queue.Pop();
            // r = queue.Pop();

            // Exercise.QueueImplementedStack stack = new QueueImplementedStack();
            // stack.Push(1);
            // stack.Push(2);
            // stack.Push(3);
            // stack.Push(4);
            // stack.Push(5);
            // var r1 = stack.Pop();
            // r1 = stack.Pop();
            // r1 = stack.Pop();
            // r1 = stack.Pop();
            // r1 = stack.Pop();
            // r1 = stack.Pop();

        }
    }
}
