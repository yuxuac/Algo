using System.Collections.Generic;

namespace algo.implement_queue_using_stacks
{
    /* 
    https://leetcode.com/problems/implement-queue-using-stacks/
    
    Implement a first in first out (FIFO) queue using only two stacks. The implemented queue should support all the functions of a normal queue (push, peek, pop, and empty).

    Implement the MyQueue class:

    void push(int x) Pushes element x to the back of the queue.
    int pop() Removes the element from the front of the queue and returns it.
    int peek() Returns the element at the front of the queue.
    boolean empty() Returns true if the queue is empty, false otherwise.
    Notes:

    You must use only standard operations of a stack, which means only push to top, peek/pop from top, size, and is empty operations are valid.
    Depending on your language, the stack may not be supported natively. You may simulate a stack using a list or deque (double-ended queue) as long as you use only a stack's standard operations.
    Follow-up: Can you implement the queue such that each operation is amortized O(1) time complexity? In other words, performing n operations will take overall O(n) time even if one of those operations may take longer.

    Example 1:

    Input
    ["MyQueue", "push", "push", "peek", "pop", "empty"]
    [[], [1], [2], [], [], []]
    Output
    [null, null, null, 1, 1, false]

    Explanation
    MyQueue myQueue = new MyQueue();
    myQueue.push(1); // queue is: [1]
    myQueue.push(2); // queue is: [1, 2] (leftmost is front of the queue)
    myQueue.peek(); // return 1
    myQueue.pop(); // return 1, queue is [2]
    myQueue.empty(); // return false

    Constraints:

    1 <= x <= 9
    At most 100 calls will be made to push, pop, peek, and empty.
    All the calls to pop and peek are valid.    
    */
    
    public class MyQueue
    {

        private Stack<int?> dataStack = null;
        private Stack<int?> tempStack = null;
        private int? First { get; set; }
        private int? Last { get; set; }
        private long Length;

        /** Initialize your data structure here. */
        public MyQueue()
        {
            this.dataStack = new Stack<int?>();
            this.tempStack = new Stack<int?>();
            this.First = null;
            this.Last = null;
            this.Length = 0;
        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            if (this.Length == 0)
            {
                this.First = x;
            }
            this.Last = x;
            this.dataStack.Push(x);
            this.Length++;
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            if (this.tempStack == null)
                this.tempStack = new Stack<int?>();
            else
                this.tempStack.Clear();

            while (this.dataStack.Count > 0)
            {
                this.tempStack.Push(this.dataStack.Pop());
            }

            // Get result item
            var lastItem = this.tempStack.Pop();

            var index = 0;
            var tempStackLength = this.tempStack.Count;
            while (index < tempStackLength)
            {
                var item = this.tempStack.Pop();

                // First
                if (index == 0)
                    this.First = item;

                // Last
                else if (index == tempStackLength - 1)
                    this.Last = item;

                this.dataStack.Push(item);
                index++;
            }
            this.Length--;

            return lastItem.Value;
        }

        /** Get the front element. */
        public int Peek()
        {
            return this.First.Value;
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return this.Length <= 0;
        }
    }

    /**
     * Your MyQueue object will be instantiated and called as such:
     * MyQueue obj = new MyQueue();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Peek();
     * bool param_4 = obj.Empty();
     */
}