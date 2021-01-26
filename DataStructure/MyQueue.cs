using System;

namespace Algo
{
    public class MyQueue
    {
        private Node First { get; set; }
        private Node Last { get; set; }
        private long Length { get; set; }
        public MyQueue()
        {
            this.First = null;
            this.Last = null;
            this.Length = 0;
        }

        public Node Peek()
        {
            if (this.Length <= 0)
                return null;
            else
                return this.First;
        }
        
        // 
        public Node Enqueue(object val)
        {
            var newNode = new Node(val);
            if (this.Length <= 0)
            {
                this.First = newNode;
                this.Last = newNode;
            }
            else
            {
                // If last node points to the new node like this: 1(first)->2->3->4->5(last)->6(new node)
                this.Last.Next = newNode;
                this.Last = newNode;

                // If new node points to the last node in this way: 1(first)<-2<-3<-4<-5(last)<-6(new node)
                // newNode.Next = this.Last;
                // this.Last = newNode;
            }
            this.Length++;
            return this.Last;
        }

        public Node Dequeue()
        {
            if (this.Length <= 0)
                return null;

            Node result = null;

            if(this.Length == 1)
            {
                result = this.First;
                this.First = null;
                this.Last = null;
            }
            else
            {
                // If last node points to the new node.
                result = this.First;
                this.First = this.First.Next;
                
                /*
                // If new node points to the last node: 1(first)<-2<-3<-4<-5(last)<-6(newNode)
                // Get node before first
                var currentNode = this.Last;
                var currentIndex = 0;
                while (currentIndex < this.Length - 2)
                {
                    currentNode = currentNode.Next;
                    currentIndex++;
                }

                result = currentNode.Next;
                this.First = currentNode;
                currentNode.Next = null;
                this.Length--;
                return result;
                */
            }
            this.Length--;
            return result;
        }

        public void Print()
        {
            Console.WriteLine($"First: {this.First?.Value} - Last: {this.Last?.Value} - Length: {this.Length}");
            var currentNode = this.First;
            while (currentNode != null)
            {
                Console.Write(currentNode.Value + "->");
                currentNode = currentNode.Next;
            }
            Console.WriteLine();
        }
    }
}