using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;

namespace Algo
{
    public class MyArray
    {
        private const int InitialSize = 100;
        private const int Increasement = 100;

        private int Length { get; set; }
        public object[] Data;

        public MyArray()
        {
            this.Length = 0;
            this.Data = new object[100];
        }

        public void Push(object val)
        {
            if (this.Length >= InitialSize && this.Length % Increasement == 0)
            {
                var newDataArray = new object[this.Length + Increasement];
                this.Data.CopyTo(newDataArray, 0);
                this.Data = newDataArray;
            }
            this.Data[this.Length] = val;
            this.Length++;
        }

        public object Pop()
        {
            if (this.Length <= 0)
                return null;

            object lastItem = this.Data[this.Length - 1];
            this.Data[this.Length - 1] = null;

            // Shrink
            if (this.Length >= InitialSize && (this.Length - 1) % Increasement == 0)
            {
                var newDataArray = new object[this.Length - 1];
                Array.Copy(this.Data, newDataArray, this.Length - 1);
                this.Data = newDataArray;
            }
            this.Length--;
            return lastItem;
        }

        public object Get(int index)
        {
            if (index < 0 || index > this.Length - 1)
                throw new ArgumentException("index is out of range.");
            return this.Data[index];
        }

        public void Delete(int index)
        {
            var delItem = this.Data[index];
            this.ShiftItems(index);
            // Shrink
            if (this.Length >= InitialSize && (this.Length - 1) % Increasement == 0)
            {
                var newDataArray = new object[this.Length - 1];
                Array.Copy(this.Data, newDataArray, this.Length - 1);
                this.Data = newDataArray;
            }
            this.Length--;
        }

        private void ShiftItems(int index)
        {
            for (int i = index; i < this.Length; i++)
            {
                this.Data[i] = this.Data[i + 1];
            }
            this.Data[this.Length - 1] = null;
        }

        public void Print()
        {
            Console.WriteLine($"Length: {this.Length}");
            for (int i = 0; i < this.Length; i++)
            {
                Console.Write(this.Data[i] + ", ");
            }
            Console.WriteLine();
        }

        public object this[int i]
        {
            get { return this.Data[i]; }
            set { this.Data[i] = value; }
        }
    }
}