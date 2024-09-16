using System.Collections.Generic;

namespace Algo.Exercise
{
    public class QueueImplementedStack
    {
        public object Head { get; set; }
        public object Tail { get; set; }
        public int Length { get; set; }

        private Queue<object> dataQueue;
        private Queue<object> tempQueue;

        public QueueImplementedStack()
        {
            this.dataQueue = new Queue<object>();
            this.tempQueue = new Queue<object>();
            this.Head = null;
            this.Tail = null;
            this.Length = 0;
        }

        public void Push(object obj)
        {
            this.Tail = obj;
            if (this.Length == 0)
                this.Head = obj;

            while (this.dataQueue.Count > 0)
            {
                this.tempQueue.Enqueue(this.dataQueue.Dequeue());
            }
            this.dataQueue.Enqueue(obj);
            while (this.tempQueue.Count > 0)
            {
                this.dataQueue.Enqueue(this.tempQueue.Dequeue());
            }
            this.Length++;
        }

        public object Pop()
        {
            if(this.dataQueue.Count <= 0)
                return null;

            var result = this.dataQueue.Dequeue();
            this.Length--;

            if (this.Length == 0)
            {
                this.Head = null;
                this.Tail = null;
            }
            else
                this.Head = this.dataQueue.Peek();
            return result;
        }

        public object Peek()
        {
            return this.dataQueue.Peek();
        }

        public bool Empty()
        {
            return this.Length <= 0;
        }
    }
}