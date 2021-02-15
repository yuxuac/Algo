namespace Algo
{
    public class MyStack
    {
        public MyStack()
        {
            this.Top = null;
            this.Bottom = null;
            this.Length = 0;
        }

        public Node Top { get; set; }
        public Node Bottom { get; set; }
        public long Length { get; set; }

        public Node Peek()
        {
            if (this.Length <= 0)
                return null;
            return this.Top;
        }

        public void Push(object value)
        {
			var node = new Node(value);
			
            if (this.Length == 0)
            {
                this.Top = node;
                this.Bottom = node;
            }
            else
            {
                node.Next = this.Top;
                this.Top = node;
            }
            this.Length++;
        }

        public Node Pop()
        {
            if (this.Length <= 0)
                return null;

            var result = this.Top;
            this.Top = this.Top.Next;

            if (this.Length == 1)
                this.Bottom = null;

            this.Length--;
            return result;
        }
    }
}