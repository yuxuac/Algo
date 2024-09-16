using System;

namespace Algo.Exercise
{
    public class Stack_Array
    {
        private object[] Data { get; set; }
        public int Length { get; set; }
        private const int SIZE = 100;
        private const int INCREASEMENT = 100;
        public Stack_Array()
        {
            this.Data = new object[SIZE];
            this.Length = 0;
        }

        public void Push(object val)
        {
			// Expand data array by INCREASEMENT
            if(this.Length > 0 && this.Length % INCREASEMENT == 0)
			{
				var newData = new object[this.Length + INCREASEMENT]; 
				Array.Copy(this.Data, newData, this.Length);
				this.Data = newData;
			}
			this.Data[this.Length] = val;
            this.Length++;
        }

        public object Pop()
        {
			if(this.Length <= 0)
				return null;
			
			object result = this.Data[this.Length - 1];
			this.Data[this.Length - 1] = null;
			
			// Shrink data array
			if(this.Length > 1 && this.Length % INCREASEMENT == 1)
			{
				var newData = new object[this.Length - 1];
				Array.Copy(this.Data, newData, this.Length - 1);
				this.Data = newData;
			}
			
            this.Length--;
			return result;
        }

        public object Peek()
        {
            if(this.Length == 0)
                return null;
            else 
                return this.Data[this.Length - 1];
        }

        public void Print()
        {
            Console.WriteLine($"Length: {this.Length}");
            for (int i = 0; i < this.Length; i++)
            {
                Console.Write(this.Data[i] + "->");
            }
            Console.WriteLine();
        }
    }
}