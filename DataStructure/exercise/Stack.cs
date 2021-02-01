namespace Algo.Exercise
{
    public class Stack
    {
        public LstNode Top { get; set; }
        public LstNode Bottom { get; set; }
        public int Length { get; set; }
        public Stack()
        {
            this.Top = null;
            this.Bottom = null;
			this.Length = 0;
        }
		
		public void Push(object val)
		{
			var newNode = new LstNode(val);
			
			if(this.Length == 0)
			{
				this.Top = newNode;
				this.Bottom = newNode;
			}
			else
			{
				newNode.Next = this.Top;
				this.Top = newNode;
			}
			this.Length++;
		}
		
		public object Pop()
		{
			object result = null;
			if(this.Length <= 0)
				return null;
			else if(this.Length == 1)
			{
				result = this.Top;
				this.Top = null;
				this.Bottom = null;
			}
			else
			{
				result = this.Top;
				var tempNode = this.Top.Next;
				this.Top.Next = null;
				this.Top = tempNode;
			}
			
			this.Length--;
			return result;
		}
		
		public object Peek()
		{
			if(this.Length <= 0)
				return null;
			else
				return this.Top.Value;
		}
    }
}