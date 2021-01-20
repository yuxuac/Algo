using System;
using System.Collections.Generic;

namespace Algo
{
    public class MyLinkedList
    {
        public Item Head { get; set; }
        public Item Tail { get; set; }
        public long Length { get; set; }

        public MyLinkedList(object val)
        {
            Head = new Item(val);
            Tail = this.Head;
            Length = 1;
        }

        public void Append(object val)
        {
            this.Tail.Next = new Item(val);
            this.Tail = this.Tail.Next;
            this.Length++;
        }

        public void Prepend(object val)
        {
            var newHead = new Item(val);
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
                Item currentNode = this.Head;
                for (int i = 0; i < index - 1; i++)
                {
                    currentNode = currentNode.Next;
                }
                Item addedNode = new Item(val);
                Item tempNode = currentNode.Next;
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
					if(index == this.Length - 1)
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
				while(currentNode != null && currentNode.Value.Equals(val))
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

        private Item FindItemViaIndex(long index)
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

    public class Item
    {
        public object Value { get; set; }
        public Item Next { get; set; }
        public Item(object val)
        {
            this.Value = val;
        }
    }
}