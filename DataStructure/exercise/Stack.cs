using System;
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
		
        /*
         top         bottom  
            o-->o-->o-->o
       top           bottom   
        n-->o-->o-->o-->o
        */
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
		
        /*
          top        bottom  
           o-->o-->o-->o
              top    bottom  
               o-->o-->o
        */
		public object Pop()
		{
			object result = null;
			if(this.Length <= 0)
				return null;
            
            result = this.Top;
			if(this.Length == 1)
			{
				this.Top = null;
				this.Bottom = null;
			}
			else
			{
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

		public void Print()
        {
            Console.WriteLine($"Length: {this.Length} - Top: {this.Top?.Value} - Bottom: {this.Bottom?.Value}");
            var currentNode = this.Top;
            while (currentNode != null)
            {
                Console.Write(currentNode.Value + "->");
                currentNode = currentNode.Next;
            }
            Console.WriteLine();
        }
    }
}