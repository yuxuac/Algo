using System;

namespace Algo.Exercise
{
    public class Queue
    {
        public LstNode Head { get; set; }
        public LstNode Tail { get; set; }
        public int Length { get; set; }
        public Queue()
        {
            this.Head = null;
            this.Tail = null;
            this.Length = 0;
        }

        /*
        Head        Tail
          o-->o-->o-->o
        Head             Tail
          o-->o-->o-->o-->n
        */
        public void Enqueue(object obj)
        {
            var newNode = new LstNode(obj);

            if(this.Length == 0)
            {
                this.Head = newNode;
                this.Tail = newNode;
            }
            else
            {
                this.Tail.Next = newNode;
                this.Tail = newNode;
            }
            this.Length++;
        }

        /*
        Head        Tail
          o-->o-->o-->o
            Head    Tail
              o-->o-->o
        */
        public object Dequeue()
        {
            if(this.Length <= 0)
                return null;

            var result = this.Head.Value;
            if(this.Length == 1)
            {
                this.Head = null;
                this.Tail = null;
            }
            else
            {
                var tempNode = this.Head.Next;
                this.Head.Next = null;
                this.Head = tempNode;
            }
            this.Length--;
            return result;
        }

        public object Peek()
        {
            if(this.Length <= 0)
                return null;
            else
                return this.Head.Value;
        }

        public void Print()
        {
            Console.WriteLine($"Head: {this.Head?.Value} - Tail: {this.Tail?.Value} - Length: {this.Length}");
            var currentNode = this.Head;
            while (currentNode != null)
            {
                Console.Write(currentNode.Value + "->");
                currentNode = currentNode.Next;
            }
            Console.WriteLine();
        }
    }
}