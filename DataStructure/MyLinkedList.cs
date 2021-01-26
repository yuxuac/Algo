using System;
using System.Collections.Generic;

namespace Algo
{
    public class MyLinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public long Length { get; set; }

        public MyLinkedList(object val)
        {
            Head = new Node(val);
            Tail = this.Head;
            Length = 1;
        }

        public void Append(object val)
        {
            this.Tail.Next = new Node(val);
            this.Tail = this.Tail.Next;
            this.Length++;
        }

        public void Prepend(object val)
        {
            var newHead = new Node(val);
            newHead.Next = this.Head;
            this.Head = newHead;
            this.Length++;
        }

        public void Insert(long index, object val)
        {
            if (index < 0)
                throw new ArgumentException("Invalid index < 0, try a positive one.");

            if (index == 0)
                this.Prepend(val);
            else if (index >= this.Length)
                this.Append(val);
            else
            {
                Node currentNode = this.Head;
                for (int i = 0; i < index - 1; i++)
                {
                    currentNode = currentNode.Next;
                }
                Node addedNode = new Node(val);
                Node tempNode = currentNode.Next;
                addedNode.Next = tempNode;
                currentNode.Next = addedNode;
            }
        }

        /// <summary>
        /// Remove nodes within linked list via index or val.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="val"></param>
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
                    this.Head = this.Head.Next;
                    this.Length--;
                }
                else
                {
                    var itemPreTheIndex = FindItemViaIndex(index.Value - 1);
                    itemPreTheIndex.Next = itemPreTheIndex.Next.Next;
                    if (index == this.Length - 1)
                    {
                        this.Tail = itemPreTheIndex;
                    }
                    this.Length--;
                }
            }
            else
            {
                var currentNode = this.Head;

                // Delete head node
                while (currentNode != null && currentNode.Value.Equals(val))
                {
                    this.Head = this.Head.Next;
                    currentNode = this.Head;
                    this.Length--;
                }
                // Delete other nodes
                while (currentNode != null)
                {
                    while (currentNode.Next != null && currentNode.Next.Value.Equals(val))
                    {
                        currentNode.Next = currentNode.Next.Next;
                        this.Length--;
                    }
                    currentNode = currentNode.Next;
                }
            }
        }

        public void Reverse()
        {
            var currentNode = this.Head;
            this.Tail = this.Head;

            // If there is only one item, no need to reverse
            if(currentNode.Next == null)
                return;

            Node preNode = null;
            Node theNextNode = null;
            Node tempTail = this.Tail;
            while (currentNode != null)
            {
                theNextNode = currentNode.Next;
                currentNode.Next = preNode;
                preNode = currentNode;
                currentNode = theNextNode;
            }
            this.Head = preNode;
        }

        private Node FindItemViaIndex(long index)
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
            var currentNode = this.Head;
            while (currentNode != null)
            {
                Console.Write(currentNode.Value + "->");
                currentNode = currentNode.Next;
            }
            Console.WriteLine();
        }
    }

    public class Node
    {
        public object Value { get; set; }
        public Node Next { get; set; }
        public Node(object val)
        {
            this.Value = val;
        }
    }
}