using System;

namespace Algo
{
    public class MyDoublyLinkedList
    {
        public TNode Head { get; set; }
        public TNode Tail { get; set; }
        public long Length { get; set; }

        public MyDoublyLinkedList(object val)
        {
            var newNode = new TNode(val);
            this.Head = newNode;
            this.Tail = newNode;
            this.Length = 1;
        }

        public void Append(object val)
        {
            var newNode = new TNode(val);
            this.Tail.Next = newNode;
            newNode.Pre = this.Tail;
            this.Tail = newNode;
            this.Length++;
        }

        public void Prepend(object val)
        {
            var newNode = new TNode(val);
            newNode.Next = this.Head;
            this.Head.Pre = newNode;
            this.Head = newNode;
            this.Length++;
        }

        public void Insert(long index, object val)
        {
            var newNode = new TNode(val);
            var preNode = FindItemViaIndex(index - 1);
            var currentNode = preNode.Next;

            preNode.Next = newNode;
            newNode.Pre = preNode;
            currentNode.Pre = newNode;
            newNode.Next = currentNode;
            this.Length++;
        }

        public void Remove(long? index, object val)
        {
            if (index.HasValue)
            {
                if (index < 0)
                    throw new ArgumentException("Invalid index < 0, try a positive one.");
                else if (index >= this.Length)
                    throw new ArgumentException("index out of range.");

                if (index == 0)
                {
                    if (this.Length > 1)
                    {
                        this.Head = this.Head.Next;
                        this.Head.Pre = null;
                        this.Length--;
                    }
                    else if (this.Length == 1)
                    {
                        this.Head = null;
                        this.Tail = null;
                        this.Length--;
                    }
                }
                else if (index == this.Length - 1)
                {
                    var preNode = this.Tail.Pre;
                    preNode.Next = null;
                    this.Tail = preNode;
                    this.Length--;
                }
                else
                {
                    var preNode = FindItemViaIndex(index.Value - 1);
                    var toDeleteNode = preNode.Next;
                    var nextNode = preNode.Next.Next;
                    preNode.Next = nextNode;

                    if (nextNode != null)
                        nextNode.Pre = preNode;
                    this.Length--;
                }
            }
            else
            {
                var currentNode = this.Head;
                // Remove head
                while (currentNode != null && currentNode.Value.Equals(val))
                {
                    this.Head = currentNode.Next;
                    this.Head.Pre = null;
                    this.Length--;
                    currentNode = currentNode.Next;
                }

                // Remove other nodes
                while (currentNode.Next != null)
                {
                    if (currentNode.Next.Value.Equals(val))
                    {
                        var nextOfNext = currentNode.Next.Next;
                        currentNode.Next = nextOfNext;
                        nextOfNext.Pre = currentNode;
                        this.Length--;
                    }
                    else
                        currentNode = currentNode.Next;
                }
            }
        }

        private TNode FindItemViaIndex(long index)
        {
            var currentNode = this.Head;
            long pointer = 0;
            while (pointer < index)
            {
                currentNode = currentNode.Next;
                pointer++;
            }
            return currentNode;
        }

        public void Print()
        {

        }
    }

    public class TNode
    {
        public TNode(object val)
        {
            this.Value = val;
        }

        public object Value { get; set; }
        public TNode Pre { get; set; }
        public TNode Next { get; set; }
    }
}