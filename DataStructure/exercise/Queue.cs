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
    }
}