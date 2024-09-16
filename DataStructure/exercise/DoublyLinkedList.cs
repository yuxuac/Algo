using System;

namespace Algo.Exercise
{
    public class DoublyLinkedList
    {
        // Head
        // Tail
        // Length

        // public void Prepend(object val)
        // public void Append(object val)
        // public void Insert(long index, object val)
        // public void Remove(long index)

		public DNode Head { get; set; }
		public DNode Tail { get; set; }
		public long Length { get; set; }
		
        public DoublyLinkedList(object obj)
        {
            var newNode = new DNode(obj);
			this.Head = newNode;
			this.Tail = newNode;
			this.Length = 1;
        }
		
		/*
		    head      tail
			 o<-->o<-->o<-->null
	   head           tail
		n<-->o<-->o<-->o<-->null
		*/
		
		public void Prepend(object val)
		{
			var newNode = new DNode(val);
			newNode.Next = this.Head;
			this.Head.Pre = newNode;
			this.Head = newNode;
			this.Length++;
		}                                        
		/*
		   head      tail
		    o<-->o<-->o--->null
		   head           tail 
			o<-->o<-->o<-->n--->null
		*/
		public void Append(object val)
		{
			var newNode = new DNode(val);
			newNode.Pre = this.Tail;
			this.Tail.Next = newNode;
			this.Tail = newNode;
			this.Length++;
		}
		
		/*
		   head      tail
		    o<-->o<-->o--->null
		   head      tail 
			o     o<-->o--->null
			 \   /
			  \	/
			   n (index = 1): we should get preNode(index = 0) and nextNode(index = 1).
			
		    if index == 0                   : call Prepend();
			else if index == this.Length - 1: call Append();
			else 
				find preNode then:
				newNode.Pre = preNode;
			    preNode.Next = newNode;
				newNode.Next = nextNode;
				nextNode.Pre = newNode;
				
		*/
		public void Insert(long index, object val)
		{
			if(index < 0 || index >= this.Length)
				throw new ArgumentException("Invalid index range.");
			if(index == 0)
				this.Prepend(val);
			else if(index == this.Length - 1)
				this.Append(val);
			else
			{
				var pointer = index - 1;
				var currentNode = this.Head;
				while(pointer > 0)
				{
					currentNode = currentNode.Next;
					pointer--;
				}
				var thePreNode = currentNode;
				var theNextNode = currentNode.Next;
				var newNode = new DNode(val);
				newNode.Pre = thePreNode;
				thePreNode.Next = newNode;
				newNode.Next = theNextNode;
				theNextNode.Pre = newNode;
			}
		}
		
		
		/*
		head       tail  
		  o<-->o<-->o<-->null
		
		*/
		public void Remove(long index)
		{
			if(index < 0 || index >= this.Length)
				throw new ArgumentException("Invalid index range.");
            
			if(this.Length == 1)
				throw new InvalidOperationException("Keep at least one item in the list.");
            
            if(index == 0)
            {
                this.Head = this.Head.Next;
                this.Head.Pre = null;
            }
            else if(index == this.Length - 1)
            {
                this.Tail = this.Tail.Pre;
                this.Tail.Next = null;
            }
            else
            {
				int pointer = 0;
				var currentNode = this.Head;
				while(pointer < index)
				{
					currentNode = currentNode.Next;
					pointer++;
				}
				var preNode = currentNode.Pre;
				var nextNode = currentNode.Next;
				preNode.Next = nextNode;
				nextNode.Pre = preNode;
            }
            this.Length--;
		}
		
		public void Print()
		{
			Console.WriteLine($"Head: {this.Head.Value}, Tail: {this.Tail.Value}, Length: {this.Length}");
			var currentNode = this.Head;
			while(currentNode!=null)
			{
				Console.Write(currentNode.Value + "<-->");
                currentNode = currentNode.Next;
			}
			Console.WriteLine();
		}
    }

    public class DNode
    {
        public DNode(object obj)
        {
            Value = obj;
        }
        
        public object Value { get; set; }
        public DNode Pre { get; set; }
        public DNode Next { get; set; }
    }
}