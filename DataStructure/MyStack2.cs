using System;

namespace Algo
{
    // To complete this using array.
    public class MyStack2
    {
        private const int Size = 5;
        private const int Increasement = 5;

        public MyStack2()
        {
            this.Array = new object[20];
            this.Top = null;
            this.Bottom = null;
            this.Length = 0;
        }

        private object[] Array { get; set; }

        public object Top { get; set; }
        public object Bottom { get; set; }
        public long Length { get; set; }

        public object Peek()
        {
            return this.Array[this.Length - 1];
        }

        public void Push(object value)
        {
            if (this.Length == 0)
            {
                this.Bottom = value;
                this.Top = value;
                this.Array[0] = value;
            }
            else
            {
                // Expand
                if (this.Length % Size == 0)
                {
                    var newArray = new object[this.Length + Increasement];
                    for (int i = 0; i < this.Length; i++)
                    {
                        newArray[i] = Array[i];
                    }
                    this.Array = newArray;
                }
                this.Array[this.Length] = value;
                this.Top = value;
            }
            this.Length++;
        }

        public object Pop()
        {
            if (this.Length <= 0)
                return null;

            object result = null;

            if (this.Length == 1)
            {
                result = this.Top;
                this.Top = null;
                this.Bottom = null;
            }
            else
            {
                result = this.Top;
                this.Array[this.Length - 1] = null;
                // Shrink
                if (this.Length % Increasement == 1)
                {
                    var newArray = new object[this.Length - 1];
                    for (int i = 0; i < newArray.Length; i++)
                    {
                        newArray[i] = this.Array[i];
                    }
                    this.Array = newArray;
                }
                this.Top = this.Array[this.Length - 2];
            }
            this.Length--;
            return result;
        }

        public void Print()
        {
            Console.WriteLine($"Length: {this.Length} - Top: {this.Top} - Bottom: {this.Bottom}");
            for (int i = 0; i < this.Length; i++)
            {
                Console.Write(this.Array[i] + "->");
            }
            Console.WriteLine();
        }
    }
}