using System;

namespace Algo.Exercise
{
    public class LinkedList
    {
        public LstNode Head { get; set; }
        public LstNode Tail { get; set; }
        public int Length { get; set; }

        public LinkedList(object val)
        {
            this.Head = new LstNode(val);
            this.Tail = this.Head;
            this.Length = 1;
        }

        public void Prepend(object val)
        {
            var newNode = new LstNode(val);
            newNode.Next = this.Head;
            this.Head = newNode;
            this.Length++;
        }

        public void Append(object val)
        {
            var newNode = new LstNode(val);
            this.Tail.Next = newNode;
            this.Tail = newNode;
            this.Length++;
        }

        public void Insert(long index, object val)
        {
            if (index < 0 || index >= this.Length)
                throw new ArgumentException("index is out of range.");

            // 1. index = 0 || index = this.Length - 1
            if (index == 0)
                this.Prepend(val);
            else if (index == this.Length - 1)
                this.Append(val);
            // 2. index in the middle
            else
            {
                var newNode = new LstNode(val);

                long pointer = 0;
                var leadingNode = this.Head;
                while (pointer < index - 1)
                {
                    leadingNode = leadingNode.Next;
                    pointer++;
                }
                var currentNode = leadingNode.Next;
                leadingNode.Next = newNode;
                newNode.Next = currentNode;
                this.Length++;
            }
        }

        public void Remove(long index)
        {
            if (index < 0 || index >= this.Length)
                throw new ArgumentException("index is out of range.");

            if (index == 0)
            {
                this.Head = this.Head.Next;
                this.Length--;
            }
            else
            {
                var pointer = 0;
                var leadingNode = this.Head;
                while (pointer < index - 1)
                {
                    leadingNode = leadingNode.Next;
                    pointer++;
                }

                var currentNode = leadingNode.Next;
                // If it is the tail node, move tail leftward.
                if (currentNode.Equals(this.Tail))
                    this.Tail = leadingNode;

                var rearNode = (currentNode != null ? currentNode.Next : null);
                leadingNode.Next = rearNode;
                this.Length--;
            }
        }

        public void Reverse()
        {
            var currentNode = this.Head;
            LstNode preNode = null;
            var nextNode = currentNode.Next;

            // Swap head and tail
            var tempTail = this.Tail;
            this.Tail = this.Head;
            this.Head = tempTail;

            while (currentNode != null)
            {
                nextNode = currentNode.Next;
                currentNode.Next = preNode;
                preNode = currentNode;
                currentNode = nextNode;
            }
        }
    }

    public class LstNode
    {
        public LstNode(object obj)
        {
            this.Value = obj;
            this.Next = null;
        }

        public object Value { get; set; }
        public LstNode Next { get; set; }
    }
}